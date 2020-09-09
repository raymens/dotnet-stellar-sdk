// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  union PathPaymentStrictReceiveResult switch (PathPaymentStrictReceiveResultCode code)
//  {
//  case PATH_PAYMENT_STRICT_RECEIVE_SUCCESS:
//      struct
//      {
//          ClaimOfferAtom offers<>;
//          SimplePaymentResult last;
//      } success;
//  case PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER:
//      Asset noIssuer; // the asset that caused the error
//  default:
//      void;
//  };
//  ===========================================================================
    public class PathPaymentStrictReceiveResult
    {
        public PathPaymentStrictReceiveResult()
        {
        }

        public PathPaymentStrictReceiveResultCode Discriminant { get; set; } = new PathPaymentStrictReceiveResultCode();

        public PathPaymentStrictReceiveResultSuccess Success { get; set; }
        public Asset NoIssuer { get; set; }

        public static void Encode(XdrDataOutputStream stream,
            PathPaymentStrictReceiveResult encodedPathPaymentStrictReceiveResult)
        {
            stream.WriteInt((int) encodedPathPaymentStrictReceiveResult.Discriminant.InnerValue);
            switch (encodedPathPaymentStrictReceiveResult.Discriminant.InnerValue)
            {
                case PathPaymentStrictReceiveResultCode.PathPaymentStrictReceiveResultCodeEnum
                    .PATH_PAYMENT_STRICT_RECEIVE_SUCCESS:
                    PathPaymentStrictReceiveResultSuccess.Encode(stream, encodedPathPaymentStrictReceiveResult.Success);
                    break;
                case PathPaymentStrictReceiveResultCode.PathPaymentStrictReceiveResultCodeEnum
                    .PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER:
                    Asset.Encode(stream, encodedPathPaymentStrictReceiveResult.NoIssuer);
                    break;
                default:
                    break;
            }
        }

        public static PathPaymentStrictReceiveResult Decode(XdrDataInputStream stream)
        {
            PathPaymentStrictReceiveResult decodedPathPaymentStrictReceiveResult = new PathPaymentStrictReceiveResult();
            PathPaymentStrictReceiveResultCode discriminant = PathPaymentStrictReceiveResultCode.Decode(stream);
            decodedPathPaymentStrictReceiveResult.Discriminant = discriminant;
            switch (decodedPathPaymentStrictReceiveResult.Discriminant.InnerValue)
            {
                case PathPaymentStrictReceiveResultCode.PathPaymentStrictReceiveResultCodeEnum
                    .PATH_PAYMENT_STRICT_RECEIVE_SUCCESS:
                    decodedPathPaymentStrictReceiveResult.Success =
                        PathPaymentStrictReceiveResultSuccess.Decode(stream);
                    break;
                case PathPaymentStrictReceiveResultCode.PathPaymentStrictReceiveResultCodeEnum
                    .PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER:
                    decodedPathPaymentStrictReceiveResult.NoIssuer = Asset.Decode(stream);
                    break;
                default:
                    break;
            }

            return decodedPathPaymentStrictReceiveResult;
        }

        public class PathPaymentStrictReceiveResultSuccess
        {
            public PathPaymentStrictReceiveResultSuccess()
            {
            }

            public ClaimOfferAtom[] Offers { get; set; }
            public SimplePaymentResult Last { get; set; }

            public static void Encode(XdrDataOutputStream stream,
                PathPaymentStrictReceiveResultSuccess encodedPathPaymentStrictReceiveResultSuccess)
            {
                int offerssize = encodedPathPaymentStrictReceiveResultSuccess.Offers.Length;
                stream.WriteInt(offerssize);
                for (int i = 0; i < offerssize; i++)
                {
                    ClaimOfferAtom.Encode(stream, encodedPathPaymentStrictReceiveResultSuccess.Offers[i]);
                }

                SimplePaymentResult.Encode(stream, encodedPathPaymentStrictReceiveResultSuccess.Last);
            }

            public static PathPaymentStrictReceiveResultSuccess Decode(XdrDataInputStream stream)
            {
                PathPaymentStrictReceiveResultSuccess decodedPathPaymentStrictReceiveResultSuccess =
                    new PathPaymentStrictReceiveResultSuccess();
                int offerssize = stream.ReadInt();
                decodedPathPaymentStrictReceiveResultSuccess.Offers = new ClaimOfferAtom[offerssize];
                for (int i = 0; i < offerssize; i++)
                {
                    decodedPathPaymentStrictReceiveResultSuccess.Offers[i] = ClaimOfferAtom.Decode(stream);
                }

                decodedPathPaymentStrictReceiveResultSuccess.Last = SimplePaymentResult.Decode(stream);
                return decodedPathPaymentStrictReceiveResultSuccess;
            }
        }
    }
}