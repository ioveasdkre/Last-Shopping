using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.Models
{
    /// <summary>產品資訊表</summary>
    [Index(nameof(FactoryId))]
    [Index(nameof(ProductTypeId))]
    [Index(nameof(ProductInformationId))]
    public class ProductInformation
    {
        /// <summary>產品Id</summary>
        [Display(Name = "產品Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductInformationId { get; set; }
        /// <summary>產品名稱</summary>
        [Display(Name = "產品名稱")]
        [Required]
        public string ProductName { get; set; }
        /// <summary>建議售價</summary>
        [Display(Name = "建議售價")]
        [Required]
        public int SuggestedPrice { get; set; }
        /// <summary>庫存量</summary>
        [Display(Name = "庫存量")]
        [Required]
        public int Inventory { get; set; }
        /// <summary>售價</summary>
        [Display(Name = "售價")]
        [Required]
        public int SellPrice { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        public DateTime? ModifyDate { get; set; }
        /// <summary>主要圖片路徑</summary>
        [Display(Name = "主要圖片路徑")]
        [Required]
        public string ProductImgPath { get; set; }

        /// <summary>廠商Id</summary>
        [Display(Name = "廠商Id")]
        [Required]
        public int FactoryId { get; set; }
        [ForeignKey("FactoryId")]
        public virtual Factory Factory { get; set; }

        /// <summary>產品類型Id</summary>
        [Display(Name = "產品類型Id")]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public virtual ProductType ProductType { get; set; }

        public ICollection<ProductImg> ProductImgs { get; set; }
        public ICollection<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
    }
}
