﻿using Ecore.Frame;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EMin.Model.Collection
{
    public class Sale_Order : IEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        public string Id { get; set; }

        public string TradeId { get; set; }

        public string ItemId { get; set; }

        public string ItemSkuId { get; set; }

        public int Count { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 按利率折扣
        /// </summary>
        public decimal DiscountRate { get; set; }

        /// <summary>
        /// 按额度折扣
        /// </summary>
        public decimal DiscountAmount { get; set; }

        public decimal ActualAmount { get; set; }

        /// <summary>
        /// 10:生成订单，20：交易确认， 30：交易完成（已发货）
        /// </summary>
        public int OrderState { get; set; }

    }
}
