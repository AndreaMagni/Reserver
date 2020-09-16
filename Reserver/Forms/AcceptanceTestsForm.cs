using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Reserver.Forms
{
    public partial class AcceptanceTestsForm : Form
    {
        Reserver reserverForm;

        public AcceptanceTestsForm()
        {
            InitializeComponent();
            metroComboBoxStartHour.SelectedIndex = 0;
            metroComboBoxEndHour.SelectedIndex = metroComboBoxEndHour.Items.Count - 1;
            AcceptanceTestsServers_Load();
            AcceptanceTests_Load();
        }

        public AcceptanceTestsForm(Reserver form)
        {
            InitializeComponent();
            reserverForm = form;
            metroComboBoxStartHour.SelectedIndex = 0;
            metroComboBoxEndHour.SelectedIndex = metroComboBoxEndHour.Items.Count - 1;
            AcceptanceTestsServers_Load();
            AcceptanceTests_Load();
        }

        private void AcceptanceTestsServers_Load()
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
                        //row[1] = "Please select";
                        dataTableServerList.Rows.InsertAt(rowServerList, 0);

                        metroComboBoxServers.DataSource = dataTableServerList;
                        metroComboBoxServers.DisplayMember = "descrizione";
                        metroComboBoxServers.ValueMember = "idserver";
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

        private void AcceptanceTests_Load()
        {
            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (FbDataAdapter dataAdapterGrid = new FbDataAdapter(@"
                        select 
                            s.DESCRIZIONE as Ambiente, 
                            u.DENOMINAZIONE as Utente, 
                            c.DESCRIZIONE, 
                            c.INIZIOCOLLAUDO as Inizio, 
                            c.FINECOLLAUDO as Fine
                        from collaudi c
                        join servers s on s.IDSERVER = c.IDSERVER
                        join utenti u on u.IDUTENTE = c.IDUTENTE
                        order by c.INIZIOCOLLAUDO DESC", connection))
                    {
                        DataTable dataTableGrid = new DataTable();
                        dataAdapterGrid.Fill(dataTableGrid);
                        metroGridAcceptanceTests.DataSource = dataTableGrid;
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    if (!CheckInsertingInformations())
                    {
                        MessageBox.Show("Dati inseriti non congrui o mancanti.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        connection.Open();
                        string queryInsertNewAcceptanceTest = string.Format(@"INSERT INTO COLLAUDI(IDSERVER, IDUTENTE, INIZIOCOLLAUDO, FINECOLLAUDO, STATO, DESCRIZIONE, DATAINSERIMENTO)
                        VALUES({0}, {1}, '{2}', '{3}', 'INSERITO', '{4}', CURRENT_TIMESTAMP)",
                            metroComboBoxServers.SelectedValue,
                            reserverForm.CurrentUserID,
                            (metroDateTimeStartDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxStartHour.Text + ":00").ToString(),
                            (metroDateTimeEndDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxEndHour.Text + ":00").ToString(),
                            metroTextBoxAcceptanceTestDescription.Text);
                        FbCommand insertNewAcceptanceTest = new FbCommand(queryInsertNewAcceptanceTest, connection);
                        insertNewAcceptanceTest.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Richiesta al database fallita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    connection.Close();
                    this.AcceptanceTestsServers_Load();
                    this.AcceptanceTests_Load();
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
            if (DateTime.Parse(metroDateTimeStartDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxStartHour.Text + ":00") >=
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

        private void GridAcceptanceTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = metroGridAcceptanceTests.CurrentCell.RowIndex;
            string gridValue = metroGridAcceptanceTests.CurrentCell.Value.ToString();
            string idCollaudo = metroGridAcceptanceTests.Rows[selectedRow].Cells[1].Value.ToString();
            //metroGridAcceptanceTests.Rows.RemoveAt(selectedRow);
            //DataGridViewRow row = metroGridAcceptanceTests.Rows[selectedRow];

            switch (gridValue)
            {
                case "Concludi":
                    using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
                    {
                        try
                        {
                            connection.Open();
                            //Fixare e decidere come impostare i vari tasti
                            // Creare tasto che chiede se si vuole concludere il collaudo (se la persona è quella che l'ha creato) e rispetto a yes / no update 
                            string queryUpdateServerStatus = string.Format(@"UPDATE COLLAUDI SET STATO = 'OCCUPATO', IDUTENTE = {0} WHERE IDSERVER = {1}", reserverForm.CurrentUserID, 1);
                            FbCommand updateServerStatus = new FbCommand(queryUpdateServerStatus, connection);
                            updateServerStatus.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Richiesta al database fallita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    break;

                default:
                    break;
            }
        }


    }
}
