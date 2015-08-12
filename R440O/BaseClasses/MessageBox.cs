using System.Windows.Forms;

namespace R440O.BaseClasses
{
    public partial class MessageBox : Form
    {
        public MessageBox(string title, string message)
        {
            InitializeComponent();
            this.Text = title;
            Message.Text = message;
        }
    }
}
