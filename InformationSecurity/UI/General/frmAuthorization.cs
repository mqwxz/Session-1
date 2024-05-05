using InformationSecurity.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurity.UI.General
{
    public partial class frmAuthorization : Form
    {
        private string word = string.Empty; // Слово из капчи
        private int incorrectAnswer = 0; // Количество неудачных попыток
        private int countTrying = 3; // Количество попыток


        public frmAuthorization()
        {
            InitializeComponent();
            GetData();
        }

        private async void btnAuth_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (login == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.connectionString))
                    {
                        sqlConnection.Open();

                        using (SqlCommand sqlCommand = new SqlCommand("GetUser", sqlConnection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@login", login);
                            sqlCommand.Parameters.AddWithValue("@password", password);

                            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                            {
                                if (sqlDataReader.HasRows && sqlDataReader.Read())
                                {
                                    User.InitializeUser(sqlDataReader);

                                    switch (User.role)
                                    {
                                        // Участник
                                        case 1:

                                            break;
                                        
                                        // Модератор
                                        case 2:

                                            break;

                                        // Организатор
                                        case 3:

                                            break;

                                        // Жюри
                                        case 4:

                                            break;
                                    }
                                }
                                else
                                {
                                    incorrectAnswer++;

                                    if (countTrying > 0)
                                    {
                                        MessageBox.Show($"Неверное имя пользователя или пароль!\n" +
                                            $"Количество попыток: {--countTrying}", "Предупреждение",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                    if (incorrectAnswer == 3)
                                    {
                                        MessageBox.Show("Слишком много неудачных попыток.\n" +
                                            "Доступ будет запрещен на 10 секунд, пожалуйста, подождите!", "Сообщение",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        btnAuth.Enabled = false;
                                        await Task.Delay(10000);
                                        btnAuth.Enabled = true;
                                    }

                                    if (incorrectAnswer > 3)
                                    {
                                        MessageBox.Show("Слишком много неудачных попыток!\n" +
                                        "Необходимо решить капчу, чтобы продолжить работу", "Сообщение",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        btnAuth.Enabled = false;

                                        word = string.Empty;
                                        lblCaptcha.Visible = true;
                                        picCaptcha.Visible = true;
                                        txtCaptcha.Visible = true;
                                        btnCaptcha.Visible = true;
                                        btnRefreshCaptcha.Visible = true;
                                        LoadCaptcha();
                                    }
                                }
                                sqlDataReader.Close();
                            }
                            sqlConnection.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось проверить учетные данные!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Метод получения сохраненных учетных данных
        /// </summary>
        private void GetData()
        {
            Properties.Settings.Default.login = txtLogin.Text.Trim();
            Properties.Settings.Default.password = txtPassword.Text.Trim();
        }

        /// <summary>
        /// Метод сохранения учетных данных
        /// </summary>
        private void SaveData()
        {
            txtLogin.Text = Properties.Settings.Default.login;
            txtPassword.Text = Properties.Settings.Default.password;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Генерация капчи
        /// </summary>
        private void LoadCaptcha()
        {
            // Заполнения слова различными символами
            Random random = new Random();
            string chars = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            for (int i = 0; i < 6; i++)
            {
                word += chars[random.Next(chars.Length)];
            }

            var bitmap = new Bitmap(this.picCaptcha.Width, this.picCaptcha.Height);
            var font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            // Отрисовка шума
            for (int i = 0; i < 2222; i++)
            {
                int x = random.Next(this.picCaptcha.Width);
                int y = random.Next(this.picCaptcha.Height);

                graphics.DrawRectangle(new Pen(Color.Black), x, y, 1, 1);
            }

            // Отрисовка самого слово для капчи
            graphics.DrawString(word.ToString(), font, Brushes.DarkBlue,
                new Point(picCaptcha.Width / 2 - 40, picCaptcha.Height - 50));

            picCaptcha.Image = bitmap;
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            SaveData();
            GetData();
        }

        private void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            word = string.Empty;
            LoadCaptcha();
        }

        private async void btnCaptcha_Click(object sender, EventArgs e)
        {
            if (txtCaptcha.Text == word)
            {

                MessageBox.Show("Капча успешно пройдена.\nМожете продолжать работу",
                    "Сообщение",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAuth.Enabled = true;
                btnCaptcha.Visible = false;
                btnRefreshCaptcha.Visible = false;
                lblCaptcha.Visible = false;
                picCaptcha.Visible = false;
                txtCaptcha.Visible = false;
            }
            else
            {
                MessageBox.Show("Капча не прошла проверку\n" +
                    "Доступ будет запрещен на 10 секунд, пожалуйста, подождите!",
                    "Предупреждение",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAuth.Enabled = false;
                btnCaptcha.Enabled = false;
                btnRefreshCaptcha.Enabled = false;
                await Task.Delay(10000);
                btnAuth.Enabled = true;
                btnCaptcha.Enabled = true;
                btnRefreshCaptcha.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainSystem frmMainSystem = new frmMainSystem();
            frmMainSystem.Show();
            this.Close();
        }
    }
}
