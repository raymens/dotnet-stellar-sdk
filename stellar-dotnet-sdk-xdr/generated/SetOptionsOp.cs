// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  struct SetOptionsOp
//  {
//      AccountID* inflationDest; // sets the inflation destination
//  
//      uint32* clearFlags; // which flags to clear
//      uint32* setFlags;   // which flags to set
//  
//      // account threshold manipulation
//      uint32* masterWeight; // weight of the master account
//      uint32* lowThreshold;
//      uint32* medThreshold;
//      uint32* highThreshold;
//  
//      string32* homeDomain; // sets the home domain
//  
//      // Add, update or remove a signer for the account
//      // signer is deleted if the weight is 0
//      Signer* signer;
//  };
//  ===========================================================================
public class SetOptionsOp  {
  public SetOptionsOp () {}
  public AccountID InflationDest {get; set;}
  public Uint32 ClearFlags {get; set;}
  public Uint32 SetFlags {get; set;}
  public Uint32 MasterWeight {get; set;}
  public Uint32 LowThreshold {get; set;}
  public Uint32 MedThreshold {get; set;}
  public Uint32 HighThreshold {get; set;}
  public String32 HomeDomain {get; set;}
  public Signer Signer {get; set;}

  public static void Encode(XdrDataOutputStream stream, SetOptionsOp encodedSetOptionsOp) {
    if (encodedSetOptionsOp.InflationDest != null) {
    stream.WriteInt(1);
    AccountID.Encode(stream, encodedSetOptionsOp.InflationDest);
    } else {
    stream.WriteInt(0);
    }
    if (encodedSetOptionsOp.ClearFlags != null) {
    stream.WriteInt(1);
    Uint32.Encode(stream, encodedSetOptionsOp.ClearFlags);
    } else {
    stream.WriteInt(0);
    }
    if (encodedSetOptionsOp.SetFlags != null) {
    stream.WriteInt(1);
    Uint32.Encode(stream, encodedSetOptionsOp.SetFlags);
    } else {
    stream.WriteInt(0);
    }
    if (encodedSetOptionsOp.MasterWeight != null) {
    stream.WriteInt(1);
    Uint32.Encode(stream, encodedSetOptionsOp.MasterWeight);
    } else {
    stream.WriteInt(0);
    }
    if (encodedSetOptionsOp.LowThreshold != null) {
    stream.WriteInt(1);
    Uint32.Encode(stream, encodedSetOptionsOp.LowThreshold);
    } else {
    stream.WriteInt(0);
    }
    if (encodedSetOptionsOp.MedThreshold != null) {
    stream.WriteInt(1);
    Uint32.Encode(stream, encodedSetOptionsOp.MedThreshold);
    } else {
    stream.WriteInt(0);
    }
    if (encodedSetOptionsOp.HighThreshold != null) {
    stream.WriteInt(1);
    Uint32.Encode(stream, encodedSetOptionsOp.HighThreshold);
    } else {
    stream.WriteInt(0);
    }
    if (encodedSetOptionsOp.HomeDomain != null) {
    stream.WriteInt(1);
    String32.Encode(stream, encodedSetOptionsOp.HomeDomain);
    } else {
    stream.WriteInt(0);
    }
    if (encodedSetOptionsOp.Signer != null) {
    stream.WriteInt(1);
    Signer.Encode(stream, encodedSetOptionsOp.Signer);
    } else {
    stream.WriteInt(0);
    }
  }
  public static SetOptionsOp Decode(XdrDataInputStream stream) {
    SetOptionsOp decodedSetOptionsOp = new SetOptionsOp();
    int InflationDestPresent = stream.ReadInt();
    if (InflationDestPresent != 0) {
    decodedSetOptionsOp.InflationDest = AccountID.Decode(stream);
    }
    int ClearFlagsPresent = stream.ReadInt();
    if (ClearFlagsPresent != 0) {
    decodedSetOptionsOp.ClearFlags = Uint32.Decode(stream);
    }
    int SetFlagsPresent = stream.ReadInt();
    if (SetFlagsPresent != 0) {
    decodedSetOptionsOp.SetFlags = Uint32.Decode(stream);
    }
    int MasterWeightPresent = stream.ReadInt();
    if (MasterWeightPresent != 0) {
    decodedSetOptionsOp.MasterWeight = Uint32.Decode(stream);
    }
    int LowThresholdPresent = stream.ReadInt();
    if (LowThresholdPresent != 0) {
    decodedSetOptionsOp.LowThreshold = Uint32.Decode(stream);
    }
    int MedThresholdPresent = stream.ReadInt();
    if (MedThresholdPresent != 0) {
    decodedSetOptionsOp.MedThreshold = Uint32.Decode(stream);
    }
    int HighThresholdPresent = stream.ReadInt();
    if (HighThresholdPresent != 0) {
    decodedSetOptionsOp.HighThreshold = Uint32.Decode(stream);
    }
    int HomeDomainPresent = stream.ReadInt();
    if (HomeDomainPresent != 0) {
    decodedSetOptionsOp.HomeDomain = String32.Decode(stream);
    }
    int SignerPresent = stream.ReadInt();
    if (SignerPresent != 0) {
    decodedSetOptionsOp.Signer = Signer.Decode(stream);
    }
    return decodedSetOptionsOp;
  }
}
}
