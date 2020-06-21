namespace Синаптик
{
    partial class FormSites
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
            this.listViewLend = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.listViewMultipage = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLend = new System.Windows.Forms.Label();
            this.textBoxLend = new System.Windows.Forms.TextBox();
            this.labelMulti = new System.Windows.Forms.Label();
            this.textBoxMulti = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewLend
            // 
            this.listViewLend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewLend.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.listViewLend.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewLend.FullRowSelect = true;
            this.listViewLend.GridLines = true;
            this.listViewLend.Location = new System.Drawing.Point(230, 35);
            this.listViewLend.Margin = new System.Windows.Forms.Padding(15);
            this.listViewLend.MultiSelect = false;
            this.listViewLend.Name = "listViewLend";
            this.listViewLend.Size = new System.Drawing.Size(490, 165);
            this.listViewLend.TabIndex = 76;
            this.listViewLend.UseCompatibleStateImageBehavior = false;
            this.listViewLend.View = System.Windows.Forms.View.Details;
            this.listViewLend.SelectedIndexChanged += new System.EventHandler(this.listViewLend_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип сайта";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Количество блоков";
            this.columnHeader4.Width = 129;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelType.Location = new System.Drawing.Point(32, 67);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(68, 17);
            this.labelType.TabIndex = 75;
            this.labelType.Text = "Тип сайта";
            this.labelType.Click += new System.EventHandler(this.labelType_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(32, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 17);
            this.labelName.TabIndex = 74;
            this.labelName.Text = "Название";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(32, 35);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 20);
            this.textBoxName.TabIndex = 73;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Многостраничный",
            "Лендинг"});
            this.comboBoxType.Location = new System.Drawing.Point(35, 88);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(168, 21);
            this.comboBoxType.TabIndex = 77;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // listViewMultipage
            // 
            this.listViewMultipage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewMultipage.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.listViewMultipage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewMultipage.FullRowSelect = true;
            this.listViewMultipage.GridLines = true;
            this.listViewMultipage.Location = new System.Drawing.Point(230, 35);
            this.listViewMultipage.Margin = new System.Windows.Forms.Padding(15);
            this.listViewMultipage.MultiSelect = false;
            this.listViewMultipage.Name = "listViewMultipage";
            this.listViewMultipage.Size = new System.Drawing.Size(490, 165);
            this.listViewMultipage.TabIndex = 78;
            this.listViewMultipage.UseCompatibleStateImageBehavior = false;
            this.listViewMultipage.View = System.Windows.Forms.View.Details;
            this.listViewMultipage.SelectedIndexChanged += new System.EventHandler(this.listViewMultipage_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Название";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Тип сайта";
            this.columnHeader7.Width = 117;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Количество страниц";
            this.columnHeader8.Width = 142;
            // 
            // labelLend
            // 
            this.labelLend.AutoSize = true;
            this.labelLend.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelLend.Location = new System.Drawing.Point(35, 122);
            this.labelLend.Name = "labelLend";
            this.labelLend.Size = new System.Drawing.Size(124, 17);
            this.labelLend.TabIndex = 80;
            this.labelLend.Text = "Количество блоков";
            // 
            // textBoxLend
            // 
            this.textBoxLend.ForeColor = System.Drawing.Color.Black;
            this.textBoxLend.Location = new System.Drawing.Point(35, 143);
            this.textBoxLend.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxLend.Name = "textBoxLend";
            this.textBoxLend.Size = new System.Drawing.Size(168, 20);
            this.textBoxLend.TabIndex = 79;
            // 
            // labelMulti
            // 
            this.labelMulti.AutoSize = true;
            this.labelMulti.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelMulti.Location = new System.Drawing.Point(32, 122);
            this.labelMulti.Name = "labelMulti";
            this.labelMulti.Size = new System.Drawing.Size(132, 17);
            this.labelMulti.TabIndex = 82;
            this.labelMulti.Text = "Количество страниц";
            this.labelMulti.Click += new System.EventHandler(this.labelMulti_Click);
            // 
            // textBoxMulti
            // 
            this.textBoxMulti.ForeColor = System.Drawing.Color.Black;
            this.textBoxMulti.Location = new System.Drawing.Point(35, 143);
            this.textBoxMulti.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxMulti.Name = "textBoxMulti";
            this.textBoxMulti.Size = new System.Drawing.Size(168, 20);
            this.textBoxMulti.TabIndex = 81;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Artico Soft Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(270, 230);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 38);
            this.buttonAdd.TabIndex = 85;
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
            this.buttonEdit.Location = new System.Drawing.Point(430, 230);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(130, 38);
            this.buttonEdit.TabIndex = 84;
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
            this.buttonDel.Location = new System.Drawing.Point(590, 230);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(130, 38);
            this.buttonDel.TabIndex = 83;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Синаптик.Properties.Resources._627eb394_3c83_4c73_a1a3_fec1724eda3e;
            this.pictureBox1.Location = new System.Drawing.Point(35, 230);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(744, 295);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.labelMulti);
            this.Controls.Add(this.textBoxMulti);
            this.Controls.Add(this.labelLend);
            this.Controls.Add(this.textBoxLend);
            this.Controls.Add(this.listViewMultipage);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.listViewLend);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormSites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSites";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLend;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ListView listViewMultipage;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label labelLend;
        private System.Windows.Forms.TextBox textBoxLend;
        private System.Windows.Forms.Label labelMulti;
        private System.Windows.Forms.TextBox textBoxMulti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
    }
}