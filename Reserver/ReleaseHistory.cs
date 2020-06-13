using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserver
{
    public partial class ReleaseHistory : UserControl
    {
        new public Reserver ParentForm { get; set; }

        public ReleaseHistory()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return metroTextBox1.Text; }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            var textBoxContent = this.metroTextBox1.Text;
            //var parent = this.Parent as Reserver;
            //ParentForm.ID = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //metroTextBox1.Text = metroDateTime1.Text;
        }
    }
}
