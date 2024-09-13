using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [Required]
        public int GroupId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(5000)]
        public string Description { get; set; }
        public int Visit { get; set; }
        public string ImageName { get; set; }
        public DateTime CreatDate { get; set; }

        public virtual BlogGroup BlogGroup { get; set; }
        public virtual ICollection<BlogComment> BlogComments { get; set; }
    }
}
