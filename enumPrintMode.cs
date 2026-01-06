namespace LabelManager2
{
    using System;

    public enum enumPrintMode
    {
        lppxPrintModeTest = 1,
        lppxPrintModeDirect = 2,
        lppxPrintModeMergeAll = 4,
        lppxPrintModeMerge = 8,
        lppxPrintModeInfile = 0x100,
        lppxPrintModeRePrint = 0x200
    }
}

