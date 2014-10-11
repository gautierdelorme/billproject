using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billproject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            string subPath = (Path.Combine(Directory.GetCurrentDirectory(), @"SchoolBills"));

            if (!Directory.Exists(subPath))
                Directory.CreateDirectory(subPath);

            subPath = (Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));

            if (!Directory.Exists(subPath))
                Directory.CreateDirectory(subPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePageForm());
            
			/*SchoolBill sb = new SchoolBill ("gautier",true);
			sb.CreateArticle("yo",4,23.90,Article.typeTaxes.FP);
			sb.CreateArticle("yo",16,23.90,Article.typeTaxes.FP);
			sb.CreateArticle("aight",67,3.90,Article.typeTaxes.F);
            sb.Save();

            SchoolBill sb2 = new SchoolBill("solo",true);
            sb2.CreateArticle("yoy", 4, 2.90, Article.typeTaxes.P);
            sb2.CreateArticle("yo", 10, 23.90, Article.typeTaxes.FP);
            sb2.CreateArticle("aightttt", 67, 333.90, Article.typeTaxes.F);
            sb2.Save();

            SchoolBill sb3 = new SchoolBill(false);
            sb3 = (SchoolBill) ((Bill)sb+(Bill)sb2);
            sb3.Save();
			sb3.PrintArticles ();*/
            
		}
	}
}
