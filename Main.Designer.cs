using System.Windows.Forms;
using System;

namespace NotePadWF_CS
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            autoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            searchWithBingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            findPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            replaceAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            insertTimeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            blackOnWhiteDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            blackOnLightGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            amberOnBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            greenOnBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            selectTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            restoreDefaultZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            autoSaveToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripSpacer3 = new System.Windows.Forms.ToolStripStatusLabel();
            positionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripSpacer2 = new System.Windows.Forms.ToolStripStatusLabel();
            wordCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripSpacer1 = new System.Windows.Forms.ToolStripStatusLabel();
            zoomToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new System.Windows.Forms.PrintDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
   
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            menuStrip1.Size = new System.Drawing.Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, newWindowToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, autoSaveToolStripMenuItem, toolStripSeparator1, pageSetupToolStripMenuItem, printToolStripMenuItem, toolStripSeparator2, ExitToolStripMenuItem });
            fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            fileToolStripMenuItem.Text = "文件"; // 改为中文
                                               // 
                                               // newToolStripMenuItem
                                               // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            newToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            newToolStripMenuItem.Text = "新建"; // 改为中文
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.N;
            newWindowToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            newWindowToolStripMenuItem.Text = "新窗口"; // 改为中文
            newWindowToolStripMenuItem.Click += newWindowToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            openToolStripMenuItem.Text = "打开"; // 改为中文
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            saveToolStripMenuItem.Text = "保存"; // 改为中文
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            saveAsToolStripMenuItem.Text = "另存为"; // 改为中文
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // autoSaveToolStripMenuItem
            // 
            autoSaveToolStripMenuItem.Name = "autoSaveToolStripMenuItem";
            autoSaveToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            autoSaveToolStripMenuItem.Text = "自动保存"; // 改为中文
            autoSaveToolStripMenuItem.Click += autoSaveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            pageSetupToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            pageSetupToolStripMenuItem.Text = "页面设置"; // 改为中文
            pageSetupToolStripMenuItem.Click += pageSetupToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
            printToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            printToolStripMenuItem.Text = "打印"; // 改为中文
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            ExitToolStripMenuItem.Text = "退出"; // 改为中文
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, toolStripSeparator4, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator5, searchWithBingToolStripMenuItem, findToolStripMenuItem, findNextToolStripMenuItem, findPreviousToolStripMenuItem, replaceToolStripMenuItem, replaceAllToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator6, selectAllToolStripMenuItem, insertTimeDateToolStripMenuItem });
            editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            editToolStripMenuItem.Text = "编辑"; // 改为中文
                                               // 
                                               // undoToolStripMenuItem
                                               // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            undoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            undoToolStripMenuItem.Text = "撤销"; // 改为中文
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(214, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            cutToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            cutToolStripMenuItem.Text = "剪切"; // 改为中文
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            copyToolStripMenuItem.Text = "复制"; // 改为中文
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            pasteToolStripMenuItem.Text = "粘贴"; // 改为中文
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            deleteToolStripMenuItem.Text = "删除"; // 改为中文
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(214, 6);
            // 
            // searchWithBingToolStripMenuItem
            // 
            searchWithBingToolStripMenuItem.Name = "searchWithBingToolStripMenuItem";
            searchWithBingToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            searchWithBingToolStripMenuItem.Text = "使用 Bing 搜索"; // 改为中文
            searchWithBingToolStripMenuItem

            .Click += searchWithBingToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F;
            findToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            findToolStripMenuItem.Text = "查找"; // 改为中文
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            findNextToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            findNextToolStripMenuItem.Text = "查找下一个"; // 改为中文
            findNextToolStripMenuItem.Click += findNextToolStripMenuItem_Click;
            // 
            // findPreviousToolStripMenuItem
            // 
            findPreviousToolStripMenuItem.Name = "findPreviousToolStripMenuItem";
            findPreviousToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3;
            findPreviousToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            findPreviousToolStripMenuItem.Text = "查找上一个"; // 改为中文
            findPreviousToolStripMenuItem.Click += findPreviousToolStripMenuItem_Click;
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H;
            replaceToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            replaceToolStripMenuItem.Text = "替换"; // 改为中文
            replaceToolStripMenuItem.Click += replaceToolStripMenuItem_Click;
            // 
            // replaceAllToolStripMenuItem
            // 
            replaceAllToolStripMenuItem.Name = "replaceAllToolStripMenuItem";
            replaceAllToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            replaceAllToolStripMenuItem.Text = "全部替换"; // 改为中文
            replaceAllToolStripMenuItem.Click += replaceAllToolStripMenuItem_Click;
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G;
            goToToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            goToToolStripMenuItem.Text = "转到"; // 改为中文
            goToToolStripMenuItem.Click += goToToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(214, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            selectAllToolStripMenuItem.Text = "全选"; // 改为中文
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // insertTimeDateToolStripMenuItem
            // 
            insertTimeDateToolStripMenuItem.Name = "insertTimeDateToolStripMenuItem";
            insertTimeDateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            insertTimeDateToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            insertTimeDateToolStripMenuItem.Text = "插入时间/日期"; // 改为中文
            insertTimeDateToolStripMenuItem.Click += insertTimeDateToolStripMenuItem_Click;

            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { wordWrapToolStripMenuItem, fontToolStripMenuItem });
            formatToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            formatToolStripMenuItem.Text = "格式化";

            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            wordWrapToolStripMenuItem.Text = "&Word Wrap";
            wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;

            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            fontToolStripMenuItem.Text = "字体";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;

            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, zoomToolStripMenuItem, statusBarToolStripMenuItem });
            viewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            viewToolStripMenuItem.Text = "视图";

            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { blackOnWhiteDefaultToolStripMenuItem, blackOnLightGrayToolStripMenuItem, amberOnBlackToolStripMenuItem, greenOnBlackToolStripMenuItem, toolStripSeparator3, selectTextColorToolStripMenuItem, selectBackgroundColorToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            toolStripMenuItem1.Text = "主题";

            // 
            // blackOnWhiteDefaultToolStripMenuItem
            // 
            blackOnWhiteDefaultToolStripMenuItem.Name = "blackOnWhiteDefaultToolStripMenuItem";
            blackOnWhiteDefaultToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            blackOnWhiteDefaultToolStripMenuItem.Text = "Black on &White (Default)";
            blackOnWhiteDefaultToolStripMenuItem.Click += blackOnWhiteDefaultToolStripMenuItem_Click;

            // 
            // blackOnLightGrayToolStripMenuItem
            // 
            blackOnLightGrayToolStripMenuItem.Name = "blackOnLightGrayToolStripMenuItem";
            blackOnLightGrayToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            blackOnLightGrayToolStripMenuItem.Text = "Black on &Light Gray";
            blackOnLightGrayToolStripMenuItem.Click += blackOnLightGrayToolStripMenuItem_Click;

            // 
            // amberOnBlackToolStripMenuItem
            // 
            amberOnBlackToolStripMenuItem.Name = "amberOnBlackToolStripMenuItem";
            amberOnBlackToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            amberOnBlackToolStripMenuItem.Text = "&Amber on Black";
            amberOnBlackToolStripMenuItem.Click += amberOnBlackToolStripMenuItem_Click;

            // 
            // greenOnBlackToolStripMenuItem
            // 
            greenOnBlackToolStripMenuItem.Name = "greenOnBlackToolStripMenuItem";
            greenOnBlackToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            greenOnBlackToolStripMenuItem.Text = "&Green on Black";
            greenOnBlackToolStripMenuItem.Click += greenOnBlackToolStripMenuItem_Click;

            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(218, 6);

            // 
            // selectTextColorToolStripMenuItem
            // 
            selectTextColorToolStripMenuItem.Name = "selectTextColorToolStripMenuItem";
            selectTextColorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            selectTextColorToolStripMenuItem.Text = "Select &Text Color...";
            selectTextColorToolStripMenuItem.Click += selectTextColorToolStripMenuItem_Click;

            // 
            // selectBackgroundColorToolStripMenuItem
            // 
            selectBackgroundColorToolStripMenuItem.Name = "selectBackgroundColorToolStripMenuItem";
            selectBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            selectBackgroundColorToolStripMenuItem.Text = "Select &Background Color";
            selectBackgroundColorToolStripMenuItem.Click += selectBackgroundColorToolStripMenuItem_Click;

            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, restoreDefaultZoomToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            zoomToolStripMenuItem.Text = "缩放";

            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Plus";
            zoomInToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus;
            zoomInToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            zoomInToolStripMenuItem.Text = "放大";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;

            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Minus";
            zoomOutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus;
            zoomOutToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            zoomOutToolStripMenuItem.Text = "缩小";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;

            // 
            // restoreDefaultZoomToolStripMenuItem
            // 
            restoreDefaultZoomToolStripMenuItem.Name = "restoreDefaultZoomToolStripMenuItem";
            restoreDefaultZoomToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0;
            restoreDefaultZoomToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            restoreDefaultZoomToolStripMenuItem.Text = "重置缩放比例";
            restoreDefaultZoomToolStripMenuItem.Click += restoreDefaultZoomToolStripMenuItem_Click;

            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            statusBarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            statusBarToolStripMenuItem.Text = "状态栏";
            statusBarToolStripMenuItem.Click += statusBarToolStripMenuItem_Click;

            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            helpToolStripMenuItem.Text = "帮助";

            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            aboutToolStripMenuItem.Text = "关于";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;

            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { autoSaveToolStripStatusLabel, toolStripStatusLabel5, toolStripSpacer3, positionToolStripStatusLabel, toolStripStatusLabel3, toolStripSpacer2, wordCountToolStripStatusLabel, toolStripStatusLabel2, toolStripSpacer1, zoomToolStripStatusLabel, toolStripStatusLabel4, toolStripStatusLabel1 });
            statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip1.Location = new System.Drawing.Point(0, 513);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            statusStrip1.Size = new System.Drawing.Size(933, 33);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";

            // 
            // autoSaveToolStripStatusLabel
            // 
            autoSaveToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(25, 3, 50, 3);
            autoSaveToolStripStatusLabel.Name = "autoSaveToolStripStatusLabel";
            autoSaveToolStripStatusLabel.Size = new System.Drawing.Size(91, 27);
            autoSaveToolStripStatusLabel.Text = "自动保存";

            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new System.Drawing.Size(37, 27);
            toolStripStatusLabel5.Text = "      ";

            // 
            // toolStripSpacer3
            // 
            toolStripSpacer3.AutoSize = false;
            toolStripSpacer3.Name = "toolStripSpacer3";
            toolStripSpacer3.Size = new System.Drawing.Size(25, 27);
            toolStripSpacer3.Spring = true;

            // 
            // positionToolStripStatusLabel
            // 
            positionToolStripStatusLabel.Name = "positionToolStripStatusLabel";
            positionToolStripStatusLabel.Size = new System.Drawing.Size(53, 27);
            positionToolStripStatusLabel.Text = "Line: 1, Column: 1";

            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new System.Drawing.Size(30, 27);
            toolStripStatusLabel3.Text = "   ";

            // 
            // toolStripSpacer2
            // 
            toolStripSpacer2.AutoSize = false;
            toolStripSpacer2.Name = "toolStripSpacer2";
            toolStripSpacer2.Size = new System.Drawing.Size(25, 27);
            toolStripSpacer2.Spring = true;

            // 
            // wordCountToolStripStatusLabel
            // 
            wordCountToolStripStatusLabel.Name = "wordCountToolStripStatusLabel";
            wordCountToolStripStatusLabel.Size = new System.Drawing.Size(87, 27);
            wordCountToolStripStatusLabel.Text = "Words: 0";

            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(30, 27);
            toolStripStatusLabel2.Text = "   ";

            // 
            // toolStripSpacer1
            // 
            toolStripSpacer1.AutoSize = false;
            toolStripSpacer1.Name = "toolStripSpacer1";
            toolStripSpacer1.Size = new System.Drawing.Size(25, 27);
            toolStripSpacer1.Spring = true;

            // 
            // zoomToolStripStatusLabel
            // 
            zoomToolStripStatusLabel.Name = "zoomToolStripStatusLabel";
            zoomToolStripStatusLabel.Size = new System.Drawing.Size(94, 27);
            zoomToolStripStatusLabel.Text = "缩放: 100%";

            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new System.Drawing.Size(30, 27);
            toolStripStatusLabel4.Text = "   ";

            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(25, 27);
            toolStripStatusLabel1.Text = "   ";
            //
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            richTextBox1.Location = new System.Drawing.Point(0, 24);
            richTextBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(933, 489);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text documents (*.txt)|*.txt";
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text Documents (*.txt)|*txt|All Files (*.*)|*.*";
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDocument1
            // 
            printDocument1.DocumentName = "richTextBox1.Text";
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30000;
            timer1.Tick += timer1_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 546);
            Controls.Add(richTextBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            MinimumSize = new System.Drawing.Size(486, 176);
            Name = "Main";
            Text = "EasyNoteBook";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel autoSaveToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel positionToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel zoomToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreDefaultZoomToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blackOnWhiteDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackOnLightGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amberOnBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenOnBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem searchWithBingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPreviousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertTimeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel wordCountToolStripStatusLabel;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem autoSaveToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer1;
    }
}

