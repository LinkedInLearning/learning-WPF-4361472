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

namespace SampleUserControlWpf
{
    /// <summary>
    /// UserControl1.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SampleProperty = DependencyProperty.Register
        (
            "Sample",
            typeof(string),
            typeof(UserControl1),
            new PropertyMetadata(default(string), new PropertyChangedCallback(OnSamplePropertyChanged))
        );


        private static void OnSamplePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var control = (UserControl1)obj;
            control.button.Content = e.NewValue;
        }

        public string Sample
        {
            get { return (string)GetValue(SampleProperty); }
            set { SetValue(SampleProperty, value); }
        }
    }
}
