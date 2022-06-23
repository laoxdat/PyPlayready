// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyDomain
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  public sealed class PlayReadyDomain : IPlayReadyDomain
  {
    public extern Guid AccountId { [MethodImpl] get; }

    public extern Guid ServiceId { [MethodImpl] get; }

    public extern uint Revision { [MethodImpl] get; }

    public extern string FriendlyName { [MethodImpl] get; }

    public extern Uri DomainJoinUrl { [MethodImpl] get; }
  }
}
