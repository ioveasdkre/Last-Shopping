using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.LastShoppingModels
{
    /// <summary>銷售訂單表</summary>
    [Index(nameof(UserId))]
    public class SalesOrder
    {
        /// <summary>銷售訂單Id</summary>
        [Display(Name = "銷售訂單資訊Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesOrderId { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Required]
        public DateTime CreatedDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        public DateTime? ModifyDate { get; set; }

        /// <summary>消費者Id</summary>
        [Display(Name = "消費者Id")]
        [Required]
        public int UserId { get; set; }
    }
}
