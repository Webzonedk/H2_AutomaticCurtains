using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;

namespace SmartCurtain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SerialPort myPort;

        protected void portCreater()
        {
            myPort = new SerialPort();
            myPort.BaudRate = 9600;
            myPort.PortName = "COM5";
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClickPreset0Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.WriteLine("0");
            myPort.Close();
        }

        private void ButtonClickPreset25Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.WriteLine("25");
            myPort.Close();
        }

        private void ButtonClickPreset50Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.WriteLine("50");
            myPort.Close();
        }

        private void ButtonClickPreset75Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.WriteLine("75");
            myPort.Close();
        }

        private void ButtonClickPreset100Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.WriteLine("100");
            myPort.Close();
        }

        private void ButtonClickTurnAutomationOn_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino

            myPort.Close();
        }

        private void ButtonClickTurnAutomationOff_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino

            myPort.Close();
        }

        private void ButtonClickManuelDown_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino

            myPort.Close();
        }

        private void ButtonClickManuelUp_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino

            myPort.Close();
        }
    }
}
