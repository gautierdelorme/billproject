using System;

namespace billproject
{
	public interface IArticle
	{
		Article createArticle(string item, int quantity, double price, Article.typeTaxes Taxes);
		void addArticle(Article article);
		void removeArticle(Article article);
		int nbArticle();
		void save();
		void load(Bill bill);
	}
}

