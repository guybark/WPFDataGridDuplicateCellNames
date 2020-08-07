using System.Collections.ObjectModel;
using System.Windows;

namespace WPFDataGridDuplicateCellNames
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<SampleItem> sampleItems = GetData();

            SampleDataGrid.DataContext = sampleItems;
        }

        private ObservableCollection<SampleItem> GetData()
        {
            var samplesItems = new ObservableCollection<SampleItem>();

            var samplesItem1 = new SampleItem();
            samplesItem1.Label = "Hummingbird";
            samplesItem1.LabelId = "HB";
            samplesItem1.Description = "A small bird.";
            samplesItems.Add(samplesItem1);

            var samplesItem2 = new SampleItem();
            samplesItem2.Label = "Test";
            samplesItem2.LabelId = "Test";
            samplesItem2.Description = "This is a test item.";
            samplesItems.Add(samplesItem2);

            var samplesItem3 = new SampleItem();
            samplesItem3.Label = "Towhee";
            samplesItem3.LabelId = "TH";
            samplesItem3.Description = "A bigger bird.";
            samplesItems.Add(samplesItem3);

            return samplesItems;
        }

        public class SampleItem
        {
            public string Label { get; set; }
            public string LabelId { get; set; }
            public string Description { get; set; }
        }
    }
}
