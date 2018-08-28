#define MCG_WINRT_SUPPORTED
using Mcg.System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using global::Windows.Foundation;
using global::Windows.Foundation.Collections;


// -----------------------------------------------------------------------------------------------------------
// 
// WARNING: THIS SOURCE FILE IS FOR 64-BIT BUILDS ONLY!
// 
// MCG GENERATED CODE
// 
// This C# source file is generated by MCG and is added into the application at compile time to support interop features.
// 
// It has three primary components:
// 
// 1. Public type definitions with interop implementation used by this application including WinRT & COM data structures and P/Invokes.
// 
// 2. The '__Interop' class containing marshaling code that acts as a bridge from managed code to native code.
// 
// 3. The 'McgNative' class containing marshaling code and native type definitions that call into native code and are called by native code.
// 
// -----------------------------------------------------------------------------------------------------------
// 
// warning CS0067: The event 'event' is never used
#pragma warning disable 67
// warning CS0169: The field 'field' is never used
#pragma warning disable 169
// warning CS0649: Field 'field' is never assigned to, and will always have its default value 0
#pragma warning disable 414
// warning CS0414: The private field 'field' is assigned but its value is never used
#pragma warning disable 649
// warning CS1591: Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// warning CS0108 'member1' hides inherited member 'member2'. Use the new keyword if hiding was intended.
#pragma warning disable 108
// warning CS0114 'member1' hides inherited member 'member2'.  To make the current method override that implementation, add the override keyword. Otherwise add the new keyword.
#pragma warning disable 114
// warning CS0659 'type' overrides Object.Equals but does not override GetHashCode.
#pragma warning disable 659
// warning CS0465 Introducing a 'Finalize' method can interfere with destructor invocation. Did you intend to declare a destructor?
#pragma warning disable 465
// warning CS0028 'function declaration' has the wrong signature to be an entry point
#pragma warning disable 28
// warning CS0162 Unreachable code Detected
#pragma warning disable 162
// warning CS0628 new protected member declared in sealed class
#pragma warning disable 628

namespace __Interop
{
	/// <summary>
	/// P/Invoke class for module '[MRT]'
	/// </summary>
	public unsafe static partial class _MRT_
	{
		// Signature, RhpGetFuncEvalParameterBufferSize, [fwd] [return] [EETypeRva:0x0004157C] uint__unsigned int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhpGetFuncEvalParameterBufferSize")]
		public static uint RhpGetFuncEvalParameterBufferSize()
		{
			// Setup
			uint unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop._MRT__PInvokes.RhpGetFuncEvalParameterBufferSize();
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}

		// Signature, RhpGetFuncEvalMode, [fwd] [return] [EETypeRva:0x0004157C] uint__unsigned int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhpGetFuncEvalMode")]
		public static uint RhpGetFuncEvalMode()
		{
			// Setup
			uint unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop._MRT__PInvokes.RhpGetFuncEvalMode();
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}

		// Signature, RhpRecordDebuggeeInitiatedHandle, [fwd] [return] [EETypeRva:0x0004157C] uint__unsigned int, [fwd] [in] [EETypeRva:0x0004157C] void___ptrvoid *, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhpRecordDebuggeeInitiatedHandle")]
		public static uint RhpRecordDebuggeeInitiatedHandle(void* objectHandle)
		{
			// Setup
			uint unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop._MRT__PInvokes.RhpRecordDebuggeeInitiatedHandle(((void*)objectHandle));
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}

		// Signature, RhpVerifyDebuggerCleanup, [fwd] [return] [EETypeRva:0x000405F8] void__void, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhpVerifyDebuggerCleanup")]
		public static void RhpVerifyDebuggerCleanup()
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes.RhpVerifyDebuggerCleanup();
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}

		// Signature, RhpGetCurrentThread, [fwd] [return] [EETypeRva:0x0004157C] System_IntPtr____w64 int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhpGetCurrentThread")]
		public static global::System.IntPtr RhpGetCurrentThread()
		{
			// Setup
			global::System.IntPtr unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop._MRT__PInvokes.RhpGetCurrentThread();
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}

		// Signature, RhWaitForPendingFinalizers, [fwd] [return] [EETypeRva:0x000405F8] void__void, [fwd] [in] [EETypeRva:0x0004157C] int__int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhWaitForPendingFinalizers")]
		public static void RhWaitForPendingFinalizers(int allowReentrantWait)
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes.RhWaitForPendingFinalizers(allowReentrantWait);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}

		// Signature, _RhYield, [fwd] [return] [EETypeRva:0x0004157C] int__int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "_RhYield")]
		public static int _RhYield()
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop._MRT__PInvokes._RhYield();
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}

		// Signature, RhFlushProcessWriteBuffers, [fwd] [return] [EETypeRva:0x000405F8] void__void, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhFlushProcessWriteBuffers")]
		public static void RhFlushProcessWriteBuffers()
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes.RhFlushProcessWriteBuffers();
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}

		// Signature, RhCompatibleReentrantWaitAny, [fwd] [return] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] System_IntPtr___ptr__w64 int *, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhCompatibleReentrantWaitAny")]
		public static int RhCompatibleReentrantWaitAny(
					int alertable, 
					int timeout, 
					int count, 
					global::System.IntPtr* handles)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop._MRT__PInvokes.RhCompatibleReentrantWaitAny(
								alertable, 
								timeout, 
								count, 
								((global::System.IntPtr*)handles)
							);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}

		// Signature, RhCallDescrWorkerNative, [fwd] [return] [EETypeRva:0x000405F8] void__void, [fwd] [in] [EETypeRva:0x0004157C] System_IntPtr____w64 int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhCallDescrWorkerNative")]
		public static void RhCallDescrWorkerNative(global::System.IntPtr callDescr)
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes.RhCallDescrWorkerNative(callDescr);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}

		// Signature, _ecvt_s, [fwd] [return] [EETypeRva:0x000405F8] void__void, [fwd] [in] [EETypeRva:0x0004157C] byte___ptrunsigned char *, [fwd] [in] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] double__double, [fwd] [in] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] int___ptrint *, [fwd] [in] [EETypeRva:0x0004157C] int___ptrint *, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "_ecvt_s")]
		public static void _ecvt_s(
					byte* buffer, 
					int sizeInBytes, 
					double value, 
					int count, 
					int* dec, 
					int* sign)
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes._ecvt_s(
								((byte*)buffer), 
								sizeInBytes, 
								value, 
								count, 
								((int*)dec), 
								((int*)sign)
							);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}

		// Signature, memmove, [fwd] [return] [EETypeRva:0x000405F8] void__void, [fwd] [in] [EETypeRva:0x0004157C] byte___ptrunsigned char *, [fwd] [in] [EETypeRva:0x0004157C] byte___ptrunsigned char *, [fwd] [in] [EETypeRva:0x0004157C] ulong__unsigned __int64, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "memmove")]
		public static void memmove(
					byte* dmem, 
					byte* smem, 
					ulong size)
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes.memmove(
								((byte*)dmem), 
								((byte*)smem), 
								size
							);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}

		// Signature, memset, [fwd] [return] [EETypeRva:0x000405F8] void__void, [fwd] [in] [EETypeRva:0x0004157C] byte___ptrunsigned char *, [fwd] [in] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] ulong__unsigned __int64, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "memset")]
		public static void memset(
					byte* mem, 
					int value, 
					ulong size)
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes.memset(
								((byte*)mem), 
								value, 
								size
							);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}
	}

	/// <summary>
	/// P/Invoke class for module '*'
	/// </summary>
	public unsafe static partial class _
	{
		// Signature, CallingConventionConverter_GetStubs, [fwd] [return] [EETypeRva:0x000405F8] void__void, [fwd] [out] [managedbyref] [nativebyref] [EETypeRva:0x0004157C] System_IntPtr____w64 int, [fwd] [out] [managedbyref] [nativebyref] [EETypeRva:0x0004157C] System_IntPtr____w64 int, [fwd] [out] [managedbyref] [nativebyref] [EETypeRva:0x0004157C] System_IntPtr____w64 int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.TypeLoader, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Internal.Runtime.TypeLoader.CallConverterThunk", "CallingConventionConverter_GetStubs")]
		public static void CallingConventionConverter_GetStubs(
					out global::System.IntPtr returnVoidStub, 
					out global::System.IntPtr returnIntegerStub, 
					out global::System.IntPtr commonStub)
		{
			// Marshalling
			fixed (global::System.IntPtr* pinned_returnVoidStub = &(returnVoidStub))
				fixed (global::System.IntPtr* pinned_returnIntegerStub = &(returnIntegerStub))
					fixed (global::System.IntPtr* pinned_commonStub = &(commonStub))
					{
						// Call to native method
						global::__Interop.__PInvokes.CallingConventionConverter_GetStubs(
											pinned_returnVoidStub, 
											pinned_returnIntegerStub, 
											pinned_commonStub
										);
						global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
					}
			// Return
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-winrt-string-l1-1-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_winrt_string_l1_1_0_dll
	{
		// Signature, WindowsCreateStringReference, [fwd] [return] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] char___ptrwchar_t *, [fwd] [in] [EETypeRva:0x0004157C] uint__unsigned int, [fwd] [in] [EETypeRva:0x0004157C] System_Runtime_InteropServices_HSTRING_HEADER__System_Private_Interop___ptrSystem_Runtime_InteropServices__HSTRING_HEADER__System_Private_Interop *, [fwd] [in] [EETypeRva:0x0004157C] void___ptrvoid *, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.WinRTInterop.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "mincore", "WindowsCreateStringReference")]
		public static int WindowsCreateStringReference(
					char* sourceString, 
					uint length, 
					global::System_Runtime_InteropServices.HSTRING_HEADER__System_Private_Interop* phstringHeader, 
					void* hstring)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_winrt_string_l1_1_0_dll_PInvokes.WindowsCreateStringReference(
								((ushort*)sourceString), 
								length, 
								((global::System_Runtime_InteropServices.HSTRING_HEADER__System_Private_Interop*)phstringHeader), 
								((void*)hstring)
							);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-errorhandling-l1-1-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_errorhandling_l1_1_0_dll
	{
		// Signature, GetLastError, [fwd] [return] [EETypeRva:0x0004157C] int__int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Interop+mincore", "GetLastError")]
		public static int GetLastError()
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_errorhandling_l1_1_0_dll_PInvokes.GetLastError();
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}

		// Signature, SetLastError, [fwd] [return] [EETypeRva:0x000405F8] void__void, [fwd] [in] [EETypeRva:0x0004157C] uint__unsigned int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Interop+mincore", "SetLastError")]
		public static void SetLastError(uint dwErrCode)
		{
			// Marshalling
			// Call to native method
			global::__Interop.api_ms_win_core_errorhandling_l1_1_0_dll_PInvokes.SetLastError(dwErrCode);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-winrt-l1-1-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_winrt_l1_1_0_dll
	{
		// Signature, RoInitialize, [fwd] [return] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] uint__unsigned int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.WinRTInterop.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "mincore+mincore_PInvokes", "RoInitialize")]
		public static int RoInitialize(uint initType)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_winrt_l1_1_0_dll_PInvokes.RoInitialize(initType);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-localization-l1-2-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_localization_l1_2_0_dll
	{
		// Signature, IsValidLocaleName, [fwd] [return] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] char___ptrwchar_t *, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.WinRTInterop.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "mincore+mincore_PInvokes", "IsValidLocaleName")]
		public static int IsValidLocaleName(char* lpLocaleName)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_localization_l1_2_0_dll_PInvokes.IsValidLocaleName(((ushort*)lpLocaleName));
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}

		// Signature, ResolveLocaleName, [fwd] [return] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] char___ptrwchar_t *, [fwd] [in] [EETypeRva:0x0004157C] char___ptrwchar_t *, [fwd] [in] [EETypeRva:0x0004157C] int__int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.WinRTInterop.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "mincore+mincore_PInvokes", "ResolveLocaleName")]
		public static int ResolveLocaleName(
					char* lpNameToResolve, 
					char* lpLocaleName, 
					int cchLocaleName)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_localization_l1_2_0_dll_PInvokes.ResolveLocaleName(
								((ushort*)lpNameToResolve), 
								((ushort*)lpLocaleName), 
								cchLocaleName
							);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}
	}

	/// <summary>
	/// P/Invoke class for module 'kernel32.dll'
	/// </summary>
	public unsafe static partial class kernel32_dll
	{
		// Signature, GetCPInfoExW, [fwd] [return] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] uint__unsigned int, [fwd] [in] [EETypeRva:0x0004157C] uint__unsigned int, [fwd] [in] [EETypeRva:0x0004157C] __Interop_Kernel32_CPINFOEXW__System_Text_Encoding_CodePages___ptr__Interop_Kernel32_CPINFOEXW__System_Text_Encoding_CodePages *, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Text.Encoding.CodePages, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Interop+Kernel32", "GetCPInfoExW")]
		public static int GetCPInfoExW(
					uint CodePage, 
					uint dwFlags, 
					global::_.Interop_Kernel32_CPINFOEXW__System_Text_Encoding_CodePages* lpCPInfoEx)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.kernel32_dll_PInvokes.GetCPInfoExW(
								CodePage, 
								dwFlags, 
								((global::_.Interop_Kernel32_CPINFOEXW__System_Text_Encoding_CodePages*)lpCPInfoEx)
							);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
			return unsafe___value;
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-com-l1-1-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_com_l1_1_0_dll
	{
		// Signature, CoCreateInstance, [fwd] [return] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] byte___ptrunsigned char *, [fwd] [in] [EETypeRva:0x0004157C] System_IntPtr____w64 int, [fwd] [in] [EETypeRva:0x0004157C] int__int, [fwd] [in] [EETypeRva:0x0004157C] byte___ptrunsigned char *, [fwd] [out] [managedbyref] [nativebyref] [EETypeRva:0x0004157C] System_IntPtr____w64 int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.StackTraceGenerator, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Internal.StackTraceGenerator.StackTraceGenerator", "CoCreateInstance")]
		public static int CoCreateInstance(
					byte* rclsid, 
					global::System.IntPtr pUnkOuter, 
					int dwClsContext, 
					byte* riid, 
					out global::System.IntPtr ppv)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			fixed (global::System.IntPtr* pinned_ppv = &(ppv))
			{
				// Call to native method
				unsafe___value = global::__Interop.api_ms_win_core_com_l1_1_0_dll_PInvokes.CoCreateInstance(
									((byte*)rclsid), 
									pUnkOuter, 
									dwClsContext, 
									((byte*)riid), 
									pinned_ppv
								);
				global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			}
			// Return
			return unsafe___value;
		}
	}

	/// <summary>
	/// P/Invoke class for module 'OleAut32'
	/// </summary>
	public unsafe static partial class OleAut32
	{
		// Signature, SysFreeString, [fwd] [return] [EETypeRva:0x000405F8] void__void, [fwd] [in] [EETypeRva:0x0004157C] System_IntPtr____w64 int, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.StackTraceGenerator, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Internal.LightweightInterop.MarshalExtensions", "SysFreeString")]
		public static void SysFreeString(global::System.IntPtr bstr)
		{
			// Marshalling
			// Call to native method
			global::__Interop.OleAut32_PInvokes.SysFreeString(bstr);
			global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
			// Return
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-winrt-robuffer-l1-1-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_winrt_robuffer_l1_1_0_dll
	{
		// Signature, RoGetBufferMarshaler, [fwd] [return] [EETypeRva:0x0004157C] int__int, [fwd] [out] [managedbyref] [nativebyref] [EETypeRva:0x00041E80] System_Runtime_InteropServices_IMarshal__System_Runtime_WindowsRuntime__System_Runtime_InteropServices__IMarshal__System_Runtime_WindowsRuntime *, 
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Runtime.WindowsRuntime, Version=4.0.14.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "Interop+mincore", "RoGetBufferMarshaler")]
		public static int RoGetBufferMarshaler(out global::System_Runtime_InteropServices.IMarshal__System_Runtime_WindowsRuntime bufferMarshalerPtr)
		{
			// Setup
			void* unsafe_bufferMarshalerPtr = default(void*);
			int unsafe___value;
			try
			{
				// Marshalling
				unsafe_bufferMarshalerPtr = null;
				// Call to native method
				unsafe___value = global::__Interop.api_ms_win_core_winrt_robuffer_l1_1_0_dll_PInvokes.RoGetBufferMarshaler(&(unsafe_bufferMarshalerPtr));
				global::System.Diagnostics.DebugAnnotations.PreviousCallContainsDebuggerStepInCode();
				bufferMarshalerPtr = (global::System_Runtime_InteropServices.IMarshal__System_Runtime_WindowsRuntime)global::System.Runtime.InteropServices.McgMarshal.ComInterfaceToObject(
									((global::System.IntPtr)unsafe_bufferMarshalerPtr), 
									global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.InteropServices.IMarshal,System.Runtime.WindowsRuntime, Version=4.0.14.0, Culture=neutral, Public" +
											"KeyToken=b77a5c561934e089")
								);
				// Return
				return unsafe___value;
			}
			finally
			{
				// Cleanup
				global::System.Runtime.InteropServices.McgMarshal.ComSafeRelease(new global::System.IntPtr(((void*)unsafe_bufferMarshalerPtr)));
			}
		}
	}

	public unsafe static partial class _MRT__PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public extern static uint RhpGetFuncEvalParameterBufferSize();

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public extern static uint RhpGetFuncEvalMode();

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public extern static uint RhpRecordDebuggeeInitiatedHandle(void* objectHandle);

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public extern static void RhpVerifyDebuggerCleanup();

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public extern static global::System.IntPtr RhpGetCurrentThread();

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void RhWaitForPendingFinalizers(int allowReentrantWait);

		[global::System.Runtime.InteropServices.DllImport("[MRT]", EntryPoint="RhYield", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public extern static int _RhYield();

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public extern static void RhFlushProcessWriteBuffers();

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int RhCompatibleReentrantWaitAny(
					int alertable, 
					int timeout, 
					int count, 
					global::System.IntPtr* handles);

		[global::System.Runtime.InteropServices.DllImport("[MRT]", EntryPoint="RhCallDescrWorker", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void RhCallDescrWorkerNative(global::System.IntPtr callDescr);

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void _ecvt_s(
					byte* buffer, 
					int sizeInBytes, 
					double value, 
					int count, 
					int* dec, 
					int* sign);

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void memmove(
					byte* dmem, 
					byte* smem, 
					ulong size);

		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void memset(
					byte* mem, 
					int value, 
					ulong size);
	}

	public unsafe static partial class __PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("*", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void CallingConventionConverter_GetStubs(
					global::System.IntPtr* returnVoidStub, 
					global::System.IntPtr* returnIntegerStub, 
					global::System.IntPtr* commonStub);
	}

	public unsafe static partial class api_ms_win_core_winrt_string_l1_1_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int WindowsCreateStringReference(
					ushort* sourceString, 
					uint length, 
					global::System_Runtime_InteropServices.HSTRING_HEADER__System_Private_Interop* phstringHeader, 
					void* hstring);
	}

	public unsafe static partial class api_ms_win_core_errorhandling_l1_1_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-errorhandling-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int GetLastError();

		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-errorhandling-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void SetLastError(uint dwErrCode);
	}

	public unsafe static partial class api_ms_win_core_winrt_l1_1_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-winrt-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int RoInitialize(uint initType);
	}

	public unsafe static partial class api_ms_win_core_localization_l1_2_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-localization-l1-2-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int IsValidLocaleName(ushort* lpLocaleName);

		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-localization-l1-2-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int ResolveLocaleName(
					ushort* lpNameToResolve, 
					ushort* lpLocaleName, 
					int cchLocaleName);
	}

	public unsafe static partial class kernel32_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int GetCPInfoExW(
					uint CodePage, 
					uint dwFlags, 
					global::_.Interop_Kernel32_CPINFOEXW__System_Text_Encoding_CodePages* lpCPInfoEx);
	}

	public unsafe static partial class api_ms_win_core_com_l1_1_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-com-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int CoCreateInstance(
					byte* rclsid, 
					global::System.IntPtr pUnkOuter, 
					int dwClsContext, 
					byte* riid, 
					global::System.IntPtr* ppv);
	}

	public unsafe static partial class OleAut32_PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("OleAut32", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void SysFreeString(global::System.IntPtr bstr);
	}

	public unsafe static partial class api_ms_win_core_winrt_robuffer_l1_1_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-winrt-robuffer-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.StdCall)]
		public extern static int RoGetBufferMarshaler(void** bufferMarshalerPtr);
	}
}

