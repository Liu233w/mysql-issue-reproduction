using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LongtextIssue
{
    public class Entity
    {
        public int Id { get; set; }
        
        [Column(TypeName = "varchar(5000)")]
        public string LongString { get; set; }
    }
}
