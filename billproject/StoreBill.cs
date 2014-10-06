using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace billproject
{
	public class StoreBill : Bill<StoreBill>,IArticle<StoreBill>
	{

		public StoreBill(bool s)
		{
			DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(),@"StoreBills"));
			FileInfo[] files = directory.GetFiles();

			int id = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0).Count() + 1;

			Id = id;
			Articles = new List<Article> ();

			if (s)
				Save ();
		}
		/// <summary>
		/// Print all bills' articles
		/// </summary>
		public override void PrintArticles()
		{
			Console.WriteLine ("*************** Articles ***************");
			foreach (Article art in Articles)
			{
				Console.WriteLine(art);
			}
		}

		public override void CopyFrom(StoreBill bill)
		{
			Articles = bill.Articles;
		}
		/*
		protected override StoreBill Addition (StoreBill bill) {
			StoreBill finalBill;
			if (!Articles.Any()) {
				finalBill = bill;
			} else {
				finalBill = this;
				foreach (Article article1 in bill.Articles) {
					foreach (Article article2 in finalBill.Articles) {
						if (article1.Item == article2.Item)
							finalBill.Articles[finalBill.Articles.IndexOf(article2)].Quantity = article2.Quantity + article1.Quantity;
						else
							finalBill.Articles.Add (article1);
					}
				}
			}
			return finalBill;
		}

		protected override StoreBill Subtraction (StoreBill bill) {
			StoreBill finalBill;
			finalBill = this;
			foreach (Article article1 in bill.Articles) {
				foreach (Article article2 in finalBill.Articles) {
					if (article1.Item == article2.Item)
						finalBill.Articles[finalBill.Articles.IndexOf(article2)].Quantity = article2.Quantity - article1.Quantity;
				}
			}
			return finalBill;
		}
		*/

		/// <summary>
		/// Create a new article
		/// </summary>
		/// <returns></returns>

		public void CreateArticle (string item,int quantity, double price, Article.typeTaxes typeTaxe) {
			AddArticle(new Article (item, quantity, price, typeTaxe));
		}

		/// <summary>
		/// Add an article to the bill
		/// </summary>
		/// <param name="art"></param>
		public void AddArticle(Article art)
		{
			Articles.Add(art);
		}
		/// <summary>
		/// Remove an article from the bill
		/// </summary>
		/// <param name="artName">Article name</param>
		public void RemoveArticle(Article art)
		{
			Articles.Remove (art);
		}
		/// <summary>
		/// Return an int which contain the number of bill's article
		/// </summary>
		/// <returns></returns>
		public int NbArticle()
		{
			return Articles.Count;
		}

		public void Save()
		{
			using (StreamWriter file = File.CreateText(Path.Combine (Directory.GetCurrentDirectory (),"StoreBills", Id+".txt")))
			{
				JsonSerializer serializer = new JsonSerializer();
				serializer.Serialize(file, Articles);
			}
		}

		public void Load (int id)
		{
			using (StreamReader file = File.OpenText(Path.Combine (Directory.GetCurrentDirectory (),"StoreBills", id+".txt")))
			{
				JsonSerializer serializer = new JsonSerializer();
				Id = id;
				Articles = (List<Article>)serializer.Deserialize(file, typeof(List<Article>));
			}
		}

 
	}
}

