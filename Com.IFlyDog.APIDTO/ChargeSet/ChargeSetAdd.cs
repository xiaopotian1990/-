﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.IFlyDog.APIDTO
{
    /// <summary>
    /// 添加套餐dto
    /// </summary>
   public class ChargeSetAdd
    {
        /// <summary>
        /// id
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 套餐名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// 状态0：停用1：使用
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string PinYin { get; set; }
        /// <summary>
        /// 是否有时间限制0：没有1：有
        /// </summary>
        public string TimeLimit { get; set; }
        /// <summary>
        /// 0：从购买时算1：从消费时算
        /// </summary>
        public string TimeStart { get; set; }
        /// <summary>
        /// 天数
        /// </summary>
        public string Days { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public long CreateUserID { get; set; }

        /// <summary>
        ///套餐收费项目映射详情dto
        /// </summary>
        public virtual List<SmartChargeSetDetail> SmartChargeSetDetailAdd { get; set; }
    }

    /// <summary>
    /// 套餐收费项目映射表
    /// </summary>
    public class SmartChargeSetDetail {
        /// <summary>
        /// 套餐收费项目映射id
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 套餐id
        /// </summary>
        public string SetID { get; set; }
        /// <summary>
        /// 收费项目id
        /// </summary>
        public string ChargeID { get; set; }
        /// <summary>
        /// 收费项目名称
        /// </summary>
        public string ChargeName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string Num { get; set; }
/// <summary>
/// 总价格
/// </summary>
        public string Amount { get; set; }
    }
}
