using System;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Reserver
{
    public partial class SlotReservation : UserControl
    {
        new public Reserver ParentForm { get; set; }

        public SlotReservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.info;
            popup.ImagePadding = new Padding(10);
            popup.ContentPadding = new Padding(10);
            popup.TitlePadding = new Padding(10);
            popup.TitleText = "Test prenotazioni";
            popup.ContentText = "Il tuo slot per rilasciare è ora disponibile per i prossimi minuti";
            popup.Popup();
        }
    }
}
