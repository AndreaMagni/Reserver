using FirebirdSql.Data.FirebirdClient;
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
    public partial class ReleaseHistoryForm : Form
    {
        Reserver reserverForm;
        DataTable dataTableGrid;

        public ReleaseHistoryForm()
        {
            InitializeComponent();
            ReleaseHistoryForm_Load();
        }

        public ReleaseHistoryForm(Reserver form)
        {
            InitializeComponent();
            reserverForm = form;
            ReleaseHistoryForm_Load();
        }

        private void ReleaseHistoryForm_Load()
        {
            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
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

                        comboBoxServers.DataSource = dataTableServerList;
                        comboBoxServers.DisplayMember = "descrizione";
                        comboBoxServers.ValueMember = "idserver";
                    }

                    using (FbDataAdapter dataAdapterServerList = new FbDataAdapter("SELECT idutente, denominazione FROM utenti", connection))
                    {
                        DataTable dataTableServerList = new DataTable();
                        dataAdapterServerList.Fill(dataTableServerList);

                        DataRow rowServerList = dataTableServerList.NewRow();
                        rowServerList[0] = 0;
                        //row[1] = "Please select";
                        dataTableServerList.Rows.InsertAt(rowServerList, 0);

                        comboBoxUsers.DataSource = dataTableServerList;
                        comboBoxUsers.DisplayMember = "denominazione";
                        comboBoxUsers.ValueMember = "idutente";
                    }

                    ReleaseHistoryGrid_Load();
                }
                catch (Exception)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void ReleaseHistoryGrid_Load()
        {
            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (FbDataAdapter dataAdapterGrid = new FbDataAdapter(@"
                        select s.DESCRIZIONE as Ambiente, u.DENOMINAZIONE, sr.DATAINIZIO, sr.DATAFINE
                        from STORICORILASCI sr 
                        join SERVERS s on s.IDSERVER = sr.IDSERVER
                        join utenti u on u.IDUTENTE = sr.IDUTENTE
                        order by sr.DATAFINE nulls first, sr.DATAINIZIO desc", connection))
                    {
                        dataTableGrid = new DataTable();
                        dataAdapterGrid.Fill(dataTableGrid);
                        gridReleaseHistory.DataSource = dataTableGrid;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            string filtro = "";

            if (comboBoxServers.Text.Equals(""))
            {
                if (!comboBoxUsers.Text.Equals(""))
                {
                    filtro = "DENOMINAZIONE = '" + comboBoxUsers.Text + "'";
                    filtro = filtro + "and DATAINIZIO >= '" + dateTimeDa.Text + "' and DATAFINE <= '" + Convert.ToDateTime(dateTimeA.Text).AddDays(1) + "'";
                }
                else
                {
                    filtro = "DATAINIZIO >= '" + dateTimeDa.Text + "' and DATAFINE <= '" + Convert.ToDateTime(dateTimeA.Text).AddDays(1) + "'";
                }
            }
            else
            {
                filtro = "AMBIENTE = '" + comboBoxServers.Text + "'";
                if (!comboBoxUsers.Text.Equals(""))
                {
                    filtro = filtro + " and DENOMINAZIONE = '" + comboBoxUsers.Text + "'";
                }
                filtro = filtro + "and DATAINIZIO >= '" + dateTimeDa.Text + "' and DATAFINE <= '" + Convert.ToDateTime(dateTimeA.Text).AddDays(1) + "'";
            }
            dataTableGrid.DefaultView.RowFilter = filtro;
            dataTableGrid.DefaultView.Sort = "DATAINIZIO desc";
        }

    }
}