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

			Article art = new Article ("yolo", 4, 1, Article.typeTaxes.FP);
			sb.AddArticle (art);
			sb.PrintArticles ();
			sb.RemoveArticle (art);
			sb.PrintArticles ();
		}
	}
}
