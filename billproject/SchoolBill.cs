using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace billproject
{
	public class SchoolBill : Bill<SchoolBill>, IArticle<SchoolBill>
	{
		public SchoolBill () : base() {
		}

		public override void PrintArticles () {
			Console.WriteLine ("*************** Articles ***************");
			foreach (Article article in Articles) {
				Console.WriteLine (article);
			}
		}

		public override void CopyFrom(SchoolBill bill) {
			Articles = bill.Articles;
		}

		protected override SchoolBill Addition (SchoolBill bill) {
			SchoolBill finalBill;
			if (!Articles.Any ()) {
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

		protected override SchoolBill Subtraction (SchoolBill bill) {
			SchoolBill finalBill;
			finalBill = this;
			foreach (Article article1 in bill.Articles) {
				foreach (Article article2 in finalBill.Articles) {
					if (article1.Item == article2.Item)
						finalBill.Articles[finalBill.Articles.IndexOf(article2)].Quantity = article2.Quantity - article1.Quantity;
				}
			}
			return finalBill;
		}

		public Article CreateArticle (string item,int quantity, double price, Article.typeTaxes typeTaxe) {
			return new Article (item, quantity, price, typeTaxe);
		}

		public void AddArticle(Article article) {
			if (!Articles.Exists (x => x.Item == article.Item))
				Articles.Add (article);
			else
				Articles [Articles.FindIndex (x => x.Item == article.Item)].Quantity += article.Quantity;
		}

		public void RemoveArticle(Article article) {
			Articles.Remove (article);
		}

		public int NbArticle() {
			return Articles.Count;
		}

		public void Save () {
		}

		public void Load (SchoolBill bill) {
		}
	}
}

