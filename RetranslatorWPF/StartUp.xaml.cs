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
using System.Windows.Shapes;

namespace RetranslatorWPF
{
    /// <summary>
    /// Логика взаимодействия для StartUp.xaml
    /// </summary>
    public partial class StartUp : Window
    {
        List<int> stations;
        StackPanel pair;
        List<int> employed;
        List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();

        public StartUp()
        {
            InitializeComponent();
            // Убрать, как только добавлю подключение станции
            stations = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            employed = new List<int>();
        }

        //TODO Добавить прогрессбар без прогреса, ожидание серверов
        //TODO В комбобохе должны отображдаться только подключённые станции, а не все
        private void Add_Pair(object sender, RoutedEventArgs e)
        {         
            pair = new StackPanel() { Orientation = Orientation.Horizontal };

            ComboBox station1 = new ComboBox() { Width = 150 };
            ComboBox station2 = new ComboBox() { Width = 150, Margin = new Thickness(233, 0, 0, 0) };

            foreach (int station in stations)
            {
                station1.Items.Add(station);
                station2.Items.Add(station);
            }

            station1.SelectionChanged += ComboBoxValueChange;
            station2.SelectionChanged += ComboBoxValueChange;

            pair.Tag = "pair";
            pair.Children.Add(station1);
            pair.Children.Add(station2);
            satationList.Items.Add(pair);

            addPair.Margin = new Thickness(addPair.Margin.Left, addPair.Margin.Top + 25, addPair.Margin.Right, addPair.Margin.Bottom);
        }

        private void ComboBoxValueChange(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                foreach (int emp in employed)
                {
                    if (emp == (int)e.AddedItems[0])
                    {
                        MessageBox.Show($"Станция с номером {emp} занята");
                        ((ComboBox)sender).SelectedValue = null;
                        return;
                    }
                }

                employed.Add((int)e.AddedItems[0]);
            }
        }

        private void StartRepeater(object sender, RoutedEventArgs e)
        {
            foreach (StackPanel item in satationList.Items)
            {
                if (item.Tag.ToString() == "pair")
                {
                    pairs.Add(new Tuple<int, int>((int)((ComboBox)item.Children[0]).SelectedItem, (int)((ComboBox)item.Children[1]).SelectedItem));
                }
            }
            MainWindow mainWindow = new MainWindow(pairs);
            this.Hide();
            mainWindow.Show();
            this.Close();
        }
    }
}
