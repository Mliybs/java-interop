using System;
using System.Collections.Generic;
using Java.Interop;
using Java.Lang.Invoke;

namespace Java.Lang.Constants {

	partial interface IClassDesc
	{
		Object? ITypeDescriptor.IOfField.ArrayType () => ArrayType () as Object;

		Object? ITypeDescriptor.IOfField.ComponentType () => ComponentType () as Object;
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']"
	[global::Java.Interop.JniTypeSignature ("java/lang/constant/ClassDesc", GenerateJavaPeer=false, InvokerType=typeof (Java.Lang.Constants.IClassDescInvoker))]
	public partial interface IClassDesc : global::Java.Lang.Constants.IConstantDesc, global::Java.Lang.Invoke.ITypeDescriptor.IOfField {
		private static readonly JniPeerMembers _members = new JniPeerMembers ("java/lang/constant/ClassDesc", typeof (IClassDesc), isInterface: true);

		virtual unsafe bool IsArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='isArray' and count(parameter)=0]"
			get {
				const string __id = "isArray.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		virtual unsafe bool IsClassOrInterface {
			// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='isClassOrInterface' and count(parameter)=0]"
			get {
				const string __id = "isClassOrInterface.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		virtual unsafe bool IsPrimitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='isPrimitive' and count(parameter)=0]"
			get {
				const string __id = "isPrimitive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='descriptorString' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("descriptorString", "()Ljava/lang/String;")]
		string? DescriptorString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[global::Java.Interop.JniMethodSignature ("equals", "(Ljava/lang/Object;)Z")]
		bool Equals (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='arrayType' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("arrayType", "()Ljava/lang/constant/ClassDesc;")]
		unsafe global::Java.Lang.Constants.IClassDesc? ArrayType ()
		{
			const string __id = "arrayType.()Ljava/lang/constant/ClassDesc;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='arrayType' and count(parameter)=1 and parameter[1][@type='int']]"
		[global::Java.Interop.JniMethodSignature ("arrayType", "(I)Ljava/lang/constant/ClassDesc;")]
		virtual unsafe global::Java.Lang.Constants.IClassDesc? ArrayType (int rank)
		{
			const string __id = "arrayType.(I)Ljava/lang/constant/ClassDesc;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rank);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='componentType' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("componentType", "()Ljava/lang/constant/ClassDesc;")]
		unsafe global::Java.Lang.Constants.IClassDesc? ComponentType ()
		{
			const string __id = "componentType.()Ljava/lang/constant/ClassDesc;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='displayName' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("displayName", "()Ljava/lang/String;")]
		virtual unsafe string? DisplayName ()
		{
			const string __id = "displayName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Strings.ToString (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='nested' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[global::Java.Interop.JniMethodSignature ("nested", "(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;")]
		virtual unsafe global::Java.Lang.Constants.IClassDesc? Nested (string? nestedName)
		{
			const string __id = "nested.(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;";
			var native_nestedName = global::Java.Interop.JniEnvironment.Strings.NewString (nestedName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_nestedName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::Java.Interop.JniObjectReference.Dispose (ref native_nestedName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='nested' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[global::Java.Interop.JniMethodSignature ("nested", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/constant/ClassDesc;")]
		virtual unsafe global::Java.Lang.Constants.IClassDesc? Nested (string? firstNestedName, params string[]? moreNestedNames)
		{
			const string __id = "nested.(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/constant/ClassDesc;";
			var native_firstNestedName = global::Java.Interop.JniEnvironment.Strings.NewString (firstNestedName);
			var native_moreNestedNames = global::Java.Interop.JniEnvironment.Arrays.CreateMarshalObjectArray<string> (moreNestedNames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_firstNestedName);
				__args [1] = new JniArgumentValue (native_moreNestedNames);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::Java.Interop.JniObjectReference.Dispose (ref native_firstNestedName);
				if (native_moreNestedNames != null) {
					native_moreNestedNames.CopyTo (moreNestedNames!, 0);
					native_moreNestedNames.Dispose ();
				}
				global::System.GC.KeepAlive (moreNestedNames);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[global::Java.Interop.JniMethodSignature ("of", "(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;")]
		public static unsafe global::Java.Lang.Constants.IClassDesc? Of (string? name)
		{
			const string __id = "of.(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;";
			var native_name = global::Java.Interop.JniEnvironment.Strings.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::Java.Interop.JniObjectReference.Dispose (ref native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='of' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[global::Java.Interop.JniMethodSignature ("of", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/constant/ClassDesc;")]
		public static unsafe global::Java.Lang.Constants.IClassDesc? Of (string? packageName, string? className)
		{
			const string __id = "of.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/constant/ClassDesc;";
			var native_packageName = global::Java.Interop.JniEnvironment.Strings.NewString (packageName);
			var native_className = global::Java.Interop.JniEnvironment.Strings.NewString (className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (native_className);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::Java.Interop.JniObjectReference.Dispose (ref native_packageName);
				global::Java.Interop.JniObjectReference.Dispose (ref native_className);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='ofDescriptor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[global::Java.Interop.JniMethodSignature ("ofDescriptor", "(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;")]
		public static unsafe global::Java.Lang.Constants.IClassDesc? OfDescriptor (string? descriptor)
		{
			const string __id = "ofDescriptor.(Ljava/lang/String;)Ljava/lang/constant/ClassDesc;";
			var native_descriptor = global::Java.Interop.JniEnvironment.Strings.NewString (descriptor);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_descriptor);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Lang.Constants.IClassDesc> (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
				global::Java.Interop.JniObjectReference.Dispose (ref native_descriptor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='java.lang.constant']/interface[@name='ClassDesc']/method[@name='packageName' and count(parameter)=0]"
		[global::Java.Interop.JniMethodSignature ("packageName", "()Ljava/lang/String;")]
		virtual unsafe string? PackageName ()
		{
			const string __id = "packageName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Strings.ToString (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

	}

	[global::Java.Interop.JniTypeSignature ("java/lang/constant/ClassDesc", GenerateJavaPeer=false)]
	internal partial class IClassDescInvoker : global::Java.Lang.Object, IClassDesc {
		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members_java_lang_constant_ClassDesc; }
		}

		static readonly JniPeerMembers _members_java_lang_constant_ClassDesc = new JniPeerMembers ("java/lang/constant/ClassDesc", typeof (IClassDescInvoker));

		static readonly JniPeerMembers _members_java_lang_constant_ConstantDesc = new JniPeerMembers ("java/lang/constant/ConstantDesc", typeof (IClassDescInvoker));

		static readonly JniPeerMembers _members_java_lang_invoke_TypeDescriptor = new JniPeerMembers ("java/lang/invoke/TypeDescriptor", typeof (IClassDescInvoker));

		static readonly JniPeerMembers _members_java_lang_invoke_TypeDescriptor_OfField = new JniPeerMembers ("java/lang/invoke/TypeDescriptor$OfField", typeof (IClassDescInvoker));

		public IClassDescInvoker (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
		{
		}

		public unsafe string? DescriptorString ()
		{
			const string __id = "descriptorString.()Ljava/lang/String;";
			try {
				var __rm = _members_java_lang_constant_ClassDesc.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Interop.JniEnvironment.Strings.ToString (ref __rm, JniObjectReferenceOptions.CopyAndDispose);
			} finally {
			}
		}

		public unsafe bool Equals (global::Java.Lang.Object? p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members_java_lang_constant_ClassDesc.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
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

		public unsafe bool IsArray {
			get {
				const string __id = "isArray.()Z";
				try {
					var __rm = _members_java_lang_invoke_TypeDescriptor_OfField.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsPrimitive {
			get {
				const string __id = "isPrimitive.()Z";
				try {
					var __rm = _members_java_lang_invoke_TypeDescriptor_OfField.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
