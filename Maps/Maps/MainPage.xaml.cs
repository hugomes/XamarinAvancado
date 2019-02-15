using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Maps
{
    public partial class MainPage : ContentPage
    {
        private Map map { get; set; }

        public MainPage()
        {
            InitializeComponent();

            PermissaoGPSAsync();
        }

        private async Task PermissaoGPSAsync()
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Need location", "Gunna need that location", "OK");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                    //Best practice to always check that the key exists
                    if (results.ContainsKey(Permission.Location))
                        status = results[Permission.Location];
                }

                if (status == PermissionStatus.Granted)
                {
                    CriarMapa();
                    var results = await CrossGeolocator.Current.GetPositionAsync();
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await DisplayAlert("Location Denied", "Can not continue, try again.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "Error: " + ex, "Fechar");
            }
        }

        public void CriarMapa()
        {
            map = new Map(MapSpan.FromCenterAndRadius(new Position(-8.0205838, -34.9405926), Distance.FromKilometers(1)));
            map.IsShowingUser = true;
            map.MapType = MapType.Street;

            var pin1 = new Pin()
            {
                Address = "Endereço 1",
                Label = "Label 1",
                Type = PinType.Place,
                Position = new Position(-8.0219646, -34.9289621)
            };
            map.Pins.Add(pin1);

            var pin2 = new Pin()
            {
                Address = "Endereço 2",
                Label = "Label 2",
                Type = PinType.SavedPin,
                Position = new Position(-8.0216143, -34.9353783)
            };
            map.Pins.Add(pin2); 

            GPS gps = new GPS();
            if (gps.IsLocationAvailable())
            {
                Plugin.Geolocator.Abstractions.Position position = GPS.GetCurrentPosition().GetAwaiter().GetResult();
                if (position != null)
                {
                    var meuPin = new Pin()
                    {
                        Address = "Meu Endereço",
                        Label = "Minha Posição",
                        Type = PinType.SavedPin,
                        Position = new Position(position.Latitude, position.Longitude)
                    };
                    map.Pins.Add(meuPin);
                }
            }
            mapContainer.Children.Add(map);
        }
    }
}
