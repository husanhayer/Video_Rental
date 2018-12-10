namespace Video_Rental
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LastName_txtbox = new System.Windows.Forms.TextBox();
            this.lastname_lable = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.phone_txtbox = new System.Windows.Forms.TextBox();
            this.phone_lable = new System.Windows.Forms.Label();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.Name_txtbox = new System.Windows.Forms.TextBox();
            this.firstname_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.returndate_label = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.dateissue_lable = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.customerid_lable = new System.Windows.Forms.Label();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.movieid_lable = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnVideos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.genre_label = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.plot_lable = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.copies_label = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnVideoAdd = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.rentalcost_lable = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.rating_lable = new System.Windows.Forms.Label();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LastName_txtbox);
            this.groupBox1.Controls.Add(this.lastname_lable);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.phone_txtbox);
            this.groupBox1.Controls.Add(this.phone_lable);
            this.groupBox1.Controls.Add(this.address_txtbox);
            this.groupBox1.Controls.Add(this.address_label);
            this.groupBox1.Controls.Add(this.Name_txtbox);
            this.groupBox1.Controls.Add(this.firstname_label);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(16, 382);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(455, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // LastName_txtbox
            // 
            this.LastName_txtbox.Location = new System.Drawing.Point(208, 97);
            this.LastName_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.LastName_txtbox.Name = "LastName_txtbox";
            this.LastName_txtbox.Size = new System.Drawing.Size(209, 30);
            this.LastName_txtbox.TabIndex = 10;
            // 
            // lastname_lable
            // 
            this.lastname_lable.AutoSize = true;
            this.lastname_lable.Location = new System.Drawing.Point(19, 103);
            this.lastname_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastname_lable.Name = "lastname_lable";
            this.lastname_lable.Size = new System.Drawing.Size(106, 25);
            this.lastname_lable.TabIndex = 9;
            this.lastname_lable.Text = "Last Name";
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel.Location = new System.Drawing.Point(61, 316);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(296, 37);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(217, 267);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 42);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(61, 267);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.Location = new System.Drawing.Point(204, 198);
            this.phone_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.Size = new System.Drawing.Size(209, 30);
            this.phone_txtbox.TabIndex = 5;
            // 
            // phone_lable
            // 
            this.phone_lable.AutoSize = true;
            this.phone_lable.Location = new System.Drawing.Point(33, 198);
            this.phone_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_lable.Name = "phone_lable";
            this.phone_lable.Size = new System.Drawing.Size(69, 25);
            this.phone_lable.TabIndex = 4;
            this.phone_lable.Text = "Phone";
            // 
            // address_txtbox
            // 
            this.address_txtbox.Location = new System.Drawing.Point(207, 146);
            this.address_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(209, 30);
            this.address_txtbox.TabIndex = 3;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(33, 143);
            this.address_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(85, 25);
            this.address_label.TabIndex = 2;
            this.address_label.Text = "Address";
            this.address_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Name_txtbox
            // 
            this.Name_txtbox.Location = new System.Drawing.Point(209, 47);
            this.Name_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.Name_txtbox.Name = "Name_txtbox";
            this.Name_txtbox.Size = new System.Drawing.Size(209, 30);
            this.Name_txtbox.TabIndex = 1;
            this.Name_txtbox.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Location = new System.Drawing.Point(19, 47);
            this.firstname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(106, 25);
            this.firstname_label.TabIndex = 0;
            this.firstname_label.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Location = new System.Drawing.Point(40, 52);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.Size = new System.Drawing.Size(701, 276);
            this.dgvRecord.TabIndex = 3;
            this.dgvRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellContentClick);
            this.dgvRecord.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellContentDoubleClick);
            this.dgvRecord.DoubleClick += new System.EventHandler(this.dgvRecord_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpReturn);
            this.groupBox2.Controls.Add(this.dtpIssue);
            this.groupBox2.Controls.Add(this.returndate_label);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.btnReturn);
            this.groupBox2.Controls.Add(this.btnIssue);
            this.groupBox2.Controls.Add(this.dateissue_lable);
            this.groupBox2.Controls.Add(this.txtCID);
            this.groupBox2.Controls.Add(this.customerid_lable);
            this.groupBox2.Controls.Add(this.txtMID);
            this.groupBox2.Controls.Add(this.movieid_lable);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(499, 382);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(491, 370);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental Video";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(240, 206);
            this.dtpReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(209, 30);
            this.dtpReturn.TabIndex = 11;
            // 
            // dtpIssue
            // 
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssue.Location = new System.Drawing.Point(240, 154);
            this.dtpIssue.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(209, 30);
            this.dtpIssue.TabIndex = 10;
            // 
            // returndate_label
            // 
            this.returndate_label.AutoSize = true;
            this.returndate_label.Location = new System.Drawing.Point(8, 219);
            this.returndate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returndate_label.Name = "returndate_label";
            this.returndate_label.Size = new System.Drawing.Size(115, 25);
            this.returndate_label.TabIndex = 9;
            this.returndate_label.Text = "Return Date";
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(61, 316);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(296, 37);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Location = new System.Drawing.Point(217, 267);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 42);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssue.Location = new System.Drawing.Point(61, 267);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(140, 42);
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // dateissue_lable
            // 
            this.dateissue_lable.AutoSize = true;
            this.dateissue_lable.Location = new System.Drawing.Point(8, 165);
            this.dateissue_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateissue_lable.Name = "dateissue_lable";
            this.dateissue_lable.Size = new System.Drawing.Size(131, 25);
            this.dateissue_lable.TabIndex = 4;
            this.dateissue_lable.Text = "Date Of Issue";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(240, 103);
            this.txtCID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(209, 30);
            this.txtCID.TabIndex = 3;
            // 
            // customerid_lable
            // 
            this.customerid_lable.AutoSize = true;
            this.customerid_lable.Location = new System.Drawing.Point(19, 103);
            this.customerid_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerid_lable.Name = "customerid_lable";
            this.customerid_lable.Size = new System.Drawing.Size(121, 25);
            this.customerid_lable.TabIndex = 2;
            this.customerid_lable.Text = "Customer ID";
            // 
            // txtMID
            // 
            this.txtMID.Location = new System.Drawing.Point(240, 47);
            this.txtMID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(209, 30);
            this.txtMID.TabIndex = 1;
            // 
            // movieid_lable
            // 
            this.movieid_lable.AutoSize = true;
            this.movieid_lable.Location = new System.Drawing.Point(19, 47);
            this.movieid_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieid_lable.Name = "movieid_lable";
            this.movieid_lable.Size = new System.Drawing.Size(89, 25);
            this.movieid_lable.TabIndex = 0;
            this.movieid_lable.Text = "Movie ID";
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomer.Location = new System.Drawing.Point(40, 25);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(100, 28);
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRental
            // 
            this.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRental.Location = new System.Drawing.Point(139, 25);
            this.btnRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(100, 28);
            this.btnRental.TabIndex = 11;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnVideos
            // 
            this.btnVideos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVideos.Location = new System.Drawing.Point(237, 25);
            this.btnVideos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVideos.Name = "btnVideos";
            this.btnVideos.Size = new System.Drawing.Size(100, 28);
            this.btnVideos.TabIndex = 12;
            this.btnVideos.Text = "Videos";
            this.btnVideos.UseVisualStyleBackColor = true;
            this.btnVideos.Click += new System.EventHandler(this.btnVideos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGenre);
            this.groupBox3.Controls.Add(this.genre_label);
            this.groupBox3.Controls.Add(this.txtPlot);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.plot_lable);
            this.groupBox3.Controls.Add(this.txtCopies);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.copies_label);
            this.groupBox3.Controls.Add(this.txtCost);
            this.groupBox3.Controls.Add(this.btnVideoAdd);
            this.groupBox3.Controls.Add(this.txtYear);
            this.groupBox3.Controls.Add(this.rentalcost_lable);
            this.groupBox3.Controls.Add(this.year_label);
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Controls.Add(this.title_label);
            this.groupBox3.Controls.Add(this.txtRating);
            this.groupBox3.Controls.Add(this.rating_lable);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(772, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(548, 374);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Video Details";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(160, 324);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(209, 30);
            this.txtGenre.TabIndex = 17;
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(19, 327);
            this.genre_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(66, 25);
            this.genre_label.TabIndex = 16;
            this.genre_label.Text = "Genre";
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(160, 278);
            this.txtPlot.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(209, 30);
            this.txtPlot.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(391, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plot_lable
            // 
            this.plot_lable.AutoSize = true;
            this.plot_lable.Location = new System.Drawing.Point(19, 282);
            this.plot_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plot_lable.Name = "plot_lable";
            this.plot_lable.Size = new System.Drawing.Size(45, 25);
            this.plot_lable.TabIndex = 14;
            this.plot_lable.Text = "Plot";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(160, 233);
            this.txtCopies.Margin = new System.Windows.Forms.Padding(4);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(209, 30);
            this.txtCopies.TabIndex = 13;
            this.txtCopies.TextChanged += new System.EventHandler(this.txtCopies_TextChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(391, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // copies_label
            // 
            this.copies_label.AutoSize = true;
            this.copies_label.Location = new System.Drawing.Point(19, 235);
            this.copies_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copies_label.Name = "copies_label";
            this.copies_label.Size = new System.Drawing.Size(74, 25);
            this.copies_label.TabIndex = 12;
            this.copies_label.Text = "Copies";
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(160, 188);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(209, 30);
            this.txtCost.TabIndex = 11;
            // 
            // btnVideoAdd
            // 
            this.btnVideoAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVideoAdd.Location = new System.Drawing.Point(391, 47);
            this.btnVideoAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnVideoAdd.Name = "btnVideoAdd";
            this.btnVideoAdd.Size = new System.Drawing.Size(140, 42);
            this.btnVideoAdd.TabIndex = 6;
            this.btnVideoAdd.Text = "Add";
            this.btnVideoAdd.UseVisualStyleBackColor = true;
            this.btnVideoAdd.Click += new System.EventHandler(this.btnVideoAdd_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(160, 142);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(209, 30);
            this.txtYear.TabIndex = 10;
            // 
            // rentalcost_lable
            // 
            this.rentalcost_lable.AutoSize = true;
            this.rentalcost_lable.Location = new System.Drawing.Point(8, 188);
            this.rentalcost_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rentalcost_lable.Name = "rentalcost_lable";
            this.rentalcost_lable.Size = new System.Drawing.Size(113, 25);
            this.rentalcost_lable.TabIndex = 9;
            this.rentalcost_lable.Text = "Rental Cost";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(19, 142);
            this.year_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(53, 25);
            this.year_label.TabIndex = 4;
            this.year_label.Text = "Year";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(160, 95);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(209, 30);
            this.txtTitle.TabIndex = 3;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(19, 95);
            this.title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(49, 25);
            this.title_label.TabIndex = 2;
            this.title_label.Text = "Title";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(160, 47);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(209, 30);
            this.txtRating.TabIndex = 1;
            // 
            // rating_lable
            // 
            this.rating_lable.AutoSize = true;
            this.rating_lable.Location = new System.Drawing.Point(19, 47);
            this.rating_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rating_lable.Name = "rating_lable";
            this.rating_lable.Size = new System.Drawing.Size(67, 25);
            this.rating_lable.TabIndex = 0;
            this.rating_lable.Text = "Rating";
            // 
            // btnMovies
            // 
            this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.Location = new System.Drawing.Point(1043, 411);
            this.btnMovies.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(225, 39);
            this.btnMovies.TabIndex = 13;
            this.btnMovies.Text = "Most Viewed Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.Location = new System.Drawing.Point(1043, 468);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(225, 39);
            this.btnRanking.TabIndex = 14;
            this.btnRanking.Text = "Customer Ranking ";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1043, 535);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(225, 39);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1333, 767);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnVideos);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_txtbox;
        private System.Windows.Forms.TextBox phone_txtbox;
        private System.Windows.Forms.Label phone_lable;
        private System.Windows.Forms.TextBox address_txtbox;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label dateissue_lable;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label customerid_lable;
        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.Label movieid_lable;
        private System.Windows.Forms.Label returndate_label;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.TextBox LastName_txtbox;
        private System.Windows.Forms.Label lastname_lable;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnVideos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label rentalcost_lable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVideoAdd;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label rating_lable;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label copies_label;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.Label plot_lable;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btn_exit;
    }
}