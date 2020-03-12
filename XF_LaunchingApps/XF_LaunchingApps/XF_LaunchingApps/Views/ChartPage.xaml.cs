using Microcharts;
using SkiaSharp;
using System.Collections.Generic;
using Xamarin.Forms;
namespace XF_LaunchingApps.Views
{
    public partial class ChartPage : ContentPage
    {

        private readonly List<ChartEntry> entries =
            new List<ChartEntry> {
        new ChartEntry(200) {Label = "January",ValueLabel = "200",Color = SKColor.Parse("#266489"),TextColor=SKColor.Parse("#FFFFFF") },
        new ChartEntry(400) {Label = "February",ValueLabel = "400",Color = SKColor.Parse("#68B9C0"),TextColor=SKColor.Parse("#FFFFFF")  },
        new ChartEntry(-100) {Label = "March",ValueLabel = "-100",Color = SKColor.Parse("#90D585"),TextColor=SKColor.Parse("#FFFFFF")  }
            };

        public ChartPage()
        {
            InitializeComponent();
            Xamarin.Forms.DebugRainbows.DebugRainbow.SetShowColors(this, true);
            FirstChart.Chart = new RadialGaugeChart { Entries = entries };
        }
    }
}
