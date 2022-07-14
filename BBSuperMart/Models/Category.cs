using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BBSuperMart.Models
{
    public partial class Category
    {
        [Key]
        public int CatId { get; set; }

        [Required]
        public string CatName { get; set; }

        [Required]
        [DisplayName("Display Order")]
        [Range(1,int.MaxValue,ErrorMessage ="Number should be more than 0")]
        public int DisplayOrder { get; set; }

        public string CatImageIcon { get; set; }
    }
}
