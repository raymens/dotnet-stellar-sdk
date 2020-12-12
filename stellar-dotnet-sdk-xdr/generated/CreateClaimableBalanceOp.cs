// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  struct CreateClaimableBalanceOp
//  {
//      Asset asset;
//      int64 amount;
//      Claimant claimants<10>;
//  };
//  ===========================================================================
public class CreateClaimableBalanceOp  {
  public CreateClaimableBalanceOp () {}
  public Asset Asset {get; set;}
  public Int64 Amount {get; set;}
  public Claimant[] Claimants {get; set;}

  public static void Encode(XdrDataOutputStream stream, CreateClaimableBalanceOp encodedCreateClaimableBalanceOp) {
    Asset.Encode(stream, encodedCreateClaimableBalanceOp.Asset);
    Int64.Encode(stream, encodedCreateClaimableBalanceOp.Amount);
    int claimantssize = encodedCreateClaimableBalanceOp.Claimants.Length;
    stream.WriteInt(claimantssize);
    for (int i = 0; i < claimantssize; i++) {
      Claimant.Encode(stream, encodedCreateClaimableBalanceOp.Claimants[i]);
    }
  }
  public static CreateClaimableBalanceOp Decode(XdrDataInputStream stream) {
    CreateClaimableBalanceOp decodedCreateClaimableBalanceOp = new CreateClaimableBalanceOp();
    decodedCreateClaimableBalanceOp.Asset = Asset.Decode(stream);
    decodedCreateClaimableBalanceOp.Amount = Int64.Decode(stream);
    int claimantssize = stream.ReadInt();
    decodedCreateClaimableBalanceOp.Claimants = new Claimant[claimantssize];
    for (int i = 0; i < claimantssize; i++) {
      decodedCreateClaimableBalanceOp.Claimants[i] = Claimant.Decode(stream);
    }
    return decodedCreateClaimableBalanceOp;
  }
}
}
