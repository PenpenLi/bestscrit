// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 2002_GCGetReward.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from 2002_GCGetReward.proto</summary>
  public static partial class GCGetRewardReflection {

    #region Descriptor
    /// <summary>File descriptor for 2002_GCGetReward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGetRewardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChYyMDAyX0dDR2V0UmV3YXJkLnByb3RvItMBCgtHQ0dldFJld2FyZBISCgph",
            "Y2NvdW50X2lkGAEgASgEEhEKCXBsYXllcl9pZBgCIAEoBBIQCghkaWFtb25k",
            "cxgDIAEoBRINCgVsZXZlbBgEIAEoBRILCgNleHAYBSABKAUSCgoCaHAYBiAB",
            "KAUSCgoCbXAYByABKAUSDAoEZm9vZBgIIAEoBRIMCgRnb2xkGAkgASgFEg0K",
            "BWNhcmRzGAogAygFEg0KBWl0ZW1zGAsgAygFEg0KBWJ1ZmZzGAwgAygFEg4K",
            "BmVxdWlwcxgNIAMoBUJHCh1jb20ud2hhbGVpc2xhbmQuZ2FtZS5wcm90b2Nv",
            "bEITR0NHZXRSZXdhcmRQcm90b2NvbKoCEEJpZ0hlYWQucHJvdG9jb2xiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.GCGetReward), global::BigHead.protocol.GCGetReward.Parser, new[]{ "AccountId", "PlayerId", "Diamonds", "Level", "Exp", "Hp", "Mp", "Food", "Gold", "Cards", "Items", "Buffs", "Equips" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request to Enter the instance
  /// </summary>
  public sealed partial class GCGetReward : pb::IMessage<GCGetReward> {
    private static readonly pb::MessageParser<GCGetReward> _parser = new pb::MessageParser<GCGetReward>(() => new GCGetReward());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GCGetReward> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.GCGetRewardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCGetReward() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCGetReward(GCGetReward other) : this() {
      accountId_ = other.accountId_;
      playerId_ = other.playerId_;
      diamonds_ = other.diamonds_;
      level_ = other.level_;
      exp_ = other.exp_;
      hp_ = other.hp_;
      mp_ = other.mp_;
      food_ = other.food_;
      gold_ = other.gold_;
      cards_ = other.cards_.Clone();
      items_ = other.items_.Clone();
      buffs_ = other.buffs_.Clone();
      equips_ = other.equips_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCGetReward Clone() {
      return new GCGetReward(this);
    }

    /// <summary>Field number for the "account_id" field.</summary>
    public const int AccountIdFieldNumber = 1;
    private ulong accountId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong AccountId {
      get { return accountId_; }
      set {
        accountId_ = value;
      }
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 2;
    private ulong playerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PlayerId {
      get { return playerId_; }
      set {
        playerId_ = value;
      }
    }

    /// <summary>Field number for the "diamonds" field.</summary>
    public const int DiamondsFieldNumber = 3;
    private int diamonds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Diamonds {
      get { return diamonds_; }
      set {
        diamonds_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 4;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 5;
    private int exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 6;
    private int hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "mp" field.</summary>
    public const int MpFieldNumber = 7;
    private int mp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Mp {
      get { return mp_; }
      set {
        mp_ = value;
      }
    }

    /// <summary>Field number for the "food" field.</summary>
    public const int FoodFieldNumber = 8;
    private int food_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Food {
      get { return food_; }
      set {
        food_ = value;
      }
    }

    /// <summary>Field number for the "gold" field.</summary>
    public const int GoldFieldNumber = 9;
    private int gold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gold {
      get { return gold_; }
      set {
        gold_ = value;
      }
    }

    /// <summary>Field number for the "cards" field.</summary>
    public const int CardsFieldNumber = 10;
    private static readonly pb::FieldCodec<int> _repeated_cards_codec
        = pb::FieldCodec.ForInt32(82);
    private readonly pbc::RepeatedField<int> cards_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Cards {
      get { return cards_; }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 11;
    private static readonly pb::FieldCodec<int> _repeated_items_codec
        = pb::FieldCodec.ForInt32(90);
    private readonly pbc::RepeatedField<int> items_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Items {
      get { return items_; }
    }

    /// <summary>Field number for the "buffs" field.</summary>
    public const int BuffsFieldNumber = 12;
    private static readonly pb::FieldCodec<int> _repeated_buffs_codec
        = pb::FieldCodec.ForInt32(98);
    private readonly pbc::RepeatedField<int> buffs_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Buffs {
      get { return buffs_; }
    }

    /// <summary>Field number for the "equips" field.</summary>
    public const int EquipsFieldNumber = 13;
    private static readonly pb::FieldCodec<int> _repeated_equips_codec
        = pb::FieldCodec.ForInt32(106);
    private readonly pbc::RepeatedField<int> equips_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Equips {
      get { return equips_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GCGetReward);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GCGetReward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountId != other.AccountId) return false;
      if (PlayerId != other.PlayerId) return false;
      if (Diamonds != other.Diamonds) return false;
      if (Level != other.Level) return false;
      if (Exp != other.Exp) return false;
      if (Hp != other.Hp) return false;
      if (Mp != other.Mp) return false;
      if (Food != other.Food) return false;
      if (Gold != other.Gold) return false;
      if(!cards_.Equals(other.cards_)) return false;
      if(!items_.Equals(other.items_)) return false;
      if(!buffs_.Equals(other.buffs_)) return false;
      if(!equips_.Equals(other.equips_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AccountId != 0UL) hash ^= AccountId.GetHashCode();
      if (PlayerId != 0UL) hash ^= PlayerId.GetHashCode();
      if (Diamonds != 0) hash ^= Diamonds.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (Mp != 0) hash ^= Mp.GetHashCode();
      if (Food != 0) hash ^= Food.GetHashCode();
      if (Gold != 0) hash ^= Gold.GetHashCode();
      hash ^= cards_.GetHashCode();
      hash ^= items_.GetHashCode();
      hash ^= buffs_.GetHashCode();
      hash ^= equips_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AccountId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(AccountId);
      }
      if (PlayerId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(PlayerId);
      }
      if (Diamonds != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Diamonds);
      }
      if (Level != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Level);
      }
      if (Exp != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Exp);
      }
      if (Hp != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Hp);
      }
      if (Mp != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Mp);
      }
      if (Food != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Food);
      }
      if (Gold != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Gold);
      }
      cards_.WriteTo(output, _repeated_cards_codec);
      items_.WriteTo(output, _repeated_items_codec);
      buffs_.WriteTo(output, _repeated_buffs_codec);
      equips_.WriteTo(output, _repeated_equips_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AccountId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AccountId);
      }
      if (PlayerId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PlayerId);
      }
      if (Diamonds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Diamonds);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Exp);
      }
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hp);
      }
      if (Mp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Mp);
      }
      if (Food != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Food);
      }
      if (Gold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gold);
      }
      size += cards_.CalculateSize(_repeated_cards_codec);
      size += items_.CalculateSize(_repeated_items_codec);
      size += buffs_.CalculateSize(_repeated_buffs_codec);
      size += equips_.CalculateSize(_repeated_equips_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GCGetReward other) {
      if (other == null) {
        return;
      }
      if (other.AccountId != 0UL) {
        AccountId = other.AccountId;
      }
      if (other.PlayerId != 0UL) {
        PlayerId = other.PlayerId;
      }
      if (other.Diamonds != 0) {
        Diamonds = other.Diamonds;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.Mp != 0) {
        Mp = other.Mp;
      }
      if (other.Food != 0) {
        Food = other.Food;
      }
      if (other.Gold != 0) {
        Gold = other.Gold;
      }
      cards_.Add(other.cards_);
      items_.Add(other.items_);
      buffs_.Add(other.buffs_);
      equips_.Add(other.equips_);
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
            AccountId = input.ReadUInt64();
            break;
          }
          case 16: {
            PlayerId = input.ReadUInt64();
            break;
          }
          case 24: {
            Diamonds = input.ReadInt32();
            break;
          }
          case 32: {
            Level = input.ReadInt32();
            break;
          }
          case 40: {
            Exp = input.ReadInt32();
            break;
          }
          case 48: {
            Hp = input.ReadInt32();
            break;
          }
          case 56: {
            Mp = input.ReadInt32();
            break;
          }
          case 64: {
            Food = input.ReadInt32();
            break;
          }
          case 72: {
            Gold = input.ReadInt32();
            break;
          }
          case 82:
          case 80: {
            cards_.AddEntriesFrom(input, _repeated_cards_codec);
            break;
          }
          case 90:
          case 88: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
          case 98:
          case 96: {
            buffs_.AddEntriesFrom(input, _repeated_buffs_codec);
            break;
          }
          case 106:
          case 104: {
            equips_.AddEntriesFrom(input, _repeated_equips_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code