// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyServiceRequest
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;

namespace Microsoft.Media.PlayReadyClient
{
  [Guid(2785796737, 56444, 18539, 137, 220, 169, 137, 214, 6, 233, 97)]
  [Version(100794368)]
  public interface IPlayReadyServiceRequest : IMediaProtectionServiceRequest
  {
    Uri Uri { get; set; }

    string ResponseCustomData { get; }

    string ChallengeCustomData { get; set; }

    IAsyncAction BeginServiceRequest();

    IPlayReadyServiceRequest NextServiceRequest();

    PlayReadySoapMessage GenerateManualEnablingChallenge();

    HResult ProcessManualEnablingResponse([Range(0, 2147483647)] byte[] responseBytes);
  }
}
