﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace CommboxInGrid905
{
    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value;

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value as ComboBoxItem;
        }
    }
}
