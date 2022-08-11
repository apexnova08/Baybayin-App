﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lesson12Page : ContentPage
    {
        public Lesson12Page()
        {
            InitializeComponent();
        }
        private async void ActivityClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../{nameof(Activity12Page)}");
        }
    }
}