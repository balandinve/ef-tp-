using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_tpс.entities
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(): base("DefaultConnection") { }

        public DbSet<ArticleCommon> Articles { get; set; }
        public DbSet<ArticleFirstType> ArticleFirstTypes { get; set; }
        public DbSet<ArticleSecondType> ArticleSecondTypes { get; set; }
        
    }
}
