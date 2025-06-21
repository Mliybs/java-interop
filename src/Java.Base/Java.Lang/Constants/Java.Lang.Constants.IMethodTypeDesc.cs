using System;
using System.Collections.Generic;
using Java.Interop;
using Java.Lang.Invoke;

namespace Java.Lang.Constants
{
	partial class IMethodTypeDescInvoker
	{
		Object? ITypeDescriptor.IOfMethod.DropParameterTypes (int p0, int p1) => DropParameterTypes (p0, p1) as Object;

		JavaObjectArray<Object>? ITypeDescriptor.IOfMethod.ParameterArray () => throw new Exception (); // ParameterArray () as Object;

		Object? ITypeDescriptor.IOfMethod.ParameterType (int p0) => ParameterType (p0) as Object;

		Object? ITypeDescriptor.IOfMethod.ReturnType () => ReturnType () as Object;
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']"
	[global::Java.Interop.JniTypeSignature ("java/lang/constant/MethodTypeDesc", GenerateJavaPeer = false, InvokerType = typeof (Java.Lang.Constants.IMethodTypeDescInvoker))]
	public partial interface IMethodTypeDesc : global::Java.Lang.Constants.IConstantDesc, global::Java.Lang.Invoke.ITypeDescriptor.IOfMethod
	{
		private static readonly JniPeerMembers _members = new JniPeerMembers ("java/lang/constant/MethodTypeDesc", typeof (IMethodTypeDesc), isInterface: true);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='changeParameterType' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.constant.ClassDesc']]"
		[global::Java.Interop.JniMethodSignature ("changeParameterType", "(ILjava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;")]
		global::Java.Lang.Constants.IMethodTypeDesc? ChangeParameterType (int p0, global::Java.Lang.Constants.IClassDesc? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='changeReturnType' and count(parameter)=1 and parameter[1][@type='java.lang.constant.ClassDesc']]"
		[global::Java.Interop.JniMethodSignature ("changeReturnType", "(Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;")]
		global::Java.Lang.Constants.IMethodTypeDesc? ChangeReturnType (global::Java.Lang.Constants.IClassDesc? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='dropParameterTypes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[global::Java.Interop.JniMethodSignature ("dropParameterTypes", "(II)Ljava/lang/constant/MethodTypeDesc;")]
		global::Java.Lang.Constants.IMethodTypeDesc? DropParameterTypes (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[global::Java.Interop.JniMethodSignature ("equals", "(Ljava/lang/Object;)Z")]
		bool Equals (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='insertParameterTypes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.constant.ClassDesc...']]"
		[global::Java.Interop.JniMethodSignature ("insertParameterTypes", "(I[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;")]
		global::Java.Lang.Constants.IMethodTypeDesc? InsertParameterTypes (int p0, params global::Java.Lang.Constants.IClassDesc []? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='parameterArray' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("parameterArray", "()[Ljava/lang/constant/ClassDesc;")]
		global::Java.Interop.JavaObjectArray<global::Java.Lang.Constants.IClassDesc>? ParameterArray ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='parameterCount' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("parameterCount", "()I")]
		int ParameterCount ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='parameterList' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("parameterList", "()Ljava/util/List;")]
		global::Java.Util.IList? ParameterList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='parameterType' and count(parameter)=1 and parameter[1][@type='int']]"
		[global::Java.Interop.JniMethodSignature ("parameterType", "(I)Ljava/lang/constant/ClassDesc;")]
		global::Java.Lang.Constants.IClassDesc? ParameterType (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='returnType' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("returnType", "()Ljava/lang/constant/ClassDesc;")]
		global::Java.Lang.Constants.IClassDesc? ReturnType ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='descriptorString' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("descriptorString", "()Ljava/lang/String;")]
		unsafe string? Java.Lang.Invoke.ITypeDescriptor.DescriptorString ()
		{
			const string __id = "descriptorString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Strings.ToString (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='displayDescriptor' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("displayDescriptor", "()Ljava/lang/String;")]
		virtual unsafe string? DisplayDescriptor ()
		{
			const string __id = "displayDescriptor.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Strings.ToString (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='of' and count(parameter)=2 and parameter[1][@type='java.lang.constant.ClassDesc'] and parameter[2][@type='java.lang.constant.ClassDesc...']]"
		[global::Java.Interop.JniMethodSignature ("of", "(Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;")]
		public static unsafe global::Java.Lang.Constants.IMethodTypeDesc? Of (global::Java.Lang.Constants.IClassDesc? returnDesc, params global::Java.Lang.Constants.IClassDesc []? paramDescs)
		{
			const string __id = "of.(Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;";
			var native_paramDescs = global::Java.Interop.JniEnvironment.Arrays.CreateMarshalObjectArray<global::Java.Lang.Constants.IClassDesc> (paramDescs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (returnDesc);
				__args [1] = new JniArgumentValue (native_paramDescs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IMethodTypeDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				if (native_paramDescs != null) {
					native_paramDescs.CopyTo (paramDescs!, 0);
					native_paramDescs.Dispose ();
				}
				global::System.GC.KeepAlive (returnDesc);
				global::System.GC.KeepAlive (paramDescs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='MethodTypeDesc']/method[@name='ofDescriptor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[global::Java.Interop.JniMethodSignature ("ofDescriptor", "(Ljava/lang/String;)Ljava/lang/constant/MethodTypeDesc;")]
		public static unsafe global::Java.Lang.Constants.IMethodTypeDesc? OfDescriptor (string? descriptor)
		{
			const string __id = "ofDescriptor.(Ljava/lang/String;)Ljava/lang/constant/MethodTypeDesc;";
			var native_descriptor = global::Java.Interop.JniEnvironment.Strings.NewString (descriptor);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_descriptor);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IMethodTypeDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::Java.Interop.JniObjectReference.Dispose (ref native_descriptor);
			}
		}

	}

	[global::Java.Interop.JniTypeSignature ("java/lang/constant/MethodTypeDesc", GenerateJavaPeer = false)]
	internal partial class IMethodTypeDescInvoker : global::Java.Lang.Object, IMethodTypeDesc
	{
		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members_java_lang_constant_MethodTypeDesc; }
		}

		static readonly JniPeerMembers _members_java_lang_constant_ConstantDesc = new JniPeerMembers ("java/lang/constant/ConstantDesc", typeof (IMethodTypeDescInvoker));

		static readonly JniPeerMembers _members_java_lang_constant_MethodTypeDesc = new JniPeerMembers ("java/lang/constant/MethodTypeDesc", typeof (IMethodTypeDescInvoker));

		static readonly JniPeerMembers _members_java_lang_invoke_TypeDescriptor = new JniPeerMembers ("java/lang/invoke/TypeDescriptor", typeof (IMethodTypeDescInvoker));

		static readonly JniPeerMembers _members_java_lang_invoke_TypeDescriptor_OfMethod = new JniPeerMembers ("java/lang/invoke/TypeDescriptor$OfMethod", typeof (IMethodTypeDescInvoker));

		public IMethodTypeDescInvoker (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
		{
		}

		public unsafe global::Java.Lang.Constants.IMethodTypeDesc? ChangeParameterType (int p0, global::Java.Lang.Constants.IClassDesc? p1)
		{
			const string __id = "changeParameterType.(ILjava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IMethodTypeDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		public unsafe global::Java.Lang.Constants.IMethodTypeDesc? ChangeReturnType (global::Java.Lang.Constants.IClassDesc? p0)
		{
			const string __id = "changeReturnType.(Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IMethodTypeDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe global::Java.Lang.Constants.IMethodTypeDesc? DropParameterTypes (int p0, int p1)
		{
			const string __id = "dropParameterTypes.(II)Ljava/lang/constant/MethodTypeDesc;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IMethodTypeDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe bool Equals (global::Java.Lang.Object? p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe global::Java.Lang.Constants.IMethodTypeDesc? InsertParameterTypes (int p0, params global::Java.Lang.Constants.IClassDesc []? p1)
		{
			const string __id = "insertParameterTypes.(I[Ljava/lang/constant/ClassDesc;)Ljava/lang/constant/MethodTypeDesc;";
			var native_p1 = global::Java.Interop.JniEnvironment.Arrays.CreateMarshalObjectArray<global::Java.Lang.Constants.IClassDesc> (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IMethodTypeDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				if (native_p1 != null) {
					native_p1.CopyTo (p1!, 0);
					native_p1.Dispose ();
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		public unsafe global::Java.Interop.JavaObjectArray<global::Java.Lang.Constants.IClassDesc>? ParameterArray ()
		{
			const string __id = "parameterArray.()[Ljava/lang/constant/ClassDesc;";
			try {
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Interop.JavaObjectArray<Java.Lang.Constants.IClassDesc>> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe int ParameterCount ()
		{
			const string __id = "parameterCount.()I";
			try {
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		public unsafe global::Java.Util.IList? ParameterList ()
		{
			const string __id = "parameterList.()Ljava/util/List;";
			try {
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Util.IList> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe global::Java.Lang.Constants.IClassDesc? ParameterType (int p0)
		{
			const string __id = "parameterType.(I)Ljava/lang/constant/ClassDesc;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe global::Java.Lang.Constants.IClassDesc? ReturnType ()
		{
			const string __id = "returnType.()Ljava/lang/constant/ClassDesc;";
			try {
				var __rm = _members_java_lang_constant_MethodTypeDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe global::Java.Lang.Object? ResolveConstantDesc (global::Java.Lang.Invoke.MethodHandles.Lookup? p0)
		{
			const string __id = "resolveConstantDesc.(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_lang_constant_ConstantDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe global::Java.Lang.Object? ChangeParameterType (int p0, global::Java.Lang.Object? p1)
		{
			const string __id = "changeParameterType.(ILjava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;";
			var native_p1 = (p1?.PeerReference ?? default);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members_java_lang_invoke_TypeDescriptor_OfMethod.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		public unsafe global::Java.Lang.Object? ChangeReturnType (global::Java.Lang.Object? p0)
		{
			const string __id = "changeReturnType.(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;";
			var native_p0 = (p0?.PeerReference ?? default);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members_java_lang_invoke_TypeDescriptor_OfMethod.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe global::Java.Lang.Object? InsertParameterTypes (int p0, params global::Java.Lang.Object []? p1)
		{
			const string __id = "insertParameterTypes.(I[Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;";
			var native_p1 = global::Java.Interop.JniEnvironment.Arrays.CreateMarshalObjectArray<global::Java.Lang.Object> (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members_java_lang_invoke_TypeDescriptor_OfMethod.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Object> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				if (native_p1 != null) {
					native_p1.CopyTo (p1!, 0);
					native_p1.Dispose ();
				}
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
