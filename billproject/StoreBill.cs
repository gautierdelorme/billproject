using System;

namespace billproject
{
	public class StoreBill //: Bill,IArticle
	{
		/*public StoreBill():base()
		{

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

		public static StoreBill operator +(StoreBill bill1,StoreBill bill2)
		{
			StoreBill NewBill = new StoreBill();

			if (bill1.Articles==null & bill2.Articles==null)
			{
				NewBill.Articles = null;
			}
			else if (bill1.Articles == null)
			{
				NewBill.Articles = bill2.Articles;
			}
			else if (bill2.Articles == null)
			{
				NewBill.Articles = bill1.Articles;
			}
			else
			{
				NewBill.Articles = bill1.Articles;
				foreach (Article artBill2 in bill2.Articles)
				{

					foreach (Article artNewBill in NewBill.Articles)
					{
						if (artBill2.Item==artNewBill.Item)
						{
							artNewBill.Price += artBill2.Price;
							artNewBill.Quantity += artNewBill.Quantity;

						}
						else
						{
							NewBill.Articles.Add(artBill2);

						}

					}
				}
			}
			return NewBill;
		}

		public static StoreBill operator -(StoreBill bill1,StoreBill bill2)
		{
			StoreBill NewBill = new StoreBill();
			if (bill1==null & bill2==null)
			{
				NewBill.Articles = null;
			}
			else if (bill1==null )
			{
				NewBill.Articles = bill2.Articles;
			}
			else if (bill2==null)
			{
				NewBill.Articles = bill1.Articles;
			}
			else
			{
				NewBill.Articles = bill1.Articles;
				foreach(Article artBill2 in bill2.Articles)
				{
					foreach (Article artNewBill in NewBill.Articles)
					{
						if (artBill2.Item == artNewBill.Item)
						{
							artNewBill.Price= Math.Abs(artNewBill.Price-artBill2.Price);
							artNewBill.Quantity= Math.Abs(artNewBill.Quantity-artBill2.Quantity);
						}
						else
						{
							NewBill.Articles.Add(artBill2);

						}

					}
				}
			}
			return NewBill;


		}*/
		/// <summary>
		/// Create a new article
		/// </summary>
		/// <returns></returns>
		/*
        public Article CreateArticle(string artName,int quantity, double price, string typeTaxeName )
        {
            
            
        }
        */
		/// <summary>
		/// Add an article to the bill
		/// </summary>
		/// <param name="art"></param>
		/*public void AddArticle(Article art)
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
			return Articles.Count();
		}*/
	}
}

