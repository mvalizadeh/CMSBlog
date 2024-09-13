using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class BlogComment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public int BlogId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
