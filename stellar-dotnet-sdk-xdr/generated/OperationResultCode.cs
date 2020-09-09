// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  enum OperationResultCode
//  {
//      opINNER = 0, // inner object result is valid
//  
//      opBAD_AUTH = -1,            // too few valid signatures / wrong network
//      opNO_ACCOUNT = -2,          // source account was not found
//      opNOT_SUPPORTED = -3,       // operation not supported at this time
//      opTOO_MANY_SUBENTRIES = -4, // max number of subentries already reached
//      opEXCEEDED_WORK_LIMIT = -5, // operation did too much work
//      opTOO_MANY_SPONSORING = -6  // account is sponsoring too many entries
//  };
//  ===========================================================================
    public class OperationResultCode
    {
        public enum OperationResultCodeEnum
        {
            opINNER = 0,
            opBAD_AUTH = -1,
            opNO_ACCOUNT = -2,
            opNOT_SUPPORTED = -3,
            opTOO_MANY_SUBENTRIES = -4,
            opEXCEEDED_WORK_LIMIT = -5,
            opTOO_MANY_SPONSORING = -6,
        }

        public OperationResultCodeEnum InnerValue { get; set; } = default(OperationResultCodeEnum);

        public static OperationResultCode Create(OperationResultCodeEnum v)
        {
            return new OperationResultCode
            {
                InnerValue = v
            };
        }

        public static OperationResultCode Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(OperationResultCodeEnum.opINNER);
                case -1: return Create(OperationResultCodeEnum.opBAD_AUTH);
                case -2: return Create(OperationResultCodeEnum.opNO_ACCOUNT);
                case -3: return Create(OperationResultCodeEnum.opNOT_SUPPORTED);
                case -4: return Create(OperationResultCodeEnum.opTOO_MANY_SUBENTRIES);
                case -5: return Create(OperationResultCodeEnum.opEXCEEDED_WORK_LIMIT);
                case -6: return Create(OperationResultCodeEnum.opTOO_MANY_SPONSORING);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, OperationResultCode value)
        {
            stream.WriteInt((int) value.InnerValue);
        }
    }
}