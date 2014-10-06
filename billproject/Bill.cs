using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace billproject
{
	public class Bill
	{
		public List<Article> Articles { get; set; }
		public enum typeTaxes { FP, F, P, O };
		public int Id { get; private set; }
		public Bill()
		{
			int id = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(),""),"*", SearchOption.TopDirectoryOnly).Length;
			Id = id;
		}
		public abstract void PrintArticles();
		public abstract void CopyFrom(Bill bill);
		/*
        public static abstract Bill operator +(Bill bill1, Bill bill2);
        public static abstract Bill operator -(Bill bill1, Bill bill2);
        */
		public void solobg();
	}
}

