using Java.Interop;

namespace Java.Util;

public partial interface IEventListener : IJavaPeerable
{
}

[global::Java.Interop.JniTypeSignature("java/util/EventListener", GenerateJavaPeer = false)]
internal partial class IEventListenerInvoker : global::Java.Lang.Object, IEventListener
{
    [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    public override global::Java.Interop.JniPeerMembers JniPeerMembers
    {
        get { return _members_java_util_EventListener; }
    }

    static readonly JniPeerMembers _members_java_util_EventListener = new JniPeerMembers("java/util/EventListener", typeof(IEventListenerInvoker));

    public IEventListenerInvoker(ref JniObjectReference reference, JniObjectReferenceOptions options) : base(ref reference, options)
    {
    }

}