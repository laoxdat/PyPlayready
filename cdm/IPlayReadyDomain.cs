// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyDomain
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Guid(2294396617, 7233, 16402, 186, 202, 45, 169, 176, 0, 193, 202)]
  [Version(100794368)]
  public interface IPlayReadyDomain
  {
    Guid AccountId { get; }

    Guid ServiceId { get; }

    uint Revision { get; }

    string FriendlyName { get; }

    Uri DomainJoinUrl { get; }
  }
}
