using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.LastShoppingModels
{
    /// <summary>進貨訂單明細表</summary>
    [Index(nameof(PurchaseOrderId))]
    [Index(nameof(ProductInformationId))]
    public class PurchaseOrderDetails
    {
        /// <summary>進貨訂單Id</summary>
        [Display(Name = "訂單Id")]
        public int PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        /// <summary>產品Id</summary>
        [Display(Name = "產品Id")]
        public int ProductInformationId { get; set; }
        public ProductInformation ProductInformation { get; set; }
        /// <summary>進貨數量</summary>
        [Display(Name = "進貨數量")]
        [Required]
        public int ProductAmount { get; set; }
        /// <summary>進貨成本</summary>
        [Display(Name = "進貨成本")]
        [Required]
        public int ProductPrice { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        public DateTime? ModifyDate { get; set; }
        /// <summary>是否結案</summary>
        [Display(Name = "是否結單")]
        [MaxLength(1)]
        [Required]
        [Column(TypeName = "nchar(1)")]
        public string 是否結單 { get; set; }
    }
}
