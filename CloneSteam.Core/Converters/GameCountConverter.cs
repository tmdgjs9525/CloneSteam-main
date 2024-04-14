using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace CloneSteam.Core.Converters
{
    public class GameCountConverter : MarkupExtension, IValueConverter
    {
        //라이브러리에 카테고리별로 게임이 몇 개 있는지
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int count = int.Parse(value.ToString());
            string strCount = $"({count})"; 
            return strCount;
        }

        public object ConvertBack(
            object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
