// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================
//  union SCPHistoryEntry switch (int v)
//  {
//  case 0:
//      SCPHistoryEntryV0 v0;
//  };
//  ===========================================================================
public class SCPHistoryEntry  {
  public SCPHistoryEntry () {}
  public int Discriminant { get; set; } = new int();
  public SCPHistoryEntryV0 V0 {get; set;}
  public static void Encode(XdrDataOutputStream stream, SCPHistoryEntry encodedSCPHistoryEntry) {
  stream.WriteInt((int)encodedSCPHistoryEntry.Discriminant);
  switch (encodedSCPHistoryEntry.Discriminant) {
  case 0:
  SCPHistoryEntryV0.Encode(stream, encodedSCPHistoryEntry.V0);
  break;
  }
  }
  public static SCPHistoryEntry Decode(XdrDataInputStream stream) {
  SCPHistoryEntry decodedSCPHistoryEntry = new SCPHistoryEntry();
  int discriminant =  stream.ReadInt();
  decodedSCPHistoryEntry.Discriminant = discriminant;
  switch (decodedSCPHistoryEntry.Discriminant) {
  case 0:
  decodedSCPHistoryEntry.V0 = SCPHistoryEntryV0.Decode(stream);
  break;
  }
    return decodedSCPHistoryEntry;
  }
}
}
