using System;
using Java.Util.Randoms;

namespace Java.Util
{
	partial class SplittableRandom
	{
		IRandomGenerator.ISplittableGenerator? IRandomGenerator.ISplittableGenerator.Split () => Split ();

		IRandomGenerator.ISplittableGenerator? IRandomGenerator.ISplittableGenerator.Split (IRandomGenerator.ISplittableGenerator? p0) => Split (p0);
	}
}
