// <copyright file="MainWindow.xaml.cs" company="Maxime Merigeaux">
// Copyright (c) Maxime Merigeaux. All rights reserved.
// </copyright>

namespace GestFormApp
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using GestFormApp.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnClickGenerateElements(object sender, RoutedEventArgs e)
        {
            GestformViewModel gestformViewModelObject = new GestformViewModel();
            gestformViewModelObject.LoadGestformModel(Convert.ToInt32(this.TextBoxElementCount.Text));

            this.GestformViewControl.DataContext = gestformViewModelObject;
        }

        private void TextBoxElementCountChanged(object sender, TextChangedEventArgs e)
        {
            this.ButtonGenerateElements.IsEnabled = !string.IsNullOrEmpty((sender as TextBox).Text);
        }

        /// <summary>
        /// Validate input of a textbox to match only digits, not starting with 0.
        /// </summary>
        /// <param name="sender">The component.</param>
        /// <param name="e">the event.</param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox myTextbox = sender as TextBox;
                if (!e.Text.All(char.IsDigit) || (myTextbox.Text.Length == 0 && e.Text == "0")
                    || (myTextbox.SelectionStart == 0 && e.Text == "0"))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Prohibit space key input.
        /// </summary>
        /// <param name="sender">The component triggering the event.</param>
        /// <param name="e">the event.</param>
        private void TextBoxNoSpaceKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
