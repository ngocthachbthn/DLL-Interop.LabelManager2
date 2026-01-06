namespace LabelManager2
{
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.ComTypes;
    using System.Threading;

    internal sealed class INotifyDocumentEvent_EventProvider : INotifyDocumentEvent_Event, IDisposable
    {
        private IConnectionPointContainer m_ConnectionPointContainer;
        private ArrayList m_aEventSinkHelpers;
        private IConnectionPoint m_ConnectionPoint;

        public INotifyDocumentEvent_EventProvider(object obj1)
        {
            this.m_ConnectionPointContainer = (IConnectionPointContainer) obj1;
        }

        public override void add_BeginPrinting(INotifyDocumentEvent_BeginPrintingEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyDocumentEvent_SinkHelper helper = new INotifyDocumentEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_BeginPrintingDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_Change(INotifyDocumentEvent_ChangeEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyDocumentEvent_SinkHelper helper = new INotifyDocumentEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_ChangeDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_Close(INotifyDocumentEvent_CloseEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyDocumentEvent_SinkHelper helper = new INotifyDocumentEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_CloseDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_EndPrinting(INotifyDocumentEvent_EndPrintingEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyDocumentEvent_SinkHelper helper = new INotifyDocumentEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_EndPrintingDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_EndPrintingReport(INotifyDocumentEvent_EndPrintingReportEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyDocumentEvent_SinkHelper helper = new INotifyDocumentEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_EndPrintingReportDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_PausedPrinting(INotifyDocumentEvent_PausedPrintingEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyDocumentEvent_SinkHelper helper = new INotifyDocumentEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_PausedPrintingDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_ProgressPrinting(INotifyDocumentEvent_ProgressPrintingEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyDocumentEvent_SinkHelper helper = new INotifyDocumentEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_ProgressPrintingDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void Dispose()
        {
            this.Finalize();
            GC.SuppressFinalize(this);
        }

        public override void Finalize()
        {
            Monitor.Enter(this);
            try
            {
                if (this.m_ConnectionPoint != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int num2 = 0;
                    if (0 < count)
                    {
                        do
                        {
                            INotifyDocumentEvent_SinkHelper helper = (INotifyDocumentEvent_SinkHelper) this.m_aEventSinkHelpers[num2];
                            this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                            num2++;
                        }
                        while (num2 < count);
                    }
                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Monitor.Exit(this);
            }
        }

        private void Init()
        {
            IConnectionPoint ppCP = null;
            Guid riid = new Guid(new byte[] { 0xc5, 0xb9, 0x24, 0x36, 0x5d, 0x9e, 0xd3, 0x11, 0xa8, 150, 0, 0xc0, 0x4f, 50, 0x4e, 0x22 });
            this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
            this.m_ConnectionPoint = ppCP;
            this.m_aEventSinkHelpers = new ArrayList();
        }

        public override void remove_BeginPrinting(INotifyDocumentEvent_BeginPrintingEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_aEventSinkHelpers != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int index = 0;
                    if (0 < count)
                    {
                        while (true)
                        {
                            INotifyDocumentEvent_SinkHelper helper = (INotifyDocumentEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_BeginPrintingDelegate, null) || !(helper.m_BeginPrintingDelegate.Equals((object) handler1) & 0xff))
                            {
                                index++;
                                if (index < count)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                this.m_aEventSinkHelpers.RemoveAt(index);
                                this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                if (count <= 1)
                                {
                                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                    this.m_ConnectionPoint = null;
                                    this.m_aEventSinkHelpers = null;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        public override void remove_Change(INotifyDocumentEvent_ChangeEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_aEventSinkHelpers != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int index = 0;
                    if (0 < count)
                    {
                        while (true)
                        {
                            INotifyDocumentEvent_SinkHelper helper = (INotifyDocumentEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_ChangeDelegate, null) || !(helper.m_ChangeDelegate.Equals((object) handler1) & 0xff))
                            {
                                index++;
                                if (index < count)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                this.m_aEventSinkHelpers.RemoveAt(index);
                                this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                if (count <= 1)
                                {
                                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                    this.m_ConnectionPoint = null;
                                    this.m_aEventSinkHelpers = null;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        public override void remove_Close(INotifyDocumentEvent_CloseEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_aEventSinkHelpers != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int index = 0;
                    if (0 < count)
                    {
                        while (true)
                        {
                            INotifyDocumentEvent_SinkHelper helper = (INotifyDocumentEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_CloseDelegate, null) || !(helper.m_CloseDelegate.Equals((object) handler1) & 0xff))
                            {
                                index++;
                                if (index < count)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                this.m_aEventSinkHelpers.RemoveAt(index);
                                this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                if (count <= 1)
                                {
                                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                    this.m_ConnectionPoint = null;
                                    this.m_aEventSinkHelpers = null;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        public override void remove_EndPrinting(INotifyDocumentEvent_EndPrintingEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_aEventSinkHelpers != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int index = 0;
                    if (0 < count)
                    {
                        while (true)
                        {
                            INotifyDocumentEvent_SinkHelper helper = (INotifyDocumentEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_EndPrintingDelegate, null) || !(helper.m_EndPrintingDelegate.Equals((object) handler1) & 0xff))
                            {
                                index++;
                                if (index < count)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                this.m_aEventSinkHelpers.RemoveAt(index);
                                this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                if (count <= 1)
                                {
                                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                    this.m_ConnectionPoint = null;
                                    this.m_aEventSinkHelpers = null;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        public override void remove_EndPrintingReport(INotifyDocumentEvent_EndPrintingReportEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_aEventSinkHelpers != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int index = 0;
                    if (0 < count)
                    {
                        while (true)
                        {
                            INotifyDocumentEvent_SinkHelper helper = (INotifyDocumentEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_EndPrintingReportDelegate, null) || !(helper.m_EndPrintingReportDelegate.Equals((object) handler1) & 0xff))
                            {
                                index++;
                                if (index < count)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                this.m_aEventSinkHelpers.RemoveAt(index);
                                this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                if (count <= 1)
                                {
                                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                    this.m_ConnectionPoint = null;
                                    this.m_aEventSinkHelpers = null;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        public override void remove_PausedPrinting(INotifyDocumentEvent_PausedPrintingEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_aEventSinkHelpers != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int index = 0;
                    if (0 < count)
                    {
                        while (true)
                        {
                            INotifyDocumentEvent_SinkHelper helper = (INotifyDocumentEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_PausedPrintingDelegate, null) || !(helper.m_PausedPrintingDelegate.Equals((object) handler1) & 0xff))
                            {
                                index++;
                                if (index < count)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                this.m_aEventSinkHelpers.RemoveAt(index);
                                this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                if (count <= 1)
                                {
                                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                    this.m_ConnectionPoint = null;
                                    this.m_aEventSinkHelpers = null;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        public override void remove_ProgressPrinting(INotifyDocumentEvent_ProgressPrintingEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_aEventSinkHelpers != null)
                {
                    int count = this.m_aEventSinkHelpers.Count;
                    int index = 0;
                    if (0 < count)
                    {
                        while (true)
                        {
                            INotifyDocumentEvent_SinkHelper helper = (INotifyDocumentEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_ProgressPrintingDelegate, null) || !(helper.m_ProgressPrintingDelegate.Equals((object) handler1) & 0xff))
                            {
                                index++;
                                if (index < count)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                this.m_aEventSinkHelpers.RemoveAt(index);
                                this.m_ConnectionPoint.Unadvise(helper.m_dwCookie);
                                if (count <= 1)
                                {
                                    Marshal.ReleaseComObject(this.m_ConnectionPoint);
                                    this.m_ConnectionPoint = null;
                                    this.m_aEventSinkHelpers = null;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}

