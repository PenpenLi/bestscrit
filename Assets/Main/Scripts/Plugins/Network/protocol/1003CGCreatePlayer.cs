// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 1003_CGCreatePlayer.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from 1003_CGCreatePlayer.proto</summary>
  public static partial class CGCreatePlayerReflection {

    #region Descriptor
    /// <summary>File descriptor for 1003_CGCreatePlayer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CGCreatePlayerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChkxMDAzX0NHQ3JlYXRlUGxheWVyLnByb3RvIkMKDkNHQ3JlYXRlUGxheWVy",
            "Eg4KBnVzZXJJZBgBIAEoBBITCgtjaGFyYWN0ZXJJZBgCIAEoBRIMCgRuYW1l",
            "GAMgASgJQkoKHWNvbS53aGFsZWlzbGFuZC5nYW1lLnByb3RvY29sQhZDR0Ny",
            "ZWF0ZVBsYXllclByb3RvY29sqgIQQmlnSGVhZC5wcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.CGCreatePlayer), global::BigHead.protocol.CGCreatePlayer.Parser, new[]{ "UserId", "CharacterId", "Name" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 创建角色请求
  /// </summary>
  public sealed partial class CGCreatePlayer : pb::IMessage<CGCreatePlayer> {
    private static readonly pb::MessageParser<CGCreatePlayer> _parser = new pb::MessageParser<CGCreatePlayer>(() => new CGCreatePlayer());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CGCreatePlayer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.CGCreatePlayerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGCreatePlayer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGCreatePlayer(CGCreatePlayer other) : this() {
      userId_ = other.userId_;
      characterId_ = other.characterId_;
      name_ = other.name_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGCreatePlayer Clone() {
      return new CGCreatePlayer(this);
    }

    /// <summary>Field number for the "userId" field.</summary>
    public const int UserIdFieldNumber = 1;
    private ulong userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "characterId" field.</summary>
    public const int CharacterIdFieldNumber = 2;
    private int characterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CharacterId {
      get { return characterId_; }
      set {
        characterId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CGCreatePlayer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CGCreatePlayer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (CharacterId != other.CharacterId) return false;
      if (Name != other.Name) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0UL) hash ^= UserId.GetHashCode();
      if (CharacterId != 0) hash ^= CharacterId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(UserId);
      }
      if (CharacterId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CharacterId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UserId);
      }
      if (CharacterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CharacterId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CGCreatePlayer other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0UL) {
        UserId = other.UserId;
      }
      if (other.CharacterId != 0) {
        CharacterId = other.CharacterId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
            UserId = input.ReadUInt64();
            break;
          }
          case 16: {
            CharacterId = input.ReadInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
