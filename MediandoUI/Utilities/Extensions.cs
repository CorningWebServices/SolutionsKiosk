using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Net.Http;

namespace MediandoUI
{
	public static class ImageSourceEx
	{
		private static readonly Dictionary<string, WeakReference<ImageSource>> ImageSourceWrCache = new Dictionary<string, WeakReference< ImageSource >>();

		public static ImageSource FromResource(string resource)
		{
			ImageSource imageSource;
			WeakReference<ImageSource> imageSourceWr;

			if (!ImageSourceWrCache.TryGetValue(resource, out imageSourceWr) ||
				!imageSourceWr.TryGetTarget(out imageSource))
			{
				var imgArrayLazyTask = new Lazy<Task<byte[]>>(
					async () =>
					{
						var assembly = typeof(ImageSourceEx).GetTypeInfo().Assembly;

						using (var inputStream = assembly.GetManifestResourceStream(resource))
						using (var outputStream = new MemoryStream())
						{
							await inputStream.CopyToAsync(outputStream);
							return outputStream.ToArray();
						}
					},
					isThreadSafe: true);

				imageSource = new StreamImageSource() { Stream = async _ => new MemoryStream(await imgArrayLazyTask.Value) };
				ImageSourceWrCache[resource] = new WeakReference<ImageSource>(imageSource);
			}

			return imageSource;
		}
	}
}
