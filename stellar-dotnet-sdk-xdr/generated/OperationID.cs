// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  union OperationID switch (EnvelopeType type)
//  {
//  case ENVELOPE_TYPE_OP_ID:
//      struct
//      {
//          MuxedAccount sourceAccount;
//          SequenceNumber seqNum;
//          uint32 opNum;
//      } id;
//  };
//  ===========================================================================
    public class OperationID
    {
        public OperationID()
        {
        }

        public EnvelopeType Discriminant { get; set; } = new EnvelopeType();

        public OperationIDId Id { get; set; }

        public static void Encode(XdrDataOutputStream stream, OperationID encodedOperationID)
        {
            stream.WriteInt((int) encodedOperationID.Discriminant.InnerValue);
            switch (encodedOperationID.Discriminant.InnerValue)
            {
                case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_OP_ID:
                    OperationIDId.Encode(stream, encodedOperationID.Id);
                    break;
            }
        }

        public static OperationID Decode(XdrDataInputStream stream)
        {
            OperationID decodedOperationID = new OperationID();
            EnvelopeType discriminant = EnvelopeType.Decode(stream);
            decodedOperationID.Discriminant = discriminant;
            switch (decodedOperationID.Discriminant.InnerValue)
            {
                case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_OP_ID:
                    decodedOperationID.Id = OperationIDId.Decode(stream);
                    break;
            }

            return decodedOperationID;
        }

        public class OperationIDId
        {
            public OperationIDId()
            {
            }

            public MuxedAccount SourceAccount { get; set; }
            public SequenceNumber SeqNum { get; set; }
            public Uint32 OpNum { get; set; }

            public static void Encode(XdrDataOutputStream stream, OperationIDId encodedOperationIDId)
            {
                MuxedAccount.Encode(stream, encodedOperationIDId.SourceAccount);
                SequenceNumber.Encode(stream, encodedOperationIDId.SeqNum);
                Uint32.Encode(stream, encodedOperationIDId.OpNum);
            }

            public static OperationIDId Decode(XdrDataInputStream stream)
            {
                OperationIDId decodedOperationIDId = new OperationIDId();
                decodedOperationIDId.SourceAccount = MuxedAccount.Decode(stream);
                decodedOperationIDId.SeqNum = SequenceNumber.Decode(stream);
                decodedOperationIDId.OpNum = Uint32.Decode(stream);
                return decodedOperationIDId;
            }
        }
    }
}