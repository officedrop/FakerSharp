using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace InfWeb.FakerSharp
{
	public static class IEnumerableExtension
	{
		public static object Pick(this IEnumerable collection)
		{
			return Pick<object>(collection.Cast<object>());
		}

		public static TResult Pick<TResult>(this IEnumerable<TResult> collection)
		{
			int idx = new Random().Next(collection.Count());
			return collection.ElementAt(idx);
		}
	}
}
