
namespace file_collector
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl_sourceFolders = new System.Windows.Forms.Label();
            this.txt_folderOrigin = new System.Windows.Forms.TextBox();
            this.list_folders_origins = new System.Windows.Forms.ListBox();
            this.btn_folderSearch = new System.Windows.Forms.Button();
            this.btn_copyToggle = new System.Windows.Forms.Button();
            this.btn_moveToggle = new System.Windows.Forms.Button();
            this.lbl_folderDestination = new System.Windows.Forms.Label();
            this.btn_folderDestination_search = new System.Windows.Forms.Button();
            this.txt_folderDestination = new System.Windows.Forms.TextBox();
            this.btn_folderOrigin_submit = new System.Windows.Forms.Button();
            this.btn_submit_final = new System.Windows.Forms.Button();
            this.lbl_testThingy = new System.Windows.Forms.Label();
            this.check_getSubDirectories = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sourceFolders
            // 
            this.lbl_sourceFolders.AutoSize = true;
            this.lbl_sourceFolders.Location = new System.Drawing.Point(15, 27);
            this.lbl_sourceFolders.Name = "lbl_sourceFolders";
            this.lbl_sourceFolders.Size = new System.Drawing.Size(114, 15);
            this.lbl_sourceFolders.TabIndex = 0;
            this.lbl_sourceFolders.Text = "Originating Folders: ";
            // 
            // txt_folderOrigin
            // 
            this.txt_folderOrigin.AcceptsReturn = true;
            this.txt_folderOrigin.Location = new System.Drawing.Point(15, 45);
            this.txt_folderOrigin.Name = "txt_folderOrigin";
            this.txt_folderOrigin.Size = new System.Drawing.Size(234, 23);
            this.txt_folderOrigin.TabIndex = 1;
            this.txt_folderOrigin.UseWaitCursor = true;
            // 
            // list_folders_origins
            // 
            this.list_folders_origins.FormattingEnabled = true;
            this.list_folders_origins.ItemHeight = 15;
            this.list_folders_origins.Location = new System.Drawing.Point(15, 109);
            this.list_folders_origins.Name = "list_folders_origins";
            this.list_folders_origins.Size = new System.Drawing.Size(314, 79);
            this.list_folders_origins.TabIndex = 2;
            // 
            // btn_folderSearch
            // 
            this.btn_folderSearch.Location = new System.Drawing.Point(255, 45);
            this.btn_folderSearch.Name = "btn_folderSearch";
            this.btn_folderSearch.Size = new System.Drawing.Size(74, 22);
            this.btn_folderSearch.TabIndex = 3;
            this.btn_folderSearch.Text = "Search";
            this.btn_folderSearch.UseVisualStyleBackColor = true;
            this.btn_folderSearch.Click += new System.EventHandler(this.btn_folderSearch_Click);
            // 
            // btn_copyToggle
            // 
            this.btn_copyToggle.Location = new System.Drawing.Point(16, 195);
            this.btn_copyToggle.Name = "btn_copyToggle";
            this.btn_copyToggle.Size = new System.Drawing.Size(112, 30);
            this.btn_copyToggle.TabIndex = 4;
            this.btn_copyToggle.Text = "Copy";
            this.btn_copyToggle.UseVisualStyleBackColor = true;
            // 
            // btn_moveToggle
            // 
            this.btn_moveToggle.Location = new System.Drawing.Point(134, 195);
            this.btn_moveToggle.Name = "btn_moveToggle";
            this.btn_moveToggle.Size = new System.Drawing.Size(112, 30);
            this.btn_moveToggle.TabIndex = 5;
            this.btn_moveToggle.Text = "Move";
            this.btn_moveToggle.UseVisualStyleBackColor = true;
            // 
            // lbl_folderDestination
            // 
            this.lbl_folderDestination.AutoSize = true;
            this.lbl_folderDestination.Location = new System.Drawing.Point(19, 242);
            this.lbl_folderDestination.Name = "lbl_folderDestination";
            this.lbl_folderDestination.Size = new System.Drawing.Size(140, 15);
            this.lbl_folderDestination.TabIndex = 6;
            this.lbl_folderDestination.Text = "Destination Parent Folder";
            // 
            // btn_folderDestination_search
            // 
            this.btn_folderDestination_search.Location = new System.Drawing.Point(255, 260);
            this.btn_folderDestination_search.Name = "btn_folderDestination_search";
            this.btn_folderDestination_search.Size = new System.Drawing.Size(74, 22);
            this.btn_folderDestination_search.TabIndex = 8;
            this.btn_folderDestination_search.Text = "Search";
            this.btn_folderDestination_search.UseVisualStyleBackColor = true;
            // 
            // txt_folderDestination
            // 
            this.txt_folderDestination.Location = new System.Drawing.Point(15, 260);
            this.txt_folderDestination.Name = "txt_folderDestination";
            this.txt_folderDestination.Size = new System.Drawing.Size(234, 23);
            this.txt_folderDestination.TabIndex = 7;
            // 
            // btn_folderOrigin_submit
            // 
            this.btn_folderOrigin_submit.Location = new System.Drawing.Point(15, 74);
            this.btn_folderOrigin_submit.Name = "btn_folderOrigin_submit";
            this.btn_folderOrigin_submit.Size = new System.Drawing.Size(111, 23);
            this.btn_folderOrigin_submit.TabIndex = 9;
            this.btn_folderOrigin_submit.Text = "Add";
            this.btn_folderOrigin_submit.UseVisualStyleBackColor = true;
            // 
            // btn_submit_final
            // 
            this.btn_submit_final.Location = new System.Drawing.Point(99, 300);
            this.btn_submit_final.Name = "btn_submit_final";
            this.btn_submit_final.Size = new System.Drawing.Size(137, 36);
            this.btn_submit_final.TabIndex = 10;
            this.btn_submit_final.Text = "Submit";
            this.btn_submit_final.UseVisualStyleBackColor = true;
            // 
            // lbl_testThingy
            // 
            this.lbl_testThingy.AutoSize = true;
            this.lbl_testThingy.Location = new System.Drawing.Point(20, 381);
            this.lbl_testThingy.Name = "lbl_testThingy";
            this.lbl_testThingy.Size = new System.Drawing.Size(58, 15);
            this.lbl_testThingy.TabIndex = 11;
            this.lbl_testThingy.Text = "Test Label";
            // 
            // check_getSubDirectories
            // 
            this.check_getSubDirectories.AutoSize = true;
            this.check_getSubDirectories.Location = new System.Drawing.Point(148, 78);
            this.check_getSubDirectories.Name = "check_getSubDirectories";
            this.check_getSubDirectories.Size = new System.Drawing.Size(134, 19);
            this.check_getSubDirectories.TabIndex = 12;
            this.check_getSubDirectories.Text = "Use Sub-Directories?";
            this.check_getSubDirectories.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 472);
            this.Controls.Add(this.check_getSubDirectories);
            this.Controls.Add(this.lbl_testThingy);
            this.Controls.Add(this.btn_submit_final);
            this.Controls.Add(this.btn_folderOrigin_submit);
            this.Controls.Add(this.btn_folderDestination_search);
            this.Controls.Add(this.txt_folderDestination);
            this.Controls.Add(this.lbl_folderDestination);
            this.Controls.Add(this.btn_moveToggle);
            this.Controls.Add(this.btn_copyToggle);
            this.Controls.Add(this.btn_folderSearch);
            this.Controls.Add(this.list_folders_origins);
            this.Controls.Add(this.txt_folderOrigin);
            this.Controls.Add(this.lbl_sourceFolders);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File Collector";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sourceFolders;
        private System.Windows.Forms.TextBox txt_folderOrigin;
        private System.Windows.Forms.ListBox list_folders_origins;
        private System.Windows.Forms.Button btn_folderSearch;
        private System.Windows.Forms.Button btn_copyToggle;
        private System.Windows.Forms.Button btn_moveToggle;
        private System.Windows.Forms.Label lbl_folderDestination;
        private System.Windows.Forms.Button btn_folderDestination_search;
        private System.Windows.Forms.TextBox txt_folderDestination;
        private System.Windows.Forms.Button btn_folderOrigin_submit;
        private System.Windows.Forms.Button btn_submit_final;
        private System.Windows.Forms.Label lbl_testThingy;
        private System.Windows.Forms.CheckBox check_getSubDirectories;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

