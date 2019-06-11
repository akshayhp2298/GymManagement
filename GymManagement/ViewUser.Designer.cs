namespace GymManagement
{
    partial class ViewUser
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
            this.path = new System.Windows.Forms.Label();
            this.iname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bgroup = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.otelno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.occupation = new System.Windows.Forms.TextBox();
            this.oaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.joinDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fathername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guardian = new System.Windows.Forms.TextBox();
            this.foccupation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(912, 448);
            this.path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 13);
            this.path.TabIndex = 40;
            this.path.Visible = false;
            // 
            // iname
            // 
            this.iname.AutoSize = true;
            this.iname.Location = new System.Drawing.Point(907, 422);
            this.iname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iname.Name = "iname";
            this.iname.Size = new System.Drawing.Size(0, 13);
            this.iname.TabIndex = 39;
            this.iname.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button});
            this.dataGridView1.Location = new System.Drawing.Point(229, 329);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 312);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button
            // 
            this.button.HeaderText = "View/Edit";
            this.button.Name = "button";
            this.button.ReadOnly = true;
            this.button.Text = "View/Edit";
            this.button.ToolTipText = "Click here to View or Edit";
            this.button.UseColumnTextForButtonValue = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(763, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(425, 246);
            this.dataGridView2.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(545, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "User Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(763, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 25);
            this.label14.TabIndex = 44;
            this.label14.Text = "User Payment Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bgroup);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.mobile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.otelno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.occupation);
            this.groupBox1.Controls.Add(this.oaddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.joinDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fathername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.guardian);
            this.groupBox1.Controls.Add(this.foccupation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dob);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 280);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View/Edit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bgroup
            // 
            this.bgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bgroup.FormattingEnabled = true;
            this.bgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bgroup.Location = new System.Drawing.Point(386, 74);
            this.bgroup.Name = "bgroup";
            this.bgroup.Size = new System.Drawing.Size(163, 26);
            this.bgroup.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 207);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save Changes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(578, 207);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "Select Image";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(105, 78);
            this.address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(163, 62);
            this.address.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(578, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(105, 145);
            this.mobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(163, 24);
            this.mobile.TabIndex = 4;
            this.mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobile_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Name :-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "Mobile :-";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(105, 20);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(163, 24);
            this.name.TabIndex = 1;
            // 
            // otelno
            // 
            this.otelno.Location = new System.Drawing.Point(386, 169);
            this.otelno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.otelno.Name = "otelno";
            this.otelno.Size = new System.Drawing.Size(163, 24);
            this.otelno.TabIndex = 12;
            this.otelno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobile_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Occupation :-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(292, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "Official Tel.No :-";
            // 
            // occupation
            // 
            this.occupation.Location = new System.Drawing.Point(105, 49);
            this.occupation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(163, 24);
            this.occupation.TabIndex = 2;
            // 
            // oaddress
            // 
            this.oaddress.Location = new System.Drawing.Point(386, 104);
            this.oaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oaddress.Multiline = true;
            this.oaddress.Name = "oaddress";
            this.oaddress.Size = new System.Drawing.Size(163, 62);
            this.oaddress.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Date of joining :-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(292, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Official Address :-";
            // 
            // joinDate
            // 
            this.joinDate.CustomFormat = "dd-MM-yyyy";
            this.joinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.joinDate.Location = new System.Drawing.Point(386, 20);
            this.joinDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.joinDate.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.joinDate.Name = "joinDate";
            this.joinDate.Size = new System.Drawing.Size(163, 24);
            this.joinDate.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Blood Group :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Address :-";
            // 
            // fathername
            // 
            this.fathername.Location = new System.Drawing.Point(105, 205);
            this.fathername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(163, 24);
            this.fathername.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Guardian :-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Father Name :-";
            // 
            // guardian
            // 
            this.guardian.Location = new System.Drawing.Point(386, 47);
            this.guardian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardian.Name = "guardian";
            this.guardian.Size = new System.Drawing.Size(163, 24);
            this.guardian.TabIndex = 9;
            // 
            // foccupation
            // 
            this.foccupation.Location = new System.Drawing.Point(105, 236);
            this.foccupation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foccupation.Name = "foccupation";
            this.foccupation.Size = new System.Drawing.Size(163, 24);
            this.foccupation.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Occupation :-";
            // 
            // dob
            // 
            this.dob.CustomFormat = "dd-MM-yyyy";
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(105, 174);
            this.dob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dob.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(163, 24);
            this.dob.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Date of Birth:-";
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.iname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewUser";
            this.Text = "ViewUser";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Label iname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox otelno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox occupation;
        private System.Windows.Forms.TextBox oaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker joinDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fathername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox guardian;
        private System.Windows.Forms.TextBox foccupation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bgroup;
    }
}