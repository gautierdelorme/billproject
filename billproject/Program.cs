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
			/*
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
			*/
			//Test de Json
			Article product = new Article("yo",12,600,Article.typeTaxes.FP);
			Article product2 = new Article ("yo", 12, 600, Article.typeTaxes.FP);
			List<Article> listArt = new List<Article> ();
			listArt.Add (product);
			listArt.Add (product2);

			//string json = JsonConvert.SerializeObject (listArt);

			// serialize JSON directly to a file
			using (StreamWriter file = File.CreateText(Path.Combine (Directory.GetCurrentDirectory (), "solo.txt")))
				{
				    JsonSerializer serializer = new JsonSerializer();
				serializer.Serialize(file, listArt);
				}

			// deserialize JSON directly from a file
			List<Article> movie2 = new List<Article> ();
			using (StreamReader file = File.OpenText(Path.Combine (Directory.GetCurrentDirectory (), "solo.txt")))
				{
				    JsonSerializer serializer = new JsonSerializer();
				movie2 = (List<Article>)serializer.Deserialize(file, typeof(List<Article>));
				}
			foreach (Article art in movie2) {
				Console.WriteLine (art.ToString ());
			}




			/*
			Console.WriteLine (json);
			List<Article> veogames = JsonConvert.DeserializeObject<List<Article>>(json);
			foreach (Article art in veogames) {
				Console.WriteLine (art.ToString ());
			}
*/

		}
	}
}
