﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.LastShoppingModels
{
    /// <summary>銷售訂單表</summary>
    [Index(nameof(Id))]
    [Index(nameof(UserId))]
    public class SalesOrder
    {
        /// <summary>銷售訂單Id</summary>
        [Display(Name = "銷售訂單Id")]
        [Comment("銷售訂單Id")]
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

        /// <summary>使用者Id</summary>
        [Display(Name = "使用者Id")]
        [Comment("使用者Id")]
        [Required]
        public int UserId { get; set; }
    }
}
