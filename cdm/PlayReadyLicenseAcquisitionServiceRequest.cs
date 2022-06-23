// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyLicenseAcquisitionServiceRequest
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  [Activatable(100794368)]
  public sealed class PlayReadyLicenseAcquisitionServiceRequest : IPlayReadyLicenseAcquisitionServiceRequest, IPlayReadyServiceRequest, IMediaProtectionServiceRequest
  {
    [MethodImpl]
    public extern PlayReadyLicenseAcquisitionServiceRequest();

    public extern PlayReadyContentHeader ContentHeader { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid DomainServiceId { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    public extern string ResponseCustomData { [MethodImpl] get; }

    public extern string ChallengeCustomData { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncAction BeginServiceRequest();

    [MethodImpl]
    public extern IPlayReadyServiceRequest NextServiceRequest();

    [MethodImpl]
    public extern PlayReadySoapMessage GenerateManualEnablingChallenge();

    [MethodImpl]
    public extern HResult ProcessManualEnablingResponse([Range(0, 2147483647)] byte[] responseBytes);

    public extern Guid ProtectionSystem { [MethodImpl] get; }

    public extern Guid Type { [MethodImpl] get; }
  }
}
