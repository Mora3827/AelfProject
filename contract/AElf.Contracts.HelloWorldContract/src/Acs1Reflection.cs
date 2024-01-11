using AElf.Sdk.CSharp;
using AElf.Types;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using System;

namespace AElf.Standards.ACS1
{
	public static class Acs1Reflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static Acs1Reflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(AElfString.Concat(new string[14]
			{
				"CgphY3MxLnByb3RvEgRhY3MxGhJhZWxmL29wdGlvbnMucHJvdG8aG2dvb2ds",
				"ZS9wcm90b2J1Zi9lbXB0eS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBw",
				"ZXJzLnByb3RvGg9hZWxmL2NvcmUucHJvdG8aFGF1dGhvcml0eV9pbmZvLnBy",
				"b3RvIloKCk1ldGhvZEZlZXMSEwoLbWV0aG9kX25hbWUYASABKAkSHQoEZmVl",
				"cxgCIAMoCzIPLmFjczEuTWV0aG9kRmVlEhgKEGlzX3NpemVfZmVlX2ZyZWUY",
				"AyABKAgiLgoJTWV0aG9kRmVlEg4KBnN5bWJvbBgBIAEoCRIRCgliYXNpY19m",
				"ZWUYAiABKAMyrgIKGU1ldGhvZEZlZVByb3ZpZGVyQ29udHJhY3QSOgoMU2V0",
				"TWV0aG9kRmVlEhAuYWNzMS5NZXRob2RGZWVzGhYuZ29vZ2xlLnByb3RvYnVm",
				"LkVtcHR5IgASRQoZQ2hhbmdlTWV0aG9kRmVlQ29udHJvbGxlchIOLkF1dGhv",
				"cml0eUluZm8aFi5nb29nbGUucHJvdG9idWYuRW1wdHkiABJFCgxHZXRNZXRo",
				"b2RGZWUSHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUaEC5hY3MxLk1l",
				"dGhvZEZlZXMiBYiJ9wEBEkcKFkdldE1ldGhvZEZlZUNvbnRyb2xsZXISFi5n",
				"b29nbGUucHJvdG9idWYuRW1wdHkaDi5BdXRob3JpdHlJbmZvIgWIifcBAUIf",
				"qgITQUVsZi5TdGFuZGFyZHMuQUNTMYqS9AEEYWNzMVAAUAFQAmIGcHJvdG8z"
			})), new FileDescriptor[5]
			{
				OptionsReflection.Descriptor,
				EmptyReflection.Descriptor,
				WrappersReflection.Descriptor,
				CoreReflection.Descriptor,
				AuthorityInfoReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
			{
				new GeneratedClrTypeInfo(typeof(MethodFees), MethodFees.Parser, new string[3]
				{
					"MethodName",
					"Fees",
					"IsSizeFeeFree"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MethodFee), MethodFee.Parser, new string[2]
				{
					"Symbol",
					"BasicFee"
				}, null, null, null, null)
			}));
		}
	}
}
