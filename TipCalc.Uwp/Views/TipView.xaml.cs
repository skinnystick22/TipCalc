﻿using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using TipCalc.Core.ViewModels;

namespace TipCalc.Uwp.Views
{
    [MvxViewFor(typeof(TipViewModel))]
    public sealed partial class TipView : MvxWindowsPage
    {
        public TipView()
        {
            InitializeComponent();
        }
    }
}