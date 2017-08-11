﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstMVVM.ViewModels
{
    public class DashboardViewModel
    {
        public ICommand VisitInstagramCommand { get; set; }
        public ICommand VisitGithubCommand { get; set; }

        public DashboardViewModel()
        {
            VisitInstagramCommand = new Command(VisitInstagram);
            VisitGithubCommand = new Command(VisitGithub);
        }

        private void VisitGithub(object obj)
        {
            string githubLink = "https://github.com/dimasarf";
            Device.OpenUri(new Uri(githubLink));
        }

        private void VisitInstagram(object obj)
        {
            string instagramLink = "https://www.instagram.com/dimas_arf/";
            Device.OpenUri(new Uri(instagramLink));
        }
    }
}
