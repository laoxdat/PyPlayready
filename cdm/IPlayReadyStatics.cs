// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyStatics
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [ExclusiveTo(typeof (PlayReadyStatics))]
  [Guid(107578166, 38634, 16912, 180, 249, 26, 200, 38, 102, 150, 1)]
  [Version(100794368)]
  internal interface IPlayReadyStatics
  {
    Guid DomainJoinServiceRequestType { get; }

    Guid DomainLeaveServiceRequestType { get; }

    Guid IndividualizationServiceRequestType { get; }

    Guid LicenseAcquirerServiceRequestType { get; }

    Guid MeteringReportServiceRequestType { get; }

    Guid RevocationServiceRequestType { get; }

    Guid MediaProtectionSystemId { get; }

    uint PlayReadySecurityVersion { get; }
  }
}
