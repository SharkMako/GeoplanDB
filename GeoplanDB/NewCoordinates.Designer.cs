
namespace GeoplanDB
{
    partial class NewCoordinates
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label label1;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NcStatus = new System.Windows.Forms.TextBox();
            this.NcX = new System.Windows.Forms.TextBox();
            this.NcY = new System.Windows.Forms.TextBox();
            this.NcPogr = new System.Windows.Forms.TextBox();
            this.NcOrderID = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.button2.Location = new System.Drawing.Point(273, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.NcOrderID);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.NcStatus);
            this.groupBox1.Controls.Add(surnameLabel);
            this.groupBox1.Controls.Add(this.NcX);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.NcY);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.NcPogr);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 209);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление новых координат";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(176, 19);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Статус координаты:";
            // 
            // NcStatus
            // 
            this.NcStatus.Location = new System.Drawing.Point(185, 39);
            this.NcStatus.Name = "NcStatus";
            this.NcStatus.Size = new System.Drawing.Size(220, 27);
            this.NcStatus.TabIndex = 3;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(6, 75);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(129, 19);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Координата X:";
            // 
            // NcX
            // 
            this.NcX.Location = new System.Drawing.Point(185, 72);
            this.NcX.Name = "NcX";
            this.NcX.Size = new System.Drawing.Size(220, 27);
            this.NcX.TabIndex = 5;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(6, 108);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(128, 19);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Координата Y:";
            // 
            // NcY
            // 
            this.NcY.Location = new System.Drawing.Point(185, 105);
            this.NcY.Name = "NcY";
            this.NcY.Size = new System.Drawing.Size(220, 27);
            this.NcY.TabIndex = 7;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 141);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(117, 19);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Погрешность";
            // 
            // NcPogr
            // 
            this.NcPogr.Location = new System.Drawing.Point(185, 138);
            this.NcPogr.Name = "NcPogr";
            this.NcPogr.Size = new System.Drawing.Size(220, 27);
            this.NcPogr.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 174);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 19);
            label1.TabIndex = 10;
            label1.Text = "ID заказа";
            // 
            // NcOrderID
            // 
            this.NcOrderID.Location = new System.Drawing.Point(185, 171);
            this.NcOrderID.Name = "NcOrderID";
            this.NcOrderID.Size = new System.Drawing.Size(220, 27);
            this.NcOrderID.TabIndex = 11;
            // 
            // NewCoordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(440, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewCoordinates";
            this.Text = "Добавление";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NcStatus;
        private System.Windows.Forms.TextBox NcX;
        private System.Windows.Forms.TextBox NcY;
        private System.Windows.Forms.TextBox NcPogr;
        private System.Windows.Forms.TextBox NcOrderID;
    }
}