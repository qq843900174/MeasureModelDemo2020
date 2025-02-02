﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HalconDotNet;

namespace ViewROI.Config
{
    /// <summary>
    /// 显示xld和region带有颜色
    /// </summary>
    class HObjectWithColor
    {
        private HObject hObject;
        private string color;
        public HObjectWithColor(HObject _hbj, string _color)
        {
            hObject = _hbj;
            color = _color;
        }

        public HObject HObject
        {
            get { return hObject; }
            set { hObject = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
