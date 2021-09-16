using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gauss
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i < 16; i++)
            {
                VariablesNumber.Items.Add(i);
                EquationsNumber.Items.Add(i);
                Matrix.ShowGridLines = true;
            }
        }

        private void AddRows(object sender, SelectionChangedEventArgs e)
        {
            Matrix.RowDefinitions.Clear();
            for (int i = 0; i <= Int32.Parse(EquationsNumber.SelectedItem.ToString()); i++)
                Matrix.RowDefinitions.Add(new RowDefinition());
        }

        private void AddColumns(object sender, SelectionChangedEventArgs e)
        {
            Matrix.ColumnDefinitions.Clear();
            int vars = Int32.Parse(VariablesNumber.SelectedItem.ToString());
            for (int i = 0; i <= vars; i++)
                Matrix.ColumnDefinitions.Add(new ColumnDefinition());
            AddHeaders(vars);
        }
        private void AddHeaders (int headersNumber)
        {
            if (Matrix.ColumnDefinitions.Count == 0)
                return;
            if (Matrix.RowDefinitions.Count != 0)
            {
                for (int i = 1; i <= headersNumber; i++) {
                    TextBlock textBlock = new TextBlock
                    {
                        Text = "X" + i
                    };
                    Grid.SetRow(textBlock, 0);
                    Grid.SetColumn(textBlock, i - 1);
                    Matrix.Children.Add(textBlock);
                }
            }
            TextBlock anotherTextBlock = new TextBlock
            {
                Text = "b"
            };
            Grid.SetRow(anotherTextBlock, 0);
            Grid.SetColumn(anotherTextBlock, headersNumber);
            Matrix.Children.Add(anotherTextBlock);
        }
    }
}
