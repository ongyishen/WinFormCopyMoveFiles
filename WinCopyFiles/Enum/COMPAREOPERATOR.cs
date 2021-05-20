using System.ComponentModel;

namespace WinCopyFiles
{
    public enum COMPAREOPERATOR
    {
        [Description("Equal")]
        EQUAL,

        [Description("Less Than")]
        LESSTHAN,

        [Description("Less Equal Than")]
        LESSEQUALTHAN,

        [Description("Greater Than")]
        GREATERTHAN,

        [Description("Greater Equal Than")]
        GREATEREQUALTHAN
    }
}
