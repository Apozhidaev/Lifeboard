﻿using System.Windows.Controls;
using System.Windows.Input;
using LifeBoard.ViewModels.Issues;

namespace LifeBoard.Views.Issues
{
    /// <summary>
    /// Логика взаимодействия для IssuesView.xaml
    /// </summary>
    public partial class IssuesView : Page
    {
        public IssuesView(IssuesViewModel model)
        {
            InitializeComponent();
            DataContext = model;
        }
    }
}