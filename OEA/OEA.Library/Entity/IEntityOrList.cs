﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建时间：20111110
 * 说明：此文件只包含一个类，具体内容见类型注释。
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20111110
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OEA.Library
{
    /// <summary>
    /// 实体模块组件（Entity Or EntityList）
    /// </summary>
    public interface IEntityOrList : IDirtyAware
    {
        /// <summary>
        /// 获取父组件
        /// </summary>
        IEntityOrList Parent { get; }

        /// <summary>
        /// 获取其对应的仓库
        /// </summary>
        /// <returns></returns>
        IRepository GetRepository();

        /// <summary>
        /// 设置父组件
        /// </summary>
        /// <param name="parent"></param>
        void SetParent(IEntityOrList parent);
    }
}
