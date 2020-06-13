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
    public partial class ServerStatus : UserControl
    {
        new public Reserver ParentForm { get; set; }

        public ServerStatus()
        {
            InitializeComponent();
        }
    }
}
