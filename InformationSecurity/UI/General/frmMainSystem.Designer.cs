namespace InformationSecurity.UI.General
{
    partial class frmMainSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnAuth = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.cboDirection = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Turquoise;
            this.pnlTop.Controls.Add(this.lblName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(821, 45);
            this.pnlTop.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(286, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(250, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Информационная безопасность";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Turquoise;
            this.pnlBottom.Controls.Add(this.btnAuth);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 386);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(821, 96);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnAuth
            // 
            this.btnAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuth.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Location = new System.Drawing.Point(640, 50);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(178, 43);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "Авторизация";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.dtpEventDate);
            this.pnlLeft.Controls.Add(this.cboDirection);
            this.pnlLeft.Controls.Add(this.lblEvent);
            this.pnlLeft.Controls.Add(this.dgvEvents);
            this.pnlLeft.Location = new System.Drawing.Point(0, 45);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(535, 341);
            this.pnlLeft.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фильтрация по дате";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фильтрация по направлению";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventDate.Location = new System.Drawing.Point(317, 288);
            this.dtpEventDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(215, 30);
            this.dtpEventDate.TabIndex = 5;
            this.dtpEventDate.ValueChanged += new System.EventHandler(this.dtpEventDate_ValueChanged);
            // 
            // cboDirection
            // 
            this.cboDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboDirection.DropDownHeight = 80;
            this.cboDirection.FormattingEnabled = true;
            this.cboDirection.IntegralHeight = false;
            this.cboDirection.Items.AddRange(new object[] {
            "Без фильтрации",
            "Сильный бизнес-тренер",
            "Анализ и моделироавние бизнес-процессов",
            "Сила лидера",
            "Обзор моделей",
            "Обзор стандартов",
            "Методологии",
            "Ваши позиции в рейтинге",
            "Властелин дедлайнов",
            "Must Have 21 века",
            "Включи в работу весь офис",
            "Авторские анонсы",
            "Свобода обучать",
            "Корпоративное обучение",
            "Обучение персонала",
            "Стратегические силы компании",
            "Подготовка проекта",
            "Золотой актив",
            "Скандальный суперпартнер",
            "Основы блокчейн",
            "Секреты",
            "Безопасность",
            "Осознанность личных целей",
            "Soft skills",
            "Развитие проактивности",
            "Идельный результат",
            "Тайны и секреты",
            "Рычаги",
            "Войти в ТОП",
            "Секреты продвижения",
            "Руководство проектами"});
            this.cboDirection.Location = new System.Drawing.Point(3, 288);
            this.cboDirection.Name = "cboDirection";
            this.cboDirection.Size = new System.Drawing.Size(308, 31);
            this.cboDirection.TabIndex = 4;
            this.cboDirection.SelectedIndexChanged += new System.EventHandler(this.cboDirection_SelectedIndexChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(192, 3);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(173, 23);
            this.lblEvent.TabIndex = 3;
            this.lblEvent.Text = "Список мероприятий";
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.AllowUserToResizeColumns = false;
            this.dgvEvents.AllowUserToResizeRows = false;
            this.dgvEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(3, 29);
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.Size = new System.Drawing.Size(529, 230);
            this.dgvEvents.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.picLogo);
            this.pnlRight.Controls.Add(this.lblLogo);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(535, 45);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(286, 341);
            this.pnlRight.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(3, 29);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(280, 230);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(108, 3);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(76, 23);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Логотип";
            // 
            // frmMainSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 482);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(837, 521);
            this.Name = "frmMainSystem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно системы";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ComboBox cboDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Label label2;
    }
}