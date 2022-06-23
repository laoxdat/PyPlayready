// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyDomainLeaveServiceRequest
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  [Guid(3665716931, 58134, 16961, 139, 49, 10, 180, 1, 209, 48, 236)]
  [ExclusiveTo(typeof (PlayReadyDomainLeaveServiceRequest))]
  internal interface IPlayReadyDomainLeaveServiceRequest : IPlayReadyServiceRequest, IMediaProtectionServiceRequest
  {
    Guid DomainAccountId { get; set; }

    Guid DomainServiceId { get; set; }
  }
}
