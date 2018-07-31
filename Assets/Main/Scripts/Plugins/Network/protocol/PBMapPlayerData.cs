// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PBMapPlayerData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from PBMapPlayerData.proto</summary>
  public static partial class PBMapPlayerDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PBMapPlayerData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PBMapPlayerDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQQk1hcFBsYXllckRhdGEucHJvdG8aElBCUGxheWVyRGF0YS5wcm90byI1",
            "Cg9QQk1hcFBsYXllckRhdGESIgoLcGxheWVyX2RhdGEYASABKAsyDS5QQlBs",
            "YXllckRhdGFCJAoPY29tLmNzZi5iaWdoZWFkqgIQQmlnSGVhZC5wcm90b2Nv",
            "bGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::BigHead.protocol.PBPlayerDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.PBMapPlayerData), global::BigHead.protocol.PBMapPlayerData.Parser, new[]{ "PlayerData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Map Player's Data
  /// </summary>
  public sealed partial class PBMapPlayerData : pb::IMessage<PBMapPlayerData> {
    private static readonly pb::MessageParser<PBMapPlayerData> _parser = new pb::MessageParser<PBMapPlayerData>(() => new PBMapPlayerData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PBMapPlayerData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.PBMapPlayerDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBMapPlayerData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBMapPlayerData(PBMapPlayerData other) : this() {
      PlayerData = other.playerData_ != null ? other.PlayerData.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBMapPlayerData Clone() {
      return new PBMapPlayerData(this);
    }

    /// <summary>Field number for the "player_data" field.</summary>
    public const int PlayerDataFieldNumber = 1;
    private global::BigHead.protocol.PBPlayerData playerData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::BigHead.protocol.PBPlayerData PlayerData {
      get { return playerData_; }
      set {
        playerData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PBMapPlayerData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PBMapPlayerData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerData, other.PlayerData)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (playerData_ != null) hash ^= PlayerData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (playerData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PlayerData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (playerData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PBMapPlayerData other) {
      if (other == null) {
        return;
      }
      if (other.playerData_ != null) {
        if (playerData_ == null) {
          playerData_ = new global::BigHead.protocol.PBPlayerData();
        }
        PlayerData.MergeFrom(other.PlayerData);
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
          case 10: {
            if (playerData_ == null) {
              playerData_ = new global::BigHead.protocol.PBPlayerData();
            }
            input.ReadMessage(playerData_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code