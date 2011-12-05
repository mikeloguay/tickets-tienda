using System;
using System.Linq;
using System.Windows;
using TiendaArreglos.Client.Wpf.Serialization;

namespace TiendaArreglos.Client.Wpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string tiendaArreglosConfigPath = @"Config\TiendaArreglosConfig.xml";

        public MainWindow()
        {
            InitializeComponent();
            InitializeFocus();
        }

        private void InitializeFocus()
        {
            NumberOfTicketsToPrintTextBox.Focus();
        }

        private void TestSerializeButton_Click(object sender, RoutedEventArgs e)
        {
            ISerializer<TiendaArreglosConfig> serializer = new SerializerBase<TiendaArreglosConfig>();
            TiendaArreglosConfig tiendaArreglosConfig = serializer.DeserializeObject(tiendaArreglosConfigPath);

            tiendaArreglosConfig.LastPrintedNumber++;

            serializer.SerializeObject(tiendaArreglosConfig, tiendaArreglosConfigPath);
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Printed!");
        }
    }
}