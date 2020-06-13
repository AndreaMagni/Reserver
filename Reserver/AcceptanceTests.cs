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
        }
    }
}
