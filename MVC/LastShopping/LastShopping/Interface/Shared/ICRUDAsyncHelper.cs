﻿namespace LastShopping.Interface.Shared
{
    /// <summary>CRUD共用</summary>
    /// <typeparam name="GA">取得所有資料的model</typeparam>
    /// <typeparam name="G">取得單筆資料的model</typeparam>
    /// <typeparam name="C">新建資料的model</typeparam>
    /// <typeparam name="M">修改資料的model</typeparam>

    public interface ICRUDAsyncHelper<GA, G, C, M> : IGetAllAsync<GA>, IGetAsync<G>, IDeleteAsync, IBatchDeleteAsync, IModifyAsync<M>, ICreateAsync<C>
    {
    }

    public interface IGetAllAsync<T>
    {
        /// <summary>取得所有資料</summary>
        /// <returns>所有資料</returns>
        Task<T> GetAllAsync();
        /// <summary>取得所有資料</summary>
        /// <param name="limit">讀取數量 Take</param>
        /// <param name="offset">過濾數量 Skip</param>
        /// <param name="orderBy">排序欄位 orderBy</param>
        /// <param name="orderDescription">排序方式 desc or asc</param>
        /// <param name="filterStr">篩選關鍵字 Contains</param>
        /// <returns>所有資料</returns>
        Task<T> GetAllAsync(int? limit, int? offset, string? orderBy, string? orderDescription, string? filterStr);
    }

    public interface IGetAsync<T>
    {
        /// <summary>取得單筆資料</summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        Task<T> GetAsync(int id);
    }

    public interface ICreateAsync<T>
    {
        /// <summary>新建資料</summary>
        /// <param name="request">新建資料Model</param>
        /// <returns></returns>
        public Task CreateAsync(T request);
    }

    public interface IDeleteAsync
    {
        /// <summary>刪除資料</summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public Task DeleteAsync(int id);
    }

    public interface IBatchDeleteAsync
    {
        /// <summary>批次刪除資料</summary>
        /// <param name="idList">idList</param>
        /// <returns></returns>
        public Task BatchDeleteAsync(List<int> idList);
    }

    public interface IModifyAsync<T>
    {
        /// <summary>修改資料</summary>
        /// <param name="id">id</param>
        /// <param name="request">修改資料Model</param>
        /// <returns></returns>
        public Task ModifyAsync(int id, T request);
    }
}