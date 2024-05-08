using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows;
using System.Windows.Controls;
using CloneSteam.Core.Models;

namespace CloneSteam.Core.Converters
{
    public class NewsTypeEnumConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            NewsType newsType = (NewsType)value;
            switch (newsType)
            {
                case NewsType.MAIN_UPDATE:
                    return "주요 업데이트";
                case NewsType.COMMON_UPDATE:
                    return "일반 업데이트";
                case NewsType.SMALL_UPDATE:
                    return "소규모 업데이트/패치 노트";
                default:
                    return "NewsType Error";
            }
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
