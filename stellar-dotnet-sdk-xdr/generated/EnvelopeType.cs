// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  enum EnvelopeType
//  {
//      ENVELOPE_TYPE_TX_V0 = 0,
//      ENVELOPE_TYPE_SCP = 1,
//      ENVELOPE_TYPE_TX = 2,
//      ENVELOPE_TYPE_AUTH = 3,
//      ENVELOPE_TYPE_SCPVALUE = 4,
//      ENVELOPE_TYPE_TX_FEE_BUMP = 5,
//      ENVELOPE_TYPE_OP_ID = 6
//  };
//  ===========================================================================
public class EnvelopeType  {
  public enum EnvelopeTypeEnum {
  ENVELOPE_TYPE_TX_V0 = 0,
  ENVELOPE_TYPE_SCP = 1,
  ENVELOPE_TYPE_TX = 2,
  ENVELOPE_TYPE_AUTH = 3,
  ENVELOPE_TYPE_SCPVALUE = 4,
  ENVELOPE_TYPE_TX_FEE_BUMP = 5,
  ENVELOPE_TYPE_OP_ID = 6,
  }
  public EnvelopeTypeEnum InnerValue {get; set;} = default(EnvelopeTypeEnum);
  public static EnvelopeType Create(EnvelopeTypeEnum v)
  {
    return new EnvelopeType {
      InnerValue = v
    };
  }
  public static EnvelopeType Decode(XdrDataInputStream stream) {
    int value = stream.ReadInt();
    switch (value) {
      case 0: return Create(EnvelopeTypeEnum.ENVELOPE_TYPE_TX_V0);
      case 1: return Create(EnvelopeTypeEnum.ENVELOPE_TYPE_SCP);
      case 2: return Create(EnvelopeTypeEnum.ENVELOPE_TYPE_TX);
      case 3: return Create(EnvelopeTypeEnum.ENVELOPE_TYPE_AUTH);
      case 4: return Create(EnvelopeTypeEnum.ENVELOPE_TYPE_SCPVALUE);
      case 5: return Create(EnvelopeTypeEnum.ENVELOPE_TYPE_TX_FEE_BUMP);
      case 6: return Create(EnvelopeTypeEnum.ENVELOPE_TYPE_OP_ID);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }
  public static void Encode(XdrDataOutputStream stream, EnvelopeType value) {
    stream.WriteInt((int)value.InnerValue);
  }
}
}
