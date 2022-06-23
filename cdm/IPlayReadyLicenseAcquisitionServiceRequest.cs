// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyLicenseAcquisitionServiceRequest
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;

namespace Microsoft.Media.PlayReadyClient
{
  [Guid(719716231, 21132, 19426, 183, 78, 255, 42, 140, 12, 3, 11)]
  [Version(100794368)]
  [ExclusiveTo(typeof (PlayReadyLicenseAcquisitionServiceRequest))]
  internal interface IPlayReadyLicenseAcquisitionServiceRequest : IPlayReadyServiceRequest, IMediaProtectionServiceRequest
  {
    PlayReadyContentHeader ContentHeader { get; set; }

    Guid DomainServiceId { get; set; }
  }
}
