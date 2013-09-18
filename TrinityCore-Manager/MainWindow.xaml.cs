﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Fluent;
using Ookii.Dialogs.Wpf;
using TrinityCore_Manager.Properties;

namespace TrinityCore_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : RibbonWindow
    {
        public MainWindow2()
        {
            InitializeComponent();
        }

        private void ExecCommandTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ButtonAutomationPeer peer = new ButtonAutomationPeer(ExecCommandButton);
                IInvokeProvider invokeProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
                invokeProv.Invoke();
                FocusManager.SetFocusedElement(this, ExecCommandTextBox);
                Keyboard.Focus(ExecCommandTextBox);
            }
        }

        private void SetTrunkLocButton_Click(object sender, RoutedEventArgs e)
        {

            var dialog = new VistaFolderBrowserDialog();
            dialog.SelectedPath = Settings.Default.TrunkLocation;

            var showDialog = dialog.ShowDialog();

            if (showDialog.HasValue && showDialog.Value)
            {
                Settings.Default.TrunkLocation = dialog.SelectedPath;
                Settings.Default.Save();
            }

        }

    }
}
