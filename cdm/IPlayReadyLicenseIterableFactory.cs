// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyLicenseIterableFactory
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Guid(4070476214, 34305, 19735, 152, 210, 125, 172, 70, 8, 163, 161)]
  [ExclusiveTo(typeof (PlayReadyLicenseIterable))]
  [Version(100794368)]
  internal interface IPlayReadyLicenseIterableFactory
  {
    PlayReadyLicenseIterable CreateInstance(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);
  }
}
