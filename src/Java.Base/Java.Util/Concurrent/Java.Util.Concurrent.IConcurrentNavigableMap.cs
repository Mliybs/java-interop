using System;

namespace Java.Util.Concurrent
{
	partial interface IConcurrentNavigableMap
	{
		global::Java.Util.ISortedMap? global::Java.Util.ISortedMap.HeadMap (global::Java.Lang.Object? p0) => HeadMap (p0);

		global::Java.Util.ISet? global::Java.Util.ISortedMap.KeySet () => KeySet ();

		global::Java.Util.ISortedMap? global::Java.Util.ISortedMap.SubMap (global::Java.Lang.Object? p0, global::Java.Lang.Object? p1) => SubMap (p0, p1);

		global::Java.Util.ISortedMap? global::Java.Util.ISortedMap.TailMap (global::Java.Lang.Object? p0) => TailMap (p0);

		global::Java.Util.ISet? global::Java.Util.IMap.KeySet () => KeySet ();
	}

	partial class IConcurrentNavigableMapInvoker
	{
		INavigableSet? IConcurrentNavigableMap.KeySet () => KeySet ();

		INavigableMap? INavigableMap.DescendingMap () => DescendingMap ();

		ISortedMap? INavigableMap.HeadMap (Lang.Object? p0) => HeadMap (p0);

		INavigableMap? INavigableMap.HeadMap (Lang.Object? p0, bool p1) => HeadMap (p0, p1);

		INavigableMap? INavigableMap.SubMap (Lang.Object? p0, bool p1, Lang.Object? p2, bool p3) => SubMap (p0, p1, p2, p3);

		ISortedMap? INavigableMap.SubMap (Lang.Object? p0, Lang.Object? p1) => SubMap (p0, p1);

		ISortedMap? INavigableMap.TailMap (Lang.Object? p0) => TailMap (p0);

		INavigableMap? INavigableMap.TailMap (Lang.Object? p0, bool p1) => TailMap (p0, p1);

		ISortedMap? ISortedMap.HeadMap (Lang.Object? p0) => HeadMap (p0);

		ISortedMap? ISortedMap.SubMap (Lang.Object? p0, Lang.Object? p1) => SubMap (p0, p1);

		ISortedMap? ISortedMap.TailMap (Lang.Object? p0) => TailMap (p0);
	}
}
