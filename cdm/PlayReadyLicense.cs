// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyLicense
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  public sealed class PlayReadyLicense : IPlayReadyLicense
  {
    public extern bool FullyEvaluated { [MethodImpl] get; }

    public extern bool UsableForPlay { [MethodImpl] get; }

    public extern IReference<DateTime> ExpirationDate { [MethodImpl] get; }

    public extern uint ExpireAfterFirstPlay { [MethodImpl] get; }

    public extern Guid DomainAccountID { [MethodImpl] get; }

    public extern uint ChainDepth { [MethodImpl] get; }

    [MethodImpl]
    public extern Guid GetKIDAtChainDepth(uint chainDepth);
  }
}
