using System;
using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using MvvmLightMessenging.Messages;

namespace MvvmLightMessenging
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<ButtonMessage>(new ButtonMessage(){ButtonText = "Button Pressed!"});
        }
    }
}
