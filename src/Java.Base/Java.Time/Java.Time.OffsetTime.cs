using System;
using Java.Time.Temporal;

namespace Java.Time
{
	partial class OffsetTime
	{
		ITemporal? ITemporal.Plus (long p0, ITemporalUnit? p1) => Plus (p0, p1);
		ITemporal? ITemporal.With (ITemporalField? p0, long p1) => With (p0, p1);
	}
}
