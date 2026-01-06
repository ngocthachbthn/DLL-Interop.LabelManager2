namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, TypeLibType((short) 0x1000), InterfaceType((short) 2), Guid("065A4348-717C-481D-87E9-8EE437D9612D")]
    public interface BarcodeInfos
    {
        [DispId(1)]
        int SymbologyID { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] set; }
        [DispId(2)]
        string SymbologyName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] set; }
        [DispId(3)]
        enumBarcodeCategory SymbologyCategory { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] set; }
        [DispId(4)]
        enumBarcodeChecksAvailable ChecksAvailable { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] set; }
        [DispId(5)]
        enumBarcodeHumansAvailable HumansAvailable { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] set; }
        [DispId(6)]
        bool UseRatio { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] set; }
        [DispId(7)]
        Strings SymbologySubTypes { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] set; }
        [DispId(8)]
        bool HasCompositeData { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] set; }
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x101)]
        extern enumBarcodeError IsValidData([In, MarshalAs(UnmanagedType.BStr)] string Data);
        [return: MarshalAs(UnmanagedType.BStr)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x102)]
        extern string GetDataCheck([In, MarshalAs(UnmanagedType.BStr)] string Data, enumCheckMode CheckUsed);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x103)]
        extern int GetRatiosAvailable([In] int nNarrowBarWidth);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(260)]
        extern void SetProperty([In, MarshalAs(UnmanagedType.BStr)] string strOptionName, [In, MarshalAs(UnmanagedType.Struct)] object varValue);
    }
}

