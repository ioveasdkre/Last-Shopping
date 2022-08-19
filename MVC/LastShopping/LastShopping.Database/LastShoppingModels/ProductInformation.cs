using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.LastShoppingModels
{
    /// <summary>產品資訊表</summary>
    [Index(nameof(Id))]
    [Index(nameof(FactoryId))]
    [Index(nameof(ProductTypeId))]
    public class ProductInformation
    {
        /// <summary>產品Id</summary>
        [Display(Name = "產品Id")]
        [Comment("產品Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>產品名稱</summary>
        [Display(Name = "產品名稱")]
        [Comment("產品名稱")]
        [Required]
        public string Name { get; set; } = string.Empty;
        /// <summary>建議售價</summary>
        [Display(Name = "建議售價")]
        [Comment("建議售價")]
        [Required]
        public int SuggestedPrice { get; set; }
        /// <summary>庫存量</summary>
        [Display(Name = "庫存量")]
        [Comment("庫存量")]
        [Required]
        public int Inventory { get; set; }
        /// <summary>售價</summary>
        [Display(Name = "售價")]
        [Comment("售價")]
        [Required]
        public int SellPrice { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        [Comment("修改時間")]
        public DateTime? ModifyDate { get; set; }
        /// <summary>主要圖片路徑</summary>
        [Display(Name = "主要圖片路徑")]
        [Comment("主要圖片路徑")]
        [Required]
        public string Path { get; set; } = string.Empty;

        /// <summary>廠商Id</summary>
        [Display(Name = "廠商Id")]
        [Comment("廠商Id")]
        [Required]
        public int FactoryId { get; set; }
        [ForeignKey("FactoryId")]
        public Factory Factory { get; set; } = null!;

        /// <summary>產品類型Id</summary>
        [Display(Name = "產品類型Id")]
        [Comment("產品類型Id")]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductType ProductType { get; set; } = null!;

        public ICollection<ProductImg> ProductImgs { get; set; } = null!;
        public ICollection<PurchaseOrderDetails> PurchaseOrderDetails { get; set; } = null!;
    }
}
