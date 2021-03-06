﻿using System;

namespace NewLife.Cube
{
    /// <summary>页面设置。用于控制各页面功能</summary>
    public class PageSetting
    {
        #region 静态
        /// <summary>全局设置</summary>
        public static PageSetting Global { get; } = new PageSetting();
        #endregion

        #region 属性
        /// <summary>启用导航栏。默认true</summary>
        public Boolean EnableNavbar { get; set; } = true;

        /// <summary>启用添加按钮。默认true</summary>
        public Boolean EnableAdd { get; set; } = true;

        /// <summary>启用选择列。默认Update/Delete权限时为true</summary>
        public Boolean EnableSelect { get; set; }
        #endregion

        #region 构造
        #endregion

        #region 方法
        /// <summary>克隆</summary>
        /// <returns></returns>
        public PageSetting Clone()
        {
            var set = new PageSetting
            {
                EnableNavbar = EnableNavbar,
                EnableAdd = EnableAdd,
                EnableSelect = EnableSelect,
            };

            return set;
        }
        #endregion
    }
}