namespace Синаптик
{
    partial class FormWebsite_Development
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelDesign = new System.Windows.Forms.Label();
            this.listViewDevelopment = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxPrototip = new System.Windows.Forms.ComboBox();
            this.labelPrototip = new System.Windows.Forms.Label();
            this.labelSites = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDesign = new System.Windows.Forms.ComboBox();
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.comboBoxVerstka = new System.Windows.Forms.ComboBox();
            this.comboBoxMarketing = new System.Windows.Forms.ComboBox();
            this.labelVerstka = new System.Windows.Forms.Label();
            this.labelMarceting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Artico Soft Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(335, 288);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 38);
            this.buttonAdd.TabIndex = 94;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Artico Soft Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(495, 288);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(130, 38);
            this.buttonEdit.TabIndex = 93;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Artico Soft Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(655, 288);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(130, 38);
            this.buttonDel.TabIndex = 92;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelDesign
            // 
            this.labelDesign.AutoSize = true;
            this.labelDesign.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelDesign.Location = new System.Drawing.Point(25, 115);
            this.labelDesign.Name = "labelDesign";
            this.labelDesign.Size = new System.Drawing.Size(54, 17);
            this.labelDesign.TabIndex = 91;
            this.labelDesign.Text = "Дизайн";
            // 
            // listViewDevelopment
            // 
            this.listViewDevelopment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDevelopment.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.listViewDevelopment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewDevelopment.FullRowSelect = true;
            this.listViewDevelopment.GridLines = true;
            this.listViewDevelopment.Location = new System.Drawing.Point(223, 36);
            this.listViewDevelopment.Margin = new System.Windows.Forms.Padding(15);
            this.listViewDevelopment.MultiSelect = false;
            this.listViewDevelopment.Name = "listViewDevelopment";
            this.listViewDevelopment.Size = new System.Drawing.Size(562, 222);
            this.listViewDevelopment.TabIndex = 90;
            this.listViewDevelopment.UseCompatibleStateImageBehavior = false;
            this.listViewDevelopment.View = System.Windows.Forms.View.Details;
            this.listViewDevelopment.SelectedIndexChanged += new System.EventHandler(this.listViewDevelopment_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id заказа";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Прототипирование";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Дизайн";
            this.columnHeader8.Width = 94;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Верстка";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Продвижение";
            this.columnHeader2.Width = 109;
            // 
            // comboBoxPrototip
            // 
            this.comboBoxPrototip.FormattingEnabled = true;
            this.comboBoxPrototip.Items.AddRange(new object[] {
            "Сделано",
            "Не сделано"});
            this.comboBoxPrototip.Location = new System.Drawing.Point(28, 87);
            this.comboBoxPrototip.Name = "comboBoxPrototip";
            this.comboBoxPrototip.Size = new System.Drawing.Size(168, 21);
            this.comboBoxPrototip.TabIndex = 89;
            // 
            // labelPrototip
            // 
            this.labelPrototip.AutoSize = true;
            this.labelPrototip.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelPrototip.Location = new System.Drawing.Point(25, 66);
            this.labelPrototip.Name = "labelPrototip";
            this.labelPrototip.Size = new System.Drawing.Size(125, 17);
            this.labelPrototip.TabIndex = 88;
            this.labelPrototip.Text = "Прототипирование";
            // 
            // labelSites
            // 
            this.labelSites.AutoSize = true;
            this.labelSites.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelSites.Location = new System.Drawing.Point(25, 16);
            this.labelSites.Name = "labelSites";
            this.labelSites.Size = new System.Drawing.Size(113, 17);
            this.labelSites.TabIndex = 87;
            this.labelSites.Text = "Заказанный сайт";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Синаптик.Properties.Resources._627eb394_3c83_4c73_a1a3_fec1724eda3e;
            this.pictureBox1.Location = new System.Drawing.Point(28, 288);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDesign
            // 
            this.comboBoxDesign.FormattingEnabled = true;
            this.comboBoxDesign.Items.AddRange(new object[] {
            "Сделано",
            "Не сделано"});
            this.comboBoxDesign.Location = new System.Drawing.Point(28, 136);
            this.comboBoxDesign.Name = "comboBoxDesign";
            this.comboBoxDesign.Size = new System.Drawing.Size(168, 21);
            this.comboBoxDesign.TabIndex = 96;
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Items.AddRange(new object[] {
            "Многостраничный",
            "Лендинг"});
            this.comboBoxSites.Location = new System.Drawing.Point(28, 36);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(168, 21);
            this.comboBoxSites.TabIndex = 97;
            this.comboBoxSites.SelectedIndexChanged += new System.EventHandler(this.comboBoxSites_SelectedIndexChanged);
            // 
            // comboBoxVerstka
            // 
            this.comboBoxVerstka.FormattingEnabled = true;
            this.comboBoxVerstka.Items.AddRange(new object[] {
            "Сделано",
            "Не сделано"});
            this.comboBoxVerstka.Location = new System.Drawing.Point(28, 186);
            this.comboBoxVerstka.Name = "comboBoxVerstka";
            this.comboBoxVerstka.Size = new System.Drawing.Size(168, 21);
            this.comboBoxVerstka.TabIndex = 98;
            // 
            // comboBoxMarketing
            // 
            this.comboBoxMarketing.FormattingEnabled = true;
            this.comboBoxMarketing.Items.AddRange(new object[] {
            "Сделано",
            "Не сделано"});
            this.comboBoxMarketing.Location = new System.Drawing.Point(28, 237);
            this.comboBoxMarketing.Name = "comboBoxMarketing";
            this.comboBoxMarketing.Size = new System.Drawing.Size(168, 21);
            this.comboBoxMarketing.TabIndex = 99;
            // 
            // labelVerstka
            // 
            this.labelVerstka.AutoSize = true;
            this.labelVerstka.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelVerstka.Location = new System.Drawing.Point(25, 165);
            this.labelVerstka.Name = "labelVerstka";
            this.labelVerstka.Size = new System.Drawing.Size(56, 17);
            this.labelVerstka.TabIndex = 100;
            this.labelVerstka.Text = "Верстка";
            this.labelVerstka.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMarceting
            // 
            this.labelMarceting.AutoSize = true;
            this.labelMarceting.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelMarceting.Location = new System.Drawing.Point(25, 216);
            this.labelMarceting.Name = "labelMarceting";
            this.labelMarceting.Size = new System.Drawing.Size(93, 17);
            this.labelMarceting.TabIndex = 101;
            this.labelMarceting.Text = "Продвижение";
            // 
            // FormWebsite_Development
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(809, 350);
            this.Controls.Add(this.labelMarceting);
            this.Controls.Add(this.labelVerstka);
            this.Controls.Add(this.comboBoxMarketing);
            this.Controls.Add(this.comboBoxVerstka);
            this.Controls.Add(this.comboBoxSites);
            this.Controls.Add(this.comboBoxDesign);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.labelDesign);
            this.Controls.Add(this.listViewDevelopment);
            this.Controls.Add(this.comboBoxPrototip);
            this.Controls.Add(this.labelPrototip);
            this.Controls.Add(this.labelSites);
            this.Name = "FormWebsite_Development";
            this.Text = "FormWebsite_Development";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelDesign;
        private System.Windows.Forms.ListView listViewDevelopment;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox comboBoxPrototip;
        private System.Windows.Forms.Label labelPrototip;
        private System.Windows.Forms.Label labelSites;
        private System.Windows.Forms.ComboBox comboBoxDesign;
        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.Windows.Forms.ComboBox comboBoxVerstka;
        private System.Windows.Forms.ComboBox comboBoxMarketing;
        private System.Windows.Forms.Label labelVerstka;
        private System.Windows.Forms.Label labelMarceting;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}