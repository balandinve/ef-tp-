using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_tpс.entities
{
    public class ArticleSecondType
    {
        [Key]
        [ForeignKey("ArticleCommon")]
        public int Id { get; set; }
        public string ArticleSecondTypeProperty { get; set; }
        public virtual ArticleCommon ArticleCommon { get; set; }
    }
}
