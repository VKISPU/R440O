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

namespace RetranslatorWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Tuple<Stantion, Stantion>> stations = new List<Tuple<Stantion, Stantion>>();
            Stantion st1 = new Stantion();
            Stantion st2 = new Stantion();

            
            


            stations.Add(new Tuple<Stantion, Stantion>(st1, st2));
            stations.Add(new Tuple<Stantion, Stantion>(st1, st2));
            stations.Add(new Tuple<Stantion, Stantion>(st1, st2));

            int i = 0;
           
            foreach (Tuple<Stantion,Stantion> pair in stations)
            {
                StackPanel sp = new StackPanel() { Height = 100, Orientation = Orientation.Horizontal, Margin = new Thickness(10) };
                sp.SetValue(WidthProperty, list.Width);
                list.Items.Add(sp);
                Button station1 = new Button() { Content = "Станция " + ++i, FontSize = 20,Width = 250 };
                sp.Children.Add(station1);
                Brush br = Brushes.LightGreen;
                if (i==3)
                {
                    br = Brushes.DarkGray;
                }
              
                Line line = new Line() { X1 = 0, X2 = 160, Y1 = 50, Y2 = 50, Width = 160, StrokeThickness = 10, Stroke = br, StrokeDashArray = { 0.5, 0.5 }, StrokeDashOffset = 1, StrokeMiterLimit = 1, StrokeDashCap = PenLineCap.Triangle };
                i++;
                sp.Children.Add(line);
                Button station2 = new Button() { Content = "Станция " + i,FontSize = 20, Width = 250 };
                sp.Children.Add(station2);



            }
           



        }
    }
}
