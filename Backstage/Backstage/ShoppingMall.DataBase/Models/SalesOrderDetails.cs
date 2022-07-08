using Backstage.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Backstage.Models
{
    /// <summary>銷售訂單明細表</summary>
    [Index(nameof(OrderId))]
    [Index(nameof(ProductInformationId))]
    public class SalesOrderDetails
    {
        /// <summary>銷售訂單Id</summary>
        [Display(Name = "訂單Id")]
        public int OrderId { get; set; }
        public SalesOrder Order { get; set; }
        /// <summary>產品Id</summary>
        [Display(Name = "產品Id")]
        public int ProductInformationId { get; set; }
        public ProductInformation ProductInformation { get; set; }

        /// <summary>銷售數量</summary>
        [Display(Name = "銷售數量")]
        [Required]
        public int ProductAmount { get; set; }
        /// <summary>銷售價格</summary>
        [Display(Name = "銷售價格")]
        [Required]
        public int ProductPrice { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        public DateTime? ModifyDate { get; set; }
        /// <summary>訂單狀態</summary>
        [Display(Name = "訂單狀態")]
        public OrderStatus OrderStatus { get; set; }
        /// <summary>到貨時間</summary>
        [Display(Name = "到貨時間")]
        public DateTime? ArrivalDate { get; set; }
    }
}
