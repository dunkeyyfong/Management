namespace AnimalManagement
{
    partial class Management
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtNational = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grvAnimal = new System.Windows.Forms.DataGridView();
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalNational = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(567, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(462, 311);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 26;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtNational
            // 
            this.txtNational.Location = new System.Drawing.Point(111, 271);
            this.txtNational.Multiline = true;
            this.txtNational.Name = "txtNational";
            this.txtNational.Size = new System.Drawing.Size(260, 74);
            this.txtNational.TabIndex = 24;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(311, 205);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(110, 207);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(159, 20);
            this.txtImage.TabIndex = 22;
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Mammals",
            "Amphibians",
            "Sponges",
            "Birds",
            "Insects",
            "Turtle",
            "Reptiles",
            "Fish",
            "Alligator"});
            this.cboxType.Location = new System.Drawing.Point(110, 148);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(131, 21);
            this.cboxType.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 87);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(101, 20);
            this.txtID.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Animal National";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Animal Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Animal Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Animal ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Animal Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(677, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grvAnimal
            // 
            this.grvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalName,
            this.AnimalID,
            this.AnimalType,
            this.AnimalImage,
            this.AnimalNational});
            this.grvAnimal.Location = new System.Drawing.Point(28, 414);
            this.grvAnimal.Name = "grvAnimal";
            this.grvAnimal.Size = new System.Drawing.Size(697, 145);
            this.grvAnimal.TabIndex = 30;
            this.grvAnimal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvAnimal_CellClick);
            // 
            // AnimalName
            // 
            this.AnimalName.DataPropertyName = "nameAnimal";
            this.AnimalName.HeaderText = "Animal Name";
            this.AnimalName.Name = "AnimalName";
            // 
            // AnimalID
            // 
            this.AnimalID.DataPropertyName = "idAnimal";
            this.AnimalID.HeaderText = "Animal ID";
            this.AnimalID.Name = "AnimalID";
            // 
            // AnimalType
            // 
            this.AnimalType.DataPropertyName = "typeAnimal";
            this.AnimalType.HeaderText = "Animal Type";
            this.AnimalType.Name = "AnimalType";
            // 
            // AnimalImage
            // 
            this.AnimalImage.DataPropertyName = "imageAnimal";
            this.AnimalImage.HeaderText = "Animal Image";
            this.AnimalImage.Name = "AnimalImage";
            // 
            // AnimalNational
            // 
            this.AnimalNational.DataPropertyName = "fromAnimal";
            this.AnimalNational.HeaderText = "Animal National";
            this.AnimalNational.Name = "AnimalNational";
            // 
            // pBoxImage
            // 
            this.pBoxImage.Location = new System.Drawing.Point(466, 31);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(281, 256);
            this.pBoxImage.TabIndex = 25;
            this.pBoxImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "List of Animal";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grvAnimal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.pBoxImage);
            this.Controls.Add(this.txtNational);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.PictureBox pBoxImage;
        private System.Windows.Forms.TextBox txtNational;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grvAnimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalNational;
    }
}