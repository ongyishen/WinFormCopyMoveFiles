using System;

namespace WinCopyFiles
{
    public class WinConfig
    {
        public string FromPath { get; set; }

        public string ToPath { get; set; }

        public bool IsApplyCompare { get; set; }

        public bool IsOutputFileName { get; set; }

        public bool IsOverwrite { get; set; }

        public int CompareOperator { get; set; }

        public DateTime LastWriteTime { get; set; }

        public WinConfig()
        {
            FromPath = string.Empty;
            ToPath = string.Empty;
            IsApplyCompare = true;
            CompareOperator = COMPAREOPERATOR.LESSEQUALTHAN.ParseToInt();
            LastWriteTime = DateTime.Now;
            IsOverwrite = false;
        }
    }
}
