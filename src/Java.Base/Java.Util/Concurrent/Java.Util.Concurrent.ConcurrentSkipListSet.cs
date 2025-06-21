using System;

namespace Java.Util.Concurrent
{
	partial class ConcurrentSkipListSet
	{
		ISortedSet? INavigableSet.HeadSet (Lang.Object? p0) => HeadSet (p0);

		ISortedSet? INavigableSet.SubSet (Lang.Object? p0, Lang.Object? p1) => SubSet (p0, p1);

		ISortedSet? INavigableSet.TailSet (Lang.Object? p0) => TailSet (p0);

		ISortedSet? ISortedSet.HeadSet (Lang.Object? p0) => HeadSet (p0);

		ISortedSet? ISortedSet.SubSet (Lang.Object? p0, Lang.Object? p1) => SubSet (p0, p1);

		ISortedSet? ISortedSet.TailSet (Lang.Object? p0) => TailSet (p0);
	}
}
