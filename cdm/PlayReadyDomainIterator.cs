// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyDomainIterator
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  public sealed class PlayReadyDomainIterator : IIterator<IPlayReadyDomain>
  {
    public extern IPlayReadyDomain Current { [MethodImpl] get; }

    public extern bool HasCurrent { [MethodImpl] get; }

    [MethodImpl]
    public extern bool MoveNext();

    [MethodImpl]
    public extern uint GetMany([Out] IPlayReadyDomain[] items);
  }
}
