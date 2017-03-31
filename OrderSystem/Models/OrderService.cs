using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Models
{
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <param name="order"></param>
        public void InserOrder(Models.Order order)
        {

        }
        /// <summary>
        /// 依照Id取得訂單資料
        /// </summary>
        /// <returns></returns>
        public Models.Order GetOrderById()
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚";
            return result;
        }
        /// <summary>
        /// 依照條件取得訂單資料
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrderByCondition()
        {
            return new List<Order>();
        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeleteOrderById()
        {

        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder()
        {

        }
    }
}