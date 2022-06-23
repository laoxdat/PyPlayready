// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyDomainIterable
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  [Activatable(typeof (IPlayReadyDomainIterableFactory), 100794368)]
  public sealed class PlayReadyDomainIterable : IIterable<IPlayReadyDomain>
  {
    [MethodImpl]
    public extern PlayReadyDomainIterable(Guid domainAccountId);

    [MethodImpl]
    public extern IIterator<IPlayReadyDomain> First();
  }
}
