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

namespace CombineGeometryTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var path1 = new Path {
                Stroke = Brushes.Orange,
                StrokeThickness = 1,
                Data = Geometry.Parse("M0,0 L80,80 L0,80")
            };
            var path2 = new Path {
                Stroke = Brushes.IndianRed,
                StrokeThickness = 1.2,
                Data = new EllipseGeometry(new Point(0, 0), 60, 60)
            };
            // Uncomment below to see result.
            //path1.Data = new CombinedGeometry(GeometryCombineMode.Intersect, path1.Data, path2.Data);

            Canvas.Children.Add(path1); Canvas.Children.Add(path2);
        }
    }
}
