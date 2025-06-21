using System;
using System.Collections.Generic;
using Java.Interop;
using Java.Lang.Reflect;
using Java.Time.Temporal;

namespace Java.Time.Chrono {

	partial class IChronoLocalDateInvoker
	{
		ITemporal? ITemporal.Plus (long p0, ITemporalUnit? p1) => throw new NotSupportedException ();
		ITemporal? ITemporal.With (ITemporalField? p0, long p1) => throw new NotSupportedException ();
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']"
	[global::Java.Interop.JniTypeSignature ("java/time/chrono/ChronoLocalDate", GenerateJavaPeer=false, InvokerType=typeof (Java.Time.Chrono.IChronoLocalDateInvoker))]
	public partial interface IChronoLocalDate : global::Java.Lang.IComparable, global::Java.Time.Temporal.ITemporal, global::Java.Time.Temporal.ITemporalAdjuster {
		private static readonly JniPeerMembers _members = new JniPeerMembers ("java/time/chrono/ChronoLocalDate", typeof (IChronoLocalDate), isInterface: true);

		global::Java.Time.Chrono.IChronology? Chronology {
			// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='getChronology' and count(parameter)=0]"
			[global::Java.Interop.JniMethodSignature ("getChronology", "()Ljava/time/chrono/Chronology;")]
			get; 
		}

		virtual unsafe global::Java.Time.Chrono.IEra? Era {
			// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='getEra' and count(parameter)=0]"
			get {
				const string __id = "getEra.()Ljava/time/chrono/Era;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IEra> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
				} finally {
				}
			}
		}

		virtual unsafe bool IsLeapYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='isLeapYear' and count(parameter)=0]"
			get {
				const string __id = "isLeapYear.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[global::Java.Interop.JniMethodSignature ("equals", "(Ljava/lang/Object;)Z")]
		bool Equals (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='hashCode' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("hashCode", "()I")]
		int GetHashCode ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='lengthOfMonth' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("lengthOfMonth", "()I")]
		int LengthOfMonth ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='toString' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("toString", "()Ljava/lang/String;")]
		string? ToString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='until' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDate']]"
		[global::Java.Interop.JniMethodSignature ("until", "(Ljava/time/chrono/ChronoLocalDate;)Ljava/time/chrono/ChronoPeriod;")]
		global::Java.Time.Chrono.IChronoPeriod? Until (global::Java.Time.Chrono.IChronoLocalDate? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='until' and count(parameter)=2 and parameter[1][@type='java.time.temporal.Temporal'] and parameter[2][@type='java.time.temporal.TemporalUnit']]"
		[global::Java.Interop.JniMethodSignature ("until", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J")]
		long Until (global::Java.Time.Temporal.ITemporal? p0, global::Java.Time.Temporal.ITemporalUnit? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='adjustInto' and count(parameter)=1 and parameter[1][@type='java.time.temporal.Temporal']]"
		[global::Java.Interop.JniMethodSignature ("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;")]
		unsafe global::Java.Time.Temporal.ITemporal? Java.Time.Temporal.ITemporalAdjuster.AdjustInto (global::Java.Time.Temporal.ITemporal? temporal)
		{
			const string __id = "adjustInto.(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (temporal);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Temporal.ITemporal> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (temporal);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='atTime' and count(parameter)=1 and parameter[1][@type='java.time.LocalTime']]"
		[global::Java.Interop.JniMethodSignature ("atTime", "(Ljava/time/LocalTime;)Ljava/time/chrono/ChronoLocalDateTime;")]
		virtual unsafe global::Java.Time.Chrono.IChronoLocalDateTime? AtTime (global::Java.Time.LocalTime? localTime)
		{
			const string __id = "atTime.(Ljava/time/LocalTime;)Ljava/time/chrono/ChronoLocalDateTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (localTime);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (localTime);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDate']]"
		[global::Java.Interop.JniMethodSignature ("compareTo", "(Ljava/time/chrono/ChronoLocalDate;)I")]
		virtual unsafe int CompareTo (global::Java.Time.Chrono.IChronoLocalDate? other)
		{
			const string __id = "compareTo.(Ljava/time/chrono/ChronoLocalDate;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.time.format.DateTimeFormatter']]"
		[global::Java.Interop.JniMethodSignature ("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;")]
		virtual unsafe string? Format (global::Java.Time.Format.DateTimeFormatter? formatter)
		{
			const string __id = "format.(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (formatter);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Strings.ToString (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (formatter);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalAccessor']]"
		[global::Java.Interop.JniMethodSignature ("from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDate;")]
		public static unsafe global::Java.Time.Chrono.IChronoLocalDate? From (global::Java.Time.Temporal.ITemporalAccessor? temporal)
		{
			const string __id = "from.(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (temporal);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDate> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (temporal);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='isAfter' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDate']]"
		[global::Java.Interop.JniMethodSignature ("isAfter", "(Ljava/time/chrono/ChronoLocalDate;)Z")]
		virtual unsafe bool IsAfter (global::Java.Time.Chrono.IChronoLocalDate? other)
		{
			const string __id = "isAfter.(Ljava/time/chrono/ChronoLocalDate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='isBefore' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDate']]"
		[global::Java.Interop.JniMethodSignature ("isBefore", "(Ljava/time/chrono/ChronoLocalDate;)Z")]
		virtual unsafe bool IsBefore (global::Java.Time.Chrono.IChronoLocalDate? other)
		{
			const string __id = "isBefore.(Ljava/time/chrono/ChronoLocalDate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='isEqual' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDate']]"
		[global::Java.Interop.JniMethodSignature ("isEqual", "(Ljava/time/chrono/ChronoLocalDate;)Z")]
		virtual unsafe bool IsEqual (global::Java.Time.Chrono.IChronoLocalDate? other)
		{
			const string __id = "isEqual.(Ljava/time/chrono/ChronoLocalDate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalField']]"
		[global::Java.Interop.JniMethodSignature ("isSupported", "(Ljava/time/temporal/TemporalField;)Z")]
		unsafe bool Java.Time.Temporal.ITemporalAccessor.IsSupported (global::Java.Time.Temporal.ITemporalField? field)
		{
			const string __id = "isSupported.(Ljava/time/temporal/TemporalField;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (field);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (field);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalUnit']]"
		[global::Java.Interop.JniMethodSignature ("isSupported", "(Ljava/time/temporal/TemporalUnit;)Z")]
		unsafe bool Java.Time.Temporal.ITemporal.IsSupported (global::Java.Time.Temporal.ITemporalUnit? unit)
		{
			const string __id = "isSupported.(Ljava/time/temporal/TemporalUnit;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unit);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (unit);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='lengthOfYear' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("lengthOfYear", "()I")]
		virtual unsafe int LengthOfYear ()
		{
			const string __id = "lengthOfYear.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='minus' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalAmount']]"
		//[global::Java.Interop.JniMethodSignature ("minus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDate? Java.Time.Temporal.ITemporal.Minus (global::Java.Time.Temporal.ITemporalAmount? amount)
		//{
		//	const string __id = "minus.(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [1];
		//		__args [0] = new JniArgumentValue (amount);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDate> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (amount);
		//	}
		//}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='minus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.time.temporal.TemporalUnit']]"
		//[global::Java.Interop.JniMethodSignature ("minus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDate? Java.Time.Temporal.ITemporal.Minus (long amountToSubtract, global::Java.Time.Temporal.ITemporalUnit? unit)
		//{
		//	const string __id = "minus.(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [2];
		//		__args [0] = new JniArgumentValue (amountToSubtract);
		//		__args [1] = new JniArgumentValue (unit);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDate> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (unit);
		//	}
		//}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='plus' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalAmount']]"
		//[global::Java.Interop.JniMethodSignature ("plus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDate? Java.Time.Temporal.ITemporal.Plus (global::Java.Time.Temporal.ITemporalAmount? amount)
		//{
		//	const string __id = "plus.(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [1];
		//		__args [0] = new JniArgumentValue (amount);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDate> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (amount);
		//	}
		//}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='plus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.time.temporal.TemporalUnit']]"
		//[global::Java.Interop.JniMethodSignature ("plus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDate? Java.Time.Temporal.ITemporal.Plus (long amountToAdd, global::Java.Time.Temporal.ITemporalUnit? unit)
		//{
		//	const string __id = "plus.(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [2];
		//		__args [0] = new JniArgumentValue (amountToAdd);
		//		__args [1] = new JniArgumentValue (unit);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDate> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (unit);
		//	}
		//}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='query' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalQuery&lt;R&gt;']]"
		[global::Java.Interop.JniMethodSignature ("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		unsafe global::Java.Lang.Object? Java.Time.Temporal.ITemporalAccessor.Query (global::Java.Time.Temporal.ITemporalQuery? query)
		{
			const string __id = "query.(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (query);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object>(ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (query);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='timeLineOrder' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("timeLineOrder", "()Ljava/util/Comparator;")]
		public static unsafe global::Java.Util.IComparator? TimeLineOrder ()
		{
			const string __id = "timeLineOrder.()Ljava/util/Comparator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Util.IComparator> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='toEpochDay' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("toEpochDay", "()J")]
		virtual unsafe long ToEpochDay ()
		{
			const string __id = "toEpochDay.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='with' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalAdjuster']]"
		//[global::Java.Interop.JniMethodSignature ("with", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoLocalDate;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDate? Java.Time.Temporal.ITemporal.With (global::Java.Time.Temporal.ITemporalAdjuster? adjuster)
		//{
		//	const string __id = "with.(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoLocalDate;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [1];
		//		__args [0] = new JniArgumentValue (adjuster);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDate> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (adjuster);
		//	}
		//}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDate']/method[@name='with' and count(parameter)=2 and parameter[1][@type='java.time.temporal.TemporalField'] and parameter[2][@type='long']]"
		//[global::Java.Interop.JniMethodSignature ("with", "(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoLocalDate;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDate? Java.Time.Temporal.ITemporal.With (global::Java.Time.Temporal.ITemporalField? field, long newValue)
		//{
		//	const string __id = "with.(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoLocalDate;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [2];
		//		__args [0] = new JniArgumentValue (field);
		//		__args [1] = new JniArgumentValue (newValue);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDate> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (field);
		//	}
		//}

	}

	[global::Java.Interop.JniTypeSignature ("java/time/chrono/ChronoLocalDate", GenerateJavaPeer=false)]
	internal partial class IChronoLocalDateInvoker : global::Java.Lang.Object, IChronoLocalDate {
		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members_java_time_chrono_ChronoLocalDate; }
		}

		static readonly JniPeerMembers _members_java_lang_Comparable = new JniPeerMembers ("java/lang/Comparable", typeof (IChronoLocalDateInvoker));

		static readonly JniPeerMembers _members_java_time_chrono_ChronoLocalDate = new JniPeerMembers ("java/time/chrono/ChronoLocalDate", typeof (IChronoLocalDateInvoker));

		static readonly JniPeerMembers _members_java_time_temporal_Temporal = new JniPeerMembers ("java/time/temporal/Temporal", typeof (IChronoLocalDateInvoker));

		static readonly JniPeerMembers _members_java_time_temporal_TemporalAccessor = new JniPeerMembers ("java/time/temporal/TemporalAccessor", typeof (IChronoLocalDateInvoker));

		static readonly JniPeerMembers _members_java_time_temporal_TemporalAdjuster = new JniPeerMembers ("java/time/temporal/TemporalAdjuster", typeof (IChronoLocalDateInvoker));

		public IChronoLocalDateInvoker (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
		{
		}

		public unsafe global::Java.Time.Chrono.IChronology? Chronology {
			get {
				const string __id = "getChronology.()Ljava/time/chrono/Chronology;";
				try {
					var __rm = _members_java_time_chrono_ChronoLocalDate.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronology> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
				} finally {
				}
			}
		}

		public unsafe bool Equals (global::Java.Lang.Object? p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_time_chrono_ChronoLocalDate.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members_java_time_chrono_ChronoLocalDate.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		public unsafe int LengthOfMonth ()
		{
			const string __id = "lengthOfMonth.()I";
			try {
				var __rm = _members_java_time_chrono_ChronoLocalDate.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		public unsafe string? ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members_java_time_chrono_ChronoLocalDate.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Strings.ToString (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe global::Java.Time.Chrono.IChronoPeriod? Until (global::Java.Time.Chrono.IChronoLocalDate? p0)
		{
			const string __id = "until.(Ljava/time/chrono/ChronoLocalDate;)Ljava/time/chrono/ChronoPeriod;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_time_chrono_ChronoLocalDate.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoPeriod> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe long Until (global::Java.Time.Temporal.ITemporal? p0, global::Java.Time.Temporal.ITemporalUnit? p1)
		{
			const string __id = "until.(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members_java_time_chrono_ChronoLocalDate.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		public unsafe int CompareTo (global::Java.Lang.Object? p0)
		{
			const string __id = "compareTo.(Ljava/lang/Object;)I";
			var native_p0 = (p0?.PeerReference ?? default);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members_java_lang_Comparable.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe long GetLong (global::Java.Time.Temporal.ITemporalField? p0)
		{
			const string __id = "getLong.(Ljava/time/temporal/TemporalField;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_time_temporal_TemporalAccessor.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
