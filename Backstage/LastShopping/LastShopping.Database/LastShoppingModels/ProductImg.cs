using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.LastShoppingModels
{
    /// <summary>產品圖片</summary>
    [Index(nameof(Id))]
    [Index(nameof(ProductInformationId))]
    public class ProductImg
    {
        /// <summary>產品圖片Id</summary>
        [Display(Name = "產品圖片Id")]
        [Comment("產品圖片Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>產品圖片路徑</summary>
        [Display(Name = "產品圖片路徑")]
        [Comment("產品圖片路徑")]
        public string Path { get; set; } = string.Empty;
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        [Comment("修改時間")]
        public DateTime ModifyDate { get; set; }

        /// <summary>產品Id</summary>
        [Display(Name = "產品Id")]
        [Comment("產品Id")]
        [Required]
        public int ProductInformationId { get; set; }
        [ForeignKey("ProductInformationId")]
        public ProductInformation ProductInformation { get; set; } = null!;

    }
}
