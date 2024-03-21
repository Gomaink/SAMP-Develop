namespace SAMPDevelop
{
    partial class SAMPDevelop
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAMPDevelop));
            fileMenu = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            goToToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            buildToolStripMenuItem = new ToolStripMenuItem();
            compileToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            hideShowSidebarCtrlJToolStripMenuItem = new ToolStripMenuItem();
            sAMPToolStripMenuItem1 = new ToolStripMenuItem();
            weaponsIDToolStripMenuItem = new ToolStripMenuItem();
            weaponIDToolStripMenuItem = new ToolStripMenuItem();
            bodypartIDToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutSAMPDevelopToolStripMenuItem = new ToolStripMenuItem();
            sAMPToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            bonesIDToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // fileMenu
            // 
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.Font = new Font("Microsoft Sans Serif", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, buildToolStripMenuItem, optionsToolStripMenuItem, sAMPToolStripMenuItem1, helpToolStripMenuItem, sAMPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, openFolderToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += FileToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            newToolStripMenuItem.ForeColor = Color.White;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(149, 22);
            newToolStripMenuItem.Text = "New (Ctrl+N)";
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            openToolStripMenuItem.ForeColor = Color.White;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(149, 22);
            openToolStripMenuItem.Text = "Open (Ctrl+O)";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            openFolderToolStripMenuItem.ForeColor = Color.White;
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(149, 22);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += OpenFolderToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            saveToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(149, 22);
            saveToolStripMenuItem.Text = "Save (Ctrl+S)";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            saveAsToolStripMenuItem.ForeColor = Color.White;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(149, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(149, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, findToolStripMenuItem, replaceToolStripMenuItem, goToToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(40, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            undoToolStripMenuItem.ForeColor = Color.White;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(167, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += UndoToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            cutToolStripMenuItem.ForeColor = Color.White;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(167, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            copyToolStripMenuItem.ForeColor = Color.White;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(167, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            pasteToolStripMenuItem.ForeColor = Color.White;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(167, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            deleteToolStripMenuItem.ForeColor = Color.White;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(167, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            findToolStripMenuItem.ForeColor = Color.White;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(167, 22);
            findToolStripMenuItem.Text = "Find (Ctrl+F)";
            findToolStripMenuItem.Click += FindToolStripMenuItem_Click;
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            replaceToolStripMenuItem.ForeColor = Color.White;
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(167, 22);
            replaceToolStripMenuItem.Text = "Replace (Ctrl+H)";
            replaceToolStripMenuItem.Click += ReplaceToolStripMenuItem_Click;
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            goToToolStripMenuItem.ForeColor = Color.White;
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.Size = new Size(167, 22);
            goToToolStripMenuItem.Text = "Go to... (Ctrl+G)";
            goToToolStripMenuItem.Click += GoToToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            selectAllToolStripMenuItem.ForeColor = Color.White;
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(167, 22);
            selectAllToolStripMenuItem.Text = "Select All (Ctrl+A)";
            selectAllToolStripMenuItem.Click += SelectAllToolStripMenuItem_Click;
            // 
            // buildToolStripMenuItem
            // 
            buildToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { compileToolStripMenuItem });
            buildToolStripMenuItem.ForeColor = Color.White;
            buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            buildToolStripMenuItem.Size = new Size(47, 20);
            buildToolStripMenuItem.Text = "Build";
            // 
            // compileToolStripMenuItem
            // 
            compileToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            compileToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compileToolStripMenuItem.ForeColor = Color.White;
            compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            compileToolStripMenuItem.Size = new Size(142, 22);
            compileToolStripMenuItem.Text = "Compile (F5)";
            compileToolStripMenuItem.Click += CompileToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem, hideShowSidebarCtrlJToolStripMenuItem });
            optionsToolStripMenuItem.ForeColor = Color.White;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem, darkToolStripMenuItem });
            themeToolStripMenuItem.ForeColor = Color.White;
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(222, 22);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            lightToolStripMenuItem.ForeColor = Color.White;
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(101, 22);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            darkToolStripMenuItem.ForeColor = Color.White;
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(101, 22);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // hideShowSidebarCtrlJToolStripMenuItem
            // 
            hideShowSidebarCtrlJToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            hideShowSidebarCtrlJToolStripMenuItem.ForeColor = Color.White;
            hideShowSidebarCtrlJToolStripMenuItem.Name = "hideShowSidebarCtrlJToolStripMenuItem";
            hideShowSidebarCtrlJToolStripMenuItem.Size = new Size(222, 22);
            hideShowSidebarCtrlJToolStripMenuItem.Text = "Hide/Show Sidebar (Ctrl+J)";
            hideShowSidebarCtrlJToolStripMenuItem.Click += hideShowSidebarCtrlJToolStripMenuItem_Click;
            // 
            // sAMPToolStripMenuItem1
            // 
            sAMPToolStripMenuItem1.BackColor = Color.FromArgb(35, 35, 35);
            sAMPToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { weaponsIDToolStripMenuItem });
            sAMPToolStripMenuItem1.ForeColor = Color.White;
            sAMPToolStripMenuItem1.Name = "sAMPToolStripMenuItem1";
            sAMPToolStripMenuItem1.Size = new Size(56, 20);
            sAMPToolStripMenuItem1.Text = "SA:MP";
            // 
            // weaponsIDToolStripMenuItem
            // 
            weaponsIDToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            weaponsIDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { weaponIDToolStripMenuItem, bodypartIDToolStripMenuItem, bonesIDToolStripMenuItem });
            weaponsIDToolStripMenuItem.ForeColor = Color.White;
            weaponsIDToolStripMenuItem.Name = "weaponsIDToolStripMenuItem";
            weaponsIDToolStripMenuItem.Size = new Size(180, 22);
            weaponsIDToolStripMenuItem.Text = "SA:MP ID's";
            // 
            // weaponIDToolStripMenuItem
            // 
            weaponIDToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            weaponIDToolStripMenuItem.ForeColor = Color.White;
            weaponIDToolStripMenuItem.Name = "weaponIDToolStripMenuItem";
            weaponIDToolStripMenuItem.Size = new Size(180, 22);
            weaponIDToolStripMenuItem.Text = "Weapon ID";
            weaponIDToolStripMenuItem.Click += weaponIDToolStripMenuItem_Click;
            // 
            // bodypartIDToolStripMenuItem
            // 
            bodypartIDToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            bodypartIDToolStripMenuItem.ForeColor = Color.White;
            bodypartIDToolStripMenuItem.Name = "bodypartIDToolStripMenuItem";
            bodypartIDToolStripMenuItem.Size = new Size(180, 22);
            bodypartIDToolStripMenuItem.Text = "BodyPart ID";
            bodypartIDToolStripMenuItem.Click += bodypartIDToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutSAMPDevelopToolStripMenuItem });
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(45, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSAMPDevelopToolStripMenuItem
            // 
            aboutSAMPDevelopToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            aboutSAMPDevelopToolStripMenuItem.ForeColor = Color.White;
            aboutSAMPDevelopToolStripMenuItem.Name = "aboutSAMPDevelopToolStripMenuItem";
            aboutSAMPDevelopToolStripMenuItem.Size = new Size(193, 22);
            aboutSAMPDevelopToolStripMenuItem.Text = "About SA:MP Develop";
            // 
            // sAMPToolStripMenuItem
            // 
            sAMPToolStripMenuItem.Name = "sAMPToolStripMenuItem";
            sAMPToolStripMenuItem.Size = new Size(12, 20);
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(35, 35, 35);
            treeView1.Dock = DockStyle.Left;
            treeView1.ForeColor = Color.White;
            treeView1.Location = new Point(0, 24);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(152, 426);
            treeView1.TabIndex = 2;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // bonesIDToolStripMenuItem
            // 
            bonesIDToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            bonesIDToolStripMenuItem.ForeColor = Color.White;
            bonesIDToolStripMenuItem.Name = "bonesIDToolStripMenuItem";
            bonesIDToolStripMenuItem.Size = new Size(180, 22);
            bonesIDToolStripMenuItem.Text = "Bones ID";
            bonesIDToolStripMenuItem.Click += bonesIDToolStripMenuItem_Click;
            // 
            // SAMPDevelop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9F);
            ForeColor = SystemColors.ButtonFace;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "SAMPDevelop";
            Text = "SA:MP Develop";
            Load += SAMPDevelop_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip fileMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem buildToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem goToToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem compileToolStripMenuItem;
        private ToolStripMenuItem aboutSAMPDevelopToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private TreeView treeView1;
        private ToolStripMenuItem hideSidebarCtrlJToolStripMenuItem;
        private ToolStripMenuItem hideShowSidebarCtrlJToolStripMenuItem;
        private ToolStripMenuItem sAMPToolStripMenuItem;
        private ToolStripMenuItem sAMPToolStripMenuItem1;
        private ToolStripMenuItem weaponsIDToolStripMenuItem;
        private ToolStripMenuItem weaponIDToolStripMenuItem;
        private ToolStripMenuItem bodypartIDToolStripMenuItem;
        private ToolStripMenuItem bonesIDToolStripMenuItem;
    }
}
