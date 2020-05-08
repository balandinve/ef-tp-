using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_tpс.entities
{
    public class ArticleCommon
    {
        [Key]
        public int Id { get; set; }
        public string ArticleTitle { get; set; }
        public virtual ArticleFirstType ArticleFirtType { get; set; }
        public virtual ArticleSecondType ArticleSecondType { get; set; }
    }
}
