using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Reserver
{
    public partial class ReleaseHistory : UserControl
    {
        new public Reserver ParentForm { get; set; }

        DataTable dataTableGrid;

        public ReleaseHistory()
        {
            InitializeComponent();
        }

        private void GridReleaseHistory_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            string filtro = "";

            if (comboBoxServers.Text.Equals(""))
            {
                if (!comboBoxUsers.Text.Equals(""))
                {
                    filtro = "DENOMINAZIONE = '" + comboBoxUsers.Text + "'";
                }
            }
            else
            {
                filtro = "ambiente = '" + comboBoxServers.Text + "'";
                if (!comboBoxUsers.Text.Equals(""))
                {
                    filtro = filtro + " and DENOMINAZIONE = '" + comboBoxUsers.Text + "'";
                }
            }
            dataTableGrid.DefaultView.RowFilter = filtro;
        }
    }
}
