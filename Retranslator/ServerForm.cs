using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Retranslator
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        public void DrawStantionList(List<OrderSchemePair> OrderSchemePairs)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.StantionListBox.Items.Clear();
                this.StantionListBox.Items.AddRange(OrderSchemePairs.SelectMany(pair =>
                   new[] { pair.Station1, pair.Station2 })
                   .Where(s => s != null)
                   .Select(s => s.Id + " " + (s.Signal != null ? s.Signal.Frequency.ToString()  : "empty signal"))
                   .ToArray());
            });
        }
    }
}
