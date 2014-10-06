using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace billproject
{
	public abstract class Bill<T>
	{
		public List<Article> Articles { get; set; }
		public int Id { get; protected set; }

		public abstract void PrintArticles();

		public abstract void CopyFrom(T bill);
		/*
		public static T operator +(T bill1, T bill2) {
			return bill1.Addition (bill2);
		}

		public static T operator -(T bill1, T bill2) {
			return bill1.Subtraction (bill2);
		}

		protected abstract T Addition (T bill);

		protected abstract T Subtraction (T bill);
		*/
	}
}

