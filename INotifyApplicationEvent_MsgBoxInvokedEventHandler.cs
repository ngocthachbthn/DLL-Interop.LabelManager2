namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [TypeLibType((short) 0x10), ComVisible(false)]
    public delegate void INotifyApplicationEvent_MsgBoxInvokedEventHandler([In] int nResult, [In] int nCode, [MarshalAs(UnmanagedType.BStr)] string strMessage);
}

