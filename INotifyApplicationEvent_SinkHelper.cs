namespace LabelManager2
{
    using System;
    using System.Runtime.InteropServices;

    [TypeLibType(TypeLibTypeFlags.FHidden), ClassInterface(ClassInterfaceType.None)]
    public sealed class INotifyApplicationEvent_SinkHelper : INotifyApplicationEvent
    {
        public INotifyApplicationEvent_QuitEventHandler m_QuitDelegate = null;
        public INotifyApplicationEvent_CloseEventHandler m_CloseDelegate = null;
        public INotifyApplicationEvent_DocumentClosedEventHandler m_DocumentClosedDelegate = null;
        public INotifyApplicationEvent_DocumentOpenedEventHandler m_DocumentOpenedDelegate = null;
        public INotifyApplicationEvent_MsgBoxInvokedEventHandler m_MsgBoxInvokedDelegate = null;
        public int m_dwCookie = 0;

        internal INotifyApplicationEvent_SinkHelper()
        {
        }

        public override void Close()
        {
            if (this.m_CloseDelegate != null)
            {
                this.m_CloseDelegate();
            }
        }

        public override void DocumentClosed(string text1)
        {
            if (this.m_DocumentClosedDelegate != null)
            {
                this.m_DocumentClosedDelegate(text1);
            }
        }

        public override void DocumentOpened(string text1)
        {
            if (this.m_DocumentOpenedDelegate != null)
            {
                this.m_DocumentOpenedDelegate(text1);
            }
        }

        public override void MsgBoxInvoked(int num1, int num2, string text1)
        {
            if (this.m_MsgBoxInvokedDelegate != null)
            {
                this.m_MsgBoxInvokedDelegate(num1, num2, text1);
            }
        }

        public override void Quit()
        {
            if (this.m_QuitDelegate != null)
            {
                this.m_QuitDelegate();
            }
        }
    }
}

