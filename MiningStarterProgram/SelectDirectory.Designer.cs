namespace MiningStarterProgram
{
    partial class SelectDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDirectory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_SelectFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_CopyDirectory = new System.Windows.Forms.Button();
            this.Btn_EditFile = new System.Windows.Forms.Button();
            this.Lbl_Folder = new System.Windows.Forms.Label();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All rights of this software are protected under the GPL license.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyright© 2021 BerkishTechnology";
            // 
            // Btn_SelectFolder
            // 
            this.Btn_SelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SelectFolder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_SelectFolder.Location = new System.Drawing.Point(51, 12);
            this.Btn_SelectFolder.Name = "Btn_SelectFolder";
            this.Btn_SelectFolder.Size = new System.Drawing.Size(282, 63);
            this.Btn_SelectFolder.TabIndex = 2;
            this.Btn_SelectFolder.Text = "Select Your Mining Folder";
            this.Btn_SelectFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SelectFolder.UseVisualStyleBackColor = true;
            this.Btn_SelectFolder.Click += new System.EventHandler(this.Btn_SelectFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected Folder : ";
            // 
            // Btn_CopyDirectory
            // 
            this.Btn_CopyDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CopyDirectory.Enabled = false;
            this.Btn_CopyDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CopyDirectory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_CopyDirectory.Location = new System.Drawing.Point(51, 97);
            this.Btn_CopyDirectory.Name = "Btn_CopyDirectory";
            this.Btn_CopyDirectory.Size = new System.Drawing.Size(282, 63);
            this.Btn_CopyDirectory.TabIndex = 4;
            this.Btn_CopyDirectory.Text = "Start Copy Progress";
            this.Btn_CopyDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_CopyDirectory.UseVisualStyleBackColor = true;
            this.Btn_CopyDirectory.Click += new System.EventHandler(this.Btn_CopyDirectory_Click);
            // 
            // Btn_EditFile
            // 
            this.Btn_EditFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EditFile.Enabled = false;
            this.Btn_EditFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_EditFile.Location = new System.Drawing.Point(51, 183);
            this.Btn_EditFile.Name = "Btn_EditFile";
            this.Btn_EditFile.Size = new System.Drawing.Size(282, 63);
            this.Btn_EditFile.TabIndex = 5;
            this.Btn_EditFile.Text = "Edit Mining .bat File";
            this.Btn_EditFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditFile.UseVisualStyleBackColor = true;
            this.Btn_EditFile.Click += new System.EventHandler(this.Btn_EditFile_Click);
            // 
            // Lbl_Folder
            // 
            this.Lbl_Folder.AutoSize = true;
            this.Lbl_Folder.Location = new System.Drawing.Point(134, 78);
            this.Lbl_Folder.Name = "Lbl_Folder";
            this.Lbl_Folder.Size = new System.Drawing.Size(31, 13);
            this.Lbl_Folder.TabIndex = 6;
            this.Lbl_Folder.Text = "none";
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(134, 163);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(31, 13);
            this.Lbl_Status.TabIndex = 9;
            this.Lbl_Status.Text = "none";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Progress Status : ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::MiningStarterProgram.Properties.Resources.iconfinder_User_Interface_edit_pencil_UI_interface_7548981;
            this.pictureBox3.Location = new System.Drawing.Point(51, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::MiningStarterProgram.Properties.Resources.iconfinder_User_Interface_play_cirle_start_UI_interface_7549052;
            this.pictureBox2.Location = new System.Drawing.Point(51, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::MiningStarterProgram.Properties.Resources.iconfinder_User_interface_folder_file_storage_document_interface_7549003;
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "1)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "3)";
            // 
            // SelectDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 304);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Folder);
            this.Controls.Add(this.Btn_EditFile);
            this.Controls.Add(this.Btn_CopyDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_SelectFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Berkish Technology | MiningStarterProgram 2021";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_SelectFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_CopyDirectory;
        private System.Windows.Forms.Button Btn_EditFile;
        private System.Windows.Forms.Label Lbl_Folder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}