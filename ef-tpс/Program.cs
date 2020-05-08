using ef_tpс.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_tpс
{
    class Program
    {
        static void Main(string[] args)
        {
            var type1 = new ArticleFirstType {
            ArticleFirstTypeProperty = "First"};

            var type2 = new ArticleSecondType
            {
                ArticleSecondTypeProperty = "Second"
            };
            var article1 = new ArticleCommon
            {
                ArticleTitle = "Article"
            };

            using(var db = new AppDbContext())
            {
                db.Articles.Add(article1);
                db.SaveChanges();
                type1.Id = article1.Id;
                type2.Id = article1.Id;
                db.ArticleFirstTypes.Add(type1);
                db.ArticleSecondTypes.Add(type2);
                db.SaveChanges();

                var articles = db.Articles.Select(s => new
                {
                    Title = s.ArticleTitle,
                    FirstProperty = s.ArticleFirtType.ArticleFirstTypeProperty,
                    SecondProperty = s.ArticleSecondType.ArticleSecondTypeProperty
                });
                foreach (var a in articles)
                {
                    Console.WriteLine($"{a.Title}: 1: {a.FirstProperty}, 2: {a.SecondProperty}");
                }
            }
        }
    }
}
