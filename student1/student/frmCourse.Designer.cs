﻿namespace student
{
    partial class frmCourse
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
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.laDept = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.laSno = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.laTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Gbox.Controls.Add(this.txtTime);
            this.Gbox.Controls.Add(this.laTime);
            this.Gbox.Controls.Add(this.laDept);
            this.Gbox.Controls.Add(this.laName);
            this.Gbox.Controls.Add(this.laSno);
            this.Gbox.Controls.Add(this.txtCredit);
            this.Gbox.Controls.Add(this.txtName);
            this.Gbox.Controls.Add(this.txtCno);
            this.Gbox.Location = new System.Drawing.Point(18, 2);
            this.Gbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gbox.Name = "Gbox";
            this.Gbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gbox.Size = new System.Drawing.Size(682, 150);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnInsert.Location = new System.Drawing.Point(78, 488);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 34);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // laDept
            // 
            this.laDept.AutoSize = true;
            this.laDept.Location = new System.Drawing.Point(46, 106);
            this.laDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDept.Name = "laDept";
            this.laDept.Size = new System.Drawing.Size(53, 18);
            this.laDept.TabIndex = 5;
            this.laDept.Text = "学 分";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(370, 36);
            this.laName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(62, 18);
            this.laName.TabIndex = 4;
            this.laName.Text = "课程名";
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(46, 45);
            this.laSno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(62, 18);
            this.laSno.TabIndex = 3;
            this.laSno.Text = "课程号";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(144, 102);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(162, 28);
            this.txtCredit.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(474, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 28);
            this.txtName.TabIndex = 1;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(144, 27);
            this.txtCno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(162, 28);
            this.txtCno.TabIndex = 0;
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(18, 160);
            this.dataGView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(682, 300);
            this.dataGView.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(234, 488);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.ForeColor = System.Drawing.Color.Black;
            this.btnChange.Location = new System.Drawing.Point(402, 488);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 34);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Location = new System.Drawing.Point(562, 488);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(104, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.Location = new System.Drawing.Point(373, 106);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(80, 18);
            this.laTime.TabIndex = 6;
            this.laTime.Text = "开课时间";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(474, 106);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(181, 28);
            this.txtTime.TabIndex = 7;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 573);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.Gbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息输入窗口";
            this.Gbox.ResumeLayout(false);
            this.Gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label laDept;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.TextBox txtTime;
    }
}