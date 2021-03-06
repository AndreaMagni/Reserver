﻿using FirebirdSql.Data.FirebirdClient;
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
                        dataTableServerList.Rows.InsertAt(rowServerList, 0);

                        metroComboBoxServers.DataSource = dataTableServerList;
                        metroComboBoxServers.DisplayMember = "descrizione";
                        metroComboBoxServers.ValueMember = "idserver";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita", "Errore di comunicazione con il server", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore durante il caricamento della pagina di collaudo.", ex.StackTrace.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void AcceptanceTests_Load()
        {
            using (FbConnection connection = new FbConnection(reserverForm.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (FbDataAdapter dataAdapterGrid = new FbDataAdapter(@"
                        select 
                            s.DESCRIZIONE as AMBIENTE, 
                            u.DENOMINAZIONE as UTENTE, 
                            c.DESCRIZIONE, 
                            c.INIZIOCOLLAUDO as DATAINIZIO, 
                            c.FINECOLLAUDO as DATAFINE,
                            c.stato
                        from COLLAUDI c
                        join SERVERS s on s.IDSERVER = c.IDSERVER
                        join UTENTI u on u.IDUTENTE = c.IDUTENTE
                        order by c.INIZIOCOLLAUDO DESC", connection))
                    {
                        DataTable dataTableGrid = new DataTable();
                        dataAdapterGrid.Fill(dataTableGrid);
                        metroGridAcceptanceTests.DataSource = dataTableGrid;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita", "Errore di comunicazione con il server", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore durante il caricamento della pagina di collaudo.", ex.StackTrace.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // ATTENZIONE!! Durante l'inserimento di un nuovo collaudo risulterà in stato ATTIVO. Concluso il collaudo l'operatore andrà a cliccare un bottone?? E lo stato passerà a CONCLUSO
        // Giocare sulle ore presenti nel collaudo e quelle attuali per verificare se è possibile fare un rilascio ad esempio
        // Premendo il bottone rilascio su ASP una query verificherà la presenza di collaudi ATTIVI, in caso di collaudi attivi verificherà allora anche l'orario. 
        // Se rientro nell'oraio di collaudo non potrò rilasciare
        // Se rientro in una fascia di 4 ore prima del collaudo verrò avvisato del colladuo
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
                    else if (!CheckUniqueAcceptanceTest(connection))
                    {
                        MessageBox.Show("Collaudo presente nel range indicato.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        connection.Open();
                        string queryInsertNewAcceptanceTest = string.Format(@"
                            INSERT INTO COLLAUDI(IDSERVER, IDUTENTE, INIZIOCOLLAUDO, FINECOLLAUDO, DESCRIZIONE, DATAINSERIMENTO)
                            VALUES({0}, {1}, '{2}', '{3}', '{4}', CURRENT_TIMESTAMP)",
                            metroComboBoxServers.SelectedValue,
                            reserverForm.CurrentUserID,
                            (metroDateTimeStartDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxStartHour.Text ).ToString(),
                            (metroDateTimeEndDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxEndHour.Text).ToString(),
                            metroTextBoxAcceptanceTestDescription.Text);
                        FbCommand insertNewAcceptanceTest = new FbCommand(queryInsertNewAcceptanceTest, connection);
                        insertNewAcceptanceTest.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita", "Errore di comunicazione con il server", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore.", ex.StackTrace.ToString());
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

        private bool CheckUniqueAcceptanceTest(FbConnection connection)
        {
            bool isOk = false;

            try
            {
                connection.Open();
                string queryCheckUnique = string.Format(@"
                SELECT count(c.idcollaudo)
                FROM collaudi c 
                WHERE c.idserver = {0}
                    AND (c.iniziocollaudo BETWEEN '{1}' AND '{2}'
                    OR c.finecollaudo BETWEEN '{1}' AND '{2}')",
                    metroComboBoxServers.SelectedValue,
                    (metroDateTimeStartDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxStartHour.Text).ToString(),
                    (metroDateTimeEndDate.Value.Date.ToString("dd.MM.yyyy ") + metroComboBoxEndHour.Text).ToString());
                FbCommand checkUnique = new FbCommand(queryCheckUnique, connection);
                isOk = (int)checkUnique.ExecuteScalar() == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Richiesta fallita", "Errore di comunicazione con il server", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Logger.LogStack("Errore.", ex.StackTrace.ToString());
            }
            finally
            {
                connection.Close();
            }

            return isOk;
        }
    }
}
