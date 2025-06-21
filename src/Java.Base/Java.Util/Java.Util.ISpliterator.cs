using System;

namespace Java.Util
{
	partial interface ISpliterator
	{
		partial class IOfDoubleInvoker
		{
			Lang.Object? ISpliterator.IOfPrimitive.TrySplit() => TrySplit () as Lang.Object;
			ISpliterator? ISpliterator.TrySplit () => TrySplit ();
		}

		partial class IOfIntInvoker
		{
			Lang.Object? ISpliterator.IOfPrimitive.TrySplit () => TrySplit () as Lang.Object;
			ISpliterator? ISpliterator.TrySplit () => TrySplit ();
		}

		partial class IOfLongInvoker
		{
			Lang.Object? ISpliterator.IOfPrimitive.TrySplit () => TrySplit () as Lang.Object;
			ISpliterator? ISpliterator.TrySplit () => TrySplit ();
		}

		partial class IOfPrimitiveInvoker
		{
			ISpliterator? ISpliterator.TrySplit () => TrySplit () as ISpliterator;
		}
	}
}
