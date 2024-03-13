using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using ToastNotifications;
using ToastNotifications.Position;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.ComponentModel.DataAnnotations;

namespace lab7
{
    public partial class MainWindow : Window
    {
        Notifier notifier = new Notifier(cfg =>
        {
            cfg.PositionProvider = new WindowPositionProvider(
                parentWindow: Application.Current.MainWindow,
                corner: Corner.TopRight,
                offsetX: 10,
                offsetY: 10);

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(5),
                maximumNotificationCount: MaximumNotificationCount.FromCount(5));

            cfg.Dispatcher = Application.Current.Dispatcher;
        });


        string filePath = "";
        int ID = 0;
        List<ToyModel> toys = new List<ToyModel>();

        public MainWindow()
        {
            InitializeComponent();
            save.IsEnabled = false;
            Save_as.IsEnabled = false;
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            NewToyWindow newToyWindow = new NewToyWindow();
            newToyWindow.DataAdded += NewToyWindow_DataAdded;
            newToyWindow.Owner = this;
            newToyWindow.ShowDialog();
        }

        private void NewToyWindow_DataAdded(ToyModel newToy)
        {
            Add(newToy);
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var data in toys)
                    {
                        sw.WriteLine($"{data.ID}|{data.Name}|{data.CountryName}|{data.TypeName}|{data.Price}|{data.ImageName}");
                    }
                }

                notifier.ShowSuccess("Data saved! ❤️");
            }
            catch(Exception ex)
            {
                notifier.ShowError(ex.Message);
            }
        }

        private void Save_as_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == true)
                {
                    string newFilePath = saveFileDialog.FileName;

                    using (StreamWriter sw = new StreamWriter(newFilePath))
                    {
                        foreach (var data in toys)
                        {
                            sw.WriteLine($"{data.ID}|{data.Name}|{data.CountryName}|{data.TypeName}|{data.Price}|{data.ImageName}");
                        }
                    }

                    notifier.ShowSuccess("Data saved successfull!");
                }
            }
            catch (Exception ex)
            {
                notifier.ShowError("Error saving file: " + ex.Message);
            }
        }


        private void open_file_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    filePath = openFileDialog.FileName;

                    var lines = System.IO.File.ReadAllLines(filePath);

                    if (toys.Count() > 0)
                    {
                        toys.Clear();
                    }
                    foreach (var line in lines)
                    {
                        var values = line.Split('|');

                        if (values.Length == 6)
                        {
                            ToyModel toy = new ToyModel
                            {
                                ID = int.Parse(values[0]),
                                Name = values[1],
                                CountryName = values[2],
                                TypeName = values[3],
                                Price = int.Parse(values[4]),
                                ImageName = values[5]
                            };

                            toys.Add(toy);
                        }
                        else
                        {
                            notifier.ShowError($"Error in file data!");
                            return;
                        }
                    }

                    file_data.ItemsSource = toys;
                    file_data.Items.Refresh();
                    save.IsEnabled = true;
                    Save_as.IsEnabled = true;

                }
                catch (Exception ex)
                {
                    notifier.ShowError("Error reading file: " + ex.Message);
                }
            }
        }
        private void DataGridRow_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            if (sender is DataGridRow row)
            {
                file_data.SelectedItem = row.DataContext;
            }
        }

        private void chart_Click(object sender, RoutedEventArgs e)
        {
            ChartWindow chartw = new ChartWindow(toys);
            chartw.Show();
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void file_data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (file_data.SelectedItem != null)
            {
                ToyModel selectedRow = (ToyModel)file_data.SelectedItem;

                Name.Text = selectedRow.Name;
                Country.Text = selectedRow.CountryName;
                TypeName.Text = selectedRow.TypeName;
                Price.Text = selectedRow.Price.ToString();
                ImageUrl.Text = selectedRow.ImageName;
                LoadImageAsync(selectedRow.ImageName);

                ID = selectedRow.ID;
            }
        }

        private async Task LoadImageAsync(string imageUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageData = await client.GetByteArrayAsync(imageUrl);

                    BitmapImage bitmapImage = new BitmapImage();

                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        bitmapImage.BeginInit();
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.StreamSource = stream;
                        bitmapImage.EndInit();
                    }

                    img.Source = bitmapImage;
                }
            }
            catch (Exception ex)
            {
                notifier.ShowError($"Error: {ex.Message}");
            }
        }

        private void save_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToyModel model = toys.FirstOrDefault(p => p.ID == ID);
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
                    model.Name = newdata.Name;
                    model.CountryName = newdata.CountryName;
                    model.TypeName = newdata.TypeName;
                    model.Price = newdata.Price;
                    model.ImageName = newdata.ImageName;
                    UpdateData();

                    notifier.ShowSuccess("Data updated!");
                }
                else
                {
                    foreach (var validationResult in validationResults)
                    {
                        notifier.ShowWarning(validationResult.ErrorMessage);
                    }
                }
            }
            catch(Exception ex)
            {
                notifier.ShowError("Error saving data: " + ex.Message);
            }
        }

        private void UpdateData()
        {
            file_data.ItemsSource = toys;
            file_data.Items.Refresh();
            ClearData();
        }

        private void ClearData()
        {
            ID = 0;
            Name.Text = "";
            Price.Text = "";
            Country.Text = "";
            TypeName.Text = "";
            ImageUrl.Text = "";
            img.Source = null;
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToyModel model = toys.FirstOrDefault(p => p.ID == ID);
                if (model == null)
                {
                    notifier.ShowError("Oops, something went wrong :(");
                    return;
                }
                toys.Remove(model);
                UpdateData();
                notifier.ShowSuccess("Data deleted!");
            }
            catch (Exception ex)
            {
                notifier.ShowError("Error saving data: " + ex.Message);
            }
        }


        public void Add(ToyModel model)
        {
            try
            {
                model.ID = toys.FirstOrDefault(p => p.ID == toys.Max(c => c.ID)).ID + 1;
                toys.Add(model);
                UpdateData();
                notifier.ShowSuccess("Data updated!");
            }
            catch (Exception ex)
            {
                notifier.ShowError("Error saving data: " + ex.Message);
            }
        }
    }
}
