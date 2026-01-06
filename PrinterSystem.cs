namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType((short) 2), Guid("3624B9EF-9E5D-11D3-A896-00C04F324E22"), TypeLibType((short) 0x1000)]
    public interface PrinterSystem
    {
        [DispId(9)]
        string DefaultPrinter { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] set; }
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)]
        extern Strings Families();
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)]
        extern Strings Models([In, MarshalAs(UnmanagedType.BStr)] string Family = "");
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)]
        extern Strings Printers([In] enumKindOfPrinters KindOfPrinter = 1);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)]
        extern Strings Ports();
        [return: MarshalAs(UnmanagedType.BStr)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)]
        extern string Add([In, MarshalAs(UnmanagedType.BStr)] string strPrinterName, [In, MarshalAs(UnmanagedType.BStr)] string strPortName, [In] bool DirectAccess = false);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)]
        extern void Remove([In, MarshalAs(UnmanagedType.BStr)] string strPrinterName);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)]
        extern void Rename([In, MarshalAs(UnmanagedType.BStr)] string strPrinterName, [In, MarshalAs(UnmanagedType.BStr)] string strNewPrinterName);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)]
        extern void ChangePort([In, MarshalAs(UnmanagedType.BStr)] string strPrinterName, [In, MarshalAs(UnmanagedType.BStr)] string strPortName, [In] bool DirectAccess = false);
        [return: MarshalAs(UnmanagedType.Struct)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)]
        extern object PrinterInfos([In, MarshalAs(UnmanagedType.BStr)] string strPrinterName);
    }
}

