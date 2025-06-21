using System;
using Java.Interop;

namespace Java.Time.Chrono
{
	partial class AbstractChronology
	{
		public unsafe int CompareTo (global::Java.Lang.Object? p0)
		{
			const string __id = "compareTo.(Ljava/lang/Object;)I";
			var native_p0 = (p0?.PeerReference ?? default);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}
	}
}
