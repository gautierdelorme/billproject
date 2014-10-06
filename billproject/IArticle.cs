using System;

namespace billproject
{
	public interface IArticle<T>
	{
		Article CreateArticle(string item, int quantity, double price, Article.typeTaxes Taxes);
		void AddArticle(Article article);
		void RemoveArticle(Article article);
		int NbArticle();
		void Save();
		void Load(T bill);
	}
}

