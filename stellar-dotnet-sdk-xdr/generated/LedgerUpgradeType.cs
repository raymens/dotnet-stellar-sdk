// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  enum LedgerUpgradeType
//  {
//      LEDGER_UPGRADE_VERSION = 1,
//      LEDGER_UPGRADE_BASE_FEE = 2,
//      LEDGER_UPGRADE_MAX_TX_SET_SIZE = 3,
//      LEDGER_UPGRADE_BASE_RESERVE = 4
//  };

//  ===========================================================================
    public class LedgerUpgradeType
    {
        public enum LedgerUpgradeTypeEnum
        {
            LEDGER_UPGRADE_VERSION = 1,
            LEDGER_UPGRADE_BASE_FEE = 2,
            LEDGER_UPGRADE_MAX_TX_SET_SIZE = 3,
            LEDGER_UPGRADE_BASE_RESERVE = 4,
        }

        public LedgerUpgradeTypeEnum InnerValue { get; set; } = default(LedgerUpgradeTypeEnum);

        public static LedgerUpgradeType Create(LedgerUpgradeTypeEnum v)
        {
            return new LedgerUpgradeType
            {
                InnerValue = v
            };
        }

        public static LedgerUpgradeType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 1: return Create(LedgerUpgradeTypeEnum.LEDGER_UPGRADE_VERSION);
                case 2: return Create(LedgerUpgradeTypeEnum.LEDGER_UPGRADE_BASE_FEE);
                case 3: return Create(LedgerUpgradeTypeEnum.LEDGER_UPGRADE_MAX_TX_SET_SIZE);
                case 4: return Create(LedgerUpgradeTypeEnum.LEDGER_UPGRADE_BASE_RESERVE);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, LedgerUpgradeType value)
        {
            stream.WriteInt((int) value.InnerValue);
        }
    }
}