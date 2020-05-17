using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
//using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Bluetooth
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BluetoothObserver b = new BluetoothObserver();
            b.Start();
        }
        public class BluetoothObserver
        {
            BluetoothLEAdvertisementWatcher Watcher { get; set; }
            public void Start()
            {
                Watcher = new BluetoothLEAdvertisementWatcher()
                {
                    ScanningMode = BluetoothLEScanningMode.Active
                };
                Watcher.Received += Watcher_Received;
                Watcher.Stopped += Watcher_Stopped;
                Watcher.Start();
            }
            private bool isFindDevice { get; set; } = false;
            private async void Watcher_Received(BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs args)
            {
                if (isFindDevice)
                    return;
                if (args.Advertisement.LocalName.Contains("deviceName"))
                {
                    isFindDevice = true;
                    BluetoothLEDevice bluetoothLeDevice = await BluetoothLEDevice.FromBluetoothAddressAsync(args.BluetoothAddress);
                    GattDeviceServicesResult result = await bluetoothLeDevice.GetGattServicesAsync();
                    if (result.Status == GattCommunicationStatus.Success)
                    {
                        var services = result.Services;
                        foreach (var service in services)
                        {
                            if (!service.Uuid.ToString().StartsWith("serviceName"))
                            {
                                continue;
                            }
                            GattCharacteristicsResult characteristicsResult = await service.GetCharacteristicsAsync();
                            if (characteristicsResult.Status == GattCommunicationStatus.Success)
                            {
                                var characteristics = characteristicsResult.Characteristics;
                                foreach (var characteristic in characteristics)
                                {
                                    if (!characteristic.Uuid.ToString().StartsWith("characteristicName"))
                                    {
                                        continue;
                                    }
                                    GattCharacteristicProperties properties = characteristic.CharacteristicProperties;
                                    if (properties.HasFlag(GattCharacteristicProperties.Indicate))
                                    {
                                        characteristic.ValueChanged += Characteristic_ValueChanged;
                                        GattWriteResult status = await characteristic.WriteClientCharacteristicConfigurationDescriptorWithResultAsync(GattClientCharacteristicConfigurationDescriptorValue.Indicate);
                                        return;
                                    }
                                    if (properties.HasFlag(GattCharacteristicProperties.Read))
                                    {
                                        GattReadResult gattResult = await characteristic.ReadValueAsync();
                                        if (gattResult.Status == GattCommunicationStatus.Success)
                                        {
                                            var reader = DataReader.FromBuffer(gattResult.Value);
                                            byte[] input = new byte[reader.UnconsumedBufferLength];
                                            reader.ReadBytes(input);
                                            //Читаем input
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            private void Characteristic_ValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
            {
                var reader = DataReader.FromBuffer(args.CharacteristicValue);
                byte[] input = new byte[reader.UnconsumedBufferLength];
                reader.ReadBytes(input);
                //Читаем input
            }
            private void Watcher_Stopped(BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementWatcherStoppedEventArgs args)
            {
                ;
            }
        }
    }
}
