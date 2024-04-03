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

namespace CPerryWeek2InClassRectangle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void heightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            /// in my initial version, I was missing the code on line 28.  Onece I realized this omission, I was surprised that it had been working as well as it had.
            mainRectangle.Height = heightSlider.Value;
           

            if (areaSlider != null)
            {
                double rectWidth = areaSlider.Value / heightSlider.Value;
                if(rectWidth > 780)
                {
                    mainRectangle.Width = 780;
                }
                else
                {
                    rectWidth = mainRectangle.Width;
                }
            }

            mainEllipse.Height = heightSlider.Value;
            if (mainEllipse.Height > 440)
            {
                mainEllipse.Height = 440;

            }
            
            /// check to see if area slider exists.  If it is not null, you can proceed.
            ///if (areaSlider != null)
            ///{
                ///double ellipseWidth = heightSlider.Value;
                ///if (ellipseWidth > 780)
                ///{
                   /// mainEllipse.Width = 780;
               /// }
               /// else
               /// {
                ///    ellipseWidth = mainEllipse.Width;
                ///}
            ///}
        }

        private void areaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            double rectanglewidth = areaSlider.Value / heightSlider.Value;
            mainRectangle.Width = rectanglewidth;
            ///At some point, I had the if/else statement below swapped, which didn't work and the width of the rectangle was able to go far beyond the window.
            if (rectanglewidth > 760)
            {
                mainRectangle.Width = 760;
            }
            else
            {
                mainRectangle.Width = rectanglewidth;
            }


            double ellipseWidth = areaSlider.Value / heightSlider.Value;
            mainEllipse.Width = ellipseWidth;

            if (ellipseWidth > 760)
            {
                mainEllipse.Width = 760;
            }
            else
            {
                mainEllipse.Width = ellipseWidth;
            }
        }
        private void selectRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            ///I created this to select the shape and add the color so that it was clear which shape was selected.
            
            if (mainRectangle.Visibility == Visibility.Hidden)
            {
                mainRectangle.Visibility = Visibility.Visible;
                selectRectangle.Fill = new SolidColorBrush(Color.FromRgb(13, 182, 58));

                mainEllipse.Visibility = Visibility.Hidden;
                selectEllipse.Fill = new SolidColorBrush(Color.FromRgb(244, 244, 245));

                
            }
            else
            {
                mainRectangle.Visibility = Visibility.Hidden;
                selectRectangle.Fill = new SolidColorBrush(Color.FromRgb(244, 244, 245));

                mainEllipse.Visibility = Visibility.Visible;
                selectEllipse.Fill = new SolidColorBrush(Color.FromRgb(13, 182, 58));

                
            }
        }

        private void selectEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (mainEllipse.Visibility == Visibility.Hidden)
            {
                mainEllipse.Visibility = Visibility.Visible;
                selectEllipse.Fill = new SolidColorBrush(Color.FromRgb(13, 182, 58));

                mainRectangle.Visibility = Visibility.Hidden;
                selectRectangle.Fill = new SolidColorBrush(Color.FromRgb(244, 244, 245));

                
            }
            else
            {
                mainEllipse.Visibility = Visibility.Hidden;
                selectEllipse.Fill = new SolidColorBrush(Color.FromRgb(244, 244, 245));

                mainRectangle.Visibility = Visibility.Visible;
                selectRectangle.Fill = new SolidColorBrush(Color.FromRgb(13, 182, 58));

                
            }
        }

        
    }
       
}
