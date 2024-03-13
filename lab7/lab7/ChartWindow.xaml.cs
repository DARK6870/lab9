using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace lab7
{
    public partial class ChartWindow : Window
    {
        public List<ToyModel> toys { get; set; }

        public ChartWindow(List<ToyModel> toys)
        {
            InitializeComponent();
            int kids = toys.Count(p => p.TypeName == "Kid");
            int male = toys.Count(p => p.TypeName == "M");
            int female = toys.Count(p => p.TypeName == "F");

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Kids",
                    Values = new ChartValues<int> { kids }
                },
                new ColumnSeries
                {
                    Title = "Male",
                    Values = new ChartValues<int> { male }
                },
                new ColumnSeries
                {
                    Title = "Female",
                    Values = new ChartValues<int> { female }
                }
            };

            Labels = new[] { "Kids", "Male", "Female" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}
