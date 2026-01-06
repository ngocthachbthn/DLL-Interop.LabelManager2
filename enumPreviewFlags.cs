namespace LabelManager2
{
    using System;

    public enum enumPreviewFlags
    {
        lppxPreviewBorder = 1,
        lppxPreviewBackground = 2,
        lppxPreviewObjectBorder = 4,
        lppxPreviewObjectsNone = 0,
        lppxPreviewObjectsBefore = 0x100,
        lppxPreviewObject = 0x200,
        lppxPreviewObjectsAfter = 0x300,
        lppxPreviewObjectsAll = 0x400,
        lppxPreviewObjectsMask = 0xf00,
        lppxPreviewOutputWmf = 0x1000,
        lppxPreviewOutputEmf = 0x2000,
        lppxPreviewOutputMask = 0xf000
    }
}

