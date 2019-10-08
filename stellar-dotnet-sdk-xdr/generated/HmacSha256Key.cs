// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  struct HmacSha256Key
//  {
//          opaque key[32];
//  };

//  ===========================================================================
    public class HmacSha256Key
    {
        public HmacSha256Key()
        {
        }

        public byte[] Key { get; set; }

        public static void Encode(XdrDataOutputStream stream, HmacSha256Key encodedHmacSha256Key)
        {
            int keysize = encodedHmacSha256Key.Key.Length;
            stream.Write(encodedHmacSha256Key.Key, 0, keysize);
        }

        public static HmacSha256Key Decode(XdrDataInputStream stream)
        {
            HmacSha256Key decodedHmacSha256Key = new HmacSha256Key();
            int keysize = 32;
            decodedHmacSha256Key.Key = new byte[keysize];
            stream.Read(decodedHmacSha256Key.Key, 0, keysize);
            return decodedHmacSha256Key;
        }
    }
}