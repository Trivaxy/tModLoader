﻿using Microsoft.Xna.Framework.Audio;
using ReLogic.Content;
using ReLogic.Content.Readers;
using System;
using System.IO;

namespace Terraria.ModLoader.Assets
{
	public class WavReader : IAssetReader, IDisposable
	{
		public T FromStream<T>(Stream stream) where T : class {
			if (typeof(T) != typeof(SoundEffect))
				throw AssetLoadException.FromInvalidReader<WavReader, T>();

			//if (!stream.CanSeek)
			//	stream = new MemoryStream(stream.ReadBytes(stream.Length));

			return SoundEffect.FromStream(stream) as T;
		}

		public void Dispose() {

		}

		public Type[] GetAssociatedTypes() => new[] { typeof(SoundEffect) };
	}
}
