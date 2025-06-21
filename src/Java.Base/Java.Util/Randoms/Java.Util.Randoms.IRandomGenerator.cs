using System;

namespace Java.Util.Randoms
{
	partial interface IRandomGenerator
	{
		partial class IArbitrarilyJumpableGeneratorInvoker
		{
			IRandomGenerator.ILeapableGenerator? IRandomGenerator.ILeapableGenerator.Copy () => Copy ();
			IRandomGenerator.IJumpableGenerator? IRandomGenerator.IJumpableGenerator.Copy () => Copy ();
		}

		partial class ILeapableGeneratorInvoker
		{
			IRandomGenerator.IJumpableGenerator? IRandomGenerator.IJumpableGenerator.Copy () => Copy ();
		}
	}
}
