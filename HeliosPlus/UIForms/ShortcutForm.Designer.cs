﻿using HeliosPlus.Resources;
using HeliosPlus.Shared.UserControls;

namespace HeliosPlus.UIForms
{
    partial class ShortcutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortcutForm));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.g_temporary = new System.Windows.Forms.GroupBox();
            this.p_game = new System.Windows.Forms.Panel();
            this.txt_game_id = new System.Windows.Forms.TextBox();
            this.txt_game_launcher = new System.Windows.Forms.TextBox();
            this.txt_game_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_choose_game = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_args_game = new System.Windows.Forms.TextBox();
            this.cb_args_game = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_timeout_game = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_games = new System.Windows.Forms.ListView();
            this.clm_images = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.il_games = new System.Windows.Forms.ImageList(this.components);
            this.p_standalone = new System.Windows.Forms.Panel();
            this.lbl_process_name = new System.Windows.Forms.Label();
            this.txt_args_executable = new System.Windows.Forms.TextBox();
            this.cb_args_executable = new System.Windows.Forms.CheckBox();
            this.btn_app_process = new System.Windows.Forms.Button();
            this.txt_process_name = new System.Windows.Forms.TextBox();
            this.rb_wait_process = new System.Windows.Forms.RadioButton();
            this.rb_wait_executable = new System.Windows.Forms.RadioButton();
            this.btn_app_executable = new System.Windows.Forms.Button();
            this.txt_executable = new System.Windows.Forms.TextBox();
            this.lbl_app_executable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_timeout_executable = new System.Windows.Forms.NumericUpDown();
            this.rb_launcher = new System.Windows.Forms.RadioButton();
            this.rb_standalone = new System.Windows.Forms.RadioButton();
            this.dv_profile = new HeliosPlus.Shared.UserControls.DisplayView();
            this.dialog_open = new System.Windows.Forms.OpenFileDialog();
            this.dialog_save = new System.Windows.Forms.SaveFileDialog();
            this.rb_switch_perm = new System.Windows.Forms.RadioButton();
            this.rb_switch_temp = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ilv_saved_profiles = new Manina.Windows.Forms.ImageListView();
            this.lbl_profile_shown_subtitle = new System.Windows.Forms.Label();
            this.lbl_profile_shown = new System.Windows.Forms.Label();
            this.g_temporary.SuspendLayout();
            this.p_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_timeout_game)).BeginInit();
            this.p_standalone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_timeout_executable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(602, 985);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 25);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "&Create Shortcut";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(869, 984);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 25);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "&Back";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // g_temporary
            // 
            this.g_temporary.Controls.Add(this.p_game);
            this.g_temporary.Controls.Add(this.p_standalone);
            this.g_temporary.Controls.Add(this.rb_launcher);
            this.g_temporary.Controls.Add(this.rb_standalone);
            this.g_temporary.Location = new System.Drawing.Point(12, 514);
            this.g_temporary.Name = "g_temporary";
            this.g_temporary.Size = new System.Drawing.Size(1161, 467);
            this.g_temporary.TabIndex = 4;
            this.g_temporary.TabStop = false;
            this.g_temporary.Text = "Application or Game Information";
            // 
            // p_game
            // 
            this.p_game.Controls.Add(this.txt_game_id);
            this.p_game.Controls.Add(this.txt_game_launcher);
            this.p_game.Controls.Add(this.txt_game_name);
            this.p_game.Controls.Add(this.label6);
            this.p_game.Controls.Add(this.label4);
            this.p_game.Controls.Add(this.btn_choose_game);
            this.p_game.Controls.Add(this.label1);
            this.p_game.Controls.Add(this.txt_args_game);
            this.p_game.Controls.Add(this.cb_args_game);
            this.p_game.Controls.Add(this.label5);
            this.p_game.Controls.Add(this.nud_timeout_game);
            this.p_game.Controls.Add(this.label3);
            this.p_game.Controls.Add(this.lv_games);
            this.p_game.Location = new System.Drawing.Point(26, 198);
            this.p_game.Name = "p_game";
            this.p_game.Size = new System.Drawing.Size(730, 253);
            this.p_game.TabIndex = 3;
            // 
            // txt_game_id
            // 
            this.txt_game_id.Location = new System.Drawing.Point(408, 104);
            this.txt_game_id.Name = "txt_game_id";
            this.txt_game_id.ReadOnly = true;
            this.txt_game_id.Size = new System.Drawing.Size(75, 20);
            this.txt_game_id.TabIndex = 24;
            // 
            // txt_game_launcher
            // 
            this.txt_game_launcher.Location = new System.Drawing.Point(408, 78);
            this.txt_game_launcher.Name = "txt_game_launcher";
            this.txt_game_launcher.ReadOnly = true;
            this.txt_game_launcher.Size = new System.Drawing.Size(175, 20);
            this.txt_game_launcher.TabIndex = 23;
            // 
            // txt_game_name
            // 
            this.txt_game_name.Location = new System.Drawing.Point(408, 133);
            this.txt_game_name.Name = "txt_game_name";
            this.txt_game_name.ReadOnly = true;
            this.txt_game_name.Size = new System.Drawing.Size(302, 20);
            this.txt_game_name.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(323, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Game Launcher:";
            this.label6.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(340, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Game Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            // 
            // btn_choose_game
            // 
            this.btn_choose_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choose_game.ForeColor = System.Drawing.Color.White;
            this.btn_choose_game.Location = new System.Drawing.Point(218, 117);
            this.btn_choose_game.Name = "btn_choose_game";
            this.btn_choose_game.Size = new System.Drawing.Size(29, 31);
            this.btn_choose_game.TabIndex = 16;
            this.btn_choose_game.Text = ">>";
            this.btn_choose_game.UseVisualStyleBackColor = true;
            this.btn_choose_game.Click += new System.EventHandler(this.btn_choose_game_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Games detected:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            // 
            // txt_args_game
            // 
            this.txt_args_game.Enabled = false;
            this.txt_args_game.Location = new System.Drawing.Point(408, 160);
            this.txt_args_game.Name = "txt_args_game";
            this.txt_args_game.Size = new System.Drawing.Size(302, 20);
            this.txt_args_game.TabIndex = 13;
            // 
            // cb_args_game
            // 
            this.cb_args_game.AutoSize = true;
            this.cb_args_game.ForeColor = System.Drawing.Color.White;
            this.cb_args_game.Location = new System.Drawing.Point(265, 162);
            this.cb_args_game.Name = "cb_args_game";
            this.cb_args_game.Size = new System.Drawing.Size(147, 17);
            this.cb_args_game.TabIndex = 12;
            this.cb_args_game.Text = "Pass arguments to Game:";
            this.cb_args_game.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_args_game.UseVisualStyleBackColor = true;
            this.cb_args_game.CheckedChanged += new System.EventHandler(this.cb_args_game_CheckedChanged);
            this.cb_args_game.Paint += new System.Windows.Forms.PaintEventHandler(this.checkbox_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(589, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timeout:";
            this.label5.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            // 
            // nud_timeout_game
            // 
            this.nud_timeout_game.Location = new System.Drawing.Point(640, 77);
            this.nud_timeout_game.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nud_timeout_game.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_timeout_game.Name = "nud_timeout_game";
            this.nud_timeout_game.Size = new System.Drawing.Size(70, 20);
            this.nud_timeout_game.TabIndex = 5;
            this.nud_timeout_game.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(357, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Game ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            // 
            // lv_games
            // 
            this.lv_games.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_images,
            this.clm_name});
            this.lv_games.HideSelection = false;
            this.lv_games.LargeImageList = this.il_games;
            this.lv_games.Location = new System.Drawing.Point(23, 18);
            this.lv_games.Name = "lv_games";
            this.lv_games.Size = new System.Drawing.Size(182, 229);
            this.lv_games.SmallImageList = this.il_games;
            this.lv_games.TabIndex = 22;
            this.lv_games.UseCompatibleStateImageBehavior = false;
            // 
            // il_games
            // 
            this.il_games.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.il_games.ImageSize = new System.Drawing.Size(32, 32);
            this.il_games.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // p_standalone
            // 
            this.p_standalone.Controls.Add(this.lbl_process_name);
            this.p_standalone.Controls.Add(this.txt_args_executable);
            this.p_standalone.Controls.Add(this.cb_args_executable);
            this.p_standalone.Controls.Add(this.btn_app_process);
            this.p_standalone.Controls.Add(this.txt_process_name);
            this.p_standalone.Controls.Add(this.rb_wait_process);
            this.p_standalone.Controls.Add(this.rb_wait_executable);
            this.p_standalone.Controls.Add(this.btn_app_executable);
            this.p_standalone.Controls.Add(this.txt_executable);
            this.p_standalone.Controls.Add(this.lbl_app_executable);
            this.p_standalone.Controls.Add(this.label2);
            this.p_standalone.Controls.Add(this.nud_timeout_executable);
            this.p_standalone.Enabled = false;
            this.p_standalone.Location = new System.Drawing.Point(26, 42);
            this.p_standalone.Name = "p_standalone";
            this.p_standalone.Size = new System.Drawing.Size(730, 118);
            this.p_standalone.TabIndex = 1;
            // 
            // lbl_process_name
            // 
            this.lbl_process_name.AutoSize = true;
            this.lbl_process_name.ForeColor = System.Drawing.Color.White;
            this.lbl_process_name.Location = new System.Drawing.Point(357, 57);
            this.lbl_process_name.Name = "lbl_process_name";
            this.lbl_process_name.Size = new System.Drawing.Size(97, 13);
            this.lbl_process_name.TabIndex = 12;
            this.lbl_process_name.Text = "Process to monitor:";
            this.lbl_process_name.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            // 
            // txt_args_executable
            // 
            this.txt_args_executable.Enabled = false;
            this.txt_args_executable.Location = new System.Drawing.Point(190, 83);
            this.txt_args_executable.Name = "txt_args_executable";
            this.txt_args_executable.Size = new System.Drawing.Size(520, 20);
            this.txt_args_executable.TabIndex = 11;
            // 
            // cb_args_executable
            // 
            this.cb_args_executable.AutoSize = true;
            this.cb_args_executable.ForeColor = System.Drawing.Color.White;
            this.cb_args_executable.Location = new System.Drawing.Point(23, 85);
            this.cb_args_executable.Name = "cb_args_executable";
            this.cb_args_executable.Size = new System.Drawing.Size(172, 17);
            this.cb_args_executable.TabIndex = 10;
            this.cb_args_executable.Text = "Pass arguments to Executable:";
            this.cb_args_executable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_args_executable.UseVisualStyleBackColor = true;
            this.cb_args_executable.CheckedChanged += new System.EventHandler(this.cb_args_executable_CheckedChanged);
            this.cb_args_executable.Paint += new System.Windows.Forms.PaintEventHandler(this.checkbox_Paint);
            // 
            // btn_app_process
            // 
            this.btn_app_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_app_process.ForeColor = System.Drawing.Color.White;
            this.btn_app_process.Location = new System.Drawing.Point(654, 53);
            this.btn_app_process.Name = "btn_app_process";
            this.btn_app_process.Size = new System.Drawing.Size(56, 21);
            this.btn_app_process.TabIndex = 9;
            this.btn_app_process.Text = "Choose";
            this.btn_app_process.UseVisualStyleBackColor = true;
            this.btn_app_process.Click += new System.EventHandler(this.btn_app_process_Click);
            // 
            // txt_process_name
            // 
            this.txt_process_name.Enabled = false;
            this.txt_process_name.Location = new System.Drawing.Point(454, 54);
            this.txt_process_name.Name = "txt_process_name";
            this.txt_process_name.Size = new System.Drawing.Size(194, 20);
            this.txt_process_name.TabIndex = 4;
            // 
            // rb_wait_process
            // 
            this.rb_wait_process.AutoSize = true;
            this.rb_wait_process.ForeColor = System.Drawing.Color.White;
            this.rb_wait_process.Location = new System.Drawing.Point(6, 55);
            this.rb_wait_process.Name = "rb_wait_process";
            this.rb_wait_process.Size = new System.Drawing.Size(327, 17);
            this.rb_wait_process.TabIndex = 8;
            this.rb_wait_process.Text = "Change Display Profile back when a different process is closed: ";
            this.rb_wait_process.UseVisualStyleBackColor = true;
            this.rb_wait_process.CheckedChanged += new System.EventHandler(this.rb_wait_process_CheckedChanged);
            this.rb_wait_process.Paint += new System.Windows.Forms.PaintEventHandler(this.radiobutton_Paint);
            // 
            // rb_wait_executable
            // 
            this.rb_wait_executable.AutoSize = true;
            this.rb_wait_executable.Checked = true;
            this.rb_wait_executable.ForeColor = System.Drawing.Color.White;
            this.rb_wait_executable.Location = new System.Drawing.Point(6, 32);
            this.rb_wait_executable.Name = "rb_wait_executable";
            this.rb_wait_executable.Size = new System.Drawing.Size(337, 17);
            this.rb_wait_executable.TabIndex = 7;
            this.rb_wait_executable.TabStop = true;
            this.rb_wait_executable.Text = "Change Display Profile back when the executable above is closed";
            this.rb_wait_executable.UseVisualStyleBackColor = true;
            this.rb_wait_executable.CheckedChanged += new System.EventHandler(this.rb_wait_executable_CheckedChanged);
            this.rb_wait_executable.Paint += new System.Windows.Forms.PaintEventHandler(this.radiobutton_Paint);
            // 
            // btn_app_executable
            // 
            this.btn_app_executable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_app_executable.ForeColor = System.Drawing.Color.White;
            this.btn_app_executable.Location = new System.Drawing.Point(527, 6);
            this.btn_app_executable.Name = "btn_app_executable";
            this.btn_app_executable.Size = new System.Drawing.Size(56, 20);
            this.btn_app_executable.TabIndex = 2;
            this.btn_app_executable.Text = "Choose";
            this.btn_app_executable.UseVisualStyleBackColor = true;
            this.btn_app_executable.Click += new System.EventHandler(this.btn_app_executable_Click);
            // 
            // txt_executable
            // 
            this.txt_executable.Location = new System.Drawing.Point(105, 6);
            this.txt_executable.Name = "txt_executable";
            this.txt_executable.Size = new System.Drawing.Size(416, 20);
            this.txt_executable.TabIndex = 1;
            this.txt_executable.TextChanged += new System.EventHandler(this.txt_executable_TextChanged);
            // 
            // lbl_app_executable
            // 
            this.lbl_app_executable.AutoSize = true;
            this.lbl_app_executable.ForeColor = System.Drawing.Color.White;
            this.lbl_app_executable.Location = new System.Drawing.Point(3, 10);
            this.lbl_app_executable.Name = "lbl_app_executable";
            this.lbl_app_executable.Size = new System.Drawing.Size(98, 13);
            this.lbl_app_executable.TabIndex = 0;
            this.lbl_app_executable.Text = "Executable to start:";
            this.lbl_app_executable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_app_executable.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(589, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timeout";
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Paint);
            // 
            // nud_timeout_executable
            // 
            this.nud_timeout_executable.Location = new System.Drawing.Point(640, 6);
            this.nud_timeout_executable.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nud_timeout_executable.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_timeout_executable.Name = "nud_timeout_executable";
            this.nud_timeout_executable.Size = new System.Drawing.Size(70, 20);
            this.nud_timeout_executable.TabIndex = 6;
            this.nud_timeout_executable.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // rb_launcher
            // 
            this.rb_launcher.AutoSize = true;
            this.rb_launcher.Checked = true;
            this.rb_launcher.ForeColor = System.Drawing.Color.White;
            this.rb_launcher.Location = new System.Drawing.Point(9, 178);
            this.rb_launcher.Name = "rb_launcher";
            this.rb_launcher.Size = new System.Drawing.Size(259, 17);
            this.rb_launcher.TabIndex = 2;
            this.rb_launcher.TabStop = true;
            this.rb_launcher.Text = "Launch Game already installed by Steam or Uplay";
            this.rb_launcher.UseVisualStyleBackColor = true;
            this.rb_launcher.CheckedChanged += new System.EventHandler(this.rb_launcher_CheckedChanged);
            this.rb_launcher.Paint += new System.Windows.Forms.PaintEventHandler(this.radiobutton_Paint);
            // 
            // rb_standalone
            // 
            this.rb_standalone.AutoSize = true;
            this.rb_standalone.ForeColor = System.Drawing.Color.White;
            this.rb_standalone.Location = new System.Drawing.Point(9, 19);
            this.rb_standalone.Name = "rb_standalone";
            this.rb_standalone.Size = new System.Drawing.Size(177, 17);
            this.rb_standalone.TabIndex = 0;
            this.rb_standalone.Text = "Standalone Application or Game";
            this.rb_standalone.UseVisualStyleBackColor = true;
            this.rb_standalone.CheckedChanged += new System.EventHandler(this.rb_standalone_CheckedChanged);
            this.rb_standalone.Paint += new System.Windows.Forms.PaintEventHandler(this.radiobutton_Paint);
            // 
            // dv_profile
            // 
            this.dv_profile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dv_profile.BackColor = System.Drawing.Color.DimGray;
            this.dv_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dv_profile.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv_profile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dv_profile.Location = new System.Drawing.Point(0, -1);
            this.dv_profile.Margin = new System.Windows.Forms.Padding(18);
            this.dv_profile.Name = "dv_profile";
            this.dv_profile.PaddingX = 100;
            this.dv_profile.PaddingY = 100;
            this.dv_profile.Profile = null;
            this.dv_profile.Size = new System.Drawing.Size(975, 311);
            this.dv_profile.TabIndex = 2;
            // 
            // dialog_open
            // 
            this.dialog_open.DefaultExt = "exe";
            this.dialog_open.FileName = "*.exe";
            this.dialog_open.Filter = global::HeliosPlus.Resources.Language.Executable_Files_Filter;
            this.dialog_open.RestoreDirectory = true;
            this.dialog_open.SupportMultiDottedExtensions = true;
            // 
            // dialog_save
            // 
            this.dialog_save.DefaultExt = "lnk";
            this.dialog_save.DereferenceLinks = false;
            this.dialog_save.Filter = global::HeliosPlus.Resources.Language.Shortcuts_Filter;
            this.dialog_save.RestoreDirectory = true;
            // 
            // rb_switch_perm
            // 
            this.rb_switch_perm.AutoSize = true;
            this.rb_switch_perm.ForeColor = System.Drawing.Color.White;
            this.rb_switch_perm.Location = new System.Drawing.Point(16, 456);
            this.rb_switch_perm.Name = "rb_switch_perm";
            this.rb_switch_perm.Size = new System.Drawing.Size(216, 17);
            this.rb_switch_perm.TabIndex = 7;
            this.rb_switch_perm.Text = "Switch to the Display Profile permanently";
            this.rb_switch_perm.UseVisualStyleBackColor = true;
            this.rb_switch_perm.CheckedChanged += new System.EventHandler(this.rb_switch_perm_CheckedChanged);
            this.rb_switch_perm.Paint += new System.Windows.Forms.PaintEventHandler(this.radiobutton_Paint);
            // 
            // rb_switch_temp
            // 
            this.rb_switch_temp.AutoSize = true;
            this.rb_switch_temp.Checked = true;
            this.rb_switch_temp.ForeColor = System.Drawing.Color.White;
            this.rb_switch_temp.Location = new System.Drawing.Point(16, 479);
            this.rb_switch_temp.Name = "rb_switch_temp";
            this.rb_switch_temp.Size = new System.Drawing.Size(381, 17);
            this.rb_switch_temp.TabIndex = 8;
            this.rb_switch_temp.TabStop = true;
            this.rb_switch_temp.Text = "Switch to the Display Profile temporarily while we run an application or game";
            this.rb_switch_temp.UseVisualStyleBackColor = true;
            this.rb_switch_temp.CheckedChanged += new System.EventHandler(this.rb_switch_temp_CheckedChanged);
            this.rb_switch_temp.Paint += new System.Windows.Forms.PaintEventHandler(this.radiobutton_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Title";
            // 
            // ilv_saved_profiles
            // 
            this.ilv_saved_profiles.AllowCheckBoxClick = false;
            this.ilv_saved_profiles.AllowColumnClick = false;
            this.ilv_saved_profiles.AllowColumnResize = false;
            this.ilv_saved_profiles.AllowItemReorder = false;
            this.ilv_saved_profiles.AllowPaneResize = false;
            this.ilv_saved_profiles.Location = new System.Drawing.Point(1, 322);
            this.ilv_saved_profiles.MultiSelect = false;
            this.ilv_saved_profiles.Name = "ilv_saved_profiles";
            this.ilv_saved_profiles.PersistentCacheDirectory = "";
            this.ilv_saved_profiles.PersistentCacheSize = ((long)(100));
            this.ilv_saved_profiles.Size = new System.Drawing.Size(974, 128);
            this.ilv_saved_profiles.TabIndex = 22;
            this.ilv_saved_profiles.UseWIC = true;
            this.ilv_saved_profiles.View = Manina.Windows.Forms.View.HorizontalStrip;
            this.ilv_saved_profiles.ItemClick += new Manina.Windows.Forms.ItemClickEventHandler(this.ilv_saved_profiles_ItemClick);
            // 
            // lbl_profile_shown_subtitle
            // 
            this.lbl_profile_shown_subtitle.AutoSize = true;
            this.lbl_profile_shown_subtitle.BackColor = System.Drawing.Color.DimGray;
            this.lbl_profile_shown_subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profile_shown_subtitle.ForeColor = System.Drawing.Color.White;
            this.lbl_profile_shown_subtitle.Location = new System.Drawing.Point(12, 42);
            this.lbl_profile_shown_subtitle.Name = "lbl_profile_shown_subtitle";
            this.lbl_profile_shown_subtitle.Size = new System.Drawing.Size(132, 20);
            this.lbl_profile_shown_subtitle.TabIndex = 24;
            this.lbl_profile_shown_subtitle.Text = "My Display Profile";
            // 
            // lbl_profile_shown
            // 
            this.lbl_profile_shown.AutoSize = true;
            this.lbl_profile_shown.BackColor = System.Drawing.Color.DimGray;
            this.lbl_profile_shown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profile_shown.ForeColor = System.Drawing.Color.White;
            this.lbl_profile_shown.Location = new System.Drawing.Point(12, 13);
            this.lbl_profile_shown.Name = "lbl_profile_shown";
            this.lbl_profile_shown.Size = new System.Drawing.Size(205, 29);
            this.lbl_profile_shown.TabIndex = 23;
            this.lbl_profile_shown.Text = "My Display Profile";
            // 
            // ShortcutForm
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(975, 1021);
            this.Controls.Add(this.lbl_profile_shown_subtitle);
            this.Controls.Add(this.lbl_profile_shown);
            this.Controls.Add(this.ilv_saved_profiles);
            this.Controls.Add(this.rb_switch_temp);
            this.Controls.Add(this.rb_switch_perm);
            this.Controls.Add(this.g_temporary);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dv_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShortcutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HeliosPlus - Setup Game Shortcuts";
            this.Load += new System.EventHandler(this.ShortcutForm_Load);
            this.g_temporary.ResumeLayout(false);
            this.g_temporary.PerformLayout();
            this.p_game.ResumeLayout(false);
            this.p_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_timeout_game)).EndInit();
            this.p_standalone.ResumeLayout(false);
            this.p_standalone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_timeout_executable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DisplayView dv_profile;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox g_temporary;
        private System.Windows.Forms.RadioButton rb_standalone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_timeout_executable;
        private System.Windows.Forms.Panel p_standalone;
        private System.Windows.Forms.Button btn_app_executable;
        private System.Windows.Forms.TextBox txt_executable;
        private System.Windows.Forms.Label lbl_app_executable;
        private System.Windows.Forms.TextBox txt_process_name;
        private System.Windows.Forms.RadioButton rb_launcher;
        private System.Windows.Forms.Panel p_game;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_timeout_game;
        private System.Windows.Forms.OpenFileDialog dialog_open;
        private System.Windows.Forms.SaveFileDialog dialog_save;
        private System.Windows.Forms.RadioButton rb_switch_perm;
        private System.Windows.Forms.RadioButton rb_switch_temp;
        private System.Windows.Forms.RadioButton rb_wait_process;
        private System.Windows.Forms.RadioButton rb_wait_executable;
        private System.Windows.Forms.Button btn_app_process;
        private System.Windows.Forms.TextBox txt_args_game;
        private System.Windows.Forms.CheckBox cb_args_game;
        private System.Windows.Forms.TextBox txt_args_executable;
        private System.Windows.Forms.CheckBox cb_args_executable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_choose_game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_game_name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView lv_games;
        private System.Windows.Forms.Label lbl_process_name;
        private System.Windows.Forms.ImageList il_games;
        private System.Windows.Forms.ColumnHeader clm_images;
        private System.Windows.Forms.ColumnHeader clm_name;
        private System.Windows.Forms.TextBox txt_game_id;
        private System.Windows.Forms.TextBox txt_game_launcher;
        private Manina.Windows.Forms.ImageListView ilv_saved_profiles;
        private System.Windows.Forms.Label lbl_profile_shown_subtitle;
        private System.Windows.Forms.Label lbl_profile_shown;
    }
}