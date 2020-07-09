using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ReleaseHistory_Enter(object sender, EventArgs e)
        {
            using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (FbDataAdapter dataAdapterServerList = new FbDataAdapter("SELECT idserver, descrizione FROM servers", connection))
                    {
                        DataTable dataTableServerList = new DataTable();
                        dataAdapterServerList.Fill(dataTableServerList);

                        DataRow rowServerList = dataTableServerList.NewRow();
                        rowServerList[0] = 0;
                        dataTableServerList.Rows.InsertAt(rowServerList, 0);

                        metroComboBoxServers.DataSource = dataTableServerList;
                        metroComboBoxServers.DisplayMember = "descrizione";
                        metroComboBoxServers.ValueMember = "idserver";
                    }

                    using (FbDataAdapter dataAdapterServerList = new FbDataAdapter("SELECT idutente, denominazione FROM utenti", connection))
                    {
                        DataTable dataTableServerList = new DataTable();
                        dataAdapterServerList.Fill(dataTableServerList);

                        DataRow rowServerList = dataTableServerList.NewRow();
                        rowServerList[0] = 0;
                        //row[1] = "Please select";
                        dataTableServerList.Rows.InsertAt(rowServerList, 0);

                        metroComboBoxUsers.DataSource = dataTableServerList;
                        metroComboBoxUsers.DisplayMember = "denominazione";
                        metroComboBoxUsers.ValueMember = "idutente";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore DB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void metroGridReleaseHistory_Load(object sender, EventArgs e)
        {
            using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (FbDataAdapter dataAdapterGrid = new FbDataAdapter(@"
                        select s.DESCRIZIONE as Ambiente, sr.DESCRIZIONE, u.DENOMINAZIONE, sr.DATAINIZIO, sr.DATAFINE
                        from STORICORILASCI sr 
                        join SERVERS s on s.IDSERVER = sr.IDSERVER
                        join utenti u on u.IDUTENTE = sr.IDUTENTE
                        order by sr.DATAFINE nulls first, sr.DATAINIZIO desc", connection))
                    {
                        dataTableGrid = new DataTable();
                        dataAdapterGrid.Fill(dataTableGrid);
                        metroGridReleaseHistory.DataSource = dataTableGrid;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore DB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void metroButtonFilter_Click(object sender, EventArgs e)
        {
            string filtro = "";

            if (metroComboBoxServers.Text.Equals(""))
            {
                if (!metroComboBoxUsers.Text.Equals(""))
                {
                    filtro = "DENOMINAZIONE = '" + metroComboBoxUsers.Text + "'";
                }
            }
            else
            {
                filtro = "ambiente = '" + metroComboBoxServers.Text + "'";
                if (!metroComboBoxUsers.Text.Equals(""))
                {
                    filtro = filtro + " and DENOMINAZIONE = '" + metroComboBoxUsers.Text + "'";
                }
            }
            dataTableGrid.DefaultView.RowFilter = filtro;
        }
    }
}
