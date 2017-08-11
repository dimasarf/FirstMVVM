﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstMVVM.Views
{

    public class DashboardMenuItem
    {
        public DashboardMenuItem()
        {
            TargetType = typeof(DashboardDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public ImageSource Icon { get; set; }

        public Type TargetType { get; set; }
    }
}