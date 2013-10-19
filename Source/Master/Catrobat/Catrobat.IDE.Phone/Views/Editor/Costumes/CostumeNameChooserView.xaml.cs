﻿using System.Windows.Controls;
using Catrobat.IDE.Phone.ViewModel.Editor.Costumes;
using Microsoft.Phone.Controls;
using Microsoft.Practices.ServiceLocation;

namespace Catrobat.IDE.Phone.Views.Editor.Costumes
{
    public partial class CostumeNameChooserView : PhoneApplicationPage
    {
        private readonly CostumeNameChooserViewModel _viewModel = ServiceLocator.Current.GetInstance<CostumeNameChooserViewModel>();

        public CostumeNameChooserView()
        {
            InitializeComponent();

            Dispatcher.BeginInvoke(() =>
                {
                    TextBoxCostumeName.Focus();
                    TextBoxCostumeName.SelectAll();
                });
        }

        private void TextBoxCostumeName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.CostumeName = TextBoxCostumeName.Text;
        }
    }
}