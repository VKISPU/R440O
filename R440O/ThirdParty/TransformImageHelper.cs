﻿using System.Drawing;

namespace R440O.ThirdParty
{
    class TransformImageHelper
    {
        /// <summary>
        /// Rotates the image by angle.
        /// </summary>
        /// <param name="oldBitmap">The old bitmap.</param>
        /// <param name="angle">The angle.</param>
        /// <returns></returns>
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
    }
}