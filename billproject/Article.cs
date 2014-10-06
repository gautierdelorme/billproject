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

		public double TotalAmoutWithoutTaxes() {
			return Price * Quantity;
		}

		public double TotalAmoutWithTaxes() {
			double total = 0;
			double totalAmount = TotalAmoutWithoutTaxes ();
			if (Taxes == Article.typeTaxes.FP)
				total = totalAmount+totalAmount*14.975/100;
			else if (Taxes == Article.typeTaxes.P)
				total = totalAmount+totalAmount*9.975/100;
			else if (Taxes == Article.typeTaxes.P)
				total = totalAmount+totalAmount*5.975/100;
			else
				total = totalAmount;
			return total;
		}

		public override string ToString()
		{
			return "Article : "+Item+", Quantity : "+Quantity+" at "+Price+"$/article with "
				+Taxes+" taxes ("+TotalAmoutWithoutTaxes()+"$ without taxes and total : "+TotalAmoutWithTaxes();
		}
	}
}

