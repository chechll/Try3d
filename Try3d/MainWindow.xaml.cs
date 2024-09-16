using System.Windows;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;

namespace Scanner3DPlot
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Define your points in X, Y, Z space
            double[] xData = { 1, 2, 3, 4, 5 };
            double[] zData = { 2, 4, 1, 3, 5 };
            double[] yData = { 0, 0, 0, 0, 0 };  // Static Y values, or use indexes for 3D effect

            // Create a collection of points
            var points = new Point3DCollection();

            for (int i = 0; i < xData.Length; i++)
            {
                points.Add(new Point3D(xData[i], yData[i], zData[i]));
            }

            // Assign the points to the PointsVisual3D
            pointVisual.Points = points;
        }
    }
}
