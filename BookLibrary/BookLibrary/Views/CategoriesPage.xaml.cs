﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        private bool firstLoad;
        private CategoriesViewModel _model;
        public CategoriesPage()
        {
            InitializeComponent();
            BindingContext = _model = new CategoriesViewModel();
            firstLoad = true;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (firstLoad)
            {
                _model.OnAppearing();
                firstLoad = false;
            }
        }
    }
}