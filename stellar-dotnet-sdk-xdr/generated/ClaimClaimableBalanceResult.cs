// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  union ClaimClaimableBalanceResult switch (ClaimClaimableBalanceResultCode code)
//  {
//  case CLAIM_CLAIMABLE_BALANCE_SUCCESS:
//      void;
//  default:
//      void;
//  };
//  ===========================================================================
public class ClaimClaimableBalanceResult  {
  public ClaimClaimableBalanceResult () {}
  public ClaimClaimableBalanceResultCode Discriminant { get; set; } = new ClaimClaimableBalanceResultCode();
  public static void Encode(XdrDataOutputStream stream, ClaimClaimableBalanceResult encodedClaimClaimableBalanceResult) {
  stream.WriteInt((int)encodedClaimClaimableBalanceResult.Discriminant.InnerValue);
  switch (encodedClaimClaimableBalanceResult.Discriminant.InnerValue) {
  case ClaimClaimableBalanceResultCode.ClaimClaimableBalanceResultCodeEnum.CLAIM_CLAIMABLE_BALANCE_SUCCESS:
  break;
  default:
  break;
  }
  }
  public static ClaimClaimableBalanceResult Decode(XdrDataInputStream stream) {
  ClaimClaimableBalanceResult decodedClaimClaimableBalanceResult = new ClaimClaimableBalanceResult();
  ClaimClaimableBalanceResultCode discriminant = ClaimClaimableBalanceResultCode.Decode(stream);
  decodedClaimClaimableBalanceResult.Discriminant = discriminant;
  switch (decodedClaimClaimableBalanceResult.Discriminant.InnerValue) {
  case ClaimClaimableBalanceResultCode.ClaimClaimableBalanceResultCodeEnum.CLAIM_CLAIMABLE_BALANCE_SUCCESS:
  break;
  default:
  break;
  }
    return decodedClaimClaimableBalanceResult;
  }
}
}
