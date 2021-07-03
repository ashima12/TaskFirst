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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskUS.UserControls;

namespace TaskUS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Global Properties variables
        private bool _isDown;
        private bool _isDragging;
        private Point _startPoint;
        private UIElement _realDragSource;
        private UIElement _dummyDragSource = new UIElement();
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Drag and Drop Controls on Row Basis

        private void sp_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.Source == this.sp)
            {
            }
            else
            {
                _isDown = true;
                _startPoint = e.GetPosition(this.sp);
            }
        }

        private void sp_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isDown = false;
            _isDragging = false;
            _realDragSource?.ReleaseMouseCapture();
        }

        private void sp_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDown)
            {
                if ((_isDragging == false) && ((Math.Abs(e.GetPosition(this.sp).X - _startPoint.X) > SystemParameters.MinimumHorizontalDragDistance) ||
                    (Math.Abs(e.GetPosition(this.sp).Y - _startPoint.Y) > SystemParameters.MinimumVerticalDragDistance)))
                {
                    _isDragging = true;
                    _realDragSource = e.Source as UIElement;
                    _realDragSource?.CaptureMouse();
                    DragDrop.DoDragDrop(_dummyDragSource, new DataObject("UIElement", e.Source, true), DragDropEffects.Move);
                }
            }
        }

        private void sp_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("UIElement"))
            {
                e.Effects = DragDropEffects.Move;
            }
        }

        private void sp_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("UIElement"))
            {
                UIElement droptarget = e.Source as UIElement;
                int droptargetIndex = -1, i = 0;
                foreach (UIElement element in this.sp.Children)
                {
                    if (element.Equals(droptarget))
                    {
                        droptargetIndex = i;
                        break;
                    }
                    i++;
                }
                if (droptargetIndex != -1)
                {
                    this.sp.Children.Remove(_realDragSource);
                    this.sp.Children.Insert(droptargetIndex, _realDragSource);
                }

                _isDown = false;
                _isDragging = false;
                _realDragSource?.ReleaseMouseCapture();
            }
        }

        #endregion

        #region Fly Control from List to Column 1 
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var btn = (ListBox)sender;
            if (btn != null && btn.SelectedIndex > -1)
            {
                if (btn.SelectedIndex == 0)
                {
                    //for Button controls
                    var usercontrol = new btnUserControl();
                    sp.Children.Add(usercontrol);
                    btn.SelectedIndex = -1;
                }
                else if (btn.SelectedIndex == 1)
                {
                    // for label Controls
                    var usercontrol = new LabelUserControl();
                    sp.Children.Add(usercontrol);
                    btn.SelectedIndex = -1;
                }
                else if (btn.SelectedIndex == 2)
                {
                    // for  ComBoBox control
                    var usercontrol = new ComboBoxUserControl();
                    sp.Children.Add(usercontrol);
                    btn.SelectedIndex = -1;
                }
                else if (btn.SelectedIndex == 3)
                {
                    // For Checkbox Control
                    var usercontrol = new CheckBoxUserControl();
                    sp.Children.Add(usercontrol);
                    btn.SelectedIndex = -1;
                }
            }
        }
        #endregion

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridTitlebar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                Application.Current.MainWindow.WindowState = System.Windows.WindowState.Normal;
            else
                Application.Current.MainWindow.WindowState = System.Windows.WindowState.Maximized;
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
