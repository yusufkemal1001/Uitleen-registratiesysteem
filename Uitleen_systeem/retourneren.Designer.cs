
namespace Uitleen_systeem
{
    partial class retourneren
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.txtUitleen = new System.Windows.Forms.TextBox();
            this.txtRetour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apparaat retourneren";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 354);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRetour
            // 
            this.btnRetour.Enabled = false;
            this.btnRetour.Location = new System.Drawing.Point(403, 560);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(150, 33);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retourneren";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(29, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Zoek eerst studentnummer op*";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(29, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(274, 443);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 8;
            this.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(521, 443);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(138, 443);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCat
            // 
            this.txtCat.Enabled = false;
            this.txtCat.Location = new System.Drawing.Point(19, 443);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(91, 20);
            this.txtCat.TabIndex = 12;
            this.txtCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(637, 443);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 13;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Location = new System.Drawing.Point(743, 443);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(190, 132);
            this.txtComment.TabIndex = 16;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // txtStat
            // 
            this.txtStat.Enabled = false;
            this.txtStat.Location = new System.Drawing.Point(403, 443);
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(100, 20);
            this.txtStat.TabIndex = 17;
            this.txtStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUitleen
            // 
            this.txtUitleen.Enabled = false;
            this.txtUitleen.Location = new System.Drawing.Point(138, 494);
            this.txtUitleen.Name = "txtUitleen";
            this.txtUitleen.Size = new System.Drawing.Size(199, 20);
            this.txtUitleen.TabIndex = 18;
            this.txtUitleen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRetour
            // 
            this.txtRetour.Enabled = false;
            this.txtRetour.Location = new System.Drawing.Point(388, 494);
            this.txtRetour.Name = "txtRetour";
            this.txtRetour.Size = new System.Drawing.Size(200, 20);
            this.txtRetour.TabIndex = 19;
            this.txtRetour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // retourneren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 614);
            this.Controls.Add(this.txtRetour);
            this.Controls.Add(this.txtUitleen);
            this.Controls.Add(this.txtStat);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "retourneren";
            this.Text = "retourneren";
            this.Load += new System.EventHandler(this.retourneren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtStat;
        private System.Windows.Forms.TextBox txtUitleen;
        private System.Windows.Forms.TextBox txtRetour;
    }
}