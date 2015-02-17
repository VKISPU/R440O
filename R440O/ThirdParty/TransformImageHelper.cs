using System;
using System.Windows.Forms;

namespace R440O.ThirdParty
{
    using System.Drawing;

    /// <summary>
    /// Класс предоставляющий методы для трансформирования изображений
    /// </summary>
    public class TransformImageHelper
    {
        /// <summary>
        /// Rotates the image by angle.
        /// </summary>
        /// <param name="oldBitmap">The old bitmap.</param>
        /// <param name="angle">The angle.</param>
        /// <returns>New image.</returns>
        public static Bitmap RotateImageByAngle(System.Drawing.Image oldBitmap, float angle)
        {
            var newBitmap = new Bitmap(oldBitmap.Width, oldBitmap.Height);
            var graphics = Graphics.FromImage(newBitmap);
            graphics.TranslateTransform((float)oldBitmap.Width / 2, (float)oldBitmap.Height / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-(float)oldBitmap.Width / 2, -(float)oldBitmap.Height / 2);
            graphics.DrawImage(oldBitmap, new Point(0, 0));
            return newBitmap;
        }

        /// <summary>
        /// Calculate angle for rotation
        /// </summary>
        /// <param name="elementWidth">Element width used to calculate coordinates</param>
        /// <param name="elementHeight">Element height used to calculate coordinates</param>
        /// <param name="eventArgs">Mouse event, sets current mouse position</param>
        /// <returns>Angle between vertical and mouse position</returns>
        public static int CalculateAngle(int elementWidth, int elementHeight, MouseEventArgs eventArgs)
        {
            var centerX = elementWidth / 2;
            var centerY = elementHeight / 2;
            var topX = elementWidth / 2;
            const int topY = 0;
            var pointX = eventArgs.X;
            var pointY = eventArgs.Y;

            var c = Math.Sqrt((Math.Pow(centerX - pointX, 2) + Math.Pow(centerY - pointY, 2)));
            var b = Math.Sqrt((Math.Pow(pointX - topX, 2) + Math.Pow(pointY - topY, 2)));
            var a = Math.Sqrt((Math.Pow(topX - centerX, 2) + Math.Pow(topY - centerY, 2)));
            var cosB = (a * a + c * c - b * b) / (2 * a * c);
            var angle = Math.Acos(cosB) * 180 / Math.PI;
            if (pointX < centerX) angle = -angle;
            return (int)angle;
        }
    }
}
