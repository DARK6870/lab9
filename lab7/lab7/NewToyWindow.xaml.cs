using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Diagnostics;
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
using System.Windows.Shapes;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using ToastNotifications.Messages;

namespace lab7
{
    public partial class NewToyWindow : Window
    {
        Notifier notifier = new Notifier(cfg =>
        {
            cfg.PositionProvider = new WindowPositionProvider(
                parentWindow: Application.Current.MainWindow,
                corner: Corner.TopRight,
                offsetX: 10,
                offsetY: 10);

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(3),
                maximumNotificationCount: MaximumNotificationCount.FromCount(3));

            cfg.Dispatcher = Application.Current.Dispatcher;
        });


        public delegate void DataAddedHandler(ToyModel newToy);

        public event DataAddedHandler DataAdded;

        public NewToyWindow()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToyModel newdata = new ToyModel()
                {
                    Name = Name.Text,
                    CountryName = Country.Text,
                    Price = Convert.ToInt32(Price.Text),
                    TypeName = TypeName.Text,
                    ImageName = ImageUrl.Text
                };

                var validationContext = new ValidationContext(newdata, serviceProvider: null, items: null);
                var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

                if (Validator.TryValidateObject(newdata, validationContext, validationResults, validateAllProperties: true))
                {
                    DataAdded?.Invoke(newdata);
                    Close();
                }
                else
                {
                    foreach (var validationResult in validationResults)
                    {
                        notifier.ShowWarning(validationResult.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                notifier.ShowError("Error saving data: " + ex.Message);
            }
        }
    }

}
