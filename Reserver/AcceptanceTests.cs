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
    public partial class AcceptanceTests : UserControl
    {
        new public Reserver ParentForm { get; set; }

        public AcceptanceTests()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndex = 0;
            metroComboBox3.SelectedIndex = 0;
            metroComboBox5.SelectedIndex = 0;
            metroComboBox7.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = metroComboBox2.Items.Count - 1;
            metroComboBox4.SelectedIndex = metroComboBox4.Items.Count - 1;
            metroComboBox6.SelectedIndex = metroComboBox6.Items.Count - 1;
            metroComboBox8.SelectedIndex = metroComboBox8.Items.Count - 1;
        }
    }
}
