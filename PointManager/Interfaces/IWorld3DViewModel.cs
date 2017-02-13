using System.Windows;
using System.Windows.Input;

namespace PointManager.Interfaces
{
    public interface IWorld3DViewModel
    {
        void OnKeyDown(object sender, KeyEventArgs e);
        void OnKeyUp(object sender, KeyEventArgs e);
        void OnLoaded(object sender, RoutedEventArgs e);
        void OnMouseOver(object sender, MouseEventArgs e);
    }
}