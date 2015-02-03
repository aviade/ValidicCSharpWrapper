﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ValidicCSharpApp.ViewModels;

namespace ValidicCSharpApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // private static readonly ILog Log = LogManager.GetLogger(typeof(App));
        private readonly MainWindow _mainWindow = new MainWindow();
        private readonly MainViewModel _viewModel = new MainViewModel();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Logger.Level = Level.Debug;

            // _viewModel.Dispatcher = ViewHelper.GetAddDelegate(_mainWindow);

//            _viewModel.Output.OutputDispatcher = ViewHelper.GetAddDelegate(_mainWindow);
//            _viewModel.Output.LogMessage = m => _viewModel.Output.Messages.Add(m);
//            _viewModel.SerialPortManager.StartScanningPorts();
            _mainWindow.DataContext = _viewModel;
            _mainWindow.Start(_viewModel);
            _mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            _mainWindow.Stop(_viewModel);
            _mainWindow.Close();
            Shutdown();
        }
    }
}
