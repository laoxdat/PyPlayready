// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyDomainIterableFactory
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  [ExclusiveTo(typeof (PlayReadyDomainIterable))]
  [Guid(2151941048, 3316, 20330, 131, 195, 82, 165, 123, 154, 154, 151)]
  internal interface IPlayReadyDomainIterableFactory
  {
    PlayReadyDomainIterable CreateInstance(Guid domainAccountId);
  }
}
