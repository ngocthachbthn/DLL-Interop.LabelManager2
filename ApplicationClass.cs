namespace LabelManager2
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, ComSourceInterfaces("LabelManager2.INotifyApplicationEvent\0"), Guid("3624B9C0-9E5D-11D3-A896-00C04F324E22"), TypeLibType((short) 2), ClassInterface((short) 0), DefaultMember("_Name")]
    public class ApplicationClass : IApplication, LabelManager2.Application, INotifyApplicationEvent_Event
    {
        public virtual event INotifyApplicationEvent_CloseEventHandler Close;

        public virtual event INotifyApplicationEvent_DocumentClosedEventHandler DocumentClosed;

        public virtual event INotifyApplicationEvent_DocumentOpenedEventHandler DocumentOpened;

        public virtual event INotifyApplicationEvent_QuitEventHandler INotifyApplicationEvent_Event_Quit;

        public virtual event INotifyApplicationEvent_MsgBoxInvokedEventHandler MsgBoxInvoked;

        [return: MarshalAs(UnmanagedType.Struct)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x34)]
        public virtual extern object DocumentStatus([MarshalAs(UnmanagedType.BStr)] string docName);
        [return: MarshalAs(UnmanagedType.BStr)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1d)]
        public virtual extern string ErrorMessage([In] short ErrorCode);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x35)]
        public virtual extern LabelManager2.FormatSystem FormatSystem();
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x36)]
        public virtual extern DocumentProperties GetDocumentProperties([MarshalAs(UnmanagedType.BStr)] string docName);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1c)]
        public virtual extern short GetLastError();
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x33)]
        public virtual extern LabelManager2.LabelArchive LabelArchive();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x27)]
        public virtual extern bool Lock([In, MarshalAs(UnmanagedType.BStr)] string Key);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1a)]
        public virtual extern void Move([In] int Left, [In] int Top);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x18)]
        public virtual extern LabelManager2.PrinterSystem PrinterSystem();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x17)]
        public virtual extern void Quit();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x19)]
        public virtual extern void Resize([In] int Width, [In] int Height);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1b)]
        public virtual extern void ShowHelp([In, MarshalAs(UnmanagedType.BStr)] string strHelpFile = "", [In] int HelpContextID = 0);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(40)]
        public virtual extern bool Unlock([In, MarshalAs(UnmanagedType.BStr)] string Key);
        [return: MarshalAs(UnmanagedType.Interface)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x31)]
        public virtual extern LabelManager2.VisualManager VisualManager();

        [DispId(1)]
        public virtual bool Visible { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] set; }

        [DispId(2)]
        public virtual bool UserControl { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] set; }

        [DispId(3)]
        public virtual LabelManager2.Documents Documents { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] set; }

        [DispId(4)]
        public virtual LabelManager2.Dialogs Dialogs { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] set; }

        [DispId(5)]
        public virtual object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] set; }

        [DispId(6)]
        public virtual string Caption { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] set; }

        [DispId(7)]
        public virtual string DefaultFilePath { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] set; }

        [DispId(8)]
        public virtual string FullName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] set; }

        [DispId(9)]
        public virtual string Name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] set; }

        [DispId(0)]
        public virtual string this[] { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)] set; }

        [DispId(10)]
        public virtual string Path { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)] set; }

        [DispId(11)]
        public virtual LabelManager2.Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)] set; }

        [DispId(12)]
        public virtual LabelManager2.Options Options { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)] set; }

        [DispId(13)]
        public virtual string Version { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(13)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(13)] set; }

        [DispId(14)]
        public virtual int Width { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(14)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(14)] set; }

        [DispId(15)]
        public virtual int Height { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(15)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(15)] set; }

        [DispId(0x10)]
        public virtual int Left { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x10)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x10)] set; }

        [DispId(0x11)]
        public virtual int Top { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x11)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x11)] set; }

        [DispId(0x12)]
        public virtual Document ActiveDocument { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x12)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x12)] set; }

        [DispId(0x13)]
        public virtual bool Locked { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x13)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x13)] set; }

        [DispId(20)]
        public virtual LabelManager2.RecentFiles RecentFiles { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(20)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(20)] set; }

        [DispId(0x15)]
        public virtual bool EnableEvents { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x15)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x15)] set; }

        [DispId(0x16)]
        public virtual string ActivePrinterName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x16)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x16)] set; }

        [DispId(30)]
        public virtual LabelManager2.SharedOwner SharedOwner { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(30)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(30)] set; }

        [DispId(0x1f)]
        public virtual int MainWndHandle { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1f)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1f)] set; }

        [DispId(0x20)]
        public virtual bool IsEval { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x20)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x20)] set; }

        [DispId(0x21)]
        public virtual int PID { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x21)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x21)] set; }

        [DispId(0x22)]
        public virtual int ProgramCode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x22)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x22)] set; }

        [DispId(0x23)]
        public virtual int PrintMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x23)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x23)] set; }

        [DispId(0x24)]
        public virtual int DisplayPrintMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x24)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x24)] set; }

        [DispId(0x25)]
        public virtual bool UseUserInterface { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x25)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x25)] set; }

        [DispId(0x26)]
        public virtual LabelManager2.ProductInfos ProductInfos { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x26)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x26)] set; }

        [DispId(0x29)]
        public virtual int Category { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x29)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x29)] set; }

        [DispId(0x37)]
        public virtual int SerializationVersion { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x37)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x37)] set; }

        [DispId(0x38)]
        public virtual int ClientWindow { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x38)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x38)] set; }

        [DispId(0x39)]
        public virtual string TxtSettingsCharsStart { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x39)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x39)] set; }

        [DispId(0x3a)]
        public virtual string TxtSettingsCharsEnd { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3a)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3a)] set; }

        [DispId(0x3b)]
        public virtual LabelManager2.LogFile LogFile { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3b)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3b)] set; }

        [DispId(1)]
        public virtual bool LabelManager2.IApplication.Visible { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] set; }

        [DispId(2)]
        public virtual bool LabelManager2.IApplication.UserControl { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] set; }

        [DispId(3)]
        public virtual LabelManager2.Documents LabelManager2.IApplication.Documents { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] set; }

        [DispId(4)]
        public virtual LabelManager2.Dialogs LabelManager2.IApplication.Dialogs { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(4)] set; }

        [DispId(5)]
        public virtual object LabelManager2.IApplication.Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(5)] set; }

        [DispId(6)]
        public virtual string LabelManager2.IApplication.Caption { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(6)] set; }

        [DispId(7)]
        public virtual string LabelManager2.IApplication.DefaultFilePath { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(7)] set; }

        [DispId(8)]
        public virtual string LabelManager2.IApplication.FullName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8)] set; }

        [DispId(9)]
        public virtual string LabelManager2.IApplication.Name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(9)] set; }

        [DispId(0)]
        public virtual string this[] { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0)] set; }

        [DispId(10)]
        public virtual string LabelManager2.IApplication.Path { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(10)] set; }

        [DispId(11)]
        public virtual LabelManager2.Application LabelManager2.IApplication.Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(11)] set; }

        [DispId(12)]
        public virtual LabelManager2.Options LabelManager2.IApplication.Options { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(12)] set; }

        [DispId(13)]
        public virtual string LabelManager2.IApplication.Version { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(13)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(13)] set; }

        [DispId(14)]
        public virtual int LabelManager2.IApplication.Width { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(14)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(14)] set; }

        [DispId(15)]
        public virtual int LabelManager2.IApplication.Height { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(15)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(15)] set; }

        [DispId(0x10)]
        public virtual int LabelManager2.IApplication.Left { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x10)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x10)] set; }

        [DispId(0x11)]
        public virtual int LabelManager2.IApplication.Top { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x11)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x11)] set; }

        [DispId(0x12)]
        public virtual Document LabelManager2.IApplication.ActiveDocument { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x12)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x12)] set; }

        [DispId(0x13)]
        public virtual bool LabelManager2.IApplication.Locked { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x13)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x13)] set; }

        [DispId(20)]
        public virtual LabelManager2.RecentFiles LabelManager2.IApplication.RecentFiles { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(20)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(20)] set; }

        [DispId(0x15)]
        public virtual bool LabelManager2.IApplication.EnableEvents { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x15)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x15)] set; }

        [DispId(0x16)]
        public virtual string LabelManager2.IApplication.ActivePrinterName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x16)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x16)] set; }

        [DispId(30)]
        public virtual LabelManager2.SharedOwner LabelManager2.IApplication.SharedOwner { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(30)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(30)] set; }

        [DispId(0x1f)]
        public virtual int LabelManager2.IApplication.MainWndHandle { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1f)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x1f)] set; }

        [DispId(0x20)]
        public virtual bool LabelManager2.IApplication.IsEval { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x20)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x20)] set; }

        [DispId(0x21)]
        public virtual int LabelManager2.IApplication.PID { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x21)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x21)] set; }

        [DispId(0x22)]
        public virtual int LabelManager2.IApplication.ProgramCode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x22)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x22)] set; }

        [DispId(0x23)]
        public virtual int LabelManager2.IApplication.PrintMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x23)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x23)] set; }

        [DispId(0x24)]
        public virtual int LabelManager2.IApplication.DisplayPrintMode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x24)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x24)] set; }

        [DispId(0x25)]
        public virtual bool LabelManager2.IApplication.UseUserInterface { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x25)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x25)] set; }

        [DispId(0x26)]
        public virtual LabelManager2.ProductInfos LabelManager2.IApplication.ProductInfos { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x26)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x26)] set; }

        [DispId(0x29)]
        public virtual int LabelManager2.IApplication.Category { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x29)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x29)] set; }

        [DispId(0x37)]
        public virtual int LabelManager2.IApplication.SerializationVersion { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x37)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x37)] set; }

        [DispId(0x38)]
        public virtual int LabelManager2.IApplication.ClientWindow { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x38)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x38)] set; }

        [DispId(0x39)]
        public virtual string LabelManager2.IApplication.TxtSettingsCharsStart { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x39)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x39)] set; }

        [DispId(0x3a)]
        public virtual string LabelManager2.IApplication.TxtSettingsCharsEnd { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3a)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3a)] set; }

        [DispId(0x3b)]
        public virtual LabelManager2.LogFile LabelManager2.IApplication.LogFile { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3b)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3b)] set; }
    }
}

