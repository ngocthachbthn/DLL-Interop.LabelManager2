namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("3624B9C4-9E5D-11D3-A896-00C04F324E22"), TypeLibType((short) 0x1000), InterfaceType((short) 2)]
    public interface INotifyApplicationEvent
    {
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)]
        extern void Quit();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)]
        extern void Close();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)]
        extern void DocumentClosed([In, MarshalAs(UnmanagedType.BStr)] string strDocTitle);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)]
        extern void DocumentOpened([In, MarshalAs(UnmanagedType.BStr)] string strDocTitle);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)]
        extern void MsgBoxInvoked([In] int nResult, [In] int nCode, [MarshalAs(UnmanagedType.BStr)] string strMessage);
    }
}

