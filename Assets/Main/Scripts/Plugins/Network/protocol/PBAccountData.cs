// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PBAccountData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from PBAccountData.proto</summary>
  public static partial class PBAccountDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PBAccountData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PBAccountDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQQkFjY291bnREYXRhLnByb3RvImQKDVBCQWNjb3VudERhdGESCwoDVWlk",
            "GAEgASgEEhAKCFJlY2hhcmdlGAIgASgFEhAKCERpYW1vbmRzGAMgASgFEhAK",
            "CFZpcExldmVsGAQgASgFEhAKCHVzZXJuYW1lGAUgASgJQkkKHWNvbS53aGFs",
            "ZWlzbGFuZC5nYW1lLnByb3RvY29sQhVQQkFjY291bnREYXRhUHJvdG9jb2yq",
            "AhBCaWdIZWFkLnByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.PBAccountData), global::BigHead.protocol.PBAccountData.Parser, new[]{ "Uid", "Recharge", "Diamonds", "VipLevel", "Username" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Game Player's Data
  /// </summary>
  public sealed partial class PBAccountData : pb::IMessage<PBAccountData> {
    private static readonly pb::MessageParser<PBAccountData> _parser = new pb::MessageParser<PBAccountData>(() => new PBAccountData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PBAccountData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.PBAccountDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBAccountData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBAccountData(PBAccountData other) : this() {
      uid_ = other.uid_;
      recharge_ = other.recharge_;
      diamonds_ = other.diamonds_;
      vipLevel_ = other.vipLevel_;
      username_ = other.username_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBAccountData Clone() {
      return new PBAccountData(this);
    }

    /// <summary>Field number for the "Uid" field.</summary>
    public const int UidFieldNumber = 1;
    private ulong uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "Recharge" field.</summary>
    public const int RechargeFieldNumber = 2;
    private int recharge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Recharge {
      get { return recharge_; }
      set {
        recharge_ = value;
      }
    }

    /// <summary>Field number for the "Diamonds" field.</summary>
    public const int DiamondsFieldNumber = 3;
    private int diamonds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Diamonds {
      get { return diamonds_; }
      set {
        diamonds_ = value;
      }
    }

    /// <summary>Field number for the "VipLevel" field.</summary>
    public const int VipLevelFieldNumber = 4;
    private int vipLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int VipLevel {
      get { return vipLevel_; }
      set {
        vipLevel_ = value;
      }
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 5;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PBAccountData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PBAccountData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Recharge != other.Recharge) return false;
      if (Diamonds != other.Diamonds) return false;
      if (VipLevel != other.VipLevel) return false;
      if (Username != other.Username) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0UL) hash ^= Uid.GetHashCode();
      if (Recharge != 0) hash ^= Recharge.GetHashCode();
      if (Diamonds != 0) hash ^= Diamonds.GetHashCode();
      if (VipLevel != 0) hash ^= VipLevel.GetHashCode();
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Uid);
      }
      if (Recharge != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Recharge);
      }
      if (Diamonds != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Diamonds);
      }
      if (VipLevel != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(VipLevel);
      }
      if (Username.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Username);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Uid);
      }
      if (Recharge != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Recharge);
      }
      if (Diamonds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Diamonds);
      }
      if (VipLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(VipLevel);
      }
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PBAccountData other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0UL) {
        Uid = other.Uid;
      }
      if (other.Recharge != 0) {
        Recharge = other.Recharge;
      }
      if (other.Diamonds != 0) {
        Diamonds = other.Diamonds;
      }
      if (other.VipLevel != 0) {
        VipLevel = other.VipLevel;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Uid = input.ReadUInt64();
            break;
          }
          case 16: {
            Recharge = input.ReadInt32();
            break;
          }
          case 24: {
            Diamonds = input.ReadInt32();
            break;
          }
          case 32: {
            VipLevel = input.ReadInt32();
            break;
          }
          case 42: {
            Username = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code