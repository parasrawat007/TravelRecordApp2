﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            bool IsEmailEmpty=string.IsNullOrEmpty(EntryEmail.Text);
            bool IsPasswordEmpty=string.IsNullOrEmpty(EntryPassword.Text);
            if (IsEmailEmpty||IsPasswordEmpty)
            { 
            
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
