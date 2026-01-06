namespace LabelManager2
{
    using System;
    using System.Runtime.InteropServices;

    [ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
    public sealed class INotifyDocumentEvent_SinkHelper : INotifyDocumentEvent
    {
        public INotifyDocumentEvent_ChangeEventHandler m_ChangeDelegate = null;
        public INotifyDocumentEvent_BeginPrintingEventHandler m_BeginPrintingDelegate = null;
        public INotifyDocumentEvent_ProgressPrintingEventHandler m_ProgressPrintingDelegate = null;
        public INotifyDocumentEvent_EndPrintingEventHandler m_EndPrintingDelegate = null;
        public INotifyDocumentEvent_PausedPrintingEventHandler m_PausedPrintingDelegate = null;
        public INotifyDocumentEvent_CloseEventHandler m_CloseDelegate = null;
        public INotifyDocumentEvent_EndPrintingReportEventHandler m_EndPrintingReportDelegate = null;
        public int m_dwCookie = 0;

        internal INotifyDocumentEvent_SinkHelper()
        {
        }

        public override void BeginPrinting(string text1)
        {
            if (this.m_BeginPrintingDelegate != null)
            {
                this.m_BeginPrintingDelegate(text1);
            }
        }

        public override void Change()
        {
            if (this.m_ChangeDelegate != null)
            {
                this.m_ChangeDelegate();
            }
        }

        public override void Close()
        {
            if (this.m_CloseDelegate != null)
            {
                this.m_CloseDelegate();
            }
        }

        public override void EndPrinting(enumEndPrinting printing1)
        {
            if (this.m_EndPrintingDelegate != null)
            {
                this.m_EndPrintingDelegate(printing1);
            }
        }

        public override void EndPrintingReport(int num1, int num2)
        {
            if (this.m_EndPrintingReportDelegate != null)
            {
                this.m_EndPrintingReportDelegate(num1, num2);
            }
        }

        public override void PausedPrinting(enumPausedReasonPrinting printing1, ref short numRef1)
        {
            if (this.m_PausedPrintingDelegate != null)
            {
                this.m_PausedPrintingDelegate(printing1, ref numRef1);
            }
        }

        public override void ProgressPrinting(short num1, ref short numRef1)
        {
            if (this.m_ProgressPrintingDelegate != null)
            {
                this.m_ProgressPrintingDelegate(num1, ref numRef1);
            }
        }
    }
}

