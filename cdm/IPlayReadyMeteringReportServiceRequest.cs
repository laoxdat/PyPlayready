// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyMeteringReportServiceRequest
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation.Metadata;
using Windows.Media.Protection;

namespace Microsoft.Media.PlayReadyClient
{
  [ExclusiveTo(typeof (PlayReadyMeteringReportServiceRequest))]
  [Guid(1366835629, 57485, 16591, 151, 123, 31, 52, 47, 237, 239, 35)]
  [Version(100794368)]
  internal interface IPlayReadyMeteringReportServiceRequest : IPlayReadyServiceRequest, IMediaProtectionServiceRequest
  {
    byte[] MeteringCertificate { get; [param: Range(0, 2147483647)] set; }
  }
}
