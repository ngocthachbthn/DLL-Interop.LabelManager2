namespace LabelManager2
{
    using System.Runtime.InteropServices;

    [ComImport, CoClass(typeof(ApplicationClass)), Guid("3624B9C3-9E5D-11D3-A896-00C04F324E22")]
    public interface Application : IApplication, INotifyApplicationEvent_Event
    {
    }
}

