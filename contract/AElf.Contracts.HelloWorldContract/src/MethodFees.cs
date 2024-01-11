using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace AElf.Standards.ACS1
{
	public sealed class MethodFees : IMessage<MethodFees>, IMessage, IEquatable<MethodFees>, IDeepCloneable<MethodFees>
	{
		private static readonly MessageParser<MethodFees> _parser = new MessageParser<MethodFees>((Func<MethodFees>)(() => new MethodFees()));

		private UnknownFieldSet _unknownFields;

		public const int MethodNameFieldNumber = 1;

		private string methodName_ = "";

		public const int FeesFieldNumber = 2;

		private static readonly FieldCodec<MethodFee> _repeated_fees_codec = FieldCodec.ForMessage(18u, MethodFee.Parser);

		private readonly RepeatedField<MethodFee> fees_ = new RepeatedField<MethodFee>();

		public const int IsSizeFeeFreeFieldNumber = 3;

		private bool isSizeFeeFree_;

		[DebuggerNonUserCode]
		public static MessageParser<MethodFees> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => Acs1Reflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string MethodName
		{
			get
			{
				return methodName_;
			}
			set
			{
				methodName_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<MethodFee> Fees => fees_;

		[DebuggerNonUserCode]
		public bool IsSizeFeeFree
		{
			get
			{
				return isSizeFeeFree_;
			}
			set
			{
				isSizeFeeFree_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MethodFees()
		{
		}

		[DebuggerNonUserCode]
		public MethodFees(MethodFees other)
			: this()
		{
			methodName_ = other.methodName_;
			fees_ = other.fees_.Clone();
			isSizeFeeFree_ = other.isSizeFeeFree_;
			_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		[DebuggerNonUserCode]
		public MethodFees Clone()
		{
			return new MethodFees(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as MethodFees);
		}

		[DebuggerNonUserCode]
		public bool Equals(MethodFees other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (MethodName != other.MethodName)
			{
				return false;
			}
			if (!fees_.Equals(other.fees_))
			{
				return false;
			}
			if (IsSizeFeeFree != other.IsSizeFeeFree)
			{
				return false;
			}
			return object.Equals(_unknownFields, other._unknownFields);
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (MethodName.Length != 0)
			{
				num ^= MethodName.GetHashCode();
			}
			num ^= fees_.GetHashCode();
			if (IsSizeFeeFree)
			{
				num ^= IsSizeFeeFree.GetHashCode();
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
			if (MethodName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(MethodName);
			}
			fees_.WriteTo(output, _repeated_fees_codec);
			if (IsSizeFeeFree)
			{
				output.WriteRawTag(24);
				output.WriteBool(IsSizeFeeFree);
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
				if (MethodName.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(MethodName);
				}
				num += fees_.CalculateSize(_repeated_fees_codec);
				if (IsSizeFeeFree)
				{
					num += 2;
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MethodFees other)
		{
			if (other != null)
			{
				if (other.MethodName.Length != 0)
				{
					MethodName = other.MethodName;
				}
				fees_.Add(other.fees_);
				if (other.IsSizeFeeFree)
				{
					IsSizeFeeFree = other.IsSizeFeeFree;
				}
				_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
			}
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
					MethodName = input.ReadString();
					break;
				case 18u:
					fees_.AddEntriesFrom(input, _repeated_fees_codec);
					break;
				case 24u:
					IsSizeFeeFree = input.ReadBool();
					break;
				}
			}
		}
	}
}
