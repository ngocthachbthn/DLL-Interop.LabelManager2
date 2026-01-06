namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("3624B9C5-9E5D-11D3-A896-00C04F324E22"), InterfaceType((short) 2), TypeLibType((short) 0x1000)]
    public interface INotifyDocumentEvent
    {
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)]
        extern void Change();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)]
        extern void BeginPrinting([In, MarshalAs(UnmanagedType.BStr)] string strDocName);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)]
        extern void ProgressPrinting([In] short Percent, [In, Out] ref short Cancel);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)]
        extern void EndPrinting([In] enumEndPrinting Reason);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)]
        extern void PausedPrinting([In] enumPausedReasonPrinting Reason, [In, Out] ref short Cancel);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)]
        extern void Close();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)]
        extern void EndPrintingReport([In] int Pages, [In] int Labels);
    }
}

