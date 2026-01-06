namespace LabelManager2
{
    using System;

    public enum EnumLAHistory
    {
        lppxLAHistoryPrinting = 1,
        lppxLAHistoryModifications = 2,
        lppxLAHistoryErrors = 4,
        lppxLAHistoryWarnings = 8,
        lppxLAHistoryInformation = 0x10
    }
}

