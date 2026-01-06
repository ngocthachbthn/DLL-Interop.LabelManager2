namespace LabelManager2
{
    using System.Runtime.InteropServices;

    [ComImport, CoClass(typeof(DocumentClass)), Guid("3624B9C6-9E5D-11D3-A896-00C04F324E22")]
    public interface Document : IDocument, INotifyDocumentEvent_Event
    {
    }
}

