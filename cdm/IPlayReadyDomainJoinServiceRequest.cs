// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyDomainJoinServiceRequest
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;

namespace Microsoft.Media.PlayReadyClient
{
  [Guid(1107163316, 48148, 20464, 134, 127, 10, 239, 243, 168, 84, 237)]
  [ExclusiveTo(typeof (PlayReadyDomainJoinServiceRequest))]
  [Version(100794368)]
  internal interface IPlayReadyDomainJoinServiceRequest : IPlayReadyServiceRequest, IMediaProtectionServiceRequest
  {
    Guid DomainAccountId { get; set; }

    string DomainFriendlyName { get; set; }

    Guid DomainServiceId { get; set; }
  }
}
