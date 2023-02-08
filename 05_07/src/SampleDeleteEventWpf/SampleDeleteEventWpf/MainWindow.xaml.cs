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

namespace SampleDeleteEventWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            button.Click += Button_Click;
            button.Click -= Button_Click;

            Sample sampleA = new Sample("A");
            button.Click += sampleA.SampleEvent;

            Sample sampleB = new Sample("B");
            button.Click += sampleB.SampleEvent;

            button.Click -= sampleA.SampleEvent;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Button_Click");
        }
    }

    public class Sample
    {
        private string name = string.Empty;

        public Sample(string name)
        {
            this.name = name;
        }
        public void SampleEvent(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"SampleEvent {name}");
        }
    }
}
