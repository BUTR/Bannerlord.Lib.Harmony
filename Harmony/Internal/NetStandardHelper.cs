using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace HarmonyLib
{
	internal static class NetStandardHelper
	{
		public delegate Type CreateTypeDelegate(TypeBuilder instance);
		public delegate MethodBuilder DefinePInvokeMethodDelegate(TypeBuilder instance, string name, string dllName, MethodAttributes attributes,
			CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
#if NETSTANDARD2_0
		public static readonly CreateTypeDelegate CreateType = AccessTools.MethodDelegate<CreateTypeDelegate>(AccessTools.Method(
			typeof(TypeBuilder),
			"CreateType",
			new Type[] { })
		);
		public static readonly DefinePInvokeMethodDelegate DefinePInvokeMethod = AccessTools.MethodDelegate<DefinePInvokeMethodDelegate>(AccessTools.Method(
			typeof(TypeBuilder),
			"DefinePInvokeMethod",
			new Type[] { typeof(string), typeof(string), typeof(MethodAttributes), typeof(CallingConventions), typeof(Type), typeof(Type[]), typeof(CallingConvention), typeof(CharSet), })
		);
#else
		public static readonly CreateTypeDelegate CreateType = (instance) => instance.CreateType();
		public static readonly DefinePInvokeMethodDelegate DefinePInvokeMethod = (instance, name, dllName, attributes, convention, type, types, conv, set) =>
			instance.DefinePInvokeMethod(name, dllName, attributes, convention, type, types, conv, set);
#endif
	}
}
