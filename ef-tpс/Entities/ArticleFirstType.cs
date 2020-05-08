using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_tpс.entities
{
    public class ArticleFirstType
    {
        [Key]
        [ForeignKey("ArticleCommon")]
        public int Id { get; set; }
        public string ArticleFirstTypeProperty { get; set; }
        public virtual ArticleCommon ArticleCommon { get; set; }
    }
}
