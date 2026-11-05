using System.Configuration;
using System.Data;
using System.Windows;

namespace LR1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // привязки используют русский формат даты
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),
                new FrameworkPropertyMetadata(System.Windows.Markup.XmlLanguage.GetLanguage(
                    System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
            base.OnStartup(e);
        }
    }

}
