using AElf.Types;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

public sealed class AuthorityInfo : IMessage<AuthorityInfo>, IMessage, IEquatable<AuthorityInfo>, IDeepCloneable<AuthorityInfo>
{
	private static readonly MessageParser<AuthorityInfo> _parser = new MessageParser<AuthorityInfo>((Func<AuthorityInfo>)(() => new AuthorityInfo()));

	private UnknownFieldSet _unknownFields;

	public const int ContractAddressFieldNumber = 1;

	private Address contractAddress_;

	public const int OwnerAddressFieldNumber = 2;

	private Address ownerAddress_;

	[DebuggerNonUserCode]
	public static MessageParser<AuthorityInfo> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => AuthorityInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Address ContractAddress
	{
		get
		{
			return contractAddress_;
		}
		set
		{
			contractAddress_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Address OwnerAddress
	{
		get
		{
			return ownerAddress_;
		}
		set
		{
			ownerAddress_ = value;
		}
	}

	[DebuggerNonUserCode]
	public AuthorityInfo()
	{
	}

	[DebuggerNonUserCode]
	public AuthorityInfo(AuthorityInfo other)
		: this()
	{
		contractAddress_ = ((other.contractAddress_ != null) ? other.contractAddress_.Clone() : null);
		ownerAddress_ = ((other.ownerAddress_ != null) ? other.ownerAddress_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public AuthorityInfo Clone()
	{
		return new AuthorityInfo(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as AuthorityInfo);
	}

	[DebuggerNonUserCode]
	public bool Equals(AuthorityInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ContractAddress, other.ContractAddress))
		{
			return false;
		}
		if (!object.Equals(OwnerAddress, other.OwnerAddress))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (contractAddress_ != null)
		{
			num ^= ContractAddress.GetHashCode();
		}
		if (ownerAddress_ != null)
		{
			num ^= OwnerAddress.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (contractAddress_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ContractAddress);
		}
		if (ownerAddress_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(OwnerAddress);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		checked
		{
			if (contractAddress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(ContractAddress);
			}
			if (ownerAddress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(OwnerAddress);
			}
			if (_unknownFields != null)
			{
				num += _unknownFields.CalculateSize();
			}
			return num;
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(AuthorityInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.contractAddress_ != null)
		{
			if (contractAddress_ == null)
			{
				ContractAddress = new Address();
			}
			ContractAddress.MergeFrom(other.ContractAddress);
		}
		if (other.ownerAddress_ != null)
		{
			if (ownerAddress_ == null)
			{
				OwnerAddress = new Address();
			}
			OwnerAddress.MergeFrom(other.OwnerAddress);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 10u:
				if (contractAddress_ == null)
				{
					ContractAddress = new Address();
				}
				input.ReadMessage(ContractAddress);
				break;
			case 18u:
				if (ownerAddress_ == null)
				{
					OwnerAddress = new Address();
				}
				input.ReadMessage(OwnerAddress);
				break;
			}
		}
	}
}
