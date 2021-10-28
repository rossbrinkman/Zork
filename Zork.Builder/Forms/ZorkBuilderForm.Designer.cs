
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
            System.Windows.Forms.MenuStrip menuStrip1;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem1;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
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
            System.Windows.Forms.ComboBox startingLocationComboBox;
            System.Windows.Forms.TabPage welcomeTabPage;
            System.Windows.Forms.TextBox welcomTextBox;
            System.Windows.Forms.TabPage exitTabPage;
            System.Windows.Forms.TextBox exitTextBox;
            System.Windows.Forms.ListBox roomsListBox;
            System.Windows.Forms.GroupBox roomsGroupBox;
            System.Windows.Forms.Button removeRoomButton;
            System.Windows.Forms.Button addRoomButton;
            System.Windows.Forms.GroupBox roomInfoGroupBox;
            System.Windows.Forms.TextBox itemsTextBox;
            System.Windows.Forms.Label itemsLabel;
            System.Windows.Forms.GroupBox neighborsGroupBox;
            System.Windows.Forms.ComboBox westComboBox;
            System.Windows.Forms.ComboBox eastComboBox;
            System.Windows.Forms.ComboBox southComboBox;
            System.Windows.Forms.ComboBox northComboBox;
            System.Windows.Forms.Label southLabel;
            System.Windows.Forms.Label eastLabel;
            System.Windows.Forms.Label westLabel;
            System.Windows.Forms.Label northLlabel;
            System.Windows.Forms.TextBox descriptionTextBox;
            System.Windows.Forms.TextBox roomNameTextBox;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label roomNameLabel;
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.neighborsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            startingLocationLabel = new System.Windows.Forms.Label();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            exitMessageLabel = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileSeparatorStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            startingLocationComboBox = new System.Windows.Forms.ComboBox();
            welcomeTabPage = new System.Windows.Forms.TabPage();
            welcomTextBox = new System.Windows.Forms.TextBox();
            exitTabPage = new System.Windows.Forms.TabPage();
            exitTextBox = new System.Windows.Forms.TextBox();
            roomsListBox = new System.Windows.Forms.ListBox();
            roomsGroupBox = new System.Windows.Forms.GroupBox();
            removeRoomButton = new System.Windows.Forms.Button();
            addRoomButton = new System.Windows.Forms.Button();
            roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            itemsTextBox = new System.Windows.Forms.TextBox();
            itemsLabel = new System.Windows.Forms.Label();
            neighborsGroupBox = new System.Windows.Forms.GroupBox();
            westComboBox = new System.Windows.Forms.ComboBox();
            eastComboBox = new System.Windows.Forms.ComboBox();
            southComboBox = new System.Windows.Forms.ComboBox();
            northComboBox = new System.Windows.Forms.ComboBox();
            southLabel = new System.Windows.Forms.Label();
            eastLabel = new System.Windows.Forms.Label();
            westLabel = new System.Windows.Forms.Label();
            northLlabel = new System.Windows.Forms.Label();
            descriptionTextBox = new System.Windows.Forms.TextBox();
            roomNameTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            startTabPage.SuspendLayout();
            welcomeTabPage.SuspendLayout();
            exitTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            roomsGroupBox.SuspendLayout();
            roomInfoGroupBox.SuspendLayout();
            neighborsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startingLocationLabel
            // 
            startingLocationLabel.AutoSize = true;
            startingLocationLabel.Location = new System.Drawing.Point(5, 11);
            startingLocationLabel.Name = "startingLocationLabel";
            startingLocationLabel.Size = new System.Drawing.Size(119, 17);
            startingLocationLabel.TabIndex = 2;
            startingLocationLabel.Text = "Starting Location:";
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Location = new System.Drawing.Point(5, 11);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new System.Drawing.Size(131, 17);
            welcomeMessageLabel.TabIndex = 4;
            welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // exitMessageLabel
            // 
            exitMessageLabel.AutoSize = true;
            exitMessageLabel.Location = new System.Drawing.Point(5, 11);
            exitMessageLabel.Name = "exitMessageLabel";
            exitMessageLabel.Size = new System.Drawing.Size(95, 17);
            exitMessageLabel.TabIndex = 4;
            exitMessageLabel.Text = "Exit Message:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            editToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(657, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            openRecentToolStripMenuItem,
            fileSeparatorStripMenuItem1,
            saveToolStripMenuItem,
            saveAsToolStripMenuItem,
            fileSeparatorStripMenuItem2,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openRecentToolStripMenuItem
            // 
            openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            openRecentToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            openRecentToolStripMenuItem.Text = "Open Recent";
            // 
            // fileSeparatorStripMenuItem1
            // 
            fileSeparatorStripMenuItem1.Name = "fileSeparatorStripMenuItem1";
            fileSeparatorStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // fileSeparatorStripMenuItem2
            // 
            fileSeparatorStripMenuItem2.Name = "fileSeparatorStripMenuItem2";
            fileSeparatorStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
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
            editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(startTabPage);
            tabControl.Controls.Add(welcomeTabPage);
            tabControl.Controls.Add(exitTabPage);
            tabControl.Location = new System.Drawing.Point(8, 34);
            tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(200, 100);
            tabControl.TabIndex = 1;
            // 
            // startTabPage
            // 
            startTabPage.Controls.Add(startingLocationComboBox);
            startTabPage.Controls.Add(startingLocationLabel);
            startTabPage.Location = new System.Drawing.Point(4, 25);
            startTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            startTabPage.Name = "startTabPage";
            startTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            startTabPage.Size = new System.Drawing.Size(192, 71);
            startTabPage.TabIndex = 0;
            startTabPage.Text = "Start";
            startTabPage.UseVisualStyleBackColor = true;
            // 
            // startingLocationComboBox
            // 
            startingLocationComboBox.FormattingEnabled = true;
            startingLocationComboBox.Location = new System.Drawing.Point(8, 34);
            startingLocationComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            startingLocationComboBox.Name = "startingLocationComboBox";
            startingLocationComboBox.Size = new System.Drawing.Size(177, 24);
            startingLocationComboBox.TabIndex = 12;
            // 
            // welcomeTabPage
            // 
            welcomeTabPage.Controls.Add(welcomeMessageLabel);
            welcomeTabPage.Controls.Add(welcomTextBox);
            welcomeTabPage.Location = new System.Drawing.Point(4, 25);
            welcomeTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            welcomeTabPage.Name = "welcomeTabPage";
            welcomeTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            welcomeTabPage.Size = new System.Drawing.Size(192, 71);
            welcomeTabPage.TabIndex = 1;
            welcomeTabPage.Text = "Welcome";
            welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomTextBox
            // 
            welcomTextBox.Location = new System.Drawing.Point(8, 34);
            welcomTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            welcomTextBox.Name = "welcomTextBox";
            welcomTextBox.Size = new System.Drawing.Size(177, 22);
            welcomTextBox.TabIndex = 3;
            // 
            // exitTabPage
            // 
            exitTabPage.Controls.Add(exitMessageLabel);
            exitTabPage.Controls.Add(exitTextBox);
            exitTabPage.Location = new System.Drawing.Point(4, 25);
            exitTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            exitTabPage.Name = "exitTabPage";
            exitTabPage.Size = new System.Drawing.Size(192, 71);
            exitTabPage.TabIndex = 2;
            exitTabPage.Text = "Exit";
            exitTabPage.UseVisualStyleBackColor = true;
            // 
            // exitTextBox
            // 
            exitTextBox.Location = new System.Drawing.Point(8, 34);
            exitTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            exitTextBox.Name = "exitTextBox";
            exitTextBox.Size = new System.Drawing.Size(177, 22);
            exitTextBox.TabIndex = 3;
            // 
            // roomsListBox
            // 
            roomsListBox.DataSource = this.roomsBindingSource;
            roomsListBox.DisplayMember = "Name";
            roomsListBox.FormattingEnabled = true;
            roomsListBox.ItemHeight = 16;
            roomsListBox.Location = new System.Drawing.Point(4, 21);
            roomsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            roomsListBox.Name = "roomsListBox";
            roomsListBox.Size = new System.Drawing.Size(191, 244);
            roomsListBox.TabIndex = 2;
            roomsListBox.ValueMember = "Description";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.GameViewModel);
            // 
            // roomsGroupBox
            // 
            roomsGroupBox.Controls.Add(removeRoomButton);
            roomsGroupBox.Controls.Add(addRoomButton);
            roomsGroupBox.Controls.Add(roomsListBox);
            roomsGroupBox.Location = new System.Drawing.Point(12, 137);
            roomsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            roomsGroupBox.Name = "roomsGroupBox";
            roomsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            roomsGroupBox.Size = new System.Drawing.Size(200, 302);
            roomsGroupBox.TabIndex = 3;
            roomsGroupBox.TabStop = false;
            roomsGroupBox.Text = "Rooms List";
            // 
            // removeRoomButton
            // 
            removeRoomButton.Location = new System.Drawing.Point(119, 272);
            removeRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            removeRoomButton.Name = "removeRoomButton";
            removeRoomButton.Size = new System.Drawing.Size(75, 23);
            removeRoomButton.TabIndex = 5;
            removeRoomButton.Text = "Remove";
            removeRoomButton.UseVisualStyleBackColor = true;
            // 
            // addRoomButton
            // 
            addRoomButton.Location = new System.Drawing.Point(4, 272);
            addRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addRoomButton.Name = "addRoomButton";
            addRoomButton.Size = new System.Drawing.Size(75, 23);
            addRoomButton.TabIndex = 4;
            addRoomButton.Text = "Add";
            addRoomButton.UseVisualStyleBackColor = true;
            addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // roomInfoGroupBox
            // 
            roomInfoGroupBox.Controls.Add(itemsTextBox);
            roomInfoGroupBox.Controls.Add(itemsLabel);
            roomInfoGroupBox.Controls.Add(neighborsGroupBox);
            roomInfoGroupBox.Controls.Add(descriptionTextBox);
            roomInfoGroupBox.Controls.Add(roomNameTextBox);
            roomInfoGroupBox.Controls.Add(descriptionLabel);
            roomInfoGroupBox.Controls.Add(roomNameLabel);
            roomInfoGroupBox.Location = new System.Drawing.Point(235, 31);
            roomInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            roomInfoGroupBox.Name = "roomInfoGroupBox";
            roomInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            roomInfoGroupBox.Size = new System.Drawing.Size(405, 407);
            roomInfoGroupBox.TabIndex = 4;
            roomInfoGroupBox.TabStop = false;
            roomInfoGroupBox.Text = "Room Info";
            // 
            // itemsTextBox
            // 
            itemsTextBox.Location = new System.Drawing.Point(77, 347);
            itemsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            itemsTextBox.Multiline = true;
            itemsTextBox.Name = "itemsTextBox";
            itemsTextBox.Size = new System.Drawing.Size(305, 53);
            itemsTextBox.TabIndex = 6;
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Location = new System.Drawing.Point(27, 354);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new System.Drawing.Size(45, 17);
            itemsLabel.TabIndex = 6;
            itemsLabel.Text = "Items:";
            // 
            // neighborsGroupBox
            // 
            neighborsGroupBox.Controls.Add(westComboBox);
            neighborsGroupBox.Controls.Add(eastComboBox);
            neighborsGroupBox.Controls.Add(southComboBox);
            neighborsGroupBox.Controls.Add(northComboBox);
            neighborsGroupBox.Controls.Add(southLabel);
            neighborsGroupBox.Controls.Add(eastLabel);
            neighborsGroupBox.Controls.Add(westLabel);
            neighborsGroupBox.Controls.Add(northLlabel);
            neighborsGroupBox.Location = new System.Drawing.Point(21, 190);
            neighborsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            neighborsGroupBox.Name = "neighborsGroupBox";
            neighborsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            neighborsGroupBox.Size = new System.Drawing.Size(361, 151);
            neighborsGroupBox.TabIndex = 5;
            neighborsGroupBox.TabStop = false;
            neighborsGroupBox.Text = "Neighbors";
            // 
            // westComboBox
            // 
            westComboBox.FormattingEnabled = true;
            westComboBox.Location = new System.Drawing.Point(93, 113);
            westComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            westComboBox.Name = "westComboBox";
            westComboBox.Size = new System.Drawing.Size(243, 24);
            westComboBox.TabIndex = 11;
            // 
            // eastComboBox
            // 
            eastComboBox.FormattingEnabled = true;
            eastComboBox.Location = new System.Drawing.Point(93, 82);
            eastComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            eastComboBox.Name = "eastComboBox";
            eastComboBox.Size = new System.Drawing.Size(243, 24);
            eastComboBox.TabIndex = 10;
            // 
            // southComboBox
            // 
            southComboBox.FormattingEnabled = true;
            southComboBox.Location = new System.Drawing.Point(93, 53);
            southComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            southComboBox.Name = "southComboBox";
            southComboBox.Size = new System.Drawing.Size(243, 24);
            southComboBox.TabIndex = 9;
            // 
            // northComboBox
            // 
            northComboBox.DataSource = this.neighborsBindingSource;
            northComboBox.FormattingEnabled = true;
            northComboBox.Location = new System.Drawing.Point(93, 25);
            northComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            northComboBox.Name = "northComboBox";
            northComboBox.Size = new System.Drawing.Size(243, 24);
            northComboBox.TabIndex = 5;
            northComboBox.ValueMember = "Key";
            // 
            // southLabel
            // 
            southLabel.AutoSize = true;
            southLabel.Location = new System.Drawing.Point(21, 57);
            southLabel.Name = "southLabel";
            southLabel.Size = new System.Drawing.Size(49, 17);
            southLabel.TabIndex = 8;
            southLabel.Text = "South:";
            // 
            // eastLabel
            // 
            eastLabel.AutoSize = true;
            eastLabel.Location = new System.Drawing.Point(21, 89);
            eastLabel.Name = "eastLabel";
            eastLabel.Size = new System.Drawing.Size(40, 17);
            eastLabel.TabIndex = 7;
            eastLabel.Text = "East:";
            // 
            // westLabel
            // 
            westLabel.AutoSize = true;
            westLabel.Location = new System.Drawing.Point(21, 121);
            westLabel.Name = "westLabel";
            westLabel.Size = new System.Drawing.Size(44, 17);
            westLabel.TabIndex = 6;
            westLabel.Text = "West:";
            // 
            // northLlabel
            // 
            northLlabel.AutoSize = true;
            northLlabel.Location = new System.Drawing.Point(21, 27);
            northLlabel.Name = "northLlabel";
            northLlabel.Size = new System.Drawing.Size(47, 17);
            northLlabel.TabIndex = 5;
            northLlabel.Text = "North:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            descriptionTextBox.Location = new System.Drawing.Point(21, 89);
            descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new System.Drawing.Size(361, 84);
            descriptionTextBox.TabIndex = 4;
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            roomNameTextBox.Location = new System.Drawing.Point(115, 23);
            roomNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.Size = new System.Drawing.Size(268, 22);
            roomNameTextBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(19, 63);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(19, 25);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(90, 17);
            roomNameLabel.TabIndex = 1;
            roomNameLabel.Text = "Room Name:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // neighborsBindingSource
            // 
            this.neighborsBindingSource.DataMember = "Neighbors";
            this.neighborsBindingSource.DataSource = this.roomsBindingSource;
            // 
            // ZorkBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(roomInfoGroupBox);
            this.Controls.Add(roomsGroupBox);
            this.Controls.Add(tabControl);
            this.Controls.Add(menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ZorkBuilderForm";
            this.Text = "ZorkBuilder";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            startTabPage.ResumeLayout(false);
            startTabPage.PerformLayout();
            welcomeTabPage.ResumeLayout(false);
            welcomeTabPage.PerformLayout();
            exitTabPage.ResumeLayout(false);
            exitTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            roomsGroupBox.ResumeLayout(false);
            roomInfoGroupBox.ResumeLayout(false);
            roomInfoGroupBox.PerformLayout();
            neighborsGroupBox.ResumeLayout(false);
            neighborsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource neighborsBindingSource;
    }
}

