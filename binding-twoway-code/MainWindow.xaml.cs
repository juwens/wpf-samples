using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace binding_twoway_code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetBinding();
        }

        private void SetBinding()
        {
            var b = new Binding()
            {
                Path=new PropertyPath(TextBox.TextProperty /* <-- Source Property */),
                Source=_source,
                // Mode = BindingMode.TwoWay, <-- implicitly set by WPF
                // UpdateSourceTrigger=UpdateSourceTrigger.LostFocus <-- implicitly set by WPF from TextProperty from Target
            };
            PresentationTraceSources.SetTraceLevel(b, PresentationTraceLevel.High);
            _target.SetBinding(TextBox.TextProperty, b); /* <-- Target Property */
        }
    }
}
