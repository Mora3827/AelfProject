using AElf.Sdk.CSharp;
using AElf.Types;
using Google.Protobuf.Reflection;
using System;

public static class AuthorityInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AuthorityInfoReflection()
	{
		byte[] descriptorData = Convert.FromBase64String(AElfString.Concat("ChRhdXRob3JpdHlfaW5mby5wcm90bxoPYWVsZi9jb3JlLnByb3RvIl4KDUF1", "dGhvcml0eUluZm8SJwoQY29udHJhY3RfYWRkcmVzcxgBIAEoCzINLmFlbGYu", "QWRkcmVzcxIkCg1vd25lcl9hZGRyZXNzGAIgASgLMg0uYWVsZi5BZGRyZXNz", "YgZwcm90bzM="));
		descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[1]
		{
			CoreReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AuthorityInfo), AuthorityInfo.Parser, new string[2]
			{
				"ContractAddress",
				"OwnerAddress"
			}, null, null, null, null)
		}));
	}
}
