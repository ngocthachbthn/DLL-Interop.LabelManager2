namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [TypeLibType((short) 0x10), ComVisible(false)]
    public delegate void INotifyDocumentEvent_PausedPrintingEventHandler([In] enumPausedReasonPrinting Reason, [In, Out] ref short Cancel);
}

