using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TiendaArreglos.Client.Wpf.ViewModels;

namespace TiendaArreglos.Client.Wpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            InitializeDataContext();
            AttachEvents();
        }

        private void AttachEvents()
        {
            Loaded += LoadedHandler;
            KeyUp += KeyUpHandler;
        }

        private void InitializeDataContext()
        {
            DataContext = new MainWindowViewModel();
        }

        private void InitializeFocus()
        {
            NumberOfTicketsToPrintTextBox.Focus();
        }

        void KeyUpHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }

        private void LoadedHandler(object sender, RoutedEventArgs e)
        {
            InitializeFocus();
        }

        private void TextBoxGotFocusHandler(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                textBox.SelectAll();
            }
        }
    }
}