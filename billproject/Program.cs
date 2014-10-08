using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace billproject
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			SchoolBill sb = new SchoolBill (true);
			sb.CreateArticle("yo",4,23.90,Article.typeTaxes.FP);
			sb.CreateArticle("yo",16,23.90,Article.typeTaxes.FP);
			sb.CreateArticle("aight",67,3.90,Article.typeTaxes.F);

            SchoolBill sb2 = new SchoolBill(true);
            sb.CreateArticle("yoy", 4, 2.90, Article.typeTaxes.P);
            sb.CreateArticle("yo", 10, 23.90, Article.typeTaxes.FP);
            sb.CreateArticle("aightttt", 67, 333.90, Article.typeTaxes.F);

            SchoolBill sb3 = new SchoolBill(false);
            sb3 = (SchoolBill) ((Bill)sb2+(Bill)sb);

			sb3.PrintArticles ();
		}
	}
}
