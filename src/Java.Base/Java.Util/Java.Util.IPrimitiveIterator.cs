using System;
using System.Collections.Generic;
using Java.Interop;

namespace Java.Util {

	partial interface IPrimitiveIterator
	{
		partial class IOfDoubleInvoker
		{
			Lang.Object? IIterator.Next () => ((IOfDouble) this).Next ();
		}

		partial class IOfIntInvoker
		{
			Lang.Object? IIterator.Next () => ((IOfInt) this).Next ();
		}

		partial class IOfLongInvoker
		{
			Lang.Object? IIterator.Next () => ((IOfLong) this).Next ();
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator']"
	[global::Java.Interop.JniTypeSignature ("java/util/PrimitiveIterator", GenerateJavaPeer=false, InvokerType=typeof (Java.Util.IPrimitiveIteratorInvoker))]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "T_CONS"})]
	public partial interface IPrimitiveIterator : global::Java.Util.IIterator {
		// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator']/method[@name='forEachRemaining' and count(parameter)=1 and parameter[1][@type='T_CONS']]"
		[global::Java.Interop.JniMethodSignature ("forEachRemaining", "(Ljava/lang/Object;)V")]
		void ForEachRemaining (global::Java.Lang.Object? p0);

		// Metadata.xml XPath interface reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfDouble']"
		[global::Java.Interop.JniTypeSignature ("java/util/PrimitiveIterator$OfDouble", GenerateJavaPeer=false, InvokerType=typeof (Java.Util.IPrimitiveIterator.IOfDoubleInvoker))]
		public partial interface IOfDouble : global::Java.Util.IPrimitiveIterator {
			private static readonly JniPeerMembers _members = new JniPeerMembers ("java/util/PrimitiveIterator$OfDouble", typeof (IOfDouble), isInterface: true);

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfDouble']/method[@name='nextDouble' and count(parameter)=0]"
			[global::Java.Interop.JniMethodSignature ("nextDouble", "()D")]
			double NextDouble ();

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfDouble']/method[@name='forEachRemaining' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super java.lang.Double&gt;']]"
			[global::Java.Interop.JniMethodSignature ("forEachRemaining", "(Ljava/util/function/Consumer;)V")]
			virtual unsafe void ForEachRemaining (global::Java.Util.Function.IConsumer? action)
			{
				const string __id = "forEachRemaining.(Ljava/util/function/Consumer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (action);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (action);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfDouble']/method[@name='forEachRemaining' and count(parameter)=1 and parameter[1][@type='java.util.function.DoubleConsumer']]"
			[global::Java.Interop.JniMethodSignature ("forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V")]
			virtual unsafe void ForEachRemaining (global::Java.Util.Function.IDoubleConsumer? action)
			{
				const string __id = "forEachRemaining.(Ljava/util/function/DoubleConsumer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (action);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (action);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfDouble']/method[@name='next' and count(parameter)=0]"
			[global::Java.Interop.JniMethodSignature ("next", "()Ljava/lang/Double;")]
			unsafe global::Java.Lang.Double? Next ()
			{
				const string __id = "next.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Double> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
				} finally {
				}
			}

		}

		[global::Java.Interop.JniTypeSignature ("java/util/PrimitiveIterator$OfDouble", GenerateJavaPeer=false)]
		internal partial class IOfDoubleInvoker : global::Java.Lang.Object, IOfDouble {
			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members_java_util_PrimitiveIterator_OfDouble; }
			}

			static readonly JniPeerMembers _members_java_util_Iterator = new JniPeerMembers ("java/util/Iterator", typeof (IOfDoubleInvoker));

			static readonly JniPeerMembers _members_java_util_PrimitiveIterator = new JniPeerMembers ("java/util/PrimitiveIterator", typeof (IOfDoubleInvoker));

			static readonly JniPeerMembers _members_java_util_PrimitiveIterator_OfDouble = new JniPeerMembers ("java/util/PrimitiveIterator$OfDouble", typeof (IOfDoubleInvoker));

			public IOfDoubleInvoker (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
			{
			}

			public unsafe double NextDouble ()
			{
				const string __id = "nextDouble.()D";
				try {
					var __rm = _members_java_util_PrimitiveIterator_OfDouble.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			public unsafe void ForEachRemaining (global::Java.Lang.Object? p0)
			{
				const string __id = "forEachRemaining.(Ljava/lang/Object;)V";
				var native_p0 = (p0?.PeerReference ?? default);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members_java_util_PrimitiveIterator.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			public unsafe bool HasNext {
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members_java_util_Iterator.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfInt']"
		[global::Java.Interop.JniTypeSignature ("java/util/PrimitiveIterator$OfInt", GenerateJavaPeer=false, InvokerType=typeof (Java.Util.IPrimitiveIterator.IOfIntInvoker))]
		public partial interface IOfInt : global::Java.Util.IPrimitiveIterator {
			private static readonly JniPeerMembers _members = new JniPeerMembers ("java/util/PrimitiveIterator$OfInt", typeof (IOfInt), isInterface: true);

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfInt']/method[@name='nextInt' and count(parameter)=0]"
			[global::Java.Interop.JniMethodSignature ("nextInt", "()I")]
			int NextInt ();

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfInt']/method[@name='forEachRemaining' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super java.lang.Integer&gt;']]"
			[global::Java.Interop.JniMethodSignature ("forEachRemaining", "(Ljava/util/function/Consumer;)V")]
			virtual unsafe void ForEachRemaining (global::Java.Util.Function.IConsumer? action)
			{
				const string __id = "forEachRemaining.(Ljava/util/function/Consumer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (action);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (action);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfInt']/method[@name='forEachRemaining' and count(parameter)=1 and parameter[1][@type='java.util.function.IntConsumer']]"
			[global::Java.Interop.JniMethodSignature ("forEachRemaining", "(Ljava/util/function/IntConsumer;)V")]
			virtual unsafe void ForEachRemaining (global::Java.Util.Function.IIntConsumer? action)
			{
				const string __id = "forEachRemaining.(Ljava/util/function/IntConsumer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (action);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (action);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfInt']/method[@name='next' and count(parameter)=0]"
			[global::Java.Interop.JniMethodSignature ("next", "()Ljava/lang/Integer;")]
			unsafe global::Java.Lang.Integer? Next ()
			{
				const string __id = "next.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Integer> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
				} finally {
				}
			}

		}

		[global::Java.Interop.JniTypeSignature ("java/util/PrimitiveIterator$OfInt", GenerateJavaPeer=false)]
		internal partial class IOfIntInvoker : global::Java.Lang.Object, IOfInt {
			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members_java_util_PrimitiveIterator_OfInt; }
			}

			static readonly JniPeerMembers _members_java_util_Iterator = new JniPeerMembers ("java/util/Iterator", typeof (IOfIntInvoker));

			static readonly JniPeerMembers _members_java_util_PrimitiveIterator = new JniPeerMembers ("java/util/PrimitiveIterator", typeof (IOfIntInvoker));

			static readonly JniPeerMembers _members_java_util_PrimitiveIterator_OfInt = new JniPeerMembers ("java/util/PrimitiveIterator$OfInt", typeof (IOfIntInvoker));

			public IOfIntInvoker (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
			{
			}

			public unsafe int NextInt ()
			{
				const string __id = "nextInt.()I";
				try {
					var __rm = _members_java_util_PrimitiveIterator_OfInt.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			public unsafe void ForEachRemaining (global::Java.Lang.Object? p0)
			{
				const string __id = "forEachRemaining.(Ljava/lang/Object;)V";
				var native_p0 = (p0?.PeerReference ?? default);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members_java_util_PrimitiveIterator.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			public unsafe bool HasNext {
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members_java_util_Iterator.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfLong']"
		[global::Java.Interop.JniTypeSignature ("java/util/PrimitiveIterator$OfLong", GenerateJavaPeer=false, InvokerType=typeof (Java.Util.IPrimitiveIterator.IOfLongInvoker))]
		public partial interface IOfLong : global::Java.Util.IPrimitiveIterator {
			private static readonly JniPeerMembers _members = new JniPeerMembers ("java/util/PrimitiveIterator$OfLong", typeof (IOfLong), isInterface: true);

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfLong']/method[@name='nextLong' and count(parameter)=0]"
			[global::Java.Interop.JniMethodSignature ("nextLong", "()J")]
			long NextLong ();

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfLong']/method[@name='forEachRemaining' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super java.lang.Long&gt;']]"
			[global::Java.Interop.JniMethodSignature ("forEachRemaining", "(Ljava/util/function/Consumer;)V")]
			virtual unsafe void ForEachRemaining (global::Java.Util.Function.IConsumer? action)
			{
				const string __id = "forEachRemaining.(Ljava/util/function/Consumer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (action);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (action);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfLong']/method[@name='forEachRemaining' and count(parameter)=1 and parameter[1][@type='java.util.function.LongConsumer']]"
			[global::Java.Interop.JniMethodSignature ("forEachRemaining", "(Ljava/util/function/LongConsumer;)V")]
			virtual unsafe void ForEachRemaining (global::Java.Util.Function.ILongConsumer? action)
			{
				const string __id = "forEachRemaining.(Ljava/util/function/LongConsumer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (action);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (action);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='java.util']/interface[@name='PrimitiveIterator.OfLong']/method[@name='next' and count(parameter)=0]"
			[global::Java.Interop.JniMethodSignature ("next", "()Ljava/lang/Long;")]
			unsafe global::Java.Lang.Long? Next ()
			{
				const string __id = "next.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Long> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
				} finally {
				}
			}

		}

		[global::Java.Interop.JniTypeSignature ("java/util/PrimitiveIterator$OfLong", GenerateJavaPeer=false)]
		internal partial class IOfLongInvoker : global::Java.Lang.Object, IOfLong {
			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members_java_util_PrimitiveIterator_OfLong; }
			}

			static readonly JniPeerMembers _members_java_util_Iterator = new JniPeerMembers ("java/util/Iterator", typeof (IOfLongInvoker));

			static readonly JniPeerMembers _members_java_util_PrimitiveIterator = new JniPeerMembers ("java/util/PrimitiveIterator", typeof (IOfLongInvoker));

			static readonly JniPeerMembers _members_java_util_PrimitiveIterator_OfLong = new JniPeerMembers ("java/util/PrimitiveIterator$OfLong", typeof (IOfLongInvoker));

			public IOfLongInvoker (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
			{
			}

			public unsafe long NextLong ()
			{
				const string __id = "nextLong.()J";
				try {
					var __rm = _members_java_util_PrimitiveIterator_OfLong.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			public unsafe void ForEachRemaining (global::Java.Lang.Object? p0)
			{
				const string __id = "forEachRemaining.(Ljava/lang/Object;)V";
				var native_p0 = (p0?.PeerReference ?? default);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members_java_util_PrimitiveIterator.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			public unsafe bool HasNext {
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members_java_util_Iterator.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

	}

	[global::Java.Interop.JniTypeSignature ("java/util/PrimitiveIterator", GenerateJavaPeer=false)]
	internal partial class IPrimitiveIteratorInvoker : global::Java.Lang.Object, IPrimitiveIterator {
		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members_java_util_PrimitiveIterator; }
		}

		static readonly JniPeerMembers _members_java_util_Iterator = new JniPeerMembers ("java/util/Iterator", typeof (IPrimitiveIteratorInvoker));

		static readonly JniPeerMembers _members_java_util_PrimitiveIterator = new JniPeerMembers ("java/util/PrimitiveIterator", typeof (IPrimitiveIteratorInvoker));

		public IPrimitiveIteratorInvoker (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
		{
		}

		public unsafe void ForEachRemaining (global::Java.Lang.Object? p0)
		{
			const string __id = "forEachRemaining.(Ljava/lang/Object;)V";
			var native_p0 = (p0?.PeerReference ?? default);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members_java_util_PrimitiveIterator.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe bool HasNext {
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members_java_util_Iterator.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object? Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members_java_util_Iterator.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object>(ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

	}
}
