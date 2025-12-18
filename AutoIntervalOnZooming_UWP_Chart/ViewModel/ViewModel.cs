using System.Collections.ObjectModel;

namespace AutoIntervalOnZooming_UWP_Chart
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model() {XValue=5, YValue = 5},
                new Model() {XValue=10,YValue = 35},
                new Model() {XValue=15,YValue = 80},
                new Model() {XValue= 20,YValue = 120},
                new Model() {XValue=25,YValue = 140},
                new Model() {XValue=30, YValue = 120},
                new Model() {XValue=35,YValue = 80},
                new Model() {XValue=40,YValue = 35},
                new Model() {XValue= 45,YValue = 5},
            };

        }
    }

    public class Model
    {
        public double XValue { get; set; }
        public double YValue { get; set; }
    }
}
