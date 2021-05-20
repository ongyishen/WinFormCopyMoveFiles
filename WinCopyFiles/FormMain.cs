using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinCopyFiles
{
    public partial class FormMain : Form
    {
        public const string CONFIGFILENAME = "MyConfig.json";
        WinConfig myConfig { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        #region Config
        public void LoadConfig()
        {
            try
            {
                var jsonString = CONFIGFILENAME.ReadAllLine();
                if (jsonString.IsNotEmpty())
                {
                    myConfig = jsonString.ToObject<WinConfig>();
                    if (myConfig == null)
                    {
                        myConfig = new WinConfig();
                    }
                }
                else
                {
                    myConfig = new WinConfig();
                }

                BindingConfig(false);
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        public void SaveConfig()
        {
            try
            {
                BindingConfig(true);

                var jsonString = myConfig.ToJson();

                CONFIGFILENAME.SaveJson(jsonString);
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        public void BindingConfig(bool isSave)
        {
            try
            {

                if (isSave)
                {
                    myConfig.FromPath = txtFrom.Text;
                    myConfig.ToPath = txtTo.Text;
                    myConfig.IsApplyCompare = chkApplyOp.Checked;
                    myConfig.CompareOperator = cboOp.SelectedIndex;
                    myConfig.LastWriteTime = dtpLastWriteTime.Value;
                    myConfig.IsOutputFileName = chkOutputFileName.Checked;
                    myConfig.IsOverwrite = chkOverwrite.Checked;

                }
                else
                {
                    txtFrom.Text = myConfig.FromPath;
                    txtTo.Text = myConfig.ToPath;
                    chkApplyOp.Checked = myConfig.IsApplyCompare;
                    cboOp.SelectedIndex = myConfig.CompareOperator;
                    dtpLastWriteTime.Value = myConfig.LastWriteTime;
                    chkOutputFileName.Checked = myConfig.IsOutputFileName;
                    chkOverwrite.Checked = myConfig.IsOverwrite;
                }



            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
            RefreshControl();
        }

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        public void EnableControl(bool isEnable)
        {
            btnCopy.EnableBtn(isEnable);
            btnMove.EnableBtn(isEnable);
        }

        public void RefreshControl()
        {
            groupBox1.Enabled = chkApplyOp.Checked;
        }

        public enum ACTION
        {
            COPY, MOVE
        }

        public void CopyMoveFiles(ACTION action)
        {
            SaveConfig();
            EnableControl(false);
            try
            {
                if (txtFrom.Text.IsEmpty())
                {
                    "From Empty".AlertError();
                    return;
                }

                if (txtTo.Text.IsEmpty())
                {
                    "To Empty".AlertError();
                    return;
                }

                if (!txtFrom.Text.IsDirExist())
                {
                    "From Path Not Exist".AlertError();
                    return;
                }

                if (!txtTo.Text.IsDirExist())
                {
                    "To Path Not Exist".AlertError();
                    return;
                }

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(myConfig.FromPath);

                IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

                if (myConfig.IsApplyCompare)
                {
                    if (cboOp.SelectedIndex == COMPAREOPERATOR.EQUAL.ParseToInt())
                    {
                        fileList = fileList.Where(x => x.LastWriteTime.Date == myConfig.LastWriteTime.Date).ToList();

                    }
                    else if (cboOp.SelectedIndex == COMPAREOPERATOR.LESSTHAN.ParseToInt())
                    {
                        fileList = fileList.Where(x => x.LastWriteTime.Date < myConfig.LastWriteTime.Date).ToList();

                    }
                    else if (cboOp.SelectedIndex == COMPAREOPERATOR.LESSEQUALTHAN.ParseToInt())
                    {
                        fileList = fileList.Where(x => x.LastWriteTime.Date <= myConfig.LastWriteTime.Date).ToList();

                    }
                    else if (cboOp.SelectedIndex == COMPAREOPERATOR.GREATERTHAN.ParseToInt())
                    {
                        fileList = fileList.Where(x => x.LastWriteTime.Date > myConfig.LastWriteTime.Date).ToList();

                    }
                    else if (cboOp.SelectedIndex == COMPAREOPERATOR.GREATEREQUALTHAN.ParseToInt())
                    {
                        fileList = fileList.Where(x => x.LastWriteTime.Date >= myConfig.LastWriteTime.Date).ToList();

                    }



                }


                int iTotal = fileList.Count();
                AddLog($"Total File(s) : {iTotal}");
                int iCount = 1;

                progressBar1.Value = 0;
                progressBar1.Maximum = iTotal;

                foreach (var file in fileList)
                {
                    lblStatus.Text = $"{iCount++} / {iTotal}";
                    if (myConfig.IsOutputFileName)
                    {
                        AddLog(Path.GetFileName(file.FullName));
                    }

                    string toPath = Path.Combine(myConfig.ToPath, Path.GetFileName(file.FullName));

                    if (action == ACTION.COPY)
                    {
                        file.CopyTo(toPath, myConfig.IsOverwrite);
                    }
                    else
                    {


                        file.MoveTo(toPath);
                    }



                    progressBar1.Increment(1);

                    Application.DoEvents();
                }

                AddLog($"---COMPLETE---");
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
            EnableControl(true);
        }

        public void AddLog(string value)
        {
            rtbLog.AppendText(value);
            rtbLog.AppendText("\n");
            rtbLog.ScrollToCaret();
            Application.DoEvents();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyMoveFiles(ACTION.COPY);
        }

        private void btnBrowseFrom_Click(object sender, EventArgs e)
        {
            txtFrom.BrowseFolder(this);
        }

        private void btnBrowseTo_Click(object sender, EventArgs e)
        {
            txtTo.BrowseFolder(this);
        }

        private void btnOpenFrom_Click(object sender, EventArgs e)
        {
            txtFrom.OpenFolder();
        }

        private void btnOpenTo_Click(object sender, EventArgs e)
        {
            txtTo.OpenFolder();
        }

        private void chkApplyOp_CheckedChanged(object sender, EventArgs e)
        {
            RefreshControl();

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            CopyMoveFiles(ACTION.MOVE);

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string tmpFrom = txtFrom.Text;
            string tmpTo = txtTo.Text;

            txtFrom.Text = tmpTo;
            txtTo.Text = tmpFrom;

        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            SaveConfig();
            "Done".AlertInfo();
        }
    }
}
