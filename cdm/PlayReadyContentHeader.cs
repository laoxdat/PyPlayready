// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyContentHeader
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
  [Activatable(typeof (IPlayReadyContentHeaderFactory), 100794368)]
  public sealed class PlayReadyContentHeader : IPlayReadyContentHeader
  {
    [MethodImpl]
    public extern PlayReadyContentHeader(
      [Range(0, 2147483647)] byte[] headerBytes,
      Uri licenseAcquisitionUrl,
      Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    [MethodImpl]
    public extern PlayReadyContentHeader(
      Guid contentKeyId,
      string contentKeyIdString,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      Uri licenseAcquisitionUrl,
      Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    [MethodImpl]
    public extern PlayReadyContentHeader([Range(0, 2147483647)] byte[] headerBytes);

    public extern Guid KeyId { [MethodImpl] get; }

    public extern string KeyIdString { [MethodImpl] get; }

    public extern Uri LicenseAcquisitionUrl { [MethodImpl] get; }

    public extern Uri LicenseAcquisitionUserInterfaceUrl { [MethodImpl] get; }

    public extern Guid DomainServiceId { [MethodImpl] get; }

    public extern PlayReadyEncryptionAlgorithm EncryptionType { [MethodImpl] get; }

    public extern string CustomAttributes { [MethodImpl] get; }

    public extern PlayReadyDecryptorSetup DecryptorSetup { [MethodImpl] get; }

    [MethodImpl]
    public extern byte[] GetSerializedHeader();

    public extern PlayReadyContentHeader HeaderWithEmbeddedUpdates { [MethodImpl] get; }
  }
}
