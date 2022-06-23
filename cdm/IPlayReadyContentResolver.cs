// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyContentResolver
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [ExclusiveTo(typeof (PlayReadyContentResolver))]
  [Guid(1858541012, 2216, 20439, 170, 141, 12, 87, 50, 107, 4, 176)]
  [Version(100794368)]
  internal interface IPlayReadyContentResolver
  {
    IPlayReadyServiceRequest ServiceRequest(
      PlayReadyContentHeader contentHeader);
  }
}
