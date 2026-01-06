namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("89B44D2F-399C-4E3D-9067-B6C5DA035F0F"), InterfaceType((short) 2), TypeLibType((short) 0x1000)]
    public interface FormatSystem
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)]
        extern Strings TypesList();
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)]
        extern Strings NamesList([In, MarshalAs(UnmanagedType.BStr)] string Type = "");
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)]
        extern LfmInfos GetLFM([In, MarshalAs(UnmanagedType.BStr)] string Type = "", [In, MarshalAs(UnmanagedType.BStr)] string Name = "");
    }
}

