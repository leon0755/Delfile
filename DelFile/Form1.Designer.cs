﻿namespace DelFile
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox( );
            this.btn_work = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.progressBar1 = new System.Windows.Forms.ProgressBar( );
            this.lbl_message = new System.Windows.Forms.Label( );
            this.splitter1 = new System.Windows.Forms.Splitter( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this.textBox2 = new System.Windows.Forms.TextBox( );
            this.textBox3 = new System.Windows.Forms.TextBox( );
            this.button1 = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point( 104, 12 );
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size( 280, 77 );
            this.textBox1.TabIndex = 0;
            // 
            // btn_work
            // 
            this.btn_work.Location = new System.Drawing.Point( 399, 32 );
            this.btn_work.Name = "btn_work";
            this.btn_work.Size = new System.Drawing.Size( 75, 23 );
            this.btn_work.TabIndex = 6;
            this.btn_work.Text = "快速清理";
            this.btn_work.UseVisualStyleBackColor = true;
            this.btn_work.Click += new System.EventHandler( this.buttonWork_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 32, 27 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 65, 12 );
            this.label1.TabIndex = 7;
            this.label1.Text = "目标文件夹";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point( 12, 254 );
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size( 474, 25 );
            this.progressBar1.TabIndex = 8;
            // 
            // lbl_message
            // 
            this.lbl_message.Location = new System.Drawing.Point( 12, 195 );
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size( 632, 68 );
            this.lbl_message.TabIndex = 9;
            this.lbl_message.Text = "Message";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point( 0, 0 );
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size( 3, 304 );
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 32, 115 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 95, 12 );
            this.label2.TabIndex = 11;
            this.label2.Text = "删除下列文件夹:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 306, 115 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 83, 12 );
            this.label3.TabIndex = 12;
            this.label3.Text = "删除下列文件:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point( 133, 112 );
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size( 155, 57 );
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point( 399, 112 );
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size( 155, 57 );
            this.textBox3.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 567, 112 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 75, 23 );
            this.button1.TabIndex = 15;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 654, 304 );
            this.Controls.Add( this.button1 );
            this.Controls.Add( this.textBox3 );
            this.Controls.Add( this.textBox2 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.splitter1 );
            this.Controls.Add( this.lbl_message );
            this.Controls.Add( this.progressBar1 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.btn_work );
            this.Controls.Add( this.textBox1 );
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "清理工具";
            this.Load += new System.EventHandler( this.Form1_Load );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_work;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

