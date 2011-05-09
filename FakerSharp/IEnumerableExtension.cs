using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FakerSharp
{
	public static class IEnumerableExtension
	{
		private static Random random = new Random((int)DateTime.Now.Ticks);
		public static object Pick(this IEnumerable collection)
		{
			return Pick<object>(collection.Cast<object>());
		}

		public static TResult Pick<TResult>(this IEnumerable<TResult> collection)
		{
			int idx = random.Next(collection.Count());
			return collection.ElementAt(idx);
		}
	}
}
