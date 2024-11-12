using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Threading;

namespace CursorDistance;

public partial class MainWindow : Window
{
    DispatcherTimer timer = new();
    private Point pos = new Point(0, 0);
    private bool moved = false;
    private long distance = 0L;
    private long travelTime = 0L;
    private long clearTime = 0L;
    private int speed = 0;
    private long totalSpeed = 0L;
    public MainWindow()
    {
        InitializeComponent();
        timer.Interval = TimeSpan.FromMilliseconds(8);
        timer.Tick += TimerTick;
        timer.IsEnabled = true;
        
        if (!OperatingSystem.IsMacOS()) return;
        if (TopLabel.Content != null) TopLabel.Content = TopLabel.Content.ToString()?.Replace("Alt+F4", "Cmd+Q");
    }

    private void TimerTick(object sender, EventArgs e)
    {
        var previousPoint = new Point(CursorTracker.Margin.Left, CursorTracker.Margin.Top);
        var newPoint = new Point(pos.X * 2 + this.Width, pos.Y * 2 + this.Height);
        CursorTracker.Margin = new Thickness(newPoint.X, newPoint.Y, 0, 0);
        // pythagorem theorem
        var c = Math.Sqrt(Math.Pow(newPoint.X - previousPoint.X, 2) + Math.Pow(newPoint.Y - previousPoint.Y, 2));
        distance += (long)c;
        travelTime++;
        speed = (int)(c / 8.0 * 1000.0);
        totalSpeed += speed;
        if (travelTime == clearTime)
        {
            ClearDisplay();
        }
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        var timeSecs = travelTime * 8L / 1000L;
        var avgSpeed = totalSpeed / travelTime;
        LabelPixels.Content = "Pixels travelled: " + distance;
        LabelTime.Content = "Time: " + timeSecs + " second" + ((timeSecs != 1) ? "s" : "");
        LabelCurSpeed.Content = "Current speed: " + speed + " px/s";
        LabelAvgSpeed.Content = "Average speed: " + avgSpeed + " px/s";
    }

    private void ClearDisplay()
    {
        CursorTracker.Background = Brushes.DimGray;
        CursorTracker.Foreground = Brushes.White;
        CursorTracker.Content = "";
    }

    private void PointerMoveBg(object? sender, PointerEventArgs e)
    {
        pos = new Point(e.GetPosition(this).X - this.Width, e.GetPosition(this).Y - this.Height);
        moved = true;
    }

    private void CursorTracker_OnPointerMoved(object? sender, PointerEventArgs e)
    {
        pos = new Point(e.GetPosition(this).X - CursorTracker.Width , e.GetPosition(this).Y - CursorTracker.Height);
        moved = true;
    }

    private void KeyPressed(object? sender, KeyEventArgs e)
    {
        switch (e.Key)
        {
            case Key.BrowserBack:
                CursorTracker.Background = Brushes.DeepSkyBlue;
                CursorTracker.Foreground = Brushes.Black;
                CursorTracker.Content = "BB";
                break;
            case Key.BrowserForward:
                CursorTracker.Background = Brushes.DeepPink;
                CursorTracker.Foreground = Brushes.Black;
                CursorTracker.Content = "BF";
                break;
            default:
                CursorTracker.Background = Brushes.Yellow;
                CursorTracker.Foreground = Brushes.Black;
                CursorTracker.Content = "Kbd";
                if (e.Key == Key.Escape)
                {
                    distance = 0L;
                    travelTime = 0L;
                    clearTime = 0L;
                    speed = 0;
                    totalSpeed = 0L;
                }
                break;
        }
        clearTime = travelTime + 12;
    }

    private void MousePressed(object? sender, PointerPressedEventArgs e)
    {
        bool doubleClick = e.ClickCount > 1;
        int clickCount = e.ClickCount;
        if (e.Pointer.Type == PointerType.Mouse)
        {
            if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
            {
                CursorTracker.Background = Brushes.Red;
                CursorTracker.Foreground = Brushes.White;
                CursorTracker.Content = ( doubleClick ? clickCount + "L" : "L" );
            }
            else if (e.GetCurrentPoint(this).Properties.IsMiddleButtonPressed)
            {
                CursorTracker.Background = Brushes.Lime;
                CursorTracker.Foreground = Brushes.Black;
                CursorTracker.Content = ( doubleClick ? clickCount + "M" : "M" );
            }
            else if (e.GetCurrentPoint(this).Properties.IsRightButtonPressed)
            {
                CursorTracker.Background = Brushes.Blue;
                CursorTracker.Foreground = Brushes.White;
                CursorTracker.Content = ( doubleClick ? clickCount + "R" : "R" );
            }
        } else if (e.Pointer.Type == PointerType.Touch)
        {
            CursorTracker.Background = Brushes.Orange;
            CursorTracker.Foreground = Brushes.Black;
            CursorTracker.Content = ( doubleClick ? clickCount + "T" : "T" );
        } else if (e.Pointer.Type == PointerType.Pen)
        {
            CursorTracker.Background = Brushes.White;
            CursorTracker.Foreground = Brushes.Black;
            CursorTracker.Content = ( doubleClick ? clickCount + "PT" : "PT" );
        }
        clearTime = travelTime + 12;
    }
}