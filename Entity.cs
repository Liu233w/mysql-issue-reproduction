using System.ComponentModel.DataAnnotations;

namespace LongtextIssue
{
    public class Entity
    {
        public int Id { get; set; }
        
        [StringLength(5000)]
        public string LongString { get; set; }
    }
}
