using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace EduCare.TeacherEye.Common.Controls
{
    public class ECButton : Button
    {
        public string IconText
        {
            get { return (string)GetValue(IconTextProperty); }
            set { SetValue(IconTextProperty, value); }
        }

        public static readonly DependencyProperty IconTextProperty =
            DependencyProperty.Register("IconText", typeof(string), typeof(ECButton), new PropertyMetadata(string.Empty));
    }
}
