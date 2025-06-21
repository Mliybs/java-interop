using System;

namespace Java.Util.Stream
{
	partial class IIntStreamInvoker
	{
		IIterator? IBaseStream.Iterator () => Iterator ();
		Lang.Object? IBaseStream.Parallel () => Parallel () as Lang.Object;
		Lang.Object? IBaseStream.Sequential () => Sequential () as Lang.Object;
		ISpliterator? IBaseStream.Spliterator () => Spliterator ();
	}
}
