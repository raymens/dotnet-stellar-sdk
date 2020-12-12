// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  union TransactionEnvelope switch (EnvelopeType type)
//  {
//  case ENVELOPE_TYPE_TX_V0:
//      TransactionV0Envelope v0;
//  case ENVELOPE_TYPE_TX:
//      TransactionV1Envelope v1;
//  case ENVELOPE_TYPE_TX_FEE_BUMP:
//      FeeBumpTransactionEnvelope feeBump;
//  };
//  ===========================================================================
public class TransactionEnvelope  {
  public TransactionEnvelope () {}
  public EnvelopeType Discriminant { get; set; } = new EnvelopeType();
  public TransactionV0Envelope V0 {get; set;}
  public TransactionV1Envelope V1 {get; set;}
  public FeeBumpTransactionEnvelope FeeBump {get; set;}
  public static void Encode(XdrDataOutputStream stream, TransactionEnvelope encodedTransactionEnvelope) {
  stream.WriteInt((int)encodedTransactionEnvelope.Discriminant.InnerValue);
  switch (encodedTransactionEnvelope.Discriminant.InnerValue) {
  case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_TX_V0:
  TransactionV0Envelope.Encode(stream, encodedTransactionEnvelope.V0);
  break;
  case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_TX:
  TransactionV1Envelope.Encode(stream, encodedTransactionEnvelope.V1);
  break;
  case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_TX_FEE_BUMP:
  FeeBumpTransactionEnvelope.Encode(stream, encodedTransactionEnvelope.FeeBump);
  break;
  }
  }
  public static TransactionEnvelope Decode(XdrDataInputStream stream) {
  TransactionEnvelope decodedTransactionEnvelope = new TransactionEnvelope();
  EnvelopeType discriminant = EnvelopeType.Decode(stream);
  decodedTransactionEnvelope.Discriminant = discriminant;
  switch (decodedTransactionEnvelope.Discriminant.InnerValue) {
  case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_TX_V0:
  decodedTransactionEnvelope.V0 = TransactionV0Envelope.Decode(stream);
  break;
  case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_TX:
  decodedTransactionEnvelope.V1 = TransactionV1Envelope.Decode(stream);
  break;
  case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_TX_FEE_BUMP:
  decodedTransactionEnvelope.FeeBump = FeeBumpTransactionEnvelope.Decode(stream);
  break;
  }
    return decodedTransactionEnvelope;
  }
}
}
