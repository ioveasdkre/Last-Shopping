using LastShopping.Database.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.LastShoppingModels
{
    /// <summary>銷售訂單明細表</summary>
    [Index(nameof(SalesOrderId))]
    [Index(nameof(ProductInformationId))]
    public class SalesOrderDetails
    {
        /// <summary>銷售訂單Id</summary>
        [Display(Name = "銷售訂單Id")]
        [Comment("銷售訂單Id")]
        public int SalesOrderId { get; set; }
        [ForeignKey("SalesOrderId")]
        public SalesOrder SalesOrder { get; set; } = null!;
        /// <summary>產品Id</summary>
        [Display(Name = "產品Id")]
        [Comment("產品Id")]
        public int ProductInformationId { get; set; }
        [ForeignKey("ProductInformationId")]
        public ProductInformation ProductInformation { get; set; } = null!;

        /// <summary>銷售數量</summary>
        [Display(Name = "銷售數量")]
        [Comment("銷售數量")]
        [Required]
        public int Amount { get; set; }
        /// <summary>銷售價格</summary>
        [Display(Name = "銷售價格")]
        [Comment("銷售價格")]
        [Required]
        public int Price { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        [Comment("修改時間")]
        public DateTime? ModifyDate { get; set; }
        /// <summary>訂單狀態</summary>
        [Display(Name = "訂單狀態")]
        [Comment("訂單狀態")]
        public OrderStatus OrderStatus { get; set; }
        /// <summary>到貨時間</summary>
        [Display(Name = "到貨時間")]
        [Comment("到貨時間")]
        public DateTime? ArrivalDate { get; set; }
    }
}
