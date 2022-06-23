// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.IPlayReadyContentHeaderFactory
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Version(100794368)]
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  [Guid(2112373134, 61421, 20186, 171, 24, 154, 229, 191, 0, 160, 105)]
  internal interface IPlayReadyContentHeaderFactory
  {
    PlayReadyContentHeader CreateInstanceFromWindowsMediaDrmHeader(
      [Range(0, 2147483647)] byte[] headerBytes,
      Uri licenseAcquisitionUrl,
      Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    PlayReadyContentHeader CreateInstanceFromComponents(
      Guid contentKeyId,
      string contentKeyIdString,
      PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm,
      Uri licenseAcquisitionUrl,
      Uri licenseAcquisitionUserInterfaceUrl,
      string customAttributes,
      Guid domainServiceId);

    PlayReadyContentHeader CreateInstanceFromPlayReadyHeader(
      [Range(0, 2147483647)] byte[] headerBytes);
  }
}
