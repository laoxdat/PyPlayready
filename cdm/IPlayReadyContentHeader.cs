// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyContentHeader
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  [Guid(1475622580, 40002, 18745, 184, 221, 111, 173, 30, 146, 177, 115)]
  [Version(100794368)]
  internal interface IPlayReadyContentHeader
  {
    Guid KeyId { get; }

    string KeyIdString { get; }

    Uri LicenseAcquisitionUrl { get; }

    Uri LicenseAcquisitionUserInterfaceUrl { get; }

    Guid DomainServiceId { get; }

    PlayReadyEncryptionAlgorithm EncryptionType { get; }

    string CustomAttributes { get; }

    PlayReadyDecryptorSetup DecryptorSetup { get; }

    byte[] GetSerializedHeader();

    PlayReadyContentHeader HeaderWithEmbeddedUpdates { get; }
  }
}
