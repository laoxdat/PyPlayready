// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyLicense
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Guid(2583241507, 19297, 17141, 129, 81, 25, 35, 118, 54, 144, 242)]
  [Version(100794368)]
  public interface IPlayReadyLicense
  {
    bool FullyEvaluated { get; }

    bool UsableForPlay { get; }

    IReference<DateTime> ExpirationDate { get; }

    uint ExpireAfterFirstPlay { get; }

    Guid DomainAccountID { get; }

    uint ChainDepth { get; }

    Guid GetKIDAtChainDepth(uint chainDepth);
  }
}
