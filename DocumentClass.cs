namespace LabelManager2
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using TkxRFTAG;

    [ComImport, DefaultMember("_Name"), Guid("3624B9C1-9E5D-11D3-A896-00C04F324E22"), TypeLibType((short) 2), ComSourceInterfaces("LabelManager2.INotifyDocumentEvent\0"), ClassInterface((short) 0)]
    public class DocumentClass : IDocument, Document, INotifyDocumentEvent_Event
    {
        public virtual event INotifyDocumentEvent_BeginPrintingEventHandler BeginPrinting;

        public virtual event INotifyDocumentEvent_ChangeEventHandler Change;

        public virtual event INotifyDocumentEvent_EndPrintingEventHandler EndPrinting;

        public virtual event INotifyDocumentEvent_EndPrintingReportEventHandler EndPrintingReport;

        public virtual event INotifyDocumentEvent_CloseEventHandler INotifyDocumentEvent_Event_Close;

        public virtual event INotifyDocumentEvent_PausedPrintingEventHandler PausedPrinting;

        public virtual event INotifyDocumentEvent_ProgressPrintingEventHandler ProgressPrinting;

        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1b)]
        public virtual extern void Activate();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x201)]
        public virtual extern bool AddHistory([In] EnumLAHistory nType, [In, MarshalAs(UnmanagedType.BStr)] string Comment, [In, MarshalAs(UnmanagedType.IDispatch)] object HistData);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x39)]
        public virtual extern Text AddWatermark([MarshalAs(UnmanagedType.BStr)] string strWatermark, int nFlags);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x200)]
        public virtual extern bool CheckIn([In, Out, MarshalAs(UnmanagedType.BStr)] ref string Name, EnumLACheckInMode nMode, EnumLADocStates nState, [MarshalAs(UnmanagedType.BStr)] string Comment);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1a)]
        public virtual extern void Close([In] bool Save = true);
        [return: MarshalAs(UnmanagedType.BStr)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1c)]
        public virtual extern string CopyImageToFile([In] short Colors = 8, [In, MarshalAs(UnmanagedType.BStr)] string Extension = "BMP", [In] short Rotation = 0, [In] short Percent = 100, [In, MarshalAs(UnmanagedType.BStr)] string FileName = "");
        [return: MarshalAs(UnmanagedType.BStr)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2d)]
        public virtual extern string CopyImageToFileEx([In] short Colors = 8, [In, MarshalAs(UnmanagedType.BStr)] string Extension = "BMP", [In] short Rotation = 0, [In] short Percent = 100, [In, MarshalAs(UnmanagedType.BStr)] string FileName = "", [In] bool Border = true, [In] bool NonPrintableObjects = true);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x18)]
        public virtual extern bool CopyToClipboard();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(40)]
        public virtual extern bool CopyToClipboardEx([In] bool Border = true, [In] short nMethod = 2, [In] short Colors = 8, [In] short Rotation = 0, [In] short Percent = 100);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x19)]
        public virtual extern short FormFeed();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x15)]
        public virtual extern short GeneratePOF([In, MarshalAs(UnmanagedType.BStr)] string DestFileName, [In, MarshalAs(UnmanagedType.BStr)] string ModeleFileName = "");
        [return: MarshalAs(UnmanagedType.Struct)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x33)]
        public virtual extern object GetMetaFilePreview(int Flags, [MarshalAs(UnmanagedType.BStr)] string previewObjectName);
        [return: MarshalAs(UnmanagedType.Struct)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x29)]
        public virtual extern object GetPreview(bool DrawBorder, bool Color, int nPercent);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x17)]
        public virtual extern short Insert([In, MarshalAs(UnmanagedType.BStr)] string strPathName);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x16)]
        public virtual extern short Merge([In] int Quantity, [In] int LabelCopy = 1, [In] int InterCut = 1, [In] int PageCopy = 1, [In] int NoFrom = 1, [In, MarshalAs(UnmanagedType.BStr)] string FileName = "");
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x25)]
        public virtual extern bool NewRFTag([In] enumRfTagID IDRfTag, [In] int Reserved);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x21)]
        public virtual extern void Passwords([In, MarshalAs(UnmanagedType.BStr)] string strOwnerPassword, [In, MarshalAs(UnmanagedType.BStr)] string strPrintPassword);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x13)]
        public virtual extern short PrintDocument([In] int Quantity = 1);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(20)]
        public virtual extern short PrintLabel([In] int Quantity, [In] int LabelCopy = 1, [In] int InterCut = 1, [In] int PageCopy = 1, [In] int NoFrom = 0, [In, MarshalAs(UnmanagedType.BStr)] string FileName = "");
        [return: MarshalAs(UnmanagedType.Struct)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x20)]
        public virtual extern object ReadVariables([In] enumDataSource iType);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x26)]
        public virtual extern RfTag RFTag([In] int Reserved);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2a)]
        public virtual extern void Rotate([In] int lRotate);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x11)]
        public virtual extern short Save();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x12)]
        public virtual extern short SaveAs([In, MarshalAs(UnmanagedType.BStr)] string strPathName);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x27)]
        public virtual extern bool SelectDatabase([In, MarshalAs(UnmanagedType.BStr)] string strName);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1f)]
        public virtual extern short WriteVariables([In, MarshalAs(UnmanagedType.Struct)] object varArray);

        [DispId(1)]
        public virtual LabelManager2.Variables Variables { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] set; }

        [DispId(2)]
        public virtual string Name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] set; }

        [DispId(0)]
        public virtual string this[] { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)] set; }

        [DispId(3)]
        public virtual LabelManager2.DocObjects DocObjects { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] set; }

        [DispId(4)]
        public virtual LabelManager2.Printer Printer { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] set; }

        [DispId(5)]
        public virtual LabelManager2.Format Format { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] set; }

        [DispId(6)]
        public virtual LabelManager2.Database Database { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] set; }

        [DispId(7)]
        public virtual LabelManager2.Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] set; }

        [DispId(8)]
        public virtual object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] set; }

        [DispId(9)]
        public virtual string FullName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] set; }

        [DispId(10)]
        public virtual bool ReadOnly { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)] set; }

        [DispId(11)]
        public virtual enumViewMode ViewMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)] set; }

        [DispId(12)]
        public virtual enumWindowState WindowState { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)] set; }

        [DispId(13)]
        public virtual DocumentProperties BuiltInDocumentProperties { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(13)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(13)] set; }

        [DispId(14)]
        public virtual enumTriggerForm TriggerForm { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(14)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(14)] set; }

        [DispId(15)]
        public virtual enumRotation ViewOrientation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(15)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(15)] set; }

        [DispId(0x10)]
        public virtual bool IsModified { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x10)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x10)] set; }

        [DispId(0x1d)]
        public virtual LabelManager2.SelectedDocObjects SelectedDocObjects { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1d)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1d)] set; }

        [DispId(30)]
        public virtual bool AutoPageIncrement { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(30)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(30)] set; }

        [DispId(0x22)]
        public virtual int HorzPrintOffset { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x22)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x22)] set; }

        [DispId(0x23)]
        public virtual int VertPrintOffset { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x23)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x23)] set; }

        [DispId(0x24)]
        public virtual string RFTagList { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x24)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x24)] set; }

        [DispId(0x2b)]
        public virtual int ViewZoom { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2b)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2b)] set; }

        [DispId(0x2c)]
        public virtual bool Visible { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2c)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2c)] set; }

        [DispId(0x2e)]
        public virtual bool WindowsGraphicalEmulation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2e)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2e)] set; }

        [DispId(0x2f)]
        public virtual bool KeepPrinterObjects { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2f)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2f)] set; }

        [DispId(0x30)]
        public virtual bool IsResolutionIndependentWysiwyg { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x30)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x30)] set; }

        [DispId(0x31)]
        public virtual LabelManager2.Background Background { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x31)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x31)] set; }

        [DispId(50)]
        public virtual bool RefreshDatabaseBeforePrinting { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(50)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(50)] set; }

        [DispId(0x34)]
        public virtual enumPrintingOptimizationMode PrintingOptimizationMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x34)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x34)] set; }

        [DispId(0x35)]
        public virtual int Version { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x35)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x35)] set; }

        [DispId(0x36)]
        public virtual bool FullClippingMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x36)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x36)] set; }

        [DispId(0x37)]
        public virtual enumLayers LayersShown { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x37)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x37)] set; }

        [DispId(0x38)]
        public virtual enumLayers LayersPrinted { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x38)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x38)] set; }

        [DispId(0x3a)]
        public virtual bool NeedsApproval { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3a)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3a)] set; }

        [DispId(0x3b)]
        public virtual string CauseForApproval { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3b)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3b)] set; }

        [DispId(1)]
        public virtual LabelManager2.Variables LabelManager2.IDocument.Variables { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] set; }

        [DispId(2)]
        public virtual string LabelManager2.IDocument.Name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] set; }

        [DispId(0)]
        public virtual string this[] { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)] set; }

        [DispId(3)]
        public virtual LabelManager2.DocObjects LabelManager2.IDocument.DocObjects { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] set; }

        [DispId(4)]
        public virtual LabelManager2.Printer LabelManager2.IDocument.Printer { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] set; }

        [DispId(5)]
        public virtual LabelManager2.Format LabelManager2.IDocument.Format { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] set; }

        [DispId(6)]
        public virtual LabelManager2.Database LabelManager2.IDocument.Database { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] set; }

        [DispId(7)]
        public virtual LabelManager2.Application LabelManager2.IDocument.Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] set; }

        [DispId(8)]
        public virtual object LabelManager2.IDocument.Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] set; }

        [DispId(9)]
        public virtual string LabelManager2.IDocument.FullName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] set; }

        [DispId(10)]
        public virtual bool LabelManager2.IDocument.ReadOnly { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)] set; }

        [DispId(11)]
        public virtual enumViewMode LabelManager2.IDocument.ViewMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)] set; }

        [DispId(12)]
        public virtual enumWindowState LabelManager2.IDocument.WindowState { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)] set; }

        [DispId(13)]
        public virtual DocumentProperties LabelManager2.IDocument.BuiltInDocumentProperties { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(13)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(13)] set; }

        [DispId(14)]
        public virtual enumTriggerForm LabelManager2.IDocument.TriggerForm { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(14)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(14)] set; }

        [DispId(15)]
        public virtual enumRotation LabelManager2.IDocument.ViewOrientation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(15)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(15)] set; }

        [DispId(0x10)]
        public virtual bool LabelManager2.IDocument.IsModified { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x10)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x10)] set; }

        [DispId(0x1d)]
        public virtual LabelManager2.SelectedDocObjects LabelManager2.IDocument.SelectedDocObjects { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1d)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1d)] set; }

        [DispId(30)]
        public virtual bool LabelManager2.IDocument.AutoPageIncrement { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(30)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(30)] set; }

        [DispId(0x22)]
        public virtual int LabelManager2.IDocument.HorzPrintOffset { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x22)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x22)] set; }

        [DispId(0x23)]
        public virtual int LabelManager2.IDocument.VertPrintOffset { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x23)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x23)] set; }

        [DispId(0x24)]
        public virtual string LabelManager2.IDocument.RFTagList { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x24)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x24)] set; }

        [DispId(0x2b)]
        public virtual int LabelManager2.IDocument.ViewZoom { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2b)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2b)] set; }

        [DispId(0x2c)]
        public virtual bool LabelManager2.IDocument.Visible { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2c)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2c)] set; }

        [DispId(0x2e)]
        public virtual bool LabelManager2.IDocument.WindowsGraphicalEmulation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2e)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2e)] set; }

        [DispId(0x2f)]
        public virtual bool LabelManager2.IDocument.KeepPrinterObjects { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2f)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x2f)] set; }

        [DispId(0x30)]
        public virtual bool LabelManager2.IDocument.IsResolutionIndependentWysiwyg { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x30)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x30)] set; }

        [DispId(0x31)]
        public virtual LabelManager2.Background LabelManager2.IDocument.Background { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x31)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x31)] set; }

        [DispId(50)]
        public virtual bool LabelManager2.IDocument.RefreshDatabaseBeforePrinting { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(50)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(50)] set; }

        [DispId(0x34)]
        public virtual enumPrintingOptimizationMode LabelManager2.IDocument.PrintingOptimizationMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x34)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x34)] set; }

        [DispId(0x35)]
        public virtual int LabelManager2.IDocument.Version { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x35)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x35)] set; }

        [DispId(0x36)]
        public virtual bool LabelManager2.IDocument.FullClippingMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x36)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x36)] set; }

        [DispId(0x37)]
        public virtual enumLayers LabelManager2.IDocument.LayersShown { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x37)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x37)] set; }

        [DispId(0x38)]
        public virtual enumLayers LabelManager2.IDocument.LayersPrinted { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x38)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x38)] set; }

        [DispId(0x3a)]
        public virtual bool LabelManager2.IDocument.NeedsApproval { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3a)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3a)] set; }

        [DispId(0x3b)]
        public virtual string LabelManager2.IDocument.CauseForApproval { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3b)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3b)] set; }
    }
}

