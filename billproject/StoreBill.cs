﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace billproject
{
	public class StoreBill : Bill,IArticle
	{

		public StoreBill(string name, bool s)
		{
            string subPath = (Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));

            if (!Directory.Exists(subPath))
                Directory.CreateDirectory(subPath);

			DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(),@"StoreBills"));
			FileInfo[] files = directory.GetFiles();

			int id = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0).Count() + 1;

			Id = id;
            Name = name;
			Articles = new List<Article> ();

			if (s)
				Save ();
		}

        public StoreBill(bool s)
        {
            string subPath = (Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));

            if (!Directory.Exists(subPath))
                Directory.CreateDirectory(subPath);

            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));
            FileInfo[] files = directory.GetFiles();

            int id = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0).Count() + 1;

            Id = id;
            Name = "name";
            Articles = new List<Article>();

            if (s)
                Save();
        }

        public StoreBill(string name, List<Article> articles, bool s)
        {
            string subPath = (Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));

            if (!Directory.Exists(subPath))
                Directory.CreateDirectory(subPath);

            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));
            FileInfo[] files = directory.GetFiles();

            int id = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0).Count() + 1;

            Id = id;
            Name = name;
            Articles = articles;

            if (s)
                Save();
        }

        public StoreBill(StoreBill antBill, string name, bool s)
        {
            string subPath = (Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));

            if (!Directory.Exists(subPath))
                Directory.CreateDirectory(subPath);

            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));
            FileInfo[] files = directory.GetFiles();

            int id = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0).Count() + 1;

            Id = id;
            Name = name;
            Articles = antBill.Articles;

            if (s)
                Save();
        }

		/// <summary>
		/// Print all bills' articles
		/// </summary>
		public override void PrintArticles()
		{
			Console.WriteLine ("*************** Articles ***************");
			double totalAmountWithoutTaxes = 0;
			double totalAmountWithTaxes = 0;

			foreach (Article article in Articles) {
				Console.WriteLine (article);
				totalAmountWithoutTaxes += article.TotalAmoutWithoutTaxes();
				totalAmountWithTaxes += article.TotalAmoutWithTaxes ();
			}
			Console.WriteLine ("Total without taxes : "+ totalAmountWithoutTaxes+"$");
			Console.WriteLine ("Total with taxes : "+ totalAmountWithTaxes+"$");
		}

		public override void CopyFrom(Bill bill)
		{
			Articles = bill.Articles;
		}
		
		protected override Bill Addition (Bill bill) {
            Bill finalBill = new StoreBill(this, Name + "+" + bill.Name, false);

            if (!Articles.Any())
            {
                finalBill.Articles = bill.Articles;
            }
            else
            {
                foreach (Article art in bill.Articles)
                {
                    if (finalBill.Articles.Exists(x => x.Item == art.Item))
                        finalBill.Articles[finalBill.Articles.FindIndex(x => x.Item == art.Item)].Quantity += art.Quantity;
                    else
                        finalBill.Articles.Add(art);
                }
            }
            return finalBill;
		}

		protected override Bill Subtraction (Bill bill) {
            Bill finalBill = new StoreBill(this, Name + "-" + bill.Name, false);

            if (!Articles.Any())
            {
                finalBill.Articles = bill.Articles;
            }
            else
            {
                foreach (Article art in bill.Articles)
                {
                    if (finalBill.Articles.Exists(x => x.Item == art.Item))
                        finalBill.Articles[finalBill.Articles.FindIndex(x => x.Item == art.Item)].Quantity -= art.Quantity;
                }
            }
            return finalBill;
		}

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

