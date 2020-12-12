// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  enum ThresholdIndexes
//  {
//      THRESHOLD_MASTER_WEIGHT = 0,
//      THRESHOLD_LOW = 1,
//      THRESHOLD_MED = 2,
//      THRESHOLD_HIGH = 3
//  };
//  ===========================================================================
public class ThresholdIndexes  {
  public enum ThresholdIndexesEnum {
  THRESHOLD_MASTER_WEIGHT = 0,
  THRESHOLD_LOW = 1,
  THRESHOLD_MED = 2,
  THRESHOLD_HIGH = 3,
  }
  public ThresholdIndexesEnum InnerValue {get; set;} = default(ThresholdIndexesEnum);
  public static ThresholdIndexes Create(ThresholdIndexesEnum v)
  {
    return new ThresholdIndexes {
      InnerValue = v
    };
  }
  public static ThresholdIndexes Decode(XdrDataInputStream stream) {
    int value = stream.ReadInt();
    switch (value) {
      case 0: return Create(ThresholdIndexesEnum.THRESHOLD_MASTER_WEIGHT);
      case 1: return Create(ThresholdIndexesEnum.THRESHOLD_LOW);
      case 2: return Create(ThresholdIndexesEnum.THRESHOLD_MED);
      case 3: return Create(ThresholdIndexesEnum.THRESHOLD_HIGH);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }
  public static void Encode(XdrDataOutputStream stream, ThresholdIndexes value) {
    stream.WriteInt((int)value.InnerValue);
  }
}
}
