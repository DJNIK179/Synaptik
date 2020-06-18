namespace Синаптик
{
    partial class FormDevelopment
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
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.labelDesign = new System.Windows.Forms.Label();
            this.listViewDevelop = new System.Windows.Forms.ListView();
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.labelPrototip = new System.Windows.Forms.Label();
            this.labelSites = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.labelPrise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(25, 37);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(168, 21);
            this.comboBoxClient.TabIndex = 104;
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(25, 137);
            this.comboBoxEmployees.Margin = new System.Windows.Forms.Padding(15);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(168, 21);
            this.comboBoxEmployees.TabIndex = 103;
            // 
            // labelDesign
            // 
            this.labelDesign.AutoSize = true;
            this.labelDesign.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelDesign.Location = new System.Drawing.Point(22, 116);
            this.labelDesign.Name = "labelDesign";
            this.labelDesign.Size = new System.Drawing.Size(75, 17);
            this.labelDesign.TabIndex = 102;
            this.labelDesign.Text = "Сотрудник ";
            // 
            // listViewDevelop
            // 
            this.listViewDevelop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1});
            this.listViewDevelop.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.listViewDevelop.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewDevelop.FullRowSelect = true;
            this.listViewDevelop.GridLines = true;
            this.listViewDevelop.Location = new System.Drawing.Point(220, 37);
            this.listViewDevelop.Margin = new System.Windows.Forms.Padding(15);
            this.listViewDevelop.MultiSelect = false;
            this.listViewDevelop.Name = "listViewDevelop";
            this.listViewDevelop.Size = new System.Drawing.Size(677, 171);
            this.listViewDevelop.TabIndex = 101;
            this.listViewDevelop.UseCompatibleStateImageBehavior = false;
            this.listViewDevelop.View = System.Windows.Forms.View.Details;
            this.listViewDevelop.SelectedIndexChanged += new System.EventHandler(this.listViewDevelopment_SelectedIndexChanged);
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Location = new System.Drawing.Point(25, 87);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(168, 21);
            this.comboBoxSites.TabIndex = 100;
            this.comboBoxSites.SelectedIndexChanged += new System.EventHandler(this.comboBoxSites_SelectedIndexChanged);
            // 
            // labelPrototip
            // 
            this.labelPrototip.AutoSize = true;
            this.labelPrototip.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelPrototip.Location = new System.Drawing.Point(22, 16);
            this.labelPrototip.Name = "labelPrototip";
            this.labelPrototip.Size = new System.Drawing.Size(52, 17);
            this.labelPrototip.TabIndex = 99;
            this.labelPrototip.Text = "Клиент";
            // 
            // labelSites
            // 
            this.labelSites.AutoSize = true;
            this.labelSites.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelSites.Location = new System.Drawing.Point(22, 67);
            this.labelSites.Name = "labelSites";
            this.labelSites.Size = new System.Drawing.Size(113, 17);
            this.labelSites.TabIndex = 98;
            this.labelSites.Text = "Заказанный сайт";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Синаптик.Properties.Resources._627eb394_3c83_4c73_a1a3_fec1724eda3e;
            this.pictureBox1.Location = new System.Drawing.Point(25, 238);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Artico Soft Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(447, 238);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 38);
            this.buttonAdd.TabIndex = 107;
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
            this.buttonEdit.Location = new System.Drawing.Point(607, 238);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(130, 38);
            this.buttonEdit.TabIndex = 106;
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
            this.buttonDel.Location = new System.Drawing.Point(767, 238);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(130, 38);
            this.buttonDel.TabIndex = 105;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id Клиента";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ФИО Клиента";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id Заказа";
            this.columnHeader9.Width = 70;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Название";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Id Сотрудника";
            this.columnHeader11.Width = 97;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ФИО Сотрудника";
            this.columnHeader12.Width = 131;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Стоимость заказа";
            this.columnHeader1.Width = 121;
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Location = new System.Drawing.Point(24, 188);
            this.textBoxPrise.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(168, 20);
            this.textBoxPrise.TabIndex = 109;
            // 
            // labelPrise
            // 
            this.labelPrise.AutoSize = true;
            this.labelPrise.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelPrise.Location = new System.Drawing.Point(22, 167);
            this.labelPrise.Name = "labelPrise";
            this.labelPrise.Size = new System.Drawing.Size(72, 17);
            this.labelPrise.TabIndex = 110;
            this.labelPrise.Text = "Стоимость";
            // 
            // FormDevelopment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(921, 303);
            this.Controls.Add(this.labelPrise);
            this.Controls.Add(this.textBoxPrise);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.labelDesign);
            this.Controls.Add(this.listViewDevelop);
            this.Controls.Add(this.comboBoxSites);
            this.Controls.Add(this.labelPrototip);
            this.Controls.Add(this.labelSites);
            this.Name = "FormDevelopment";
            this.Text = "FormDevelopment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.Label labelDesign;
        private System.Windows.Forms.ListView listViewDevelop;
        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.Windows.Forms.Label labelPrototip;
        private System.Windows.Forms.Label labelSites;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.Label labelPrise;
    }
}