namespace TCPClient
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_conn = new System.Windows.Forms.Button();
            this.btn_setPath = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.lsb_local = new System.Windows.Forms.ListBox();
            this.lsb_server = new System.Windows.Forms.ListBox();
            this.lsb_status = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(723, 121);
            this.btn_conn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(76, 30);
            this.btn_conn.TabIndex = 0;
            this.btn_conn.Text = "连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // btn_setPath
            // 
            this.btn_setPath.Location = new System.Drawing.Point(311, 152);
            this.btn_setPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_setPath.Name = "btn_setPath";
            this.btn_setPath.Size = new System.Drawing.Size(76, 30);
            this.btn_setPath.TabIndex = 1;
            this.btn_setPath.Text = "浏览";
            this.btn_setPath.UseVisualStyleBackColor = true;
            this.btn_setPath.Click += new System.EventHandler(this.btn_setPath_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(311, 294);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(76, 30);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "上传";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(726, 294);
            this.btn_download.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(76, 30);
            this.btn_download.TabIndex = 3;
            this.btn_download.Text = "下载";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(62, 60);
            this.tb_IP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(185, 25);
            this.tb_IP.TabIndex = 4;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(311, 61);
            this.tb_port.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(75, 25);
            this.tb_port.TabIndex = 5;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(62, 155);
            this.tb_path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(243, 25);
            this.tb_path.TabIndex = 6;
            // 
            // lsb_local
            // 
            this.lsb_local.FormattingEnabled = true;
            this.lsb_local.ItemHeight = 15;
            this.lsb_local.Location = new System.Drawing.Point(4, 194);
            this.lsb_local.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_local.Name = "lsb_local";
            this.lsb_local.Size = new System.Drawing.Size(382, 94);
            this.lsb_local.TabIndex = 7;
            // 
            // lsb_server
            // 
            this.lsb_server.FormattingEnabled = true;
            this.lsb_server.ItemHeight = 15;
            this.lsb_server.Location = new System.Drawing.Point(420, 194);
            this.lsb_server.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_server.Name = "lsb_server";
            this.lsb_server.Size = new System.Drawing.Size(381, 94);
            this.lsb_server.TabIndex = 8;
            // 
            // lsb_status
            // 
            this.lsb_status.FormattingEnabled = true;
            this.lsb_status.ItemHeight = 15;
            this.lsb_status.Location = new System.Drawing.Point(4, 372);
            this.lsb_status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_status.Name = "lsb_status";
            this.lsb_status.Size = new System.Drawing.Size(797, 94);
            this.lsb_status.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "接口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "本地：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "密码：";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(679, 61);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(120, 25);
            this.tb_password.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "用户名：";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(487, 60);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(119, 25);
            this.tb_username.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 551);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsb_status);
            this.Controls.Add(this.lsb_server);
            this.Controls.Add(this.lsb_local);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_setPath);
            this.Controls.Add(this.btn_conn);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "FTP";
            this.Load += new System.EventHandler(this.FTP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.Button btn_setPath;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.ListBox lsb_local;
        private System.Windows.Forms.ListBox lsb_server;
        private System.Windows.Forms.ListBox lsb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_username;
    }
}

