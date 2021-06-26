using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongtextIssue
{
    public class Entity
    {
        public int Id { get; set; }
        
        [StringLength(5000)]
        public string LongString { get; set; }
    }
}
