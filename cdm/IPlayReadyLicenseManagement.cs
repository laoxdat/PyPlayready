// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyLicenseManagement
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  [ExclusiveTo(typeof (PlayReadyLicenseManagement))]
  [Guid(901414425, 58717, 18322, 168, 114, 22, 125, 113, 158, 182, 223)]
  internal interface IPlayReadyLicenseManagement
  {
    IAsyncAction DeleteLicenses(PlayReadyContentHeader contentHeader);
  }
}
