// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadySoapMessage
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  [Guid(660576364, 55993, 17416, 150, 217, 193, 2, 74, 218, 213, 201)]
  [ExclusiveTo(typeof (PlayReadySoapMessage))]
  internal interface IPlayReadySoapMessage
  {
    byte[] GetMessageBody();

    IPropertySet MessageHeaders { get; }

    Uri Uri { get; }
  }
}
