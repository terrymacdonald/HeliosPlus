﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using DisplayMagicianShared;
using System.Runtime.InteropServices;
using Windows.UI.Notifications;
using AutoUpdaterDotNET;
using Newtonsoft.Json;
using System.Net;
using Windows.Data.Xml.Dom;
using Microsoft.Toolkit.Uwp.Notifications;
using WK.Libraries.HotkeyListenerNS;
using System.Collections.Generic;

namespace DisplayMagician.UIForms
{
    public partial class MainForm : Form
    {

        private bool allowVisible;     // ContextMenu's Show command used
        private bool allowClose;       // ContextMenu's Exit command used
        private HotkeyListener hotkeyListener = new HotkeyListener();
        private Hotkey hotkeyMainWindow;
        private Hotkey hotkeyShortcutLibraryWindow;
        private Hotkey hotkeyDisplayProfileWindow;
        private Dictionary<Hotkey, string> hotkeyDisplayProfiles = new Dictionary<Hotkey, string>() { };
        private Dictionary<Hotkey, string> hotkeyShortcuts = new Dictionary<Hotkey, string>() { };

        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public MainForm(Form formToOpen = null)
        {
            InitializeComponent();
            btn_setup_display_profiles.Parent = splitContainer1.Panel1;
            btn_setup_game_shortcuts.Parent = splitContainer1.Panel2;
            lbl_version.Text = string.Format(lbl_version.Text, Assembly.GetExecutingAssembly().GetName().Version);
            notifyIcon.Visible = true;
            notifyIcon.ContextMenuStrip = mainContextMenuStrip;
            RefreshNotifyIconMenus();


            // Define a new hotkey using the Hotkey class. 
            // Parameters are: [modifiers], [keys].
            //hotkeyMainWindow = new Hotkey(Keys.Control | Keys.Shift, Keys.W);
            //Program.HotkeyListener.Add(hotkeyMainWindow);

            /*if (Program.AppProgramSettings.MainWindowHotkey)
                hotkeyMainWindow = new Hotkey(Program.AppProgramSettings.MainWindowHotkey);
            if (Program.AppProgramSettings.ShortcutLibraryWindow)
                hotkeyShortcutLibraryWindow = new Hotkey(Program.AppProgramSettings.ShortcutLibraryWindow);
            if (Program.AppProgramSettings.DisplayProfileWindow)
                hotkeyDisplayProfileWindow = new Hotkey(Program.AppProgramSettings.DisplayProfileWindow);*/

            // Add all the Profile Hotkeys that are set
            foreach (ProfileItem myProfile in ProfileRepository.AllProfiles)
            {
                if (myProfile.Hotkey is Hotkey && myProfile.Hotkey.Modifiers != Keys.None && myProfile.Hotkey.KeyCode != Keys.None)
                {
                    hotkeyDisplayProfiles.Add(myProfile.Hotkey, myProfile.UUID);
                }
            }

            // Add all the Shortcut Hotkeys that are set
            foreach (ShortcutItem myShortcut in ShortcutRepository.AllShortcuts)
            {
                if (myShortcut.Hotkey is Hotkey && myShortcut.Hotkey.Modifiers != Keys.None && myShortcut.Hotkey.KeyCode != Keys.None)
                {
                    hotkeyShortcuts.Add(myShortcut.Hotkey, myShortcut.UUID);
                }
            }
            // And now connect up our processing function
            Program.HotkeyListener.HotkeyPressed += Hkl_WindowHotkeyPressed;



            if (Program.AppProgramSettings.MinimiseOnStart) 
            {
                // Make the form minimised on start 
                allowVisible = false;
                // Hide the application to notification area when the form is closed
                allowClose = false;
                cb_minimise_notification_area.Checked = true;
                // Change the exit_button text to say 'Close'
                btn_exit.Text = "&Close";

                // Remind the user that DisplayMagician is running the in background
                // Construct the toast content
                ToastContentBuilder tcBuilder = new ToastContentBuilder()
                    .AddToastActivationInfo("notify=minimiseStart&action=open", ToastActivationType.Foreground)
                    .AddText("DisplayMagician is minimised", hintMaxLines: 1)
                    .AddButton("Open", ToastActivationType.Background, "notify=minimiseStart&action=open");
                ToastContent toastContent = tcBuilder.Content;
                // Make sure to use Windows.Data.Xml.Dom
                var doc = new XmlDocument();
                doc.LoadXml(toastContent.GetContent());

                // And create the toast notification
                var toast = new ToastNotification(doc);

                // Remove any other Notifications from us
                DesktopNotifications.DesktopNotificationManagerCompat.History.Clear();

                // And then show it
                DesktopNotifications.DesktopNotificationManagerCompat.CreateToastNotifier().Show(toast);                                   

            }
            else
            {
                // Make the form show to the user on startup
                allowVisible = true;
                // Really close the application when the form is closed
                allowClose = true;
            }

            if (Program.AppProgramSettings.MinimiseOnStart && Program.AppProgramSettings.StartOnBootUp)
            {
                cb_minimise_notification_area.Checked = true;
            }
            else
            {
                cb_minimise_notification_area.Checked = false;
            }

            // If we've been handed a Form of some kind, then open it straight away
            if (formToOpen is DisplayProfileForm)
            {
                var displayProfileForm = new DisplayProfileForm();
                displayProfileForm.ShowDialog(this);
            }
            else if (formToOpen is ShortcutLibraryForm)
            {
                var shortcutLibraryForm = new ShortcutLibraryForm();
            shortcutLibraryForm.ShowDialog(this);
            }



    }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (cb_minimise_notification_area.Checked)
            {
                // Tell the user that 
                // Construct the toast content
                ToastContentBuilder tcBuilder = new ToastContentBuilder()
                    .AddToastActivationInfo("notify=stillRunning", ToastActivationType.Foreground)
                    .AddText("DisplayMagician is still running...", hintMaxLines: 1)
                    .AddText("DisplayMagician will wait in the background until you need it.")
                    .AddButton("Open DisplayMagician", ToastActivationType.Background, "notify=stillRunning&action=open")
                    .AddButton("Exit DisplayMagician", ToastActivationType.Background, "notify=stillRunning&action=exit");
                ToastContent toastContent = tcBuilder.Content;
                // Make sure to use Windows.Data.Xml.Dom
                var doc = new XmlDocument();
                doc.LoadXml(toastContent.GetContent());

                // And create the toast notification
                var toast = new ToastNotification(doc);

                // Remove any other Notifications from us
                DesktopNotifications.DesktopNotificationManagerCompat.History.Clear();
                
                // And then show it
                DesktopNotifications.DesktopNotificationManagerCompat.CreateToastNotifier().Show(toast);
            }
            Application.Exit();
        }

        private void pb_display_profile_Click(object sender, EventArgs e)
        {
            var displayProfileForm = new DisplayProfileForm();
            displayProfileForm.ShowDialog(this);
        }

        private void btn_setup_display_profiles_Click(object sender, EventArgs e)
        {
            var displayProfileForm = new DisplayProfileForm();
            displayProfileForm.ShowDialog(this);
        }

        private void pb_game_shortcut_Click(object sender, EventArgs e)
        {
            var shortcutLibraryForm = new ShortcutLibraryForm();
            shortcutLibraryForm.ShowDialog(this);
        }

        private void btn_setup_game_shortcuts_Click(object sender, EventArgs e)
        {
            var shortcutLibraryForm = new ShortcutLibraryForm();
            shortcutLibraryForm.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Start loading the Steam Games just after the Main form opens
            //SteamGame.GetAllInstalledGames();
            EnableShortcutButtonIfProfiles();

            //Run the AutoUpdater to see if there are any updates available.
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdaterOnParseUpdateInfoEvent;
            AutoUpdater.RunUpdateAsAdmin = true;
            AutoUpdater.HttpUserAgent = "DisplayMagician AutoUpdater";
            AutoUpdater.Start("http://displaymagician.littlebitbig.com/update/");
        }

        private void EnableShortcutButtonIfProfiles()
        {
            if (ProfileRepository.AllProfiles.Count > 0)
            {
                btn_setup_game_shortcuts.Visible = true;
                pb_game_shortcut.Enabled = true;
                lbl_create_profile.Visible = false;

                if (ShortcutRepository.AllShortcuts.Count > 0)
                    lbl_create_shortcut.Visible = false;
                else
                    lbl_create_shortcut.Visible = true;
            }
            else
            {
                btn_setup_game_shortcuts.Visible = false;
                pb_game_shortcut.Enabled = false;
                lbl_create_profile.Visible = true;
                lbl_create_shortcut.Visible = false;
            }

        }


        private void RefreshNotifyIconMenus()
        {
            // Clear all the profiles
            profileToolStripMenuItem.DropDownItems.Clear();
            // Prepare the heading shortcuts
            ToolStripMenuItem heading = new ToolStripMenuItem();
            heading.Text = "Display Profiles";
            Font headingFont = new Font(heading.Font, FontStyle.Italic);
            heading.Font = headingFont;
            heading.Enabled = false;
            profileToolStripMenuItem.DropDownItems.Add(heading);
            ToolStripSeparator separator = new ToolStripSeparator();
            profileToolStripMenuItem.DropDownItems.Add(separator);

            // Add the current slist of profiles into the NotifyIcon context menu
            foreach (ProfileItem profile in ProfileRepository.AllProfiles)
            {
                ToolStripMenuItem profileMenuItem = new ToolStripMenuItem(profile.Name, profile.ProfileBitmap, runProfileToolStripMenuItem_Click);
                if (profile.IsActive || !profile.IsPossible)
                    profileMenuItem.Enabled = false;
                else
                    profileMenuItem.Enabled = true;
                profileToolStripMenuItem.DropDownItems.Add(profileMenuItem);
            }

            // Clear all the shortcuts
            shortcutToolStripMenuItem.DropDownItems.Clear();
            // Prepare the heading shortcuts
            heading = new ToolStripMenuItem();
            heading.Text = "Game Shortcuts";
            heading.Font = headingFont;
            heading.Enabled = false;
            shortcutToolStripMenuItem.DropDownItems.Add(heading);
            separator = new ToolStripSeparator();
            shortcutToolStripMenuItem.DropDownItems.Add(separator);
            // Add the current list of profiles into the NotifyIcon context menu
            foreach (ShortcutItem shortcut in ShortcutRepository.AllShortcuts)
            {
                ToolStripMenuItem shortcutMenuItem = new ToolStripMenuItem(shortcut.Name, shortcut.ShortcutBitmap, runShortcutToolStripMenuItem_Click);
                if (shortcut.IsValid == ShortcutValidity.Warning || shortcut.IsValid == ShortcutValidity.Error)
                    shortcutMenuItem.Enabled = false;
                else
                    shortcutMenuItem.Enabled = true;
                shortcutToolStripMenuItem.DropDownItems.Add(shortcutMenuItem);
            }

        }

        private void runProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            ProfileItem profileToRun = null;
            if (menuItem != null)
            {
                foreach (ProfileItem profile in ProfileRepository.AllProfiles)
                {
                    if (profile.Name.Equals(menuItem.Text))
                    {
                        profileToRun = profile;
                        break;
                    }
                }

                // Run the shortcut if it's still there
                if (profileToRun != null)
                    Program.ApplyProfile(profileToRun);
            }
        }

        private void runShortcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            ShortcutItem shortcutToRun = null;
            if (menuItem != null)
            {
                foreach (ShortcutItem shortcut in ShortcutRepository.AllShortcuts)
                {
                    if (shortcut.Name.Equals(menuItem.Text))
                    {
                        shortcutToRun = shortcut;
                        break;
                    }
                }

                // Run the shortcut if it's still there
                if (shortcutToRun != null)
                    ShortcutRepository.RunShortcut(shortcutToRun, notifyIcon);
            }
        }

        public void openApplicationWindow()
        {
            allowVisible = true;
            Restore();
            Show();
            BringToFront();
        }

        public void exitApplication()
        {
            allowClose = true;
            Application.Exit();
        }

        private void openApplicationWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openApplicationWindow();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitApplication();
        }

        private void cb_minimise_notification_area_CheckedChanged(object sender, EventArgs e)
        {            
            if (cb_minimise_notification_area.Checked)
            {
                // Make the form minimised on start 
                allowVisible = false;
                // Hide the application to notification area when the form is closed
                allowClose = false;
                // Enable the MinimiseOnStart setting
                Program.AppProgramSettings.MinimiseOnStart = true;
                Program.AppProgramSettings.StartOnBootUp = true;
                // Change the exit_button text to say 'Close'
                btn_exit.Text = "&Close";
            }
            else
            {
                // Make the form show to the user on startup
                allowVisible = true;
                // Really close the application when the form is closed
                allowClose = true;
                // Disable the MinimiseOnStart setting
                Program.AppProgramSettings.MinimiseOnStart = false;
                Program.AppProgramSettings.StartOnBootUp = false;
                // Change the exit_button text to say 'Exit'
                btn_exit.Text = "&Exit";

            }
        }

        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, uint Msg);

        private const uint SW_RESTORE = 0x09;

        public void Restore()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowWindow(Handle, SW_RESTORE);
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            EnableShortcutButtonIfProfiles();
        }

        private void AutoUpdaterOnParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json.version,
                ChangelogURL = json.changelog,
                DownloadURL = json.url,
                Mandatory = new Mandatory
                {
                    Value = json.mandatory.value,
                    UpdateMode = json.mandatory.mode,
                    MinimumVersion = json.mandatory.minVersion
                },
                CheckSum = new CheckSum
                {
                    Value = json.checksum.value,
                    HashingAlgorithm = json.checksum.hashingAlgorithm
                }
            };
        }        

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.Error == null)
            {
                if (args.IsUpdateAvailable)
                {
                    DialogResult dialogResult;
                    if (args.Mandatory.Value)
                    {
                        logger.Info($"MainForm/AutoUpdaterOnCheckForUpdateEvent - New version {args.CurrentVersion} available. Current version is {args.InstalledVersion}. Mandatory upgrade.");
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {args.InstalledVersion}. This is required update. Press Ok to begin updating the application.", @"Update Available",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        logger.Info($"MainForm/AutoUpdaterOnCheckForUpdateEvent - New version {args.CurrentVersion} available. Current version is {args.InstalledVersion}. Optional upgrade.");
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {
                                        args.InstalledVersion
                                    }. Do you want to update the application now?", @"Update Available",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                    }

                    // Uncomment the following line if you want to show standard update dialog instead.
                    // AutoUpdater.ShowUpdateForm(args);

                    if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                    {
                        try
                        {
                            logger.Info($"MainForm/AutoUpdaterOnCheckForUpdateEvent - Downloading {args.InstalledVersion} update.");
                            if (AutoUpdater.DownloadUpdate(args))
                            {
                                logger.Info($"MainForm/AutoUpdaterOnCheckForUpdateEvent - Restarting to apply {args.InstalledVersion} update.");
                                Application.Exit();
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.Warn(ex, $"MainForm/AutoUpdaterOnCheckForUpdateEvent - Exception during update download.");
                            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (args.Error is WebException)
                {
                    logger.Warn(args.Error, $"MainForm/AutoUpdaterOnCheckForUpdateEvent - WebException - There was a problem reaching the update server.");
                    MessageBox.Show(
                        @"There is a problem reaching update server. Please check your internet connection and try again later.",
                        @"Update Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    logger.Warn(args.Error, $"MainForm/AutoUpdaterOnCheckForUpdateEvent - There was a problem performing the update: {args.Error.Message}");
                    MessageBox.Show(args.Error.Message,
                        args.Error.GetType().ToString(), MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
            ProgramSettings mySettings = Program.AppProgramSettings;
            // if the MainForm settings are different to the changes made when
            // tweaking the settings in the settings page, then align them
            if (mySettings.MinimiseOnStart && !cb_minimise_notification_area.Checked)
                cb_minimise_notification_area.Checked = true;
            else if (!mySettings.MinimiseOnStart && cb_minimise_notification_area.Checked)
                cb_minimise_notification_area.Checked = false;
        }

        private void lbl_create_shortcut_Click(object sender, EventArgs e)
        {
            btn_setup_game_shortcuts.PerformClick();
        }

        private void lbl_create_profile_Click(object sender, EventArgs e)
        {
            btn_setup_display_profiles.PerformClick();
        }

        private void btn_donate_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://github.com/sponsors/terrymacdonald";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openApplicationWindow();
        }
        
        private void Hkl_WindowHotkeyPressed(object sender, HotkeyEventArgs e)
        {
            if (e.Hotkey == hotkeyMainWindow)
                openApplicationWindow();
            else if (e.Hotkey == hotkeyDisplayProfileWindow)
                btn_setup_display_profiles.PerformClick();
            else if (e.Hotkey == hotkeyDisplayProfileWindow)
                btn_setup_game_shortcuts.PerformClick();
            else if (hotkeyDisplayProfiles.ContainsKey(e.Hotkey))
            {
                string displayProfileUUID = hotkeyDisplayProfiles[e.Hotkey];
                ProfileItem chosenProfile = ProfileRepository.GetProfile(displayProfileUUID);
                if (chosenProfile is ProfileItem)
                    Program.ApplyProfile(chosenProfile);
            }
            else if (hotkeyShortcuts.ContainsKey(e.Hotkey))
            {
                string shortcutUUID = hotkeyShortcuts[e.Hotkey];
                ShortcutItem chosenShortcut = ShortcutRepository.GetShortcut(shortcutUUID);
                if (chosenShortcut is ShortcutItem)
                    ShortcutRepository.RunShortcut(chosenShortcut);
            }
        }
    }
}
