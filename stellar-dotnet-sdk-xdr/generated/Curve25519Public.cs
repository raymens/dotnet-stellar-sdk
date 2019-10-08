// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  struct Curve25519Public
//  {
//          opaque key[32];
//  };

//  ===========================================================================
    public class Curve25519Public
    {
        public Curve25519Public()
        {
        }

        public byte[] Key { get; set; }

        public static void Encode(XdrDataOutputStream stream, Curve25519Public encodedCurve25519Public)
        {
            int keysize = encodedCurve25519Public.Key.Length;
            stream.Write(encodedCurve25519Public.Key, 0, keysize);
        }

        public static Curve25519Public Decode(XdrDataInputStream stream)
        {
            Curve25519Public decodedCurve25519Public = new Curve25519Public();
            int keysize = 32;
            decodedCurve25519Public.Key = new byte[keysize];
            stream.Read(decodedCurve25519Public.Key, 0, keysize);
            return decodedCurve25519Public;
        }
    }
}