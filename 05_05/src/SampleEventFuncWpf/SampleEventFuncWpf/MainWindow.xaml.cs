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

namespace SampleEventFuncWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // イベントは+=で登録する
            // 複数のイベントハンドラーを設定できる
            // イベントを発生させる側（Publisher）と通知を受け取り処理する側（Subscriber）がある 
            MyButton.Click += MyButton_Click1;
            MyButton.Click += MyButton_Click2;

            SamplePublisher sample = new SamplePublisher();
            sample.SampleEvent += Sample_SampleEvent;

            sample.CallEvent();
        }

        private void Sample_SampleEvent(object sender, EventArgs e)
        {
        }

        private void MyButton_Click2(object sender, RoutedEventArgs e)
        {
        }

        private void MyButton_Click1(object sender, RoutedEventArgs e)
        {
        }
    }

    public class SamplePublisher
    {
        public delegate void SampleEventHandler(object sender, EventArgs e);

        public event SampleEventHandler SampleEvent;

        public void CallEvent()
        {
            this.SampleEvent?.Invoke(this, new EventArgs());
        }
    }
}
