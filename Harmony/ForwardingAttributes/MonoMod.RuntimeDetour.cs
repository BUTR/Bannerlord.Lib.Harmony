#if NETFRAMEWORK || NETSTANDARD2_0
using System.Runtime.CompilerServices;

[assembly: TypeForwardedTo(typeof(MonoMod.RuntimeDetour.OnMethodCompiledEvent))]
#endif
