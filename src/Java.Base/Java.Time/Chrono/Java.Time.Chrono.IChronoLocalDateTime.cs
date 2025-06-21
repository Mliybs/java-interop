using System;
using System.Collections.Generic;
using Java.Interop;
using Java.Time.Temporal;

namespace Java.Time.Chrono {

	partial class IChronoLocalDateTimeInvoker
	{
		ITemporal? ITemporal.Plus (long p0, ITemporalUnit? p1) => Plus (p0, p1);
		ITemporal? ITemporal.With (ITemporalField? p0, long p1) => With (p0, p1);
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']"
	[global::Java.Interop.JniTypeSignature ("java/time/chrono/ChronoLocalDateTime", GenerateJavaPeer=false, InvokerType=typeof (Java.Time.Chrono.IChronoLocalDateTimeInvoker))]
	[global::Java.Interop.JavaTypeParameters (new string [] {"D extends java.time.chrono.ChronoLocalDate"})]
	public partial interface IChronoLocalDateTime : global::Java.Lang.IComparable, global::Java.Time.Temporal.ITemporal, global::Java.Time.Temporal.ITemporalAdjuster {
		private static readonly JniPeerMembers _members = new JniPeerMembers ("java/time/chrono/ChronoLocalDateTime", typeof (IChronoLocalDateTime), isInterface: true);

		virtual unsafe global::Java.Time.Chrono.IChronology? Chronology {
			// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='getChronology' and count(parameter)=0]"
			get {
				const string __id = "getChronology.()Ljava/time/chrono/Chronology;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronology> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='atZone' and count(parameter)=1 and parameter[1][@type='java.time.ZoneId']]"
		[global::Java.Interop.JniMethodSignature ("atZone", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;")]
		global::Java.Time.Chrono.IChronoZonedDateTime? AtZone (global::Java.Time.ZoneId? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[global::Java.Interop.JniMethodSignature ("equals", "(Ljava/lang/Object;)Z")]
		bool Equals (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='hashCode' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("hashCode", "()I")]
		int GetHashCode ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalField']]"
		[global::Java.Interop.JniMethodSignature ("isSupported", "(Ljava/time/temporal/TemporalField;)Z")]
		bool IsSupported (global::Java.Time.Temporal.ITemporalField? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='plus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.time.temporal.TemporalUnit']]"
		[global::Java.Interop.JniMethodSignature ("plus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDateTime;")]
		global::Java.Time.Chrono.IChronoLocalDateTime? Plus (long p0, global::Java.Time.Temporal.ITemporalUnit? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='toLocalDate' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("toLocalDate", "()Ljava/time/chrono/ChronoLocalDate;")]
		global::Java.Lang.Object? ToLocalDate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='toLocalTime' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("toLocalTime", "()Ljava/time/LocalTime;")]
		global::Java.Time.LocalTime? ToLocalTime ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='toString' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("toString", "()Ljava/lang/String;")]
		string? ToString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='with' and count(parameter)=2 and parameter[1][@type='java.time.temporal.TemporalField'] and parameter[2][@type='long']]"
		[global::Java.Interop.JniMethodSignature ("with", "(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoLocalDateTime;")]
		global::Java.Time.Chrono.IChronoLocalDateTime? With (global::Java.Time.Temporal.ITemporalField? p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='adjustInto' and count(parameter)=1 and parameter[1][@type='java.time.temporal.Temporal']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDateTime&lt;?&gt;']]"
		[global::Java.Interop.JniMethodSignature ("compareTo", "(Ljava/time/chrono/ChronoLocalDateTime;)I")]
		virtual unsafe int CompareTo (global::Java.Time.Chrono.IChronoLocalDateTime? other)
		{
			const string __id = "compareTo.(Ljava/time/chrono/ChronoLocalDateTime;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.time.format.DateTimeFormatter']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalAccessor']]"
		[global::Java.Interop.JniMethodSignature ("from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDateTime;")]
		public static unsafe global::Java.Time.Chrono.IChronoLocalDateTime? From (global::Java.Time.Temporal.ITemporalAccessor? temporal)
		{
			const string __id = "from.(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDateTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (temporal);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (temporal);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='isAfter' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDateTime&lt;?&gt;']]"
		[global::Java.Interop.JniMethodSignature ("isAfter", "(Ljava/time/chrono/ChronoLocalDateTime;)Z")]
		virtual unsafe bool IsAfter (global::Java.Time.Chrono.IChronoLocalDateTime? other)
		{
			const string __id = "isAfter.(Ljava/time/chrono/ChronoLocalDateTime;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='isBefore' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDateTime&lt;?&gt;']]"
		[global::Java.Interop.JniMethodSignature ("isBefore", "(Ljava/time/chrono/ChronoLocalDateTime;)Z")]
		virtual unsafe bool IsBefore (global::Java.Time.Chrono.IChronoLocalDateTime? other)
		{
			const string __id = "isBefore.(Ljava/time/chrono/ChronoLocalDateTime;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='isEqual' and count(parameter)=1 and parameter[1][@type='java.time.chrono.ChronoLocalDateTime&lt;?&gt;']]"
		[global::Java.Interop.JniMethodSignature ("isEqual", "(Ljava/time/chrono/ChronoLocalDateTime;)Z")]
		virtual unsafe bool IsEqual (global::Java.Time.Chrono.IChronoLocalDateTime? other)
		{
			const string __id = "isEqual.(Ljava/time/chrono/ChronoLocalDateTime;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalUnit']]"
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

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='minus' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalAmount']]"
		//[global::Java.Interop.JniMethodSignature ("minus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDateTime;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDateTime? Java.Time.Temporal.ITemporal.Minus (global::Java.Time.Temporal.ITemporalAmount? amount)
		//{
		//	const string __id = "minus.(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDateTime;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [1];
		//		__args [0] = new JniArgumentValue (amount);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (amount);
		//	}
		//}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='minus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.time.temporal.TemporalUnit']]"
		//[global::Java.Interop.JniMethodSignature ("minus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDateTime;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDateTime? Java.Time.Temporal.ITemporal.Minus (long amountToSubtract, global::Java.Time.Temporal.ITemporalUnit? unit)
		//{
		//	const string __id = "minus.(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDateTime;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [2];
		//		__args [0] = new JniArgumentValue (amountToSubtract);
		//		__args [1] = new JniArgumentValue (unit);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (unit);
		//	}
		//}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='plus' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalAmount']]"
		//[global::Java.Interop.JniMethodSignature ("plus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDateTime;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDateTime? Java.Time.Temporal.ITemporal.Plus (global::Java.Time.Temporal.ITemporalAmount? amount)
		//{
		//	const string __id = "plus.(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDateTime;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [1];
		//		__args [0] = new JniArgumentValue (amount);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (amount);
		//	}
		//}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='query' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalQuery&lt;R&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='timeLineOrder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='toEpochSecond' and count(parameter)=1 and parameter[1][@type='java.time.ZoneOffset']]"
		[global::Java.Interop.JniMethodSignature ("toEpochSecond", "(Ljava/time/ZoneOffset;)J")]
		virtual unsafe long ToEpochSecond (global::Java.Time.ZoneOffset? offset)
		{
			const string __id = "toEpochSecond.(Ljava/time/ZoneOffset;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (offset);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='toInstant' and count(parameter)=1 and parameter[1][@type='java.time.ZoneOffset']]"
		[global::Java.Interop.JniMethodSignature ("toInstant", "(Ljava/time/ZoneOffset;)Ljava/time/Instant;")]
		virtual unsafe global::Java.Time.Instant? ToInstant (global::Java.Time.ZoneOffset? offset)
		{
			const string __id = "toInstant.(Ljava/time/ZoneOffset;)Ljava/time/Instant;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Instant> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (offset);
			}
		}

		//// Metadata.xml XPath method reference: path="/api/package[@name='java.time.chrono']/interface[@name='ChronoLocalDateTime']/method[@name='with' and count(parameter)=1 and parameter[1][@type='java.time.temporal.TemporalAdjuster']]"
		//[global::Java.Interop.JniMethodSignature ("with", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoLocalDateTime;")]
		//unsafe global::Java.Time.Chrono.IChronoLocalDateTime? Java.Time.Temporal.ITemporal.With (global::Java.Time.Temporal.ITemporalAdjuster? adjuster)
		//{
		//	const string __id = "with.(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoLocalDateTime;";
		//	try {
		//		JniArgumentValue* __args = stackalloc JniArgumentValue [1];
		//		__args [0] = new JniArgumentValue (adjuster);
		//		var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
		//		return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
		//	} finally {
		//		global::System.GC.KeepAlive (adjuster);
		//	}
		//}

	}

	[global::Java.Interop.JniTypeSignature ("java/time/chrono/ChronoLocalDateTime", GenerateJavaPeer=false)]
	internal partial class IChronoLocalDateTimeInvoker : global::Java.Lang.Object, IChronoLocalDateTime {
		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members_java_time_chrono_ChronoLocalDateTime; }
		}

		static readonly JniPeerMembers _members_java_lang_Comparable = new JniPeerMembers ("java/lang/Comparable", typeof (IChronoLocalDateTimeInvoker));

		static readonly JniPeerMembers _members_java_time_chrono_ChronoLocalDateTime = new JniPeerMembers ("java/time/chrono/ChronoLocalDateTime", typeof (IChronoLocalDateTimeInvoker));

		static readonly JniPeerMembers _members_java_time_temporal_Temporal = new JniPeerMembers ("java/time/temporal/Temporal", typeof (IChronoLocalDateTimeInvoker));

		static readonly JniPeerMembers _members_java_time_temporal_TemporalAccessor = new JniPeerMembers ("java/time/temporal/TemporalAccessor", typeof (IChronoLocalDateTimeInvoker));

		static readonly JniPeerMembers _members_java_time_temporal_TemporalAdjuster = new JniPeerMembers ("java/time/temporal/TemporalAdjuster", typeof (IChronoLocalDateTimeInvoker));

		public IChronoLocalDateTimeInvoker (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
		{
		}

		public unsafe global::Java.Time.Chrono.IChronoZonedDateTime? AtZone (global::Java.Time.ZoneId? p0)
		{
			const string __id = "atZone.(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoZonedDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe bool Equals (global::Java.Lang.Object? p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		public unsafe bool IsSupported (global::Java.Time.Temporal.ITemporalField? p0)
		{
			const string __id = "isSupported.(Ljava/time/temporal/TemporalField;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe global::Java.Time.Chrono.IChronoLocalDateTime? Plus (long p0, global::Java.Time.Temporal.ITemporalUnit? p1)
		{
			const string __id = "plus.(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDateTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		public unsafe global::Java.Lang.Object? ToLocalDate ()
		{
			const string __id = "toLocalDate.()Ljava/time/chrono/ChronoLocalDate;";
			try {
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object>(ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe global::Java.Time.LocalTime? ToLocalTime ()
		{
			const string __id = "toLocalTime.()Ljava/time/LocalTime;";
			try {
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.LocalTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe string? ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Strings.ToString (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe global::Java.Time.Chrono.IChronoLocalDateTime? With (global::Java.Time.Temporal.ITemporalField? p0, long p1)
		{
			const string __id = "with.(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoLocalDateTime;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members_java_time_chrono_ChronoLocalDateTime.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Time.Chrono.IChronoLocalDateTime> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p0);
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

		public unsafe long Until (global::Java.Time.Temporal.ITemporal? p0, global::Java.Time.Temporal.ITemporalUnit? p1)
		{
			const string __id = "until.(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members_java_time_temporal_Temporal.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
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
