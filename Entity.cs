using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LongtextIssue
{
    public class Entity
    {
        public int Id { get; set; }
        
        [Column(TypeName = "longtext")]
        public string LongString { get; set; }
    }
}
