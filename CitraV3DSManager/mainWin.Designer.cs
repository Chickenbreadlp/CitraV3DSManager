namespace CitraV3DSManager
{
    partial class mainWin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_uF = new System.Windows.Forms.TextBox();
            this.gb_uF = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_uF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_current = new System.Windows.Forms.GroupBox();
            this.btn_rename = new System.Windows.Forms.Button();
            this.lbl_currentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_addEmpty = new System.Windows.Forms.Button();
            this.btn_duplicate = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.lb_V3DS = new System.Windows.Forms.ListBox();
            this.gb_uF.SuspendLayout();
            this.gb_current.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_uF
            // 
            this.tb_uF.Location = new System.Drawing.Point(113, 72);
            this.tb_uF.Name = "tb_uF";
            this.tb_uF.ReadOnly = true;
            this.tb_uF.Size = new System.Drawing.Size(212, 20);
            this.tb_uF.TabIndex = 0;
            // 
            // gb_uF
            // 
            this.gb_uF.Controls.Add(this.label1);
            this.gb_uF.Controls.Add(this.btn_uF);
            this.gb_uF.Controls.Add(this.tb_uF);
            this.gb_uF.Location = new System.Drawing.Point(12, 12);
            this.gb_uF.Name = "gb_uF";
            this.gb_uF.Size = new System.Drawing.Size(331, 98);
            this.gb_uF.TabIndex = 1;
            this.gb_uF.TabStop = false;
            this.gb_uF.Text = "Citra User Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "The Citra User Folder is where Citra is Saving the Virtual NAND and\r\nSD-Card as w" +
    "ell as all of it\'s Logs.\r\n\r\nIt\'s usually located in %AppData%\\Citra";
            // 
            // btn_uF
            // 
            this.btn_uF.Location = new System.Drawing.Point(6, 70);
            this.btn_uF.Name = "btn_uF";
            this.btn_uF.Size = new System.Drawing.Size(101, 23);
            this.btn_uF.TabIndex = 1;
            this.btn_uF.Text = "Select Citra Folder";
            this.btn_uF.UseVisualStyleBackColor = true;
            this.btn_uF.Click += new System.EventHandler(this.btn_uF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Virtual 3DS Systems";
            // 
            // gb_current
            // 
            this.gb_current.Controls.Add(this.btn_rename);
            this.gb_current.Controls.Add(this.lbl_currentName);
            this.gb_current.Controls.Add(this.label3);
            this.gb_current.Location = new System.Drawing.Point(12, 139);
            this.gb_current.Name = "gb_current";
            this.gb_current.Size = new System.Drawing.Size(331, 40);
            this.gb_current.TabIndex = 5;
            this.gb_current.TabStop = false;
            this.gb_current.Text = "Current";
            // 
            // btn_rename
            // 
            this.btn_rename.Location = new System.Drawing.Point(250, 11);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(75, 23);
            this.btn_rename.TabIndex = 4;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // lbl_currentName
            // 
            this.lbl_currentName.AutoSize = true;
            this.lbl_currentName.Location = new System.Drawing.Point(53, 16);
            this.lbl_currentName.Name = "lbl_currentName";
            this.lbl_currentName.Size = new System.Drawing.Size(0, 13);
            this.lbl_currentName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name: ";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(268, 322);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 6;
            this.btn_select.Text = "Switch";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_addEmpty
            // 
            this.btn_addEmpty.Location = new System.Drawing.Point(106, 322);
            this.btn_addEmpty.Name = "btn_addEmpty";
            this.btn_addEmpty.Size = new System.Drawing.Size(75, 23);
            this.btn_addEmpty.TabIndex = 7;
            this.btn_addEmpty.Text = "Add Empty";
            this.btn_addEmpty.UseVisualStyleBackColor = true;
            this.btn_addEmpty.Click += new System.EventHandler(this.btn_addEmpty_Click);
            // 
            // btn_duplicate
            // 
            this.btn_duplicate.Location = new System.Drawing.Point(187, 322);
            this.btn_duplicate.Name = "btn_duplicate";
            this.btn_duplicate.Size = new System.Drawing.Size(75, 23);
            this.btn_duplicate.TabIndex = 8;
            this.btn_duplicate.Text = "Duplicate";
            this.btn_duplicate.UseVisualStyleBackColor = true;
            this.btn_duplicate.Click += new System.EventHandler(this.btn_duplicate_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(12, 322);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // lb_V3DS
            // 
            this.lb_V3DS.FormattingEnabled = true;
            this.lb_V3DS.HorizontalScrollbar = true;
            this.lb_V3DS.IntegralHeight = false;
            this.lb_V3DS.Location = new System.Drawing.Point(12, 185);
            this.lb_V3DS.Name = "lb_V3DS";
            this.lb_V3DS.Size = new System.Drawing.Size(331, 131);
            this.lb_V3DS.Sorted = true;
            this.lb_V3DS.TabIndex = 10;
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 355);
            this.Controls.Add(this.lb_V3DS);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_duplicate);
            this.Controls.Add(this.btn_addEmpty);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.gb_current);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_uF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainWin";
            this.Text = "Virtual 3DS Manager";
            this.gb_uF.ResumeLayout(false);
            this.gb_uF.PerformLayout();
            this.gb_current.ResumeLayout(false);
            this.gb_current.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_uF;
        private System.Windows.Forms.GroupBox gb_uF;
        private System.Windows.Forms.Button btn_uF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_current;
        private System.Windows.Forms.Label lbl_currentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_addEmpty;
        private System.Windows.Forms.Button btn_duplicate;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ListBox lb_V3DS;
        private System.Windows.Forms.Button btn_rename;
    }
}

