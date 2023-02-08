using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SampleLifeCycle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
            IsVisibleChanged += MainWindow_IsVisibleChanged;
        }

        // 表示・非表示
        private void MainWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("MainWindow_IsVisibleChanged");
        }

        // 初期アクティブ化
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("MainWindow_Loaded");
        }

        // 中断・フォーカスの喪失
        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);

            Debug.WriteLine("OnDeactivated");
        }

        // アクティブ化・フォーカスを取得
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            Debug.WriteLine("OnActivated");
        }

        // クローズ中
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            Debug.WriteLine("OnClosing");
        }

        // クローズ
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Debug.WriteLine("OnClosed");
        }
    }
}
