using System;
using Java.Interop;

namespace Java.Util
{
	partial class AbstractQueue
	{
		[global::Java.Interop.JniMethodSignature ("offer", "(Ljava/lang/Object;)Z")]
		public virtual unsafe bool Offer (global::Java.Lang.Object? e)
		{
			const string __id = "offer.(Ljava/lang/Object;)Z";
			var native_e = (e?.PeerReference ?? default);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		[global::Java.Interop.JniMethodSignature ("peek", "()Ljava/lang/Object;")]
		public virtual unsafe global::Java.Lang.Object? Peek ()
		{
			const string __id = "peek.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		[global::Java.Interop.JniMethodSignature ("poll", "()Ljava/lang/Object;")]
		public virtual unsafe global::Java.Lang.Object? Poll ()
		{
			const string __id = "poll.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}
	}
}
