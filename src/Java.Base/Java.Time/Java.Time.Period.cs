using System;
using Java.Time.Chrono;
using Java.Time.Temporal;

namespace Java.Time
{
	partial class Period
	{
		IChronoPeriod? IChronoPeriod.MultipliedBy (int p0) => MultipliedBy (p0);
		IChronology? IChronoPeriod.Chronology => Chronology;
		IChronoPeriod? IChronoPeriod.Minus (ITemporalAmount? p0) => Minus (p0);
		IChronoPeriod? IChronoPeriod.Normalized () => Normalized ();
		IChronoPeriod? IChronoPeriod.Plus (ITemporalAmount? p0) => Plus (p0);
	}
}
