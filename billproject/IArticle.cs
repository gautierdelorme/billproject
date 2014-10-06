using System;

namespace billproject
{
	public interface IArticle<T>
	{
		void CreateArticle(string item, int quantity, double price, Article.typeTaxes Taxes);
		void AddArticle(Article article);
		void RemoveArticle(Article article);
		int NbArticle();
		void Save();
		void Load(int id);
	}
}

