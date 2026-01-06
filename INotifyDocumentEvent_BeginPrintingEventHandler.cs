namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [TypeLibType((short) 0x10), ComVisible(false)]
    public delegate void INotifyDocumentEvent_BeginPrintingEventHandler([In, MarshalAs(UnmanagedType.BStr)] string strDocName);
}

