using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Pokedata;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeDex.Converters
{
    public class DexNumberToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return "#" + ((ushort)value).ToString("000");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }

    public class TypeToTypeImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return new BitmapImage(new Uri((value as Pokemon).GetTypePictureSource(int.Parse((string)parameter))));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }

    public class ListToAbilitiesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string listOfAbilities = "";
            foreach (Ability ability in value as List<Ability>)
            {
                listOfAbilities += ability.ToString();
                if (ability != (value as List<Ability>).Last())
                    listOfAbilities += " | ";
            }

            return listOfAbilities;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}
