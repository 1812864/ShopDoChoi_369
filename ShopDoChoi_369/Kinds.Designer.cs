namespace ShopDoChoi_369
{
    partial class Kinds
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKindID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdatek = new System.Windows.Forms.Button();
            this.btnXoakind = new System.Windows.Forms.Button();
            this.btnThemkind = new System.Windows.Forms.Button();
            this.lvKind = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiDC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(200, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID";
            // 
            // txtKindID
            // 
            this.txtKindID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKindID.BackColor = System.Drawing.Color.White;
            this.txtKindID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKindID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.txtKindID.Location = new System.Drawing.Point(325, 111);
            this.txtKindID.Name = "txtKindID";
            this.txtKindID.Size = new System.Drawing.Size(237, 30);
            this.txtKindID.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(179, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 69);
            this.label8.TabIndex = 33;
            this.label8.Text = "Loại đồ chơi";
            // 
            // btnUpdatek
            // 
            this.btnUpdatek.BackColor = System.Drawing.Color.Lime;
            this.btnUpdatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatek.ForeColor = System.Drawing.Color.White;
            this.btnUpdatek.Location = new System.Drawing.Point(314, 202);
            this.btnUpdatek.Name = "btnUpdatek";
            this.btnUpdatek.Size = new System.Drawing.Size(122, 33);
            this.btnUpdatek.TabIndex = 32;
            this.btnUpdatek.Text = "Cập nhật";
            this.btnUpdatek.UseVisualStyleBackColor = false;
            // 
            // btnXoakind
            // 
            this.btnXoakind.BackColor = System.Drawing.Color.Lime;
            this.btnXoakind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoakind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoakind.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoakind.Location = new System.Drawing.Point(457, 202);
            this.btnXoakind.Name = "btnXoakind";
            this.btnXoakind.Size = new System.Drawing.Size(122, 33);
            this.btnXoakind.TabIndex = 31;
            this.btnXoakind.Text = "Xóa";
            this.btnXoakind.UseVisualStyleBackColor = false;
            // 
            // btnThemkind
            // 
            this.btnThemkind.BackColor = System.Drawing.Color.Lime;
            this.btnThemkind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemkind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemkind.ForeColor = System.Drawing.Color.White;
            this.btnThemkind.Location = new System.Drawing.Point(169, 202);
            this.btnThemkind.Name = "btnThemkind";
            this.btnThemkind.Size = new System.Drawing.Size(122, 33);
            this.btnThemkind.TabIndex = 30;
            this.btnThemkind.Text = "Thêm";
            this.btnThemkind.UseVisualStyleBackColor = false;
            // 
            // lvKind
            // 
            this.lvKind.BackColor = System.Drawing.SystemColors.Window;
            this.lvKind.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvKind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKind.ForeColor = System.Drawing.Color.Black;
            this.lvKind.GridLines = true;
            this.lvKind.HideSelection = false;
            this.lvKind.Location = new System.Drawing.Point(0, 263);
            this.lvKind.Name = "lvKind";
            this.lvKind.Size = new System.Drawing.Size(799, 227);
            this.lvKind.TabIndex = 29;
            this.lvKind.UseCompatibleStateImageBehavior = false;
            this.lvKind.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 308;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại đồ chơi";
            this.columnHeader2.Width = 512;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(200, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên đồ chơi";
            // 
            // txtTenLoaiDC
            // 
            this.txtTenLoaiDC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenLoaiDC.BackColor = System.Drawing.Color.White;
            this.txtTenLoaiDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.txtTenLoaiDC.Location = new System.Drawing.Point(325, 156);
            this.txtTenLoaiDC.Name = "txtTenLoaiDC";
            this.txtTenLoaiDC.Size = new System.Drawing.Size(237, 30);
            this.txtTenLoaiDC.TabIndex = 27;
            // 
            // Kinds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKindID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdatek);
            this.Controls.Add(this.btnXoakind);
            this.Controls.Add(this.btnThemkind);
            this.Controls.Add(this.lvKind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLoaiDC);
            this.Name = "Kinds";
            this.Text = "Kinds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKindID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdatek;
        private System.Windows.Forms.Button btnXoakind;
        private System.Windows.Forms.Button btnThemkind;
        private System.Windows.Forms.ListView lvKind;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiDC;
    }
}