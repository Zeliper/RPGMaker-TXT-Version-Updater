namespace RPGVersionUpdateHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NewText = new System.Windows.Forms.TextBox();
            this.Btn_SelectNewText = new System.Windows.Forms.Button();
            this.TB_OldTranslated = new System.Windows.Forms.TextBox();
            this.Btn_SelectOldTranslated = new System.Windows.Forms.Button();
            this.TB_OldText = new System.Windows.Forms.TextBox();
            this.Btn_SelectOldText = new System.Windows.Forms.Button();
            this.Btn_Excute = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.LogTB = new System.Windows.Forms.RichTextBox();
            this.PB_Proc = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_NewText);
            this.groupBox1.Controls.Add(this.Btn_SelectNewText);
            this.groupBox1.Controls.Add(this.TB_OldTranslated);
            this.groupBox1.Controls.Add(this.Btn_SelectOldTranslated);
            this.groupBox1.Controls.Add(this.TB_OldText);
            this.groupBox1.Controls.Add(this.Btn_SelectOldText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "경로 설정";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "신버전 텍스트폴더";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "구버전 번역텍스트 폴더";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "구버전 원본텍스트 폴더";
            // 
            // TB_NewText
            // 
            this.TB_NewText.AllowDrop = true;
            this.TB_NewText.Location = new System.Drawing.Point(151, 75);
            this.TB_NewText.Name = "TB_NewText";
            this.TB_NewText.Size = new System.Drawing.Size(457, 21);
            this.TB_NewText.TabIndex = 6;
            this.TB_NewText.DragDrop += new System.Windows.Forms.DragEventHandler(this.TB_OldText_DragDrop);
            this.TB_NewText.DragEnter += new System.Windows.Forms.DragEventHandler(this.TB_OldText_DragEnter);
            // 
            // Btn_SelectNewText
            // 
            this.Btn_SelectNewText.Location = new System.Drawing.Point(614, 75);
            this.Btn_SelectNewText.Name = "Btn_SelectNewText";
            this.Btn_SelectNewText.Size = new System.Drawing.Size(75, 23);
            this.Btn_SelectNewText.TabIndex = 3;
            this.Btn_SelectNewText.Text = "선택";
            this.Btn_SelectNewText.UseVisualStyleBackColor = true;
            this.Btn_SelectNewText.Click += new System.EventHandler(this.Btn_SelectNewText_Click);
            // 
            // TB_OldTranslated
            // 
            this.TB_OldTranslated.AllowDrop = true;
            this.TB_OldTranslated.Location = new System.Drawing.Point(151, 48);
            this.TB_OldTranslated.Name = "TB_OldTranslated";
            this.TB_OldTranslated.Size = new System.Drawing.Size(457, 21);
            this.TB_OldTranslated.TabIndex = 7;
            this.TB_OldTranslated.DragDrop += new System.Windows.Forms.DragEventHandler(this.TB_OldText_DragDrop);
            this.TB_OldTranslated.DragEnter += new System.Windows.Forms.DragEventHandler(this.TB_OldText_DragEnter);
            // 
            // Btn_SelectOldTranslated
            // 
            this.Btn_SelectOldTranslated.Location = new System.Drawing.Point(614, 48);
            this.Btn_SelectOldTranslated.Name = "Btn_SelectOldTranslated";
            this.Btn_SelectOldTranslated.Size = new System.Drawing.Size(75, 23);
            this.Btn_SelectOldTranslated.TabIndex = 4;
            this.Btn_SelectOldTranslated.Text = "선택";
            this.Btn_SelectOldTranslated.UseVisualStyleBackColor = true;
            this.Btn_SelectOldTranslated.Click += new System.EventHandler(this.Btn_SelectOldTranslated_Click);
            // 
            // TB_OldText
            // 
            this.TB_OldText.AllowDrop = true;
            this.TB_OldText.Location = new System.Drawing.Point(151, 21);
            this.TB_OldText.Name = "TB_OldText";
            this.TB_OldText.Size = new System.Drawing.Size(457, 21);
            this.TB_OldText.TabIndex = 8;
            this.TB_OldText.DragDrop += new System.Windows.Forms.DragEventHandler(this.TB_OldText_DragDrop);
            this.TB_OldText.DragEnter += new System.Windows.Forms.DragEventHandler(this.TB_OldText_DragEnter);
            // 
            // Btn_SelectOldText
            // 
            this.Btn_SelectOldText.Location = new System.Drawing.Point(614, 21);
            this.Btn_SelectOldText.Name = "Btn_SelectOldText";
            this.Btn_SelectOldText.Size = new System.Drawing.Size(75, 23);
            this.Btn_SelectOldText.TabIndex = 5;
            this.Btn_SelectOldText.Text = "선택";
            this.Btn_SelectOldText.UseVisualStyleBackColor = true;
            this.Btn_SelectOldText.Click += new System.EventHandler(this.Btn_SelectOldText_Click);
            // 
            // Btn_Excute
            // 
            this.Btn_Excute.Location = new System.Drawing.Point(721, 18);
            this.Btn_Excute.Name = "Btn_Excute";
            this.Btn_Excute.Size = new System.Drawing.Size(133, 103);
            this.Btn_Excute.TabIndex = 4;
            this.Btn_Excute.Text = "실행";
            this.Btn_Excute.UseVisualStyleBackColor = true;
            this.Btn_Excute.Click += new System.EventHandler(this.Btn_Excute_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 171);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "설명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(785, 140);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.LogTB);
            this.GroupBox3.Location = new System.Drawing.Point(12, 305);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(842, 245);
            this.GroupBox3.TabIndex = 6;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "로그";
            // 
            // LogTB
            // 
            this.LogTB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LogTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTB.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.LogTB.Location = new System.Drawing.Point(6, 20);
            this.LogTB.Name = "LogTB";
            this.LogTB.ReadOnly = true;
            this.LogTB.Size = new System.Drawing.Size(830, 219);
            this.LogTB.TabIndex = 0;
            this.LogTB.Text = "";
            // 
            // PB_Proc
            // 
            this.PB_Proc.Location = new System.Drawing.Point(12, 558);
            this.PB_Proc.Name = "PB_Proc";
            this.PB_Proc.Size = new System.Drawing.Size(842, 10);
            this.PB_Proc.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 579);
            this.Controls.Add(this.PB_Proc);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_Excute);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NewText;
        private System.Windows.Forms.Button Btn_SelectNewText;
        private System.Windows.Forms.TextBox TB_OldTranslated;
        private System.Windows.Forms.Button Btn_SelectOldTranslated;
        private System.Windows.Forms.TextBox TB_OldText;
        private System.Windows.Forms.Button Btn_SelectOldText;
        private System.Windows.Forms.Button Btn_Excute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.RichTextBox LogTB;
        private System.Windows.Forms.ProgressBar PB_Proc;
    }
}