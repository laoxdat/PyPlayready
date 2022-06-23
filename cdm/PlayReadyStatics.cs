// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyStatics
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Static(typeof (IPlayReadyStatics), 100794368)]
  [Version(100794368)]
  public static class PlayReadyStatics
  {
    public static extern Guid DomainJoinServiceRequestType { [MethodImpl] get; }

    public static extern Guid DomainLeaveServiceRequestType { [MethodImpl] get; }

    public static extern Guid IndividualizationServiceRequestType { [MethodImpl] get; }

    public static extern Guid LicenseAcquirerServiceRequestType { [MethodImpl] get; }

    public static extern Guid MeteringReportServiceRequestType { [MethodImpl] get; }

    public static extern Guid RevocationServiceRequestType { [MethodImpl] get; }

    public static extern Guid MediaProtectionSystemId { [MethodImpl] get; }

    public static extern uint PlayReadySecurityVersion { [MethodImpl] get; }
  }
}
