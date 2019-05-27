using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShiNe_WPF.Buttons
{
    /// <summary>
    /// Interaction logic for RadioButtonRound.xaml
    /// </summary>
    public partial class RadioButtonRound : RadioButton
    {
        public RadioButtonRound()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string ImgSource
        {
            get { return (string)GetValue(ImgSourceProperty); }
            set { SetValue(ImgSourceProperty, value); }
        }

        public double ImgWidth
        {
            get { return (double)GetValue(ImgWidthProperty); }
            set { SetValue(ImgWidthProperty, value); }
        }

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public SolidColorBrush SurfaceBackground
        {
            get { return (SolidColorBrush)GetValue(SurfaceBackgroundProperty); }
            set { SetValue(SurfaceBackgroundProperty, value); }
        }

        public static readonly DependencyProperty SurfaceBackgroundProperty =
DependencyProperty.Register("SurfaceBackground", typeof(SolidColorBrush),
typeof(RadioButtonRound), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(255, 0, 0))));

        public static readonly DependencyProperty ImgSourceProperty =
DependencyProperty.Register("ImgSource", typeof(string),
typeof(RadioButtonRound), new PropertyMetadata(null));

        public static readonly DependencyProperty ImgWidthProperty =
DependencyProperty.Register("ImgWidth", typeof(double),
typeof(RadioButtonRound), new PropertyMetadata((double)100));

        public static readonly DependencyProperty ButtonTextProperty =
DependencyProperty.Register("ButtonText", typeof(string),
typeof(RadioButtonRound), new PropertyMetadata(""));

    }
}
