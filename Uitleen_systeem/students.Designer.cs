
namespace Uitleen_systeem
{
    partial class students
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nName = new System.Windows.Forms.TextBox();
            this.userAdd = new System.Windows.Forms.Button();
            this.nAge = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userUpdate = new System.Windows.Forms.Button();
            this.userDelete = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.nName);
            this.panel2.Controls.Add(this.userAdd);
            this.panel2.Controls.Add(this.nAge);
            this.panel2.Location = new System.Drawing.Point(482, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 124);
            this.panel2.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Student Nummer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Naam";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(111, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Nieuwe student";
            // 
            // nName
            // 
            this.nName.Location = new System.Drawing.Point(114, 21);
            this.nName.Name = "nName";
            this.nName.Size = new System.Drawing.Size(150, 20);
            this.nName.TabIndex = 26;
            // 
            // userAdd
            // 
            this.userAdd.Location = new System.Drawing.Point(134, 94);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(76, 23);
            this.userAdd.TabIndex = 31;
            this.userAdd.Text = "Toevoegen";
            this.userAdd.UseVisualStyleBackColor = true;
            this.userAdd.Click += new System.EventHandler(this.userAdd_Click);
            // 
            // nAge
            // 
            this.nAge.Location = new System.Drawing.Point(114, 47);
            this.nAge.Name = "nAge";
            this.nAge.Size = new System.Drawing.Size(150, 20);
            this.nAge.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.userUpdate);
            this.panel1.Controls.Add(this.userDelete);
            this.panel1.Controls.Add(this.txtNaam);
            this.panel1.Location = new System.Drawing.Point(482, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 140);
            this.panel1.TabIndex = 32;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(114, 47);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(150, 20);
            this.txtAge.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Student Nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Naam";
            // 
            // userUpdate
            // 
            this.userUpdate.Location = new System.Drawing.Point(221, 96);
            this.userUpdate.Name = "userUpdate";
            this.userUpdate.Size = new System.Drawing.Size(76, 23);
            this.userUpdate.TabIndex = 25;
            this.userUpdate.Text = "Updaten";
            this.userUpdate.UseVisualStyleBackColor = true;
            this.userUpdate.Click += new System.EventHandler(this.userUpdate_Click);
            // 
            // userDelete
            // 
            this.userDelete.Location = new System.Drawing.Point(20, 96);
            this.userDelete.Name = "userDelete";
            this.userDelete.Size = new System.Drawing.Size(76, 23);
            this.userDelete.TabIndex = 24;
            this.userDelete.Text = "Verwijderen";
            this.userDelete.UseVisualStyleBackColor = true;
            this.userDelete.Click += new System.EventHandler(this.userDelete_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(114, 19);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(150, 20);
            this.txtNaam.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(458, 355);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(749, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 23);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Vernieuwen";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(589, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(154, 20);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Studenten";
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "students";
            this.Text = "students";
            this.Load += new System.EventHandler(this.students_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nName;
        private System.Windows.Forms.Button userAdd;
        private System.Windows.Forms.TextBox nAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button userUpdate;
        private System.Windows.Forms.Button userDelete;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}