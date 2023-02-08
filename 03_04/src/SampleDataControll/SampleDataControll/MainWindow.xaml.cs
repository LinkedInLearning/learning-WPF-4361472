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

namespace SampleDataControll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = new List<Person>()
            {
                new Person() {Id = 1, Name = "ABC", Age = 25 },
                new Person() {Id = 2, Name = "DEF", Age = 22 },
                new Person() {Id = 3, Name = "GHI", Age = 24 }
            };

            listBox.ItemsSource = new List<string>()
            {
                "ABC",
                "DEF",
                "GHI"
            };
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
