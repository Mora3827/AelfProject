using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace AElf.Standards.ACS1
{
	public sealed class MethodFee : IMessage<MethodFee>, IMessage, IEquatable<MethodFee>, IDeepCloneable<MethodFee>
	{
		private static readonly MessageParser<MethodFee> _parser = new MessageParser<MethodFee>((Func<MethodFee>)(() => new MethodFee()));

		private UnknownFieldSet _unknownFields;

		public const int SymbolFieldNumber = 1;

		private string symbol_ = "";

		public const int BasicFeeFieldNumber = 2;

		private long basicFee_;

		[DebuggerNonUserCode]
		public static MessageParser<MethodFee> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => Acs1Reflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Symbol
		{
			get
			{
				return symbol_;
			}
			set
			{
				symbol_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public long BasicFee
		{
			get
			{
				return basicFee_;
			}
			set
			{
				basicFee_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MethodFee()
		{
		}

		[DebuggerNonUserCode]
		public MethodFee(MethodFee other)
			: this()
		{
			symbol_ = other.symbol_;
			basicFee_ = other.basicFee_;
			_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		[DebuggerNonUserCode]
		public MethodFee Clone()
		{
			return new MethodFee(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as MethodFee);
		}

		[DebuggerNonUserCode]
		public bool Equals(MethodFee other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Symbol != other.Symbol)
			{
				return false;
			}
			if (BasicFee != other.BasicFee)
			{
				return false;
			}
			return object.Equals(_unknownFields, other._unknownFields);
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Symbol.Length != 0)
			{
				num ^= Symbol.GetHashCode();
			}
			if (BasicFee != 0L)
			{
				num ^= BasicFee.GetHashCode();
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
			if (Symbol.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Symbol);
			}
			if (BasicFee != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(BasicFee);
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
				if (Symbol.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(Symbol);
				}
				if (BasicFee != 0L)
				{
					num += 1 + CodedOutputStream.ComputeInt64Size(BasicFee);
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MethodFee other)
		{
			if (other != null)
			{
				if (other.Symbol.Length != 0)
				{
					Symbol = other.Symbol;
				}
				if (other.BasicFee != 0L)
				{
					BasicFee = other.BasicFee;
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
					Symbol = input.ReadString();
					break;
				case 16u:
					BasicFee = input.ReadInt64();
					break;
				}
			}
		}
	}
}
