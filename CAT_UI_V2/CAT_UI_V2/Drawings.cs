using System;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;

namespace CAT_UI_V2
{
    class Drawings
    {
        private enum ServoType
        {
            Horizontal,
            Threeway,
            Vertical
        }

        public void DrawServo(Canvas c, double ang, int servotype)
        {
            c.Children.Clear();
            Rectangle border = new Rectangle
            {
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                Width = c.Width,
                Height = c.Height
            };
            Canvas.SetLeft(border, 0);
            Canvas.SetTop(border, 0);
            c.Children.Add(border);

            switch(servotype)
            {
                case (int)ServoType.Horizontal:
                    Rectangle rectH = new Rectangle
                    {
                        Fill = Brushes.Black,
                        Width = 8,
                        Height = c.Height - 8
                    };
                    Canvas.SetLeft(rectH, (c.Width / 2) - 4);
                    Canvas.SetTop(rectH, 4);
                    RotateTransform rotateH = new RotateTransform(ang, 4, rectH.Height / 2);
                    rectH.RenderTransform = rotateH;
                    c.Children.Add(rectH);
                    break;

                case (int)ServoType.Threeway:
                    Rectangle rect1 = new Rectangle
                    {
                        Fill = Brushes.Black,
                        Width = 8,
                        Height = c.Height / 2
                    };
                    Canvas.SetLeft(rect1, (c.Width / 2) - 4);
                    Canvas.SetTop(rect1, 4);
                    RotateTransform rotate1 = new RotateTransform(-ang / 2, 4, rect1.Height - 4);
                    rect1.RenderTransform = rotate1;
                    c.Children.Add(rect1);

                    Rectangle rect2 = new Rectangle
                    {
                        Fill = Brushes.Black,
                        Width = c.Width / 2,
                        Height = 8
                    };
                    Canvas.SetLeft(rect2, (c.Width / 2) - 4);
                    Canvas.SetTop(rect2, (c.Height / 2) - 4);
                    RotateTransform rotate2 = new RotateTransform(-ang / 2, 4, 4);
                    rect2.RenderTransform = rotate2;
                    c.Children.Add(rect2);
                    break;

                case (int)ServoType.Vertical:
                    Rectangle rectV = new Rectangle
                    {
                        Fill = Brushes.Black,
                        Width = c.Width - 8,
                        Height = 8
                    };
                    Canvas.SetLeft(rectV, 4);
                    Canvas.SetTop(rectV, (c.Height / 2) - 4);
                    RotateTransform rotateV = new RotateTransform(ang, rectV.Width / 2, 4);
                    rectV.RenderTransform = rotateV;
                    c.Children.Add(rectV);
                    break;
            }

        }
    }
}
