using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InformationSecurity.UI.General
{
    public partial class frmMainSystem : Form
    {
        public frmMainSystem()
        {
            InitializeComponent();
            LoadEvents();
        }

        /// <summary>
        /// Метод загрузки списка мероприятий в таблицу
        /// </summary>
        private void LoadEvents()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    sqlConnection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("GetEvents", sqlConnection))
                    {
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        dgvEvents.DataSource = dataTable;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загузить список мероприятий", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик события перехода на окно авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuth_Click(object sender, EventArgs e)
        {
            frmAuthorization frmAuthorization = new frmAuthorization();
            frmAuthorization.Show();
            this.Hide();
        }

        /// <summary>
        /// Обработчик события фильтрации по направлению
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDirection.SelectedIndex == 0)
            {
                LoadEvents();
            }
            else
            {
                (dgvEvents.DataSource as DataTable).DefaultView.RowFilter = $"Направление LIKE '%{cboDirection.SelectedItem}'";
            }
        }

        /// <summary>
        /// Обработчик события фильтрации по дате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpEventDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = dgvEvents.DataSource as DataTable;

            if (dt != null)
            {
                string formattedDate = dtpEventDate.Value.ToString("yyyy-MM-dd");
                string filterExpression = $"[Дата] = #{formattedDate}#";

                dt.DefaultView.RowFilter = filterExpression;
            }
        }
    }

}
