// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  struct SCPEnvelope
//  {
//      SCPStatement statement;
//      Signature signature;
//  };
//  ===========================================================================
public class SCPEnvelope  {
  public SCPEnvelope () {}
  public SCPStatement Statement {get; set;}
  public Signature Signature {get; set;}

  public static void Encode(XdrDataOutputStream stream, SCPEnvelope encodedSCPEnvelope) {
    SCPStatement.Encode(stream, encodedSCPEnvelope.Statement);
    Signature.Encode(stream, encodedSCPEnvelope.Signature);
  }
  public static SCPEnvelope Decode(XdrDataInputStream stream) {
    SCPEnvelope decodedSCPEnvelope = new SCPEnvelope();
    decodedSCPEnvelope.Statement = SCPStatement.Decode(stream);
    decodedSCPEnvelope.Signature = Signature.Decode(stream);
    return decodedSCPEnvelope;
  }
}
}
