using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace billproject
{
	public abstract class Bill
	{
		public List<Article> Articles { get; set; }
		public int Id { get; set; }

        public string Name { get; set; }

		public abstract void PrintArticles();

		public abstract void CopyFrom(Bill bill);

		public static Bill operator +(Bill bill1, Bill bill2) {
			return bill1.Addition (bill2);
		}

		public static Bill operator -(Bill bill1, Bill bill2) {
			return bill1.Subtraction (bill2);
		}

		protected abstract Bill Addition (Bill bill);

		protected abstract Bill Subtraction (Bill bill);
	}
}

