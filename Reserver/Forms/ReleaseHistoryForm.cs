using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
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
                        dataTableServerList.Rows.InsertAt(rowServerList, 0);

                        comboBoxUsers.DataSource = dataTableServerList;
                        comboBoxUsers.DisplayMember = "denominazione";
                        comboBoxUsers.ValueMember = "idutente";
                    }
                    ReleaseHistoryGrid_Load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore.", ex.StackTrace.ToString());
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
                    /*
                     * string 
                    connection.Open();
                    using (FbDataAdapter dataAdapterGrid = new FbDataAdapter(@"
                        SELECT s.descrizione AS ambiente, u.denominazione AS utente, sr.datainizio, sr.datafine
                        FROM storicorilasci sr 
                        JOIN servers s ON s.idserver = sr.idserver
                        JOIN utenti u ON u.idutente = sr.idutente
                        WHERE sr.datainizio > '{0}'
                        ORDER BY sr.datainizio DESC, sr.datafine NULLS FIRST", "02-02-2021", connection))
                    {
                        dataTableGrid = new DataTable();
                        dataAdapterGrid.Fill(dataTableGrid);
                        gridReleaseHistory.DataSource = dataTableGrid;
                    }
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Richiesta fallita.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Logger.LogStack("Errore.", ex.StackTrace.ToString());
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
                    filtro = "utente = '" + comboBoxUsers.Text + "'";
                    filtro = filtro + " AND datainizio >= '" + dateTimeDa.Text + "' AND datafine <= '" + Convert.ToDateTime(dateTimeA.Text).AddDays(1) + "'";
                }
                else
                {
                    filtro = " datainizio >= '" + dateTimeDa.Text + "' AND datafine <= '" + Convert.ToDateTime(dateTimeA.Text).AddDays(1) + "'";
                }
            }
            else
            {
                filtro = "ambiente = '" + comboBoxServers.Text + "'";
                if (!comboBoxUsers.Text.Equals(""))
                {
                    filtro = filtro + " AND utente = '" + comboBoxUsers.Text + "'";
                }
                filtro = filtro + " AND datainizio >= '" + dateTimeDa.Text + "' AND datafine <= '" + Convert.ToDateTime(dateTimeA.Text).AddDays(1) + "'";
            }
            dataTableGrid.DefaultView.RowFilter = filtro;
            dataTableGrid.DefaultView.Sort = "datainizio DESC";
        }
    }

    /*
    public class myGroupBox : GroupBox
    {
        private Color borderColor;

        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }

        public myGroupBox()
        {
            this.borderColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Size tSize = TextRenderer.MeasureText(this.Text, this.Font);
            Rectangle borderRect = e.ClipRectangle;
            borderRect.Y += tSize.Height / 2;
            borderRect.Height -= tSize.Height / 2;
            ControlPaint.DrawBorder(e.Graphics, borderRect, this.borderColor, ButtonBorderStyle.Solid);

            Rectangle textRect = e.ClipRectangle;
            textRect.X += 6;
            textRect.Width = tSize.Width;
            textRect.Height = tSize.Height;

            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
        }
    }
    */

}