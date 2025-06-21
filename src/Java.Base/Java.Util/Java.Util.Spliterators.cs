using System;
using Java.Util.Function;

namespace Java.Util
{
	partial class Spliterators
	{
		partial class AbstractDoubleSpliterator
		{
			bool ISpliterator.IOfPrimitive.TryAdvance (Lang.Object? p0) => throw new NotImplementedException ();

			bool ISpliterator.TryAdvance (IConsumer? p0) => throw new NotImplementedException ();

			Lang.Object? ISpliterator.IOfPrimitive.TrySplit () => TrySplit () as Lang.Object;

			ISpliterator? ISpliterator.TrySplit () => TrySplit ();
		}

		partial class AbstractIntSpliterator
		{
			bool ISpliterator.IOfPrimitive.TryAdvance (Lang.Object? p0) => throw new NotImplementedException ();

			bool ISpliterator.TryAdvance (IConsumer? p0) => throw new NotImplementedException ();

			Lang.Object? ISpliterator.IOfPrimitive.TrySplit () => TrySplit () as Lang.Object;

			ISpliterator? ISpliterator.TrySplit () => TrySplit ();
		}

		partial class AbstractLongSpliterator
		{
			bool ISpliterator.IOfPrimitive.TryAdvance (Lang.Object? p0) => throw new NotImplementedException ();

			bool ISpliterator.TryAdvance (IConsumer? p0) => throw new NotImplementedException ();

			Lang.Object? ISpliterator.IOfPrimitive.TrySplit () => TrySplit () as Lang.Object;

			ISpliterator? ISpliterator.TrySplit () => TrySplit ();
		}

		partial class AbstractSpliterator
		{
			bool ISpliterator.TryAdvance (IConsumer? p0) => throw new NotImplementedException ();

			ISpliterator? ISpliterator.TrySplit () => TrySplit ();
		}
	}
}
