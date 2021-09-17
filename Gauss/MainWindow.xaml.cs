﻿using System;
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
        int equationsNumber = 0;
        int variablesNumber = 0;
        List<int> list;
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i < 16; i++)
            {
                VariablesNumber.Items.Add(i);
                EquationsNumber.Items.Add(i);
                Matrix.ShowGridLines = true;
                list = new List<int>();
            }
        }

        private void AddRows(object sender, SelectionChangedEventArgs e)
        {
            Matrix.RowDefinitions.Clear();
            equationsNumber = int.Parse(EquationsNumber.SelectedItem.ToString());
            for (int i = 0; i <= equationsNumber; i++)
                Matrix.RowDefinitions.Add(new RowDefinition());
            AddTextFields();
        }

        private void AddColumns(object sender, SelectionChangedEventArgs e)
        {
            Matrix.ColumnDefinitions.Clear();
            variablesNumber = Int32.Parse(VariablesNumber.SelectedItem.ToString());
            for (int i = 0; i <= variablesNumber; i++)
                Matrix.ColumnDefinitions.Add(new ColumnDefinition());
            AddHeaders();
            AddTextFields();
            AddButtons();
        }
        private void AddHeaders()
        {
            if (Matrix.ColumnDefinitions.Count == 0 || Matrix.ColumnDefinitions.Count == 0)
                return;

            for (int i = 1; i <= variablesNumber; i++)
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = "X" + i
                };
                Grid.SetRow(textBlock, 0);
                Grid.SetColumn(textBlock, i - 1);
                Matrix.Children.Add(textBlock);
            }

            TextBlock anotherTextBlock = new TextBlock
            {
                Text = "b"
            };
            Grid.SetRow(anotherTextBlock, 0);
            Grid.SetColumn(anotherTextBlock, variablesNumber);
            Matrix.Children.Add(anotherTextBlock);
        }

        private void AddTextFields()
        {
            if (Matrix.ColumnDefinitions.Count == 0 || Matrix.ColumnDefinitions.Count == 0)
                return;
            for (int i = 0; i <= variablesNumber; i++)
            {
                for (int j = 1; j <= equationsNumber; j++) {
                    TextBox textBox = new TextBox
                    {
                        Text = "0"
                    };
                    Grid.SetColumn(textBox, i);
                    Grid.SetRow(textBox, j);
                    Matrix.Children.Add(textBox);
                }
            }
        }

        private void AddButtons()
        {
            list.Clear();
            LabelOfColumns.Content = "";
            ColumnsList.Height = variablesNumber * 25;
            ColumnsList.RowDefinitions.Clear();
            ColumnsList.ColumnDefinitions.Clear();
            ColumnsList.ColumnDefinitions.Add(new ColumnDefinition());
            for (int i = 0; i < variablesNumber; i++)
            {
                ColumnsList.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 1; i <= variablesNumber; i++)
            {
                Button button = new Button
                {
                    Content = i
                };
                button.Click += ChooseColumn;
                Grid.SetColumn(button, 0);
                Grid.SetRow(button, i - 1);
                ColumnsList.Children.Add(button);
            }
        }

        private void ChooseColumn(object sender, EventArgs e)
        {
            ((Button)sender).IsEnabled = false;
            int a = int.Parse(((Button)sender).Content.ToString());
            list.Add(a);
            if (list.Count == equationsNumber) {
                foreach (Button button in ColumnsList.Children)
                {
                    button.IsEnabled = false;
                }
            }
            LabelOfColumns.Content += a + " ";
        }
    }
}
