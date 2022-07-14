using System.ComponentModel.DataAnnotations;

namespace LastShopping.Database.Models.Enum
{
    public enum OrderStatus
    {
        /// <summary>成立訂單</summary>
        [Display(Name = "成立訂單")]
        成立訂單 = 0,
        /// <summary>撿貨</summary>
        [Display(Name = "撿貨")]
        撿貨 = 1,
        /// <summary>理貨</summary>
        [Display(Name = "理貨")]
        理貨 = 2,
        /// <summary>出貨</summary>
        [Display(Name = "出貨")]
        出貨 = 3,
        /// <summary>已送達</summary>
        [Display(Name = "已送達")]
        已送達 = 4,
        /// <summary>廠商訂單資訊Id</summary>
        [Display(Name = "測試")]
        成立退貨 = 5,
        /// <summary>商品回收中</summary>
        [Display(Name = "商品回收中")]
        商品回收中 = 6,
        /// <summary>檢驗中</summary>
        [Display(Name = "檢驗中")]
        檢驗中 = 7,
        /// <summary>退款中</summary>
        [Display(Name = "退款中")]
        退款中 = 8,
        /// <summary>已退款</summary>
        [Display(Name = "已退款")]
        已退款 = 9
    }
}
