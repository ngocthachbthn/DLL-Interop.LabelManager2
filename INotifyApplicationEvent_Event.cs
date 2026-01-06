namespace LabelManager2
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComVisible(false), TypeLibType((short) 0x10), ComEventInterface(typeof(INotifyApplicationEvent), typeof(INotifyApplicationEvent_EventProvider))]
    public interface INotifyApplicationEvent_Event
    {
        event INotifyApplicationEvent_CloseEventHandler Close;

        event INotifyApplicationEvent_DocumentClosedEventHandler DocumentClosed;

        event INotifyApplicationEvent_DocumentOpenedEventHandler DocumentOpened;

        event INotifyApplicationEvent_MsgBoxInvokedEventHandler MsgBoxInvoked;

        event INotifyApplicationEvent_QuitEventHandler Quit;
    }
}

