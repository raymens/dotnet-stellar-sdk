// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  struct InflationPayout // or use PaymentResultAtom to limit types?
//  {
//      AccountID destination;
//      int64 amount;
//  };
//  ===========================================================================
public class InflationPayout  {
  public InflationPayout () {}
  public AccountID Destination {get; set;}
  public Int64 Amount {get; set;}

  public static void Encode(XdrDataOutputStream stream, InflationPayout encodedInflationPayout) {
    AccountID.Encode(stream, encodedInflationPayout.Destination);
    Int64.Encode(stream, encodedInflationPayout.Amount);
  }
  public static InflationPayout Decode(XdrDataInputStream stream) {
    InflationPayout decodedInflationPayout = new InflationPayout();
    decodedInflationPayout.Destination = AccountID.Decode(stream);
    decodedInflationPayout.Amount = Int64.Decode(stream);
    return decodedInflationPayout;
  }
}
}
