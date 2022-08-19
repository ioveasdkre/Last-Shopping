using System.Net;

namespace LastShopping.Models
{
    /// <summary>回傳訊息</summary>
    public class ResultModel
    {
        /// <summary>狀態</summary>
        public HttpStatusCode Code { get; set; }
        /// <summary>訊息</summary>
        public string? Message { get; set; }
    }

    /// <summary>回傳資料跟訊息</summary>
    /// <typeparam name="T"></typeparam>
    public class ResultModel<T>
    {
        /// <summary>狀態</summary>
        public HttpStatusCode Code { get; set; }
        /// <summary>訊息</summary>
        public string? Message { get; set; }
        /// <summary>數據</summary>
        public T? Data { get; set; }
    }

}
