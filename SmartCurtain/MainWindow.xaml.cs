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
using System.Threading;
using System.Diagnostics;

namespace SmartCurtain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected SerialPort myPort;

        protected void PortCreater()
        {
            myPort = new SerialPort("COM5", 9600);
            //myPort.BaudRate = 9600;
            //myPort.PortName = "COM5";
        }
        public MainWindow()
        {
            InitializeComponent();
            PortCreater();
          
        }

        private void ButtonClickPreset0Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.Write("0");
            myPort.Close();
        }

        private void ButtonClickPreset25Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.Write("1");
            myPort.Close();
        }

        private void ButtonClickPreset50Percent_Click(object sender, RoutedEventArgs e)
        {
           
            myPort.Open();
            //Here we can write to the arduino
            myPort.Write("2");
            myPort.Close();
        }

        private void ButtonClickPreset75Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.Write("3");
            myPort.Close();
        }

        private void ButtonClickPreset100Percent_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.Write("4");
            myPort.Close();
        }

        private void ButtonClickTurnAutomationOn_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.Write("a");
            myPort.Close();
        }

        private void ButtonClickTurnAutomationOff_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            //Here we can write to the arduino
            myPort.Write("m");

            myPort.Close();
        }

        private void ManualUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            myPort.Write("u");
            myPort.Close();
        }

        private void ManualDownButton_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            myPort.Write("d");
            myPort.Close();
           
        }

        private void ForceUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPort.Open();
            myPort.Write("5");
            myPort.Close();
        }

        //private void ButtonClickManuelDown_MouseDown(object sender, RoutedEventArgs e)
        //{
        //    myPort.Open();
        //    //Here we can write to the arduino
        //    myPort.Write("d");

        //    myPort.Close();
        //}

        //private void ButtonClickManuelUp_MouseDown(object sender, RoutedEventArgs e)
        //{
        //    myPort.Open();
        //    //Here we can write to the arduino
        //    myPort.Write("u");
        //    myPort.Close();
        //}


    }
}
