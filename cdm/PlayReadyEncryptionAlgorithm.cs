// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyEncryptionAlgorithm
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  public enum PlayReadyEncryptionAlgorithm
  {
    Unprotected = 0,
    Aes128Ctr = 1,
    Cocktail = 4,
    Uninitialized = 2147483647, // 0x7FFFFFFF
  }
}
