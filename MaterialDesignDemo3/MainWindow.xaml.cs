using MaterialDesignThemes.Wpf;
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

namespace MaterialDesignDemo3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                this.BtnNormal.Visibility = Visibility.Visible;
                this.btnMax.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                this.BtnNormal.Visibility = Visibility.Collapsed;
                this.btnMax.Visibility = Visibility.Visible;
            }
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// 弹出播放模式POP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCyc_Click(object sender, RoutedEventArgs e)
        {
            int n = 123;
           

            PopCyc.IsOpen = true
           ;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listview = (ListBox)sender;
            switch(listview.SelectedIndex)
            {
                case 0:
                    PlayBackMode.Kind = PackIconKind.ShuffleVariant;
                    PopCyc.IsOpen = false;
                    break;
                case 1:
                    PlayBackMode.Kind = PackIconKind.PlaylistPlay;
                    PopCyc.IsOpen = false;
                    break;
                case 2:
                    PlayBackMode.Kind = PackIconKind.RepeatOnce;
                    PopCyc.IsOpen = false;
                    break;
                case 3:
                    PlayBackMode.Kind = PackIconKind.Repeat;
                    PopCyc.IsOpen = false;
                    break;
                default:
                    break;
            }
        }
    }
}
