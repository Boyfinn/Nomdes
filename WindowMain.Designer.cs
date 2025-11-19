using System;

namespace Nomdes
{
    partial class WindowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.TB_OUT = new System.Windows.Forms.RichTextBox();
            this.BTN_GENERATE = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MENU_MAIN = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaNimelläToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsDiag = new System.Windows.Forms.SaveFileDialog();
            this.GROUP_MAIN = new System.Windows.Forms.GroupBox();
            this.FONT_SCALE = new System.Windows.Forms.NumericUpDown();
            this.lb7 = new System.Windows.Forms.Label();
            this.CHECK_CAPITAL = new System.Windows.Forms.CheckBox();
            this.lb0 = new System.Windows.Forms.Label();
            this.WORDS_TOTAL = new System.Windows.Forms.NumericUpDown();
            this.WORDS_LENGTH_MAX = new System.Windows.Forms.NumericUpDown();
            this.WORDS_LENGTH_MIN = new System.Windows.Forms.NumericUpDown();
            this.GROUP_SYL = new System.Windows.Forms.GroupBox();
            this.CHECK_COLOR = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.GROUP_TOOL = new System.Windows.Forms.GroupBox();
            this.BTN_CPY = new System.Windows.Forms.Button();
            this.MENU_MAIN.SuspendLayout();
            this.GROUP_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FONT_SCALE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WORDS_TOTAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WORDS_LENGTH_MAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WORDS_LENGTH_MIN)).BeginInit();
            this.GROUP_SYL.SuspendLayout();
            this.GROUP_TOOL.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_OUT
            // 
            this.TB_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_OUT.Location = new System.Drawing.Point(13, 27);
            this.TB_OUT.Name = "TB_OUT";
            this.TB_OUT.Size = new System.Drawing.Size(421, 324);
            this.TB_OUT.TabIndex = 0;
            this.TB_OUT.Text = "";
            // 
            // BTN_GENERATE
            // 
            this.BTN_GENERATE.Location = new System.Drawing.Point(21, 77);
            this.BTN_GENERATE.Name = "BTN_GENERATE";
            this.BTN_GENERATE.Size = new System.Drawing.Size(75, 23);
            this.BTN_GENERATE.TabIndex = 1;
            this.BTN_GENERATE.Text = "Luo";
            this.BTN_GENERATE.UseVisualStyleBackColor = true;
            this.BTN_GENERATE.Click += new System.EventHandler(this.LuoTavut);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MENU_MAIN
            // 
            this.MENU_MAIN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.apuaToolStripMenuItem});
            this.MENU_MAIN.Location = new System.Drawing.Point(0, 0);
            this.MENU_MAIN.Name = "MENU_MAIN";
            this.MENU_MAIN.Size = new System.Drawing.Size(564, 24);
            this.MENU_MAIN.TabIndex = 3;
            this.MENU_MAIN.Text = "MenuMain";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tallennaToolStripMenuItem,
            this.tallennaNimelläToolStripMenuItem,
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.Tallenna);
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            this.tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            this.tallennaNimelläToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä";
            this.tallennaNimelläToolStripMenuItem.Click += new System.EventHandler(this.TallennaNimellä);
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.Poistu);
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opasToolStripMenuItem,
            this.tietoaToolStripMenuItem});
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.apuaToolStripMenuItem.Text = "Apua";
            // 
            // opasToolStripMenuItem
            // 
            this.opasToolStripMenuItem.Name = "opasToolStripMenuItem";
            this.opasToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.opasToolStripMenuItem.Text = "Opas";
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.tietoaToolStripMenuItem.Text = "Tietoa";
            this.tietoaToolStripMenuItem.Click += new System.EventHandler(this.Info);
            // 
            // SaveAsDiag
            // 
            this.SaveAsDiag.Filter = "Tekstitiedosto |*.txt";
            // 
            // GROUP_MAIN
            // 
            this.GROUP_MAIN.Controls.Add(this.FONT_SCALE);
            this.GROUP_MAIN.Controls.Add(this.lb7);
            this.GROUP_MAIN.Controls.Add(this.CHECK_CAPITAL);
            this.GROUP_MAIN.Controls.Add(this.lb0);
            this.GROUP_MAIN.Controls.Add(this.WORDS_TOTAL);
            this.GROUP_MAIN.Location = new System.Drawing.Point(441, 27);
            this.GROUP_MAIN.Name = "GROUP_MAIN";
            this.GROUP_MAIN.Size = new System.Drawing.Size(111, 101);
            this.GROUP_MAIN.TabIndex = 4;
            this.GROUP_MAIN.TabStop = false;
            this.GROUP_MAIN.Text = "Sanat";
            // 
            // FONT_SCALE
            // 
            this.FONT_SCALE.Location = new System.Drawing.Point(52, 45);
            this.FONT_SCALE.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.FONT_SCALE.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.FONT_SCALE.Name = "FONT_SCALE";
            this.FONT_SCALE.Size = new System.Drawing.Size(44, 20);
            this.FONT_SCALE.TabIndex = 6;
            this.FONT_SCALE.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.FONT_SCALE.ValueChanged += new System.EventHandler(this.PäivitäArvot);
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(8, 47);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(32, 13);
            this.lb7.TabIndex = 5;
            this.lb7.Text = "Koko";
            // 
            // CHECK_CAPITAL
            // 
            this.CHECK_CAPITAL.AutoSize = true;
            this.CHECK_CAPITAL.Location = new System.Drawing.Point(16, 75);
            this.CHECK_CAPITAL.Name = "CHECK_CAPITAL";
            this.CHECK_CAPITAL.Size = new System.Drawing.Size(90, 17);
            this.CHECK_CAPITAL.TabIndex = 4;
            this.CHECK_CAPITAL.Text = "Iso alkukirjain";
            this.CHECK_CAPITAL.UseVisualStyleBackColor = true;
            // 
            // lb0
            // 
            this.lb0.AutoSize = true;
            this.lb0.Location = new System.Drawing.Point(6, 21);
            this.lb0.Name = "lb0";
            this.lb0.Size = new System.Drawing.Size(40, 13);
            this.lb0.TabIndex = 3;
            this.lb0.Text = "Sanoja";
            // 
            // WORDS_TOTAL
            // 
            this.WORDS_TOTAL.Location = new System.Drawing.Point(52, 19);
            this.WORDS_TOTAL.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.WORDS_TOTAL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WORDS_TOTAL.Name = "WORDS_TOTAL";
            this.WORDS_TOTAL.Size = new System.Drawing.Size(44, 20);
            this.WORDS_TOTAL.TabIndex = 0;
            this.WORDS_TOTAL.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.WORDS_TOTAL.ValueChanged += new System.EventHandler(this.PäivitäArvot);
            // 
            // WORDS_LENGTH_MAX
            // 
            this.WORDS_LENGTH_MAX.Location = new System.Drawing.Point(46, 45);
            this.WORDS_LENGTH_MAX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WORDS_LENGTH_MAX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.WORDS_LENGTH_MAX.Name = "WORDS_LENGTH_MAX";
            this.WORDS_LENGTH_MAX.Size = new System.Drawing.Size(50, 20);
            this.WORDS_LENGTH_MAX.TabIndex = 2;
            this.WORDS_LENGTH_MAX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WORDS_LENGTH_MAX.ValueChanged += new System.EventHandler(this.PäivitäArvot);
            // 
            // WORDS_LENGTH_MIN
            // 
            this.WORDS_LENGTH_MIN.Location = new System.Drawing.Point(46, 19);
            this.WORDS_LENGTH_MIN.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WORDS_LENGTH_MIN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.WORDS_LENGTH_MIN.Name = "WORDS_LENGTH_MIN";
            this.WORDS_LENGTH_MIN.Size = new System.Drawing.Size(50, 20);
            this.WORDS_LENGTH_MIN.TabIndex = 1;
            this.WORDS_LENGTH_MIN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.WORDS_LENGTH_MIN.ValueChanged += new System.EventHandler(this.PäivitäArvot);
            // 
            // GROUP_SYL
            // 
            this.GROUP_SYL.Controls.Add(this.CHECK_COLOR);
            this.GROUP_SYL.Controls.Add(this.label2);
            this.GROUP_SYL.Controls.Add(this.label1);
            this.GROUP_SYL.Controls.Add(this.WORDS_LENGTH_MIN);
            this.GROUP_SYL.Controls.Add(this.WORDS_LENGTH_MAX);
            this.GROUP_SYL.Location = new System.Drawing.Point(441, 134);
            this.GROUP_SYL.Name = "GROUP_SYL";
            this.GROUP_SYL.Size = new System.Drawing.Size(111, 98);
            this.GROUP_SYL.TabIndex = 5;
            this.GROUP_SYL.TabStop = false;
            this.GROUP_SYL.Text = "Tavut";
            // 
            // CHECK_COLOR
            // 
            this.CHECK_COLOR.AutoSize = true;
            this.CHECK_COLOR.Location = new System.Drawing.Point(16, 71);
            this.CHECK_COLOR.Name = "CHECK_COLOR";
            this.CHECK_COLOR.Size = new System.Drawing.Size(80, 17);
            this.CHECK_COLOR.TabIndex = 5;
            this.CHECK_COLOR.Text = "Väritä tavut";
            this.CHECK_COLOR.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min";
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Location = new System.Drawing.Point(21, 19);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_CLEAR.TabIndex = 6;
            this.BTN_CLEAR.Text = "Tyhjennä";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // GROUP_TOOL
            // 
            this.GROUP_TOOL.Controls.Add(this.BTN_CPY);
            this.GROUP_TOOL.Controls.Add(this.BTN_CLEAR);
            this.GROUP_TOOL.Controls.Add(this.BTN_GENERATE);
            this.GROUP_TOOL.Location = new System.Drawing.Point(441, 239);
            this.GROUP_TOOL.Name = "GROUP_TOOL";
            this.GROUP_TOOL.Size = new System.Drawing.Size(111, 112);
            this.GROUP_TOOL.TabIndex = 7;
            this.GROUP_TOOL.TabStop = false;
            this.GROUP_TOOL.Text = "Työkalut";
            // 
            // BTN_CPY
            // 
            this.BTN_CPY.Location = new System.Drawing.Point(21, 48);
            this.BTN_CPY.Name = "BTN_CPY";
            this.BTN_CPY.Size = new System.Drawing.Size(75, 23);
            this.BTN_CPY.TabIndex = 7;
            this.BTN_CPY.Text = "Kopioi";
            this.BTN_CPY.UseVisualStyleBackColor = true;
            this.BTN_CPY.Click += new System.EventHandler(this.BTN_CPY_Click);
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.GROUP_TOOL);
            this.Controls.Add(this.GROUP_SYL);
            this.Controls.Add(this.GROUP_MAIN);
            this.Controls.Add(this.MENU_MAIN);
            this.Controls.Add(this.TB_OUT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENU_MAIN;
            this.MaximumSize = new System.Drawing.Size(580, 400);
            this.MinimumSize = new System.Drawing.Size(580, 400);
            this.Name = "WindowMain";
            this.Text = "Nomdes Language Generator";
            this.MENU_MAIN.ResumeLayout(false);
            this.MENU_MAIN.PerformLayout();
            this.GROUP_MAIN.ResumeLayout(false);
            this.GROUP_MAIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FONT_SCALE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WORDS_TOTAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WORDS_LENGTH_MAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WORDS_LENGTH_MIN)).EndInit();
            this.GROUP_SYL.ResumeLayout(false);
            this.GROUP_SYL.PerformLayout();
            this.GROUP_TOOL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.RichTextBox TB_OUT;
        private System.Windows.Forms.Button BTN_GENERATE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip MENU_MAIN;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveAsDiag;
        private System.Windows.Forms.ToolStripMenuItem apuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietoaToolStripMenuItem;
        private System.Windows.Forms.GroupBox GROUP_MAIN;
        private System.Windows.Forms.Label lb0;
        private System.Windows.Forms.NumericUpDown WORDS_LENGTH_MAX;
        private System.Windows.Forms.NumericUpDown WORDS_LENGTH_MIN;
        private System.Windows.Forms.NumericUpDown WORDS_TOTAL;
        private System.Windows.Forms.GroupBox GROUP_SYL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHECK_CAPITAL;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.CheckBox CHECK_COLOR;
        private System.Windows.Forms.NumericUpDown FONT_SCALE;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.GroupBox GROUP_TOOL;
        private System.Windows.Forms.Button BTN_CPY;
    }
}

