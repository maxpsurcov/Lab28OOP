namespace Lab28OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateDirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.MoveDirectoryButton = new System.Windows.Forms.Button();
            this.SourceDirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.DestinationDirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.CopyDirectoryButton = new System.Windows.Forms.Button();
            this.DeleteDirectoryButton = new System.Windows.Forms.Button();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.MoveFileButton = new System.Windows.Forms.Button();
            this.SourceFilePathTextBox = new System.Windows.Forms.TextBox();
            this.DestinationFilePathTextBox = new System.Windows.Forms.TextBox();
            this.CopyFileButton = new System.Windows.Forms.Button();
            this.DeleteFileButton = new System.Windows.Forms.Button();
            this.EditAttributesButton = new System.Windows.Forms.Button();
            this.EditAttributesPathTextBox = new System.Windows.Forms.TextBox();
            this.ReadOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.HiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.SystemCheckBox = new System.Windows.Forms.CheckBox();
            this.ArchiveCheckBox = new System.Windows.Forms.CheckBox();
            this.NormalCheckBox = new System.Windows.Forms.CheckBox();
            this.TemporaryCheckBox = new System.Windows.Forms.CheckBox();
            this.OfflineCheckBox = new System.Windows.Forms.CheckBox();
            this.CompressedCheckBox = new System.Windows.Forms.CheckBox();
            this.EncryptedCheckBox = new System.Windows.Forms.CheckBox();
            this.NotContentIndexedCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CompressFileButton = new System.Windows.Forms.Button();
            this.ExtractFileButton = new System.Windows.Forms.Button();
            this.EditFileTextBox = new System.Windows.Forms.TextBox();
            this.CompressFilePathTextBox = new System.Windows.Forms.TextBox();
            this.CompressArchivePathTextBox = new System.Windows.Forms.TextBox();
            this.ExtractArchivePathTextBox = new System.Windows.Forms.TextBox();
            this.ExtractDirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateDirectoryButton
            // 
            this.CreateDirectoryButton.Location = new System.Drawing.Point(26, 252);
            this.CreateDirectoryButton.Name = "CreateDirectoryButton";
            this.CreateDirectoryButton.Size = new System.Drawing.Size(175, 71);
            this.CreateDirectoryButton.TabIndex = 0;
            this.CreateDirectoryButton.Text = "CreateDirectory";
            this.CreateDirectoryButton.UseVisualStyleBackColor = true;
            this.CreateDirectoryButton.Click += new System.EventHandler(this.CreateDirectoryButton_Click);
            // 
            // DirectoryPathTextBox
            // 
            this.DirectoryPathTextBox.Location = new System.Drawing.Point(170, 63);
            this.DirectoryPathTextBox.Name = "DirectoryPathTextBox";
            this.DirectoryPathTextBox.Size = new System.Drawing.Size(254, 29);
            this.DirectoryPathTextBox.TabIndex = 1;
            // 
            // MoveDirectoryButton
            // 
            this.MoveDirectoryButton.Location = new System.Drawing.Point(26, 347);
            this.MoveDirectoryButton.Name = "MoveDirectoryButton";
            this.MoveDirectoryButton.Size = new System.Drawing.Size(180, 65);
            this.MoveDirectoryButton.TabIndex = 2;
            this.MoveDirectoryButton.Text = "MoveDirectory";
            this.MoveDirectoryButton.UseVisualStyleBackColor = true;
            this.MoveDirectoryButton.Click += new System.EventHandler(this.MoveDirectoryButton_Click);
            // 
            // SourceDirectoryPathTextBox
            // 
            this.SourceDirectoryPathTextBox.Location = new System.Drawing.Point(170, 120);
            this.SourceDirectoryPathTextBox.Name = "SourceDirectoryPathTextBox";
            this.SourceDirectoryPathTextBox.Size = new System.Drawing.Size(254, 29);
            this.SourceDirectoryPathTextBox.TabIndex = 3;
            // 
            // DestinationDirectoryPathTextBox
            // 
            this.DestinationDirectoryPathTextBox.Location = new System.Drawing.Point(170, 178);
            this.DestinationDirectoryPathTextBox.Name = "DestinationDirectoryPathTextBox";
            this.DestinationDirectoryPathTextBox.Size = new System.Drawing.Size(254, 29);
            this.DestinationDirectoryPathTextBox.TabIndex = 4;
            // 
            // CopyDirectoryButton
            // 
            this.CopyDirectoryButton.Location = new System.Drawing.Point(26, 436);
            this.CopyDirectoryButton.Name = "CopyDirectoryButton";
            this.CopyDirectoryButton.Size = new System.Drawing.Size(175, 65);
            this.CopyDirectoryButton.TabIndex = 5;
            this.CopyDirectoryButton.Text = "CopyDirectory";
            this.CopyDirectoryButton.UseVisualStyleBackColor = true;
            this.CopyDirectoryButton.Click += new System.EventHandler(this.CopyDirectoryButton_Click);
            // 
            // DeleteDirectoryButton
            // 
            this.DeleteDirectoryButton.Location = new System.Drawing.Point(26, 512);
            this.DeleteDirectoryButton.Name = "DeleteDirectoryButton";
            this.DeleteDirectoryButton.Size = new System.Drawing.Size(175, 65);
            this.DeleteDirectoryButton.TabIndex = 6;
            this.DeleteDirectoryButton.Text = "DeleteDirectory";
            this.DeleteDirectoryButton.UseVisualStyleBackColor = true;
            this.DeleteDirectoryButton.Click += new System.EventHandler(this.DeleteDirectoryButton_Click);
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.Location = new System.Drawing.Point(1189, 47);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(219, 45);
            this.CreateFileButton.TabIndex = 7;
            this.CreateFileButton.Text = "CreateFile";
            this.CreateFileButton.UseVisualStyleBackColor = true;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(578, 63);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(254, 29);
            this.FilePathTextBox.TabIndex = 8;
            // 
            // MoveFileButton
            // 
            this.MoveFileButton.Location = new System.Drawing.Point(1189, 120);
            this.MoveFileButton.Name = "MoveFileButton";
            this.MoveFileButton.Size = new System.Drawing.Size(219, 46);
            this.MoveFileButton.TabIndex = 9;
            this.MoveFileButton.Text = "MoveFile";
            this.MoveFileButton.UseVisualStyleBackColor = true;
            this.MoveFileButton.Click += new System.EventHandler(this.MoveFileButton_Click);
            // 
            // SourceFilePathTextBox
            // 
            this.SourceFilePathTextBox.Location = new System.Drawing.Point(578, 120);
            this.SourceFilePathTextBox.Name = "SourceFilePathTextBox";
            this.SourceFilePathTextBox.Size = new System.Drawing.Size(254, 29);
            this.SourceFilePathTextBox.TabIndex = 10;
            // 
            // DestinationFilePathTextBox
            // 
            this.DestinationFilePathTextBox.Location = new System.Drawing.Point(578, 178);
            this.DestinationFilePathTextBox.Name = "DestinationFilePathTextBox";
            this.DestinationFilePathTextBox.Size = new System.Drawing.Size(254, 29);
            this.DestinationFilePathTextBox.TabIndex = 11;
            // 
            // CopyFileButton
            // 
            this.CopyFileButton.Location = new System.Drawing.Point(1189, 196);
            this.CopyFileButton.Name = "CopyFileButton";
            this.CopyFileButton.Size = new System.Drawing.Size(219, 47);
            this.CopyFileButton.TabIndex = 12;
            this.CopyFileButton.Text = "CopyFile";
            this.CopyFileButton.UseVisualStyleBackColor = true;
            this.CopyFileButton.Click += new System.EventHandler(this.CopyFileButton_Click);
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.Location = new System.Drawing.Point(1189, 271);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(219, 49);
            this.DeleteFileButton.TabIndex = 13;
            this.DeleteFileButton.Text = "DeleteFile";
            this.DeleteFileButton.UseVisualStyleBackColor = true;
            this.DeleteFileButton.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // EditAttributesButton
            // 
            this.EditAttributesButton.Location = new System.Drawing.Point(26, 595);
            this.EditAttributesButton.Name = "EditAttributesButton";
            this.EditAttributesButton.Size = new System.Drawing.Size(175, 72);
            this.EditAttributesButton.TabIndex = 14;
            this.EditAttributesButton.Text = "EditAttributes";
            this.EditAttributesButton.UseVisualStyleBackColor = true;
            this.EditAttributesButton.Click += new System.EventHandler(this.EditAttributesButton_Click);
            // 
            // EditAttributesPathTextBox
            // 
            this.EditAttributesPathTextBox.Location = new System.Drawing.Point(578, 241);
            this.EditAttributesPathTextBox.Name = "EditAttributesPathTextBox";
            this.EditAttributesPathTextBox.Size = new System.Drawing.Size(254, 29);
            this.EditAttributesPathTextBox.TabIndex = 15;
            // 
            // ReadOnlyCheckBox
            // 
            this.ReadOnlyCheckBox.AutoSize = true;
            this.ReadOnlyCheckBox.Location = new System.Drawing.Point(922, 63);
            this.ReadOnlyCheckBox.Name = "ReadOnlyCheckBox";
            this.ReadOnlyCheckBox.Size = new System.Drawing.Size(125, 29);
            this.ReadOnlyCheckBox.TabIndex = 16;
            this.ReadOnlyCheckBox.Text = "ReadOnly";
            this.ReadOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HiddenCheckBox
            // 
            this.HiddenCheckBox.AutoSize = true;
            this.HiddenCheckBox.Location = new System.Drawing.Point(922, 110);
            this.HiddenCheckBox.Name = "HiddenCheckBox";
            this.HiddenCheckBox.Size = new System.Drawing.Size(100, 29);
            this.HiddenCheckBox.TabIndex = 17;
            this.HiddenCheckBox.Text = "Hidden";
            this.HiddenCheckBox.UseVisualStyleBackColor = true;
            // 
            // SystemCheckBox
            // 
            this.SystemCheckBox.AutoSize = true;
            this.SystemCheckBox.Location = new System.Drawing.Point(922, 155);
            this.SystemCheckBox.Name = "SystemCheckBox";
            this.SystemCheckBox.Size = new System.Drawing.Size(104, 29);
            this.SystemCheckBox.TabIndex = 18;
            this.SystemCheckBox.Text = "System";
            this.SystemCheckBox.UseVisualStyleBackColor = true;
            // 
            // ArchiveCheckBox
            // 
            this.ArchiveCheckBox.AutoSize = true;
            this.ArchiveCheckBox.Location = new System.Drawing.Point(922, 206);
            this.ArchiveCheckBox.Name = "ArchiveCheckBox";
            this.ArchiveCheckBox.Size = new System.Drawing.Size(104, 29);
            this.ArchiveCheckBox.TabIndex = 19;
            this.ArchiveCheckBox.Text = "Archive";
            this.ArchiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // NormalCheckBox
            // 
            this.NormalCheckBox.AutoSize = true;
            this.NormalCheckBox.Location = new System.Drawing.Point(922, 252);
            this.NormalCheckBox.Name = "NormalCheckBox";
            this.NormalCheckBox.Size = new System.Drawing.Size(100, 29);
            this.NormalCheckBox.TabIndex = 20;
            this.NormalCheckBox.Text = "Normal";
            this.NormalCheckBox.UseVisualStyleBackColor = true;
            // 
            // TemporaryCheckBox
            // 
            this.TemporaryCheckBox.AutoSize = true;
            this.TemporaryCheckBox.Location = new System.Drawing.Point(922, 300);
            this.TemporaryCheckBox.Name = "TemporaryCheckBox";
            this.TemporaryCheckBox.Size = new System.Drawing.Size(133, 29);
            this.TemporaryCheckBox.TabIndex = 21;
            this.TemporaryCheckBox.Text = "Temporary";
            this.TemporaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // OfflineCheckBox
            // 
            this.OfflineCheckBox.AutoSize = true;
            this.OfflineCheckBox.Location = new System.Drawing.Point(922, 347);
            this.OfflineCheckBox.Name = "OfflineCheckBox";
            this.OfflineCheckBox.Size = new System.Drawing.Size(94, 29);
            this.OfflineCheckBox.TabIndex = 22;
            this.OfflineCheckBox.Text = "Offline";
            this.OfflineCheckBox.UseVisualStyleBackColor = true;
            // 
            // CompressedCheckBox
            // 
            this.CompressedCheckBox.AutoSize = true;
            this.CompressedCheckBox.Location = new System.Drawing.Point(922, 391);
            this.CompressedCheckBox.Name = "CompressedCheckBox";
            this.CompressedCheckBox.Size = new System.Drawing.Size(150, 29);
            this.CompressedCheckBox.TabIndex = 23;
            this.CompressedCheckBox.Text = "Compressed";
            this.CompressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // EncryptedCheckBox
            // 
            this.EncryptedCheckBox.AutoSize = true;
            this.EncryptedCheckBox.Location = new System.Drawing.Point(922, 436);
            this.EncryptedCheckBox.Name = "EncryptedCheckBox";
            this.EncryptedCheckBox.Size = new System.Drawing.Size(126, 29);
            this.EncryptedCheckBox.TabIndex = 24;
            this.EncryptedCheckBox.Text = "Encrypted";
            this.EncryptedCheckBox.UseVisualStyleBackColor = true;
            // 
            // NotContentIndexedCheckBox
            // 
            this.NotContentIndexedCheckBox.AutoSize = true;
            this.NotContentIndexedCheckBox.Location = new System.Drawing.Point(922, 490);
            this.NotContentIndexedCheckBox.Name = "NotContentIndexedCheckBox";
            this.NotContentIndexedCheckBox.Size = new System.Drawing.Size(207, 29);
            this.NotContentIndexedCheckBox.TabIndex = 25;
            this.NotContentIndexedCheckBox.Text = "NotContentIndexed";
            this.NotContentIndexedCheckBox.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(1189, 347);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(127, 41);
            this.OpenFileButton.TabIndex = 26;
            this.OpenFileButton.Text = "OpenFile";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(1189, 410);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(127, 55);
            this.SaveFileButton.TabIndex = 27;
            this.SaveFileButton.Text = "SaveFile";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1189, 490);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(127, 53);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CompressFileButton
            // 
            this.CompressFileButton.Location = new System.Drawing.Point(1189, 564);
            this.CompressFileButton.Name = "CompressFileButton";
            this.CompressFileButton.Size = new System.Drawing.Size(158, 59);
            this.CompressFileButton.TabIndex = 29;
            this.CompressFileButton.Text = "CompressFile";
            this.CompressFileButton.UseVisualStyleBackColor = true;
            this.CompressFileButton.Click += new System.EventHandler(this.CompressFileButton_Click);
            // 
            // ExtractFileButton
            // 
            this.ExtractFileButton.Location = new System.Drawing.Point(1189, 643);
            this.ExtractFileButton.Name = "ExtractFileButton";
            this.ExtractFileButton.Size = new System.Drawing.Size(158, 54);
            this.ExtractFileButton.TabIndex = 30;
            this.ExtractFileButton.Text = "ExtractFile";
            this.ExtractFileButton.UseVisualStyleBackColor = true;
            this.ExtractFileButton.Click += new System.EventHandler(this.ExtractFileButton_Click);
            // 
            // EditFileTextBox
            // 
            this.EditFileTextBox.Location = new System.Drawing.Point(464, 436);
            this.EditFileTextBox.Name = "EditFileTextBox";
            this.EditFileTextBox.Size = new System.Drawing.Size(240, 29);
            this.EditFileTextBox.TabIndex = 31;
            // 
            // CompressFilePathTextBox
            // 
            this.CompressFilePathTextBox.Location = new System.Drawing.Point(464, 490);
            this.CompressFilePathTextBox.Name = "CompressFilePathTextBox";
            this.CompressFilePathTextBox.Size = new System.Drawing.Size(240, 29);
            this.CompressFilePathTextBox.TabIndex = 32;
            // 
            // CompressArchivePathTextBox
            // 
            this.CompressArchivePathTextBox.Location = new System.Drawing.Point(464, 538);
            this.CompressArchivePathTextBox.Name = "CompressArchivePathTextBox";
            this.CompressArchivePathTextBox.Size = new System.Drawing.Size(240, 29);
            this.CompressArchivePathTextBox.TabIndex = 33;
            // 
            // ExtractArchivePathTextBox
            // 
            this.ExtractArchivePathTextBox.Location = new System.Drawing.Point(464, 593);
            this.ExtractArchivePathTextBox.Name = "ExtractArchivePathTextBox";
            this.ExtractArchivePathTextBox.Size = new System.Drawing.Size(240, 29);
            this.ExtractArchivePathTextBox.TabIndex = 34;
            // 
            // ExtractDirectoryPathTextBox
            // 
            this.ExtractDirectoryPathTextBox.Location = new System.Drawing.Point(464, 637);
            this.ExtractDirectoryPathTextBox.Name = "ExtractDirectoryPathTextBox";
            this.ExtractDirectoryPathTextBox.Size = new System.Drawing.Size(240, 29);
            this.ExtractDirectoryPathTextBox.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 719);
            this.Controls.Add(this.ExtractDirectoryPathTextBox);
            this.Controls.Add(this.ExtractArchivePathTextBox);
            this.Controls.Add(this.CompressArchivePathTextBox);
            this.Controls.Add(this.CompressFilePathTextBox);
            this.Controls.Add(this.EditFileTextBox);
            this.Controls.Add(this.ExtractFileButton);
            this.Controls.Add(this.CompressFileButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.NotContentIndexedCheckBox);
            this.Controls.Add(this.EncryptedCheckBox);
            this.Controls.Add(this.CompressedCheckBox);
            this.Controls.Add(this.OfflineCheckBox);
            this.Controls.Add(this.TemporaryCheckBox);
            this.Controls.Add(this.NormalCheckBox);
            this.Controls.Add(this.ArchiveCheckBox);
            this.Controls.Add(this.SystemCheckBox);
            this.Controls.Add(this.HiddenCheckBox);
            this.Controls.Add(this.ReadOnlyCheckBox);
            this.Controls.Add(this.EditAttributesPathTextBox);
            this.Controls.Add(this.EditAttributesButton);
            this.Controls.Add(this.DeleteFileButton);
            this.Controls.Add(this.CopyFileButton);
            this.Controls.Add(this.DestinationFilePathTextBox);
            this.Controls.Add(this.SourceFilePathTextBox);
            this.Controls.Add(this.MoveFileButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.CreateFileButton);
            this.Controls.Add(this.DeleteDirectoryButton);
            this.Controls.Add(this.CopyDirectoryButton);
            this.Controls.Add(this.DestinationDirectoryPathTextBox);
            this.Controls.Add(this.SourceDirectoryPathTextBox);
            this.Controls.Add(this.MoveDirectoryButton);
            this.Controls.Add(this.DirectoryPathTextBox);
            this.Controls.Add(this.CreateDirectoryButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDirectoryButton;
        private System.Windows.Forms.TextBox DirectoryPathTextBox;
        private System.Windows.Forms.Button MoveDirectoryButton;
        private System.Windows.Forms.TextBox SourceDirectoryPathTextBox;
        private System.Windows.Forms.TextBox DestinationDirectoryPathTextBox;
        private System.Windows.Forms.Button CopyDirectoryButton;
        private System.Windows.Forms.Button DeleteDirectoryButton;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button MoveFileButton;
        private System.Windows.Forms.TextBox SourceFilePathTextBox;
        private System.Windows.Forms.TextBox DestinationFilePathTextBox;
        private System.Windows.Forms.Button CopyFileButton;
        private System.Windows.Forms.Button DeleteFileButton;
        private System.Windows.Forms.Button EditAttributesButton;
        private System.Windows.Forms.TextBox EditAttributesPathTextBox;
        private System.Windows.Forms.CheckBox ReadOnlyCheckBox;
        private System.Windows.Forms.CheckBox HiddenCheckBox;
        private System.Windows.Forms.CheckBox SystemCheckBox;
        private System.Windows.Forms.CheckBox ArchiveCheckBox;
        private System.Windows.Forms.CheckBox NormalCheckBox;
        private System.Windows.Forms.CheckBox TemporaryCheckBox;
        private System.Windows.Forms.CheckBox OfflineCheckBox;
        private System.Windows.Forms.CheckBox CompressedCheckBox;
        private System.Windows.Forms.CheckBox EncryptedCheckBox;
        private System.Windows.Forms.CheckBox NotContentIndexedCheckBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CompressFileButton;
        private System.Windows.Forms.Button ExtractFileButton;
        private System.Windows.Forms.TextBox EditFileTextBox;
        private System.Windows.Forms.TextBox CompressFilePathTextBox;
        private System.Windows.Forms.TextBox CompressArchivePathTextBox;
        private System.Windows.Forms.TextBox ExtractArchivePathTextBox;
        private System.Windows.Forms.TextBox ExtractDirectoryPathTextBox;
    }
}

