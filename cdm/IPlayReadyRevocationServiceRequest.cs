// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyRevocationServiceRequest
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation.Metadata;
using Windows.Media.Protection;

namespace Microsoft.Media.PlayReadyClient
{
  [ExclusiveTo(typeof (PlayReadyRevocationServiceRequest))]
  [Version(100794368)]
  [Guid(334679652, 22608, 17242, 187, 7, 23, 170, 177, 243, 98, 98)]
  internal interface IPlayReadyRevocationServiceRequest : IPlayReadyServiceRequest, IMediaProtectionServiceRequest
  {
  }
}
