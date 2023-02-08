using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SampleEventCodeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SampleButton.Click += SampleButton_Click;
            SampleButton.Click += SampleButton_Click1;
        }

        private void SampleButton_Click1(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("SampleButton_Click1");
        }

        private void SampleButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("SampleButton_Click");
        }
    }
}
