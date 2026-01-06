namespace LabelManager2
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("3624B9CB-9E5D-11D3-A896-00C04F324E22"), DefaultMember("_Item"), InterfaceType((short) 2), TypeLibType((short) 0x1000)]
    public interface Documents
    {
        [DispId(1)]
        short Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] set; }
        [DispId(2)]
        LabelManager2.Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] set; }
        [DispId(3)]
        object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] set; }
        [DispId(-4)]
        object _NewEnum { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(-4)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(-4)] set; }
        [DispId(4)]
        string DefaultExt { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] set; }
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)]
        extern Document Add([In, MarshalAs(UnmanagedType.BStr)] string Key);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)]
        extern Document Item([In, MarshalAs(UnmanagedType.Struct)] object Key);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)]
        extern Document _Item([In, MarshalAs(UnmanagedType.Struct)] object Key);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)]
        extern Document Open([In, MarshalAs(UnmanagedType.BStr)] string strDocName, [In] bool ReadOnly = false);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)]
        extern void SaveAll([In] bool AlwaysPrompt = false);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)]
        extern void CloseAll([In] bool Save = true);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)]
        extern Document Import([In, MarshalAs(UnmanagedType.BStr)] string strDocName, [In, MarshalAs(UnmanagedType.BStr)] string strFileExt);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)]
        extern Document SelectOpen([In, MarshalAs(UnmanagedType.BStr)] string strDocName, [In] int hParent);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)]
        extern Document OpenFromStream([In, MarshalAs(UnmanagedType.IUnknown)] object Stream, [In, MarshalAs(UnmanagedType.BStr)] string strDocName, [In] bool ReadOnly = false);
    }
}

