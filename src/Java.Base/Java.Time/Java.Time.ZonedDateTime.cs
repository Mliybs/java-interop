using System;
using Java.Interop;
using Java.Time.Temporal;

namespace Java.Time
{
	partial class ZonedDateTime
	{
		ITemporal? ITemporal.Plus (long p0, ITemporalUnit? p1) => Plus (p0, p1);
		ITemporal? ITemporal.With (ITemporalField? p0, long p1) => With (p0, p1);

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
