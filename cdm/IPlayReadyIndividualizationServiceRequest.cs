// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyIndividualizationServiceRequest
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation.Metadata;
using Windows.Media.Protection;

namespace Microsoft.Media.PlayReadyClient
{
  [Guid(1313427317, 1056, 16660, 190, 34, 152, 230, 12, 173, 77, 70)]
  [ExclusiveTo(typeof (PlayReadyIndividualizationServiceRequest))]
  [Version(100794368)]
  internal interface IPlayReadyIndividualizationServiceRequest : IPlayReadyServiceRequest, IMediaProtectionServiceRequest
  {
  }
}
