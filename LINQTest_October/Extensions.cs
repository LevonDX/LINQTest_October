using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest_October
{
	public static class Extensions
	{
		/// <summary>
		/// Returns first element that satisfies the specific condition
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <returns></returns>
		public static T _First<T>(this IEnumerable<T> list, Predicate<T> condition)
		{
			foreach (T item in list)
			{
				if (condition(item))
					return item;
			}

			throw new InvalidOperationException();
		}

		public static T? _FirstOrDefault<T>(this IEnumerable<T> list, Predicate<T> condition)
		{
			foreach (T item in list)
			{
				if (condition(item))
					return item;
			}

			return default(T);
		}

		public static IEnumerable<T> _Where<T>(this IEnumerable<T> list, Predicate<T> condition)
		{
			foreach (T item in list)
			{
				if(condition(item))
					yield return item;
			}
		}

		public static IEnumerable<T> _SkipWhile<T>(this IEnumerable<T> list, Predicate<T> condition)
		{
			bool skipping = true;
			foreach (T item in list)
			{
				if (skipping && !condition(item))
				{
					skipping = false;
					continue;
				}

				if (!skipping)
				{
					yield return item;
				}
			}
		}
	}
}