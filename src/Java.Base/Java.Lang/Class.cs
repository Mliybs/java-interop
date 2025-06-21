using System;
using Java.Interop;

#if JAVA_API_17
using Java.Lang.Invoke;
using Java.Lang.Constants;

namespace Java.Lang {
	public partial class Class {
		Object? ITypeDescriptor.IOfField.ArrayType () => ArrayType ();

        Object ITypeDescriptor.IOfField.ComponentType()
        {
            throw new NotImplementedException();
        }
    }
}

#endif  // JAVA_API_17
