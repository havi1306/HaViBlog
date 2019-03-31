using HaViBlog.Infrastructure.DomainEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaViBlog.Data.EF.Entities
{
    [Table("Category")]
    public class Category : DomainEntity<int>
    {
        [MaxLength(100)]
        public string CategoryName { get; set; }

        [Required]
        public int ParentId { get; set; }

        [MaxLength(500)]
        public string IconClass { get; set; }

        [MaxLength(500)]
        public string Url { get; set; }

        public bool? IsParent { get; set; }

        public ICollection<PostCategory> PostCategories { get; set; }

        public Category()
        {
        }

        public Category(int id, string categoryName, int parentid, string iconclass, string url, bool? isparent)
        {
            Id = id;
            CategoryName = categoryName;
            ParentId = parentid;
            IconClass = iconclass;
            Url = url;
            IsParent = isparent;
        }
    }
}