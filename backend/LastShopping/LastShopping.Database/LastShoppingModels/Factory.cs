﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LastShopping.Database.LastShoppingModels
{
    /// <summary>廠商資訊</summary>
    public class Factory
    {
        /// <summary>廠商訂單資訊Id</summary>
        [Display(Name = "廠商訂單資訊Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>廠商名稱</summary>
        [Display(Name = "廠商名稱")]
        [Comment("廠商名稱")]
        [Required]
        public string Name { get; set; } = string.Empty;
        /// <summary>建立時間</summary>
        [Display(Name = "建立時間")]
        [Comment("建立時間")]
        [Required]
        public DateTime CreateDate { get; set; }
        /// <summary>修改時間</summary>
        [Display(Name = "修改時間")]
        [Comment("修改時間")]
        public DateTime? ModifyDate { get; set; }

        public ICollection<ProductInformation> ProductInformations { get; set; } = null!;
    }
}
