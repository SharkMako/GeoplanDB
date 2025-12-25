
namespace GeoplanDB
{
    partial class NewClient
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gEOPLAN_VKRDataSet = new GeoplanDB.GEOPLAN_VKRDataSet();
            this.NcName = new System.Windows.Forms.TextBox();
            this.NcSurname = new System.Windows.Forms.TextBox();
            this.NcPhone = new System.Windows.Forms.TextBox();
            this.NcEmail = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new GeoplanDB.GEOPLAN_VKRDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new GeoplanDB.GEOPLAN_VKRDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEOPLAN_VKRDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(45, 19);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Имя:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(6, 75);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(86, 19);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Фамилия:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(6, 108);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(156, 19);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Номер телефона:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 141);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(173, 19);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Электронная почта:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.button2.Location = new System.Drawing.Point(273, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 50);
            this.button2.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(12, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.NcName);
            this.groupBox1.Controls.Add(surnameLabel);
            this.groupBox1.Controls.Add(this.NcSurname);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.NcPhone);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.NcEmail);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового клиента";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.gEOPLAN_VKRDataSet;
            // 
            // gEOPLAN_VKRDataSet
            // 
            this.gEOPLAN_VKRDataSet.DataSetName = "GEOPLAN_VKRDataSet";
            this.gEOPLAN_VKRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NcName
            // 
            this.NcName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Name", true));
            this.NcName.Location = new System.Drawing.Point(185, 39);
            this.NcName.Name = "NcName";
            this.NcName.Size = new System.Drawing.Size(220, 27);
            this.NcName.TabIndex = 3;
            // 
            // NcSurname
            // 
            this.NcSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Surname", true));
            this.NcSurname.Location = new System.Drawing.Point(185, 72);
            this.NcSurname.Name = "NcSurname";
            this.NcSurname.Size = new System.Drawing.Size(220, 27);
            this.NcSurname.TabIndex = 5;
            // 
            // NcPhone
            // 
            this.NcPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Phone", true));
            this.NcPhone.Location = new System.Drawing.Point(185, 105);
            this.NcPhone.Name = "NcPhone";
            this.NcPhone.Size = new System.Drawing.Size(220, 27);
            this.NcPhone.TabIndex = 7;
            // 
            // NcEmail
            // 
            this.NcEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Email", true));
            this.NcEmail.Location = new System.Drawing.Point(185, 138);
            this.NcEmail.Name = "NcEmail";
            this.NcEmail.Size = new System.Drawing.Size(220, 27);
            this.NcEmail.TabIndex = 9;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.CoordinatesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GeoplanDB.GEOPLAN_VKRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(438, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewClient";
            this.Text = "Новый";
            this.Load += new System.EventHandler(this.NewClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEOPLAN_VKRDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private GEOPLAN_VKRDataSet gEOPLAN_VKRDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private GEOPLAN_VKRDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private GEOPLAN_VKRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox NcName;
        private System.Windows.Forms.TextBox NcSurname;
        private System.Windows.Forms.TextBox NcPhone;
        private System.Windows.Forms.TextBox NcEmail;
    }
}