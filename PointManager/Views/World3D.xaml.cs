using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PointManager.ViewModels;

namespace PointManager.Views
{
    /// <summary>
    /// Interaction logic for World3D.xaml
    /// </summary>
    public partial class World3D : UserControl
    {
        private World3DViewModel _world3DViewModel;

        public World3D()
        {
            _world3DViewModel = new World3DViewModel();
            InitializeComponent();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            _world3DViewModel.OnKeyDown(sender,e);
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            _world3DViewModel.OnKeyUp(sender,e);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _world3DViewModel.OnLoaded(sender,e);
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            _world3DViewModel.OnMouseOver(sender,e);
        }
    }
}
