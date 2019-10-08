// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  union ManageDataResult switch (ManageDataResultCode code)
//  {
//  case MANAGE_DATA_SUCCESS:
//      void;
//  default:
//      void;
//  };

//  ===========================================================================
    public class ManageDataResult
    {
        public ManageDataResult()
        {
        }

        public ManageDataResultCode Discriminant { get; set; } = new ManageDataResultCode();

        public static void Encode(XdrDataOutputStream stream, ManageDataResult encodedManageDataResult)
        {
            stream.WriteInt((int) encodedManageDataResult.Discriminant.InnerValue);
            switch (encodedManageDataResult.Discriminant.InnerValue)
            {
                case ManageDataResultCode.ManageDataResultCodeEnum.MANAGE_DATA_SUCCESS:
                    break;
                default:
                    break;
            }
        }

        public static ManageDataResult Decode(XdrDataInputStream stream)
        {
            ManageDataResult decodedManageDataResult = new ManageDataResult();
            ManageDataResultCode discriminant = ManageDataResultCode.Decode(stream);
            decodedManageDataResult.Discriminant = discriminant;
            switch (decodedManageDataResult.Discriminant.InnerValue)
            {
                case ManageDataResultCode.ManageDataResultCodeEnum.MANAGE_DATA_SUCCESS:
                    break;
                default:
                    break;
            }

            return decodedManageDataResult;
        }
    }
}