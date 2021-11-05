
namespace Zork.Builder
{
    partial class ZorkBuilderForm
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
            System.Windows.Forms.Label startingLocationLabel;
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label exitMessageLabel;
            System.Windows.Forms.MenuStrip menuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem1;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem2;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
            System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
            System.Windows.Forms.TabControl tabControl;
            System.Windows.Forms.TabPage startTabPage;
            System.Windows.Forms.TabPage welcomeTabPage;
            System.Windows.Forms.TabPage exitTabPage;
            System.Windows.Forms.GroupBox roomsGroupBox;
            System.Windows.Forms.GroupBox roomInfoGroupBox;
            System.Windows.Forms.GroupBox neighborsGroupBox;
            System.Windows.Forms.TextBox descriptionTextBox;
            System.Windows.Forms.TextBox roomNameTextBox;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label roomNameLabel;
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.welcomeTextBox = new System.Windows.Forms.TextBox();
            this.exitTextBox = new System.Windows.Forms.TextBox();
            this.removeRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.westNeighborDirectionControl = new Zork.Builder.UserControls.NeighborDirectionControl();
            this.eastNeighborDirectionControl = new Zork.Builder.UserControls.NeighborDirectionControl();
            this.southNeighborDirectionControl = new Zork.Builder.UserControls.NeighborDirectionControl();
            this.northNeighborDirectionControl = new Zork.Builder.UserControls.NeighborDirectionControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.welcomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            startingLocationLabel = new System.Windows.Forms.Label();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            exitMessageLabel = new System.Windows.Forms.Label();
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileSeparatorStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            fileSeparatorStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabControl = new System.Windows.Forms.TabControl();
            startTabPage = new System.Windows.Forms.TabPage();
            welcomeTabPage = new System.Windows.Forms.TabPage();
            exitTabPage = new System.Windows.Forms.TabPage();
            roomsGroupBox = new System.Windows.Forms.GroupBox();
            roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            neighborsGroupBox = new System.Windows.Forms.GroupBox();
            descriptionTextBox = new System.Windows.Forms.TextBox();
            roomNameTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            menuStrip.SuspendLayout();
            tabControl.SuspendLayout();
            startTabPage.SuspendLayout();
            welcomeTabPage.SuspendLayout();
            exitTabPage.SuspendLayout();
            roomsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            roomInfoGroupBox.SuspendLayout();
            neighborsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startingLocationLabel
            // 
            startingLocationLabel.AutoSize = true;
            startingLocationLabel.Location = new System.Drawing.Point(4, 9);
            startingLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            startingLocationLabel.Name = "startingLocationLabel";
            startingLocationLabel.Size = new System.Drawing.Size(90, 13);
            startingLocationLabel.TabIndex = 2;
            startingLocationLabel.Text = "Starting Location:";
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Location = new System.Drawing.Point(4, 9);
            welcomeMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new System.Drawing.Size(101, 13);
            welcomeMessageLabel.TabIndex = 4;
            welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // exitMessageLabel
            // 
            exitMessageLabel.AutoSize = true;
            exitMessageLabel.Location = new System.Drawing.Point(4, 9);
            exitMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            exitMessageLabel.Name = "exitMessageLabel";
            exitMessageLabel.Size = new System.Drawing.Size(73, 13);
            exitMessageLabel.TabIndex = 4;
            exitMessageLabel.Text = "Exit Message:";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            editToolStripMenuItem});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(493, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            openRecentToolStripMenuItem,
            fileSeparatorStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            fileSeparatorStripMenuItem2,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openRecentToolStripMenuItem
            // 
            openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            openRecentToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openRecentToolStripMenuItem.Text = "Open Recent";
            // 
            // fileSeparatorStripMenuItem1
            // 
            fileSeparatorStripMenuItem1.Name = "fileSeparatorStripMenuItem1";
            fileSeparatorStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // fileSeparatorStripMenuItem2
            // 
            fileSeparatorStripMenuItem2.Name = "fileSeparatorStripMenuItem2";
            fileSeparatorStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            undoToolStripMenuItem,
            redoToolStripMenuItem,
            toolStripMenuItem3,
            cutToolStripMenuItem,
            copyToolStripMenuItem,
            pasteToolStripMenuItem});
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(startTabPage);
            tabControl.Controls.Add(welcomeTabPage);
            tabControl.Controls.Add(exitTabPage);
            tabControl.Location = new System.Drawing.Point(6, 28);
            tabControl.Margin = new System.Windows.Forms.Padding(2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(150, 81);
            tabControl.TabIndex = 1;
            // 
            // startTabPage
            // 
            startTabPage.Controls.Add(this.startingLocationComboBox);
            startTabPage.Controls.Add(startingLocationLabel);
            startTabPage.Location = new System.Drawing.Point(4, 22);
            startTabPage.Margin = new System.Windows.Forms.Padding(2);
            startTabPage.Name = "startTabPage";
            startTabPage.Padding = new System.Windows.Forms.Padding(2);
            startTabPage.Size = new System.Drawing.Size(142, 55);
            startTabPage.TabIndex = 0;
            startTabPage.Text = "Start";
            startTabPage.UseVisualStyleBackColor = true;
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(4, 26);
            this.startingLocationComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(134, 21);
            this.startingLocationComboBox.TabIndex = 12;
            // 
            // welcomeTabPage
            // 
            welcomeTabPage.Controls.Add(welcomeMessageLabel);
            welcomeTabPage.Controls.Add(this.welcomeTextBox);
            welcomeTabPage.Location = new System.Drawing.Point(4, 22);
            welcomeTabPage.Margin = new System.Windows.Forms.Padding(2);
            welcomeTabPage.Name = "welcomeTabPage";
            welcomeTabPage.Padding = new System.Windows.Forms.Padding(2);
            welcomeTabPage.Size = new System.Drawing.Size(142, 55);
            welcomeTabPage.TabIndex = 1;
            welcomeTabPage.Text = "Welcome";
            welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.Location = new System.Drawing.Point(6, 28);
            this.welcomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(134, 20);
            this.welcomeTextBox.TabIndex = 3;
            // 
            // exitTabPage
            // 
            exitTabPage.Controls.Add(exitMessageLabel);
            exitTabPage.Controls.Add(this.exitTextBox);
            exitTabPage.Location = new System.Drawing.Point(4, 22);
            exitTabPage.Margin = new System.Windows.Forms.Padding(2);
            exitTabPage.Name = "exitTabPage";
            exitTabPage.Size = new System.Drawing.Size(142, 55);
            exitTabPage.TabIndex = 2;
            exitTabPage.Text = "Exit";
            exitTabPage.UseVisualStyleBackColor = true;
            // 
            // exitTextBox
            // 
            this.exitTextBox.Location = new System.Drawing.Point(6, 28);
            this.exitTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.exitTextBox.Name = "exitTextBox";
            this.exitTextBox.Size = new System.Drawing.Size(134, 20);
            this.exitTextBox.TabIndex = 3;
            // 
            // roomsGroupBox
            // 
            roomsGroupBox.Controls.Add(this.removeRoomButton);
            roomsGroupBox.Controls.Add(this.addRoomButton);
            roomsGroupBox.Controls.Add(this.roomsListBox);
            roomsGroupBox.Location = new System.Drawing.Point(9, 111);
            roomsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            roomsGroupBox.Name = "roomsGroupBox";
            roomsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            roomsGroupBox.Size = new System.Drawing.Size(150, 245);
            roomsGroupBox.TabIndex = 3;
            roomsGroupBox.TabStop = false;
            roomsGroupBox.Text = "Rooms List";
            // 
            // removeRoomButton
            // 
            this.removeRoomButton.Enabled = false;
            this.removeRoomButton.Location = new System.Drawing.Point(89, 221);
            this.removeRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeRoomButton.Name = "removeRoomButton";
            this.removeRoomButton.Size = new System.Drawing.Size(56, 19);
            this.removeRoomButton.TabIndex = 5;
            this.removeRoomButton.Text = "Remove";
            this.removeRoomButton.UseVisualStyleBackColor = true;
            this.removeRoomButton.Click += new System.EventHandler(this.removeRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Enabled = false;
            this.addRoomButton.Location = new System.Drawing.Point(3, 221);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(56, 19);
            this.addRoomButton.TabIndex = 4;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(3, 17);
            this.roomsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(144, 199);
            this.roomsListBox.TabIndex = 2;
            this.roomsListBox.ValueMember = "Description";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            this.gameViewModelBindingSource.CurrentChanged += new System.EventHandler(this.gameViewModelBindingSource_CurrentChanged);
            // 
            // roomInfoGroupBox
            // 
            roomInfoGroupBox.Controls.Add(neighborsGroupBox);
            roomInfoGroupBox.Controls.Add(descriptionTextBox);
            roomInfoGroupBox.Controls.Add(roomNameTextBox);
            roomInfoGroupBox.Controls.Add(descriptionLabel);
            roomInfoGroupBox.Controls.Add(roomNameLabel);
            roomInfoGroupBox.Location = new System.Drawing.Point(176, 25);
            roomInfoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            roomInfoGroupBox.Name = "roomInfoGroupBox";
            roomInfoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            roomInfoGroupBox.Size = new System.Drawing.Size(304, 331);
            roomInfoGroupBox.TabIndex = 4;
            roomInfoGroupBox.TabStop = false;
            roomInfoGroupBox.Text = "Room Info";
            // 
            // neighborsGroupBox
            // 
            neighborsGroupBox.Controls.Add(this.westNeighborDirectionControl);
            neighborsGroupBox.Controls.Add(this.eastNeighborDirectionControl);
            neighborsGroupBox.Controls.Add(this.southNeighborDirectionControl);
            neighborsGroupBox.Controls.Add(this.northNeighborDirectionControl);
            neighborsGroupBox.Location = new System.Drawing.Point(16, 154);
            neighborsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            neighborsGroupBox.Name = "neighborsGroupBox";
            neighborsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            neighborsGroupBox.Size = new System.Drawing.Size(271, 162);
            neighborsGroupBox.TabIndex = 5;
            neighborsGroupBox.TabStop = false;
            neighborsGroupBox.Text = "Neighbors";
            // 
            // westNeighborDirectionControl
            // 
            this.westNeighborDirectionControl.Location = new System.Drawing.Point(7, 119);
            this.westNeighborDirectionControl.Name = "westNeighborDirectionControl";
            this.westNeighborDirectionControl.Size = new System.Drawing.Size(259, 29);
            this.westNeighborDirectionControl.TabIndex = 3;
            // 
            // eastNeighborDirectionControl
            // 
            this.eastNeighborDirectionControl.Location = new System.Drawing.Point(7, 88);
            this.eastNeighborDirectionControl.Name = "eastNeighborDirectionControl";
            this.eastNeighborDirectionControl.Size = new System.Drawing.Size(259, 29);
            this.eastNeighborDirectionControl.TabIndex = 2;
            // 
            // southNeighborDirectionControl
            // 
            this.southNeighborDirectionControl.Location = new System.Drawing.Point(7, 53);
            this.southNeighborDirectionControl.Name = "southNeighborDirectionControl";
            this.southNeighborDirectionControl.Size = new System.Drawing.Size(259, 29);
            this.southNeighborDirectionControl.TabIndex = 1;
            // 
            // northNeighborDirectionControl
            // 
            this.northNeighborDirectionControl.Location = new System.Drawing.Point(7, 18);
            this.northNeighborDirectionControl.Name = "northNeighborDirectionControl";
            this.northNeighborDirectionControl.Size = new System.Drawing.Size(259, 29);
            this.northNeighborDirectionControl.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            descriptionTextBox.Location = new System.Drawing.Point(16, 72);
            descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new System.Drawing.Size(272, 69);
            descriptionTextBox.TabIndex = 4;
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            roomNameTextBox.Location = new System.Drawing.Point(86, 19);
            roomNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.Size = new System.Drawing.Size(202, 20);
            roomNameTextBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(14, 51);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(14, 20);
            roomNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(69, 13);
            roomNameLabel.TabIndex = 1;
            roomNameLabel.Text = "Room Name:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            // 
            // welcomeBindingSource
            // 
            this.welcomeBindingSource.AllowNew = true;
            this.welcomeBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // ZorkBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 366);
            this.Controls.Add(roomInfoGroupBox);
            this.Controls.Add(roomsGroupBox);
            this.Controls.Add(tabControl);
            this.Controls.Add(menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ZorkBuilderForm";
            this.Text = "ZorkBuilder";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tabControl.ResumeLayout(false);
            startTabPage.ResumeLayout(false);
            startTabPage.PerformLayout();
            welcomeTabPage.ResumeLayout(false);
            welcomeTabPage.PerformLayout();
            exitTabPage.ResumeLayout(false);
            exitTabPage.PerformLayout();
            roomsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            roomInfoGroupBox.ResumeLayout(false);
            roomInfoGroupBox.PerformLayout();
            neighborsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button removeRoomButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        public System.Windows.Forms.BindingSource welcomeBindingSource;
        private System.Windows.Forms.TextBox welcomeTextBox;
        private System.Windows.Forms.TextBox exitTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private UserControls.NeighborDirectionControl westNeighborDirectionControl;
        private UserControls.NeighborDirectionControl eastNeighborDirectionControl;
        private UserControls.NeighborDirectionControl southNeighborDirectionControl;
        private UserControls.NeighborDirectionControl northNeighborDirectionControl;
    }
}

