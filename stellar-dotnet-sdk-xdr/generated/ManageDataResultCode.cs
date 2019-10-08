// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  enum ManageDataResultCode
//  {
//      // codes considered as "success" for the operation
//      MANAGE_DATA_SUCCESS = 0,
//      // codes considered as "failure" for the operation
//      MANAGE_DATA_NOT_SUPPORTED_YET =
//          -1, // The network hasn't moved to this protocol change yet
//      MANAGE_DATA_NAME_NOT_FOUND =
//          -2, // Trying to remove a Data Entry that isn't there
//      MANAGE_DATA_LOW_RESERVE = -3, // not enough funds to create a new Data Entry
//      MANAGE_DATA_INVALID_NAME = -4 // Name not a valid string
//  };

//  ===========================================================================
    public class ManageDataResultCode
    {
        public enum ManageDataResultCodeEnum
        {
            MANAGE_DATA_SUCCESS = 0,
            MANAGE_DATA_NOT_SUPPORTED_YET = -1,
            MANAGE_DATA_NAME_NOT_FOUND = -2,
            MANAGE_DATA_LOW_RESERVE = -3,
            MANAGE_DATA_INVALID_NAME = -4,
        }

        public ManageDataResultCodeEnum InnerValue { get; set; } = default(ManageDataResultCodeEnum);

        public static ManageDataResultCode Create(ManageDataResultCodeEnum v)
        {
            return new ManageDataResultCode
            {
                InnerValue = v
            };
        }

        public static ManageDataResultCode Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(ManageDataResultCodeEnum.MANAGE_DATA_SUCCESS);
                case -1: return Create(ManageDataResultCodeEnum.MANAGE_DATA_NOT_SUPPORTED_YET);
                case -2: return Create(ManageDataResultCodeEnum.MANAGE_DATA_NAME_NOT_FOUND);
                case -3: return Create(ManageDataResultCodeEnum.MANAGE_DATA_LOW_RESERVE);
                case -4: return Create(ManageDataResultCodeEnum.MANAGE_DATA_INVALID_NAME);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, ManageDataResultCode value)
        {
            stream.WriteInt((int) value.InnerValue);
        }
    }
}