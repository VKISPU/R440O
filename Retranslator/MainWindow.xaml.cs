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
using System.Threading;
using System.ComponentModel;

namespace Retranslator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public delegate void ServerHandler();

        private string btnStartServerContent;
        public event PropertyChangedEventHandler PropertyChanged;
        public string BtnStartServerContent
        {
            get { return btnStartServerContent; }
            set { btnStartServerContent = value; }
        }
        public MainWindow()
        {
            BtnStartServerContent = "Запустить";
            InitializeComponent();
            this.DataContext = this;

        }
        private void RunServerExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (Server.isServerRun)
            {
                BtnStartServerContent = "Запустить";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BtnStartServerContent"));

            }
            else
            {
                MessageBox.Show("chlen1");
                ServerHandler handler = new ServerHandler(Server.AsynchronousSocketListener.StartListening);

                IAsyncResult resultObj = handler.BeginInvoke(null, null);
                BtnStartServerContent = "Остановить";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BtnStartServerContent"));
                MessageBox.Show("chlen2");
            }            
        }

    }
    public class WindowCommands
    {
        static WindowCommands()
        {
            RunServer = new RoutedCommand("RunServer", typeof(MainWindow));
        }
        public static RoutedCommand RunServer { get; set; }

        
    }
    
}
