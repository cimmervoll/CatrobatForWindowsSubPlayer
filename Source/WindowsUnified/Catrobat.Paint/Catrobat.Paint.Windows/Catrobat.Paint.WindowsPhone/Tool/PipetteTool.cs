﻿using Catrobat.Paint.WindowsPhone.Tool;
using System.Windows;
using Windows.Foundation;
using Windows.UI.Xaml.Media;
using Windows.Graphics;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using System;
using Windows.UI.Xaml.Shapes;

namespace Catrobat.Paint.Phone.Tool
{
    class PipetteTool : ToolBase
    {
        public PipetteTool()
        {
            ToolType = ToolType.Pipette;
            ResetCanvas();
        }


        public override void HandleDown(object arg)
        {
            //if (NeedToResetCanvas)
            //{
            //    ResetCanvas();
            //}

        }

        public override void HandleUp(object arg)
        {
            if (!(arg is Point))
            {
                return;
            }

        //PocketPaintApplication.GetInstance().PaintData.ColorSelected =
        //  new SolidColorBrush(PocketPaintApplication.GetInstance().Bitmap.);      
        }

        public override void HandleMove(object arg)
        {

        }

        public override void Draw(object o)
        {

        }

        public override void ResetDrawingSpace()
        {
            throw new NotImplementedException();
        }
    }
}
