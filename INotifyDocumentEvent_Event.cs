namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [TypeLibType((short) 0x10), ComVisible(false), ComEventInterface(typeof(INotifyDocumentEvent), typeof(INotifyDocumentEvent_EventProvider))]
    public interface INotifyDocumentEvent_Event
    {
        event INotifyDocumentEvent_BeginPrintingEventHandler BeginPrinting;

        event INotifyDocumentEvent_ChangeEventHandler Change;

        event INotifyDocumentEvent_CloseEventHandler Close;

        event INotifyDocumentEvent_EndPrintingEventHandler EndPrinting;

        event INotifyDocumentEvent_EndPrintingReportEventHandler EndPrintingReport;

        event INotifyDocumentEvent_PausedPrintingEventHandler PausedPrinting;

        event INotifyDocumentEvent_ProgressPrintingEventHandler ProgressPrinting;
    }
}

