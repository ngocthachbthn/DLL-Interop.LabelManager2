namespace LabelManager2
{
    using System;

    public enum enumBarcodeError
    {
        lppxBarcodeErrorBadData = -1,
        lppxBarcodeErrorTooLongData = -2,
        lppxBarcodeErrorTooShortData = -3,
        lppxBarcodeErrorBadLengthData = -4,
        lppxBarcodeErrorIncompleteData = -5,
        lppxBarcodeErrorInvalidCheckData = -6,
        lppxBarcodeErrorMissBraceData = -7,
        lppxBarcodeErrorTooSmallSize = -8,
        lppxBarcodeErrorTooBigSize = -9,
        lppxBarcodeErrorInvalidSize = -10,
        lppxBarcodeErrorDataForSize = -11,
        lppxBarcodeErrorEncode = -12
    }
}

