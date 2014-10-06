using System;

namespace billproject
{
	public class Article
	{
		public enum typeTaxes {FP,F,P,O};
		public string Item { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }
		public typeTaxes Taxes { get; set; }

		public Article(string item,int quantity, double price, typeTaxes typeTaxe)
		{
			Item = item;
			Quantity = quantity;
			Price = price;
			Taxes = typeTaxe;
		}

		public override string ToString()
		{
			return "Article : "+Item+", Quantity : "+Quantity+" at "+Price+"$/article with "+Taxes+" taxes.";
		}
	}
}

