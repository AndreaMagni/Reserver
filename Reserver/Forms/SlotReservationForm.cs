using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserver.Forms
{
    public partial class SlotReservationForm : Form
    {
        Reserver reserverForm;

        public SlotReservationForm()
        {
            InitializeComponent();
        }

        public SlotReservationForm(Reserver form)
        {
            InitializeComponent();
            reserverForm = form;
        }
    }
}
