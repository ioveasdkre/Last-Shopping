using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backstage.Models
{
    /// <summary>產品類型表</summary>
    [Index(nameof(ProductTypeId))]
    public class ProductType
    {
        /// <summary>產品類型Id</summary>
        [Display(Name = "產品類型Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductTypeId { get; set; }
        /// <summary>產品類型名稱</summary>
        [Display(Name = "產品類型名稱")]
        [Required]
        public string Type { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        public DateTime? ModifyDate { get; set; }

        public ICollection<ProductInformation> ProductInformations { get; set; }
    }
}
