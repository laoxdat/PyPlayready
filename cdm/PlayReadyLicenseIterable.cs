// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyLicenseIterable
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  [Activatable(typeof (IPlayReadyLicenseIterableFactory), 100794368)]
  public sealed class PlayReadyLicenseIterable : IIterable<IPlayReadyLicense>
  {
    [MethodImpl]
    public extern PlayReadyLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);

    [MethodImpl]
    public extern IIterator<IPlayReadyLicense> First();
  }
}
