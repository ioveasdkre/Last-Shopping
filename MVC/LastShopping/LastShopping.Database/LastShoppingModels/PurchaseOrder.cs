﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.LastShoppingModels
{
    /// <summary>進貨訂單表</summary>
    [Index(nameof(Id))]
    public class PurchaseOrder
    {
        /// <summary>進貨訂單資訊Id</summary>
        [Display(Name = "進貨訂單資訊Id")]
        [Comment("進貨訂單資訊Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreatedDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        [Comment("修改時間")]
        public DateTime? ModifyDate { get; set; }

        public ICollection<PurchaseOrderDetails> PurchaseOrderDetails { get; set; } = null!;
    }
}
