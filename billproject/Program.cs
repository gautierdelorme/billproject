using System;
using System.Collections.Generic;
using System.Linq;

namespace billproject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			SchoolBill sb = new SchoolBill ();
			sb.AddArticle (sb.CreateArticle("yo",4,23.90,Article.typeTaxes.FP));
			sb.AddArticle (sb.CreateArticle("yo",16,23.90,Article.typeTaxes.FP));
			sb.AddArticle (sb.CreateArticle("aight",67,3.90,Article.typeTaxes.FP));
			sb.PrintArticles ();
			SchoolBill sb2 = new SchoolBill ();
			sb2.AddArticle (sb.CreateArticle("yo",3,23.90,Article.typeTaxes.FP));
			sb2.AddArticle (sb.CreateArticle("aight",1,23.90,Article.typeTaxes.FP));
			sb2.AddArticle (sb.CreateArticle("wtf",32,300.90,Article.typeTaxes.FP));
			sb2.PrintArticles ();

			SchoolBill sb3 = new SchoolBill ();
			sb3 = sb + sb2;
			sb3.PrintArticles ();
		}
	}
}
