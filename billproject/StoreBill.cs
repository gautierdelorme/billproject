using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace billproject
{
	public class StoreBill : Bill<StoreBill>,IArticle<StoreBill>
	{

		public StoreBill(bool a)
		{
			int id = 0;
			if (a)
			{
				id = Directory.GetFiles (Path.Combine (Directory.GetCurrentDirectory (), "StoreBills/"), "*", SearchOption.TopDirectoryOnly).Length + 1;
			}
			Id = id;
			Articles = new List<Article> ();
		}
		/// <summary>
		/// Print all bills' articles
		/// </summary>
		public void PrintArticles()
		{
			foreach (Article art in Articles)
			{
				Console.WriteLine(art);
			}
		}

		public void CopyFrom(StoreBill bill)
		{
			Articles = bill.Articles;
		}

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

		/// <summary>
		/// Create a new article
		/// </summary>
		/// <returns></returns>

        public Article CreateArticle(string artName,int quantity, double price, Article.typeTaxes typeTaxeName )
        {
			return new Article (artName, quantity, price, typeTaxeName);
            
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
		public void RemoveArticle(string artName)
		{
			if (Articles==null)
			{
				Console.WriteLine("Your bill is empty");
			}
			else
			{
				Article result= Articles.Find(x => x.Item==artName);
				if (result==null)
				{
					Console.WriteLine("Your bill does'nt contain any article named :"+artName);
				}
				else
				{
					Articles.Remove(result);
				}

			}
		}
		/// <summary>
		/// Return an int which contain the number of bill's article
		/// </summary>
		/// <returns></returns>
		public int NbArticles()
		{
			return Articles.Count;
		}

		public void Save(StoreBill bill)
		{

		}

		public void Load (StoreBill bill)
		{

		}

 
	}
}

