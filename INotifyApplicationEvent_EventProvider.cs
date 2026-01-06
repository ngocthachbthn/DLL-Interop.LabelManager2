namespace LabelManager2
{
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.ComTypes;
    using System.Threading;

    internal sealed class INotifyApplicationEvent_EventProvider : INotifyApplicationEvent_Event, IDisposable
    {
        private IConnectionPointContainer m_ConnectionPointContainer;
        private ArrayList m_aEventSinkHelpers;
        private IConnectionPoint m_ConnectionPoint;

        public INotifyApplicationEvent_EventProvider(object obj1)
        {
            this.m_ConnectionPointContainer = (IConnectionPointContainer) obj1;
        }

        public override void add_Close(INotifyApplicationEvent_CloseEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyApplicationEvent_SinkHelper helper = new INotifyApplicationEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_CloseDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_DocumentClosed(INotifyApplicationEvent_DocumentClosedEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyApplicationEvent_SinkHelper helper = new INotifyApplicationEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_DocumentClosedDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_DocumentOpened(INotifyApplicationEvent_DocumentOpenedEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyApplicationEvent_SinkHelper helper = new INotifyApplicationEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_DocumentOpenedDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_MsgBoxInvoked(INotifyApplicationEvent_MsgBoxInvokedEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyApplicationEvent_SinkHelper helper = new INotifyApplicationEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_MsgBoxInvokedDelegate = handler1;
                this.m_aEventSinkHelpers.Add((object) helper);
            }
        }

        public override void add_Quit(INotifyApplicationEvent_QuitEventHandler handler1)
        {
            lock (this)
            {
                if (this.m_ConnectionPoint == null)
                {
                    this.Init();
                }
                INotifyApplicationEvent_SinkHelper helper = new INotifyApplicationEvent_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object) helper, out pdwCookie);
                helper.m_dwCookie = pdwCookie;
                helper.m_QuitDelegate = handler1;
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
                            INotifyApplicationEvent_SinkHelper helper = (INotifyApplicationEvent_SinkHelper) this.m_aEventSinkHelpers[num2];
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
            Guid riid = new Guid(new byte[] { 0xc4, 0xb9, 0x24, 0x36, 0x5d, 0x9e, 0xd3, 0x11, 0xa8, 150, 0, 0xc0, 0x4f, 50, 0x4e, 0x22 });
            this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
            this.m_ConnectionPoint = ppCP;
            this.m_aEventSinkHelpers = new ArrayList();
        }

        public override void remove_Close(INotifyApplicationEvent_CloseEventHandler handler1)
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
                            INotifyApplicationEvent_SinkHelper helper = (INotifyApplicationEvent_SinkHelper) this.m_aEventSinkHelpers[index];
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

        public override void remove_DocumentClosed(INotifyApplicationEvent_DocumentClosedEventHandler handler1)
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
                            INotifyApplicationEvent_SinkHelper helper = (INotifyApplicationEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_DocumentClosedDelegate, null) || !(helper.m_DocumentClosedDelegate.Equals((object) handler1) & 0xff))
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

        public override void remove_DocumentOpened(INotifyApplicationEvent_DocumentOpenedEventHandler handler1)
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
                            INotifyApplicationEvent_SinkHelper helper = (INotifyApplicationEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_DocumentOpenedDelegate, null) || !(helper.m_DocumentOpenedDelegate.Equals((object) handler1) & 0xff))
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

        public override void remove_MsgBoxInvoked(INotifyApplicationEvent_MsgBoxInvokedEventHandler handler1)
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
                            INotifyApplicationEvent_SinkHelper helper = (INotifyApplicationEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_MsgBoxInvokedDelegate, null) || !(helper.m_MsgBoxInvokedDelegate.Equals((object) handler1) & 0xff))
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

        public override void remove_Quit(INotifyApplicationEvent_QuitEventHandler handler1)
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
                            INotifyApplicationEvent_SinkHelper helper = (INotifyApplicationEvent_SinkHelper) this.m_aEventSinkHelpers[index];
                            if (ReferenceEquals(helper.m_QuitDelegate, null) || !(helper.m_QuitDelegate.Equals((object) handler1) & 0xff))
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

