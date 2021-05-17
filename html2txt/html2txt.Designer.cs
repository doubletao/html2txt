
namespace html2txt
{
    partial class html2txt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSrcPath = new System.Windows.Forms.TextBox();
            this.textBoxDesPath = new System.Windows.Forms.TextBox();
            this.textBoxSrcFileList = new System.Windows.Forms.TextBox();
            this.btnSrcPath = new System.Windows.Forms.Button();
            this.btnDesPath = new System.Windows.Forms.Button();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSrcPath
            // 
            this.textBoxSrcPath.Location = new System.Drawing.Point(93, 12);
            this.textBoxSrcPath.Name = "textBoxSrcPath";
            this.textBoxSrcPath.Size = new System.Drawing.Size(283, 23);
            this.textBoxSrcPath.TabIndex = 0;
            // 
            // textBoxDesPath
            // 
            this.textBoxDesPath.Location = new System.Drawing.Point(497, 12);
            this.textBoxDesPath.Name = "textBoxDesPath";
            this.textBoxDesPath.Size = new System.Drawing.Size(291, 23);
            this.textBoxDesPath.TabIndex = 1;
            // 
            // textBoxSrcFileList
            // 
            this.textBoxSrcFileList.Location = new System.Drawing.Point(12, 41);
            this.textBoxSrcFileList.Multiline = true;
            this.textBoxSrcFileList.Name = "textBoxSrcFileList";
            this.textBoxSrcFileList.Size = new System.Drawing.Size(775, 368);
            this.textBoxSrcFileList.TabIndex = 4;
            // 
            // btnSrcPath
            // 
            this.btnSrcPath.Location = new System.Drawing.Point(12, 12);
            this.btnSrcPath.Name = "btnSrcPath";
            this.btnSrcPath.Size = new System.Drawing.Size(75, 23);
            this.btnSrcPath.TabIndex = 6;
            this.btnSrcPath.Text = "源路径";
            this.btnSrcPath.UseVisualStyleBackColor = true;
            this.btnSrcPath.Click += new System.EventHandler(this.btnSrcPath_Click);
            // 
            // btnDesPath
            // 
            this.btnDesPath.Location = new System.Drawing.Point(416, 12);
            this.btnDesPath.Name = "btnDesPath";
            this.btnDesPath.Size = new System.Drawing.Size(75, 23);
            this.btnDesPath.TabIndex = 7;
            this.btnDesPath.Text = "目标路径";
            this.btnDesPath.UseVisualStyleBackColor = true;
            this.btnDesPath.Click += new System.EventHandler(this.btnDesPath_Click);
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(712, 415);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(75, 23);
            this.btnStartProcess.TabIndex = 8;
            this.btnStartProcess.Text = "开始";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // html2txt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartProcess);
            this.Controls.Add(this.btnDesPath);
            this.Controls.Add(this.btnSrcPath);
            this.Controls.Add(this.textBoxSrcFileList);
            this.Controls.Add(this.textBoxDesPath);
            this.Controls.Add(this.textBoxSrcPath);
            this.Name = "html2txt";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSrcPath;
        private System.Windows.Forms.TextBox textBoxDesPath;
        private System.Windows.Forms.TextBox textBoxSrcFileList;
        private System.Windows.Forms.Button btnSrcPath;
        private System.Windows.Forms.Button btnDesPath;
        private System.Windows.Forms.Button btnStartProcess;
    }
}

