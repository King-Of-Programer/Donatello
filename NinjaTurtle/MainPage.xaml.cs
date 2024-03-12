using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NinjaTurtle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SKCanvasView canvas = new SKCanvasView();
            canvas.PaintSurface += OnPaint;
            Content = canvas;
        }

        void OnPaint(object sender, SKPaintSurfaceEventArgs args)
        {
            var info = args.Info;
            var surface = args.Surface;
            var canvas = surface.Canvas;

            var bodyPaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.DarkGreen
            };
            canvas.DrawOval(info.Width / 2, info.Height / 2, 350, 500, bodyPaint);
            bodyPaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.Green
            };
            canvas.DrawOval(info.Width / 2, info.Height / 2, 320, 450, bodyPaint);
            canvas.DrawRect(
               new SKRect(
                   (info.Width / 2) - 75,
                   (info.Height / 2) + 100,
                   (info.Width / 2) - 175,
                   (info.Height / 2) + 800),
               bodyPaint);
            canvas.DrawRect(
                new SKRect(
                    (info.Width / 2) + 75,
                    (info.Height / 2) + 100,
                    (info.Width / 2) + 175,
                    (info.Height / 2) + 800),
                bodyPaint);
            var footStrip = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.Purple
            };
            canvas.DrawRect(
               new SKRect(
                   (info.Width / 2) - 75,
                   (info.Height / 2) + 650,
                   (info.Width / 2) - 175,
                   (info.Height / 2) + 750),
               footStrip);
            canvas.DrawRect(
                new SKRect(
                    (info.Width / 2) + 75,
                    (info.Height / 2) + 650,
                    (info.Width / 2) + 175,
                    (info.Height / 2) + 750),
                footStrip);

            canvas.DrawRect(
                new SKRect(
                    (info.Width / 2) + 180,
                    (info.Height / 2) -700,
                    (info.Width / 2) - 180,
                    (info.Height / 2) - 500),
                footStrip);

            var bodyArmor = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.Yellow
            };
            canvas.DrawRect(
                new SKRect(
                    (info.Width / 2) + 180,
                    (info.Height / 2) + 205,
                    (info.Width / 2) - 180,
                    (info.Height / 2) - 300),
                bodyArmor);
            canvas.DrawCircle(info.Width / 2, (info.Height / 2) + 200, 180, bodyArmor);
            canvas.DrawCircle((info.Width / 2) - 350, (info.Height / 2) + 200, 100, bodyPaint);
            canvas.DrawCircle((info.Width / 2) + 350, (info.Height / 2) + 200, 100, bodyPaint);
            canvas.DrawOval(info.Width / 2, (info.Height / 2) - 500, 220, 150, bodyPaint);
            canvas.DrawOval(info.Width / 2, (info.Height / 2) - 650, 140, 130, bodyPaint);
            canvas.DrawRect(
                new SKRect(
                    (info.Width / 2) + 180,
                    (info.Height / 2) - 700,
                    (info.Width / 2) - 180,
                    (info.Height / 2) - 600),
                footStrip);

            var weapon = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = SKColor.Parse("#332928")
            };

            canvas.DrawRect(
               new SKRect(
                   (info.Width / 2) + 350,
                   (info.Height / 2) - 650,
                   (info.Width / 2) + 450,
                   (info.Height / 2) + 800),
               weapon);
            var weaponStrip = new SKPaint()
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.Gray
            };
            canvas.DrawRect(
               new SKRect(
                   (info.Width / 2) + 350,
                   (info.Height / 2) - 100,
                   (info.Width / 2) + 450,
                   (info.Height / 2) + 400),
               weaponStrip);
        }
    }
}
