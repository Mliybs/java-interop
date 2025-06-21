using System;

namespace Java.Util.Concurrent.Locks
{
	partial class ReentrantReadWriteLock
	{
		ILock IReadWriteLock.ReadLock () => throw new NotSupportedException ();
		ILock IReadWriteLock.WriteLock () => throw new NotSupportedException ();
	}
}
