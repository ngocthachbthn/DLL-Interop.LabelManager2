namespace LabelManager2
{
    using System;

    public enum enumBarcodeChecksAvailable
    {
        lppxBarcodeCheckNoneAvailable = 1,
        lppxBarcodeCheck1digitAvailable = 2,
        lppxBarcodeCheck2digitAvailable = 4,
        lppxBarcodeCheckMod11Mod10Available = 8,
        lppxBarcodeCheckMod10Available = 0x10,
        lppxBarcodeCheckMod16Available = 0x20,
        lppxBarcodeCheckInHRAvailable = 0x4000,
        lppxBarcodeCheckNotInHRAvailable = 0x8000
    }
}

