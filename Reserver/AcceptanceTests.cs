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
using Microsoft.SqlServer.Server;
using System.Globalization;
using System.CodeDom;

namespace Reserver
{
    public partial class AcceptanceTests : UserControl
    {
        new public Reserver ParentForm { get; set; }

        public AcceptanceTests()
        {
            InitializeComponent();
            metroComboBoxStartHour.SelectedIndex = 0;
            metroComboBoxEndHour.SelectedIndex = metroComboBoxEndHour.Items.Count - 1;
        }

        private void AcceptanceTests_Enter(object sender, EventArgs e)
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
                        //row[1] = "Please select";
                        dataTableServerList.Rows.InsertAt(rowServerList, 0);

                        metroComboBoxServers.DataSource = dataTableServerList;
                        metroComboBoxServers.DisplayMember = "descrizione";
                        metroComboBoxServers.ValueMember = "idserver";
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

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
            {
                try
                {
                    if (!CheckInsertingInformations())
                    {
                        MessageBox.Show("Dati inseriti non congrui o mancanti.", "Dati errati", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        connection.Open();
                        string queryInsertNewAcceptanceTest = string.Format(@"INSERT INTO COLLAUDI(IDSERVER, IDUTENTE, INIZIOCOLLAUDO, FINECOLLAUDO, STATO, DESCRIZIONE, DATAINSERIMENTO)
                        VALUES({0}, {1}, '{2}', '{3}', 'INSERITO', '{4}', CURRENT_TIMESTAMP)",
                            metroComboBoxServers.SelectedValue,
                            ParentForm.CurrentUserID,
                            (metroDateTimeStartDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxStartHour.Text + ":00").ToString(),
                            (metroDateTimeEndDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxEndHour.Text + ":00").ToString(),
                            metroTextBoxAcceptanceTestDescription.Text);
                        FbCommand insertNewAcceptanceTest = new FbCommand(queryInsertNewAcceptanceTest, connection);
                        insertNewAcceptanceTest.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore DB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                finally
                {
                    connection.Close();
                    this.AcceptanceTests_Enter(sender, e);
                    this.AcceptanceTests_Load(sender, e);
                    metroTextBoxAcceptanceTestDescription.Text = null;
                    metroDateTimeStartDate.Value = DateTime.Now;
                    metroDateTimeEndDate.Value = DateTime.Now;
                    metroComboBoxStartHour.SelectedIndex = 0;
                    metroComboBoxEndHour.SelectedIndex = metroComboBoxEndHour.Items.Count - 1;
                }
            }
        }

        private bool CheckInsertingInformations()
        {
            if (metroComboBoxServers.SelectedValue.Equals(0))
            {
                return false;
            }
            if (DateTime.Parse(metroDateTimeStartDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxStartHour.Text+ ":00") >=
                DateTime.Parse(metroDateTimeEndDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxEndHour.Text + ":00"))
            {
                return false;
            }
            if (DateTime.Parse(metroDateTimeStartDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxStartHour.Text + ":00") < DateTime.Now ||
                DateTime.Parse(metroDateTimeEndDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxEndHour.Text + ":00") < DateTime.Now)
            {
                return false;
            }
            return true;
        }

        private void AcceptanceTests_Load(object sender, EventArgs e)
        {
            using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (FbDataAdapter dataAdapterGrid = new FbDataAdapter(@"
                        select s.DESCRIZIONE as Ambiente, 
                            c.DESCRIZIONE, 
                            c.INIZIOCOLLAUDO as inizio_collaudo, 
                            c.FINECOLLAUDO as fine_collaudo, 
                            u.DENOMINAZIONE as Utente_inserimento, 
                            c.STATO
                        from collaudi c
                        join servers s on s.IDSERVER = c.IDSERVER
                        join utenti u on u.IDUTENTE = c.IDUTENTE
                        where c.STATO != 'ANNULLATO'
                        and c.FINECOLLAUDO > CURRENT_TIMESTAMP
                        order by c.INIZIOCOLLAUDO ASC", connection))
                    {
                        DataTable dataTableGrid = new DataTable();
                        dataAdapterGrid.Fill(dataTableGrid);
                        metroGridAcceptanceTests.DataSource = dataTableGrid;
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

        private void metroGridAcceptanceTests_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                this.metroGridAcceptanceTests[e.RowIndex,e.ColumnIndex].ReadOnly = false;
                DataGridViewCell cell = metroGridAcceptanceTests.Rows[e.RowIndex].Cells[e.ColumnIndex];
                metroGridAcceptanceTests.CurrentCell = cell;
                metroGridAcceptanceTests.BeginEdit(true);
            }
        }

        private void metroGridAcceptanceTests_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                using (FbConnection connection = new FbConnection(ParentForm.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string queryUpdateStateAcceptanceTest = string.Format(@"update collaudi set stato = {0} where idcollaudo = {1}",
                            metroGridAcceptanceTests[e.RowIndex, e.ColumnIndex].Value,
                            metroGridAcceptanceTests[e.RowIndex, 0].Value);
                        FbCommand updateStateAcceptanceTest = new FbCommand(queryUpdateStateAcceptanceTest, connection);
                        updateStateAcceptanceTest.ExecuteNonQuery();
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
        }
    }
}
