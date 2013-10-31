using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using WinRTGridViewDataTemplateTechniques.DataModel;

namespace WinRTGridViewDataTemplateTechniques.ViewModel
{
    /// <summary>
    ///     This class contains properties that the main View can data bind to.
    ///     <para>
    ///         Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    ///     </para>
    ///     <para>
    ///         You can also use Blend to data bind with the tool's support.
    ///     </para>
    ///     <para>
    ///         See http://www.galasoft.ch/mvvm
    ///     </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        ///     Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Trip> Trips { get; private set; }

        private async void LoadData()
        {
            Trips = new ObservableCollection<Trip>();

            #region Load the sample trips

            Trips.Add(new Trip
            {
                Name = "The Bit Beyond Ubud",
                Description =
                    "Live out your inner hippy fantasies: drench yourself in patchouli, throw away your razor and buy a pair of fishermen pants so wide you could smuggle a monkey out of the country.",
                Duration = "15 days",
                Price = 0,
                Countries = "Indonesia",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/the-bit-beyond-ubud.jpg"),
                IsSale = false,
                SalePrice = 0
            });
            Trips.Add(new Trip
            {
                Name = "Essential Thailand tightarse trip",
                Description =
                    "Hilltribe trek. Local homestay. Night markets. Thai massage. Temple hopping. Noodles. Overnight trains. Short trip = short intro.",
                Duration = "8 days",
                Price = 795,
                Countries = "Thailand",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/tales-of-old-siam.jpg"),
                IsSale = true,
                SalePrice = 596
            });

            Trips.Add(new Trip
            {
                Name = "Cambodia Adventure Tightarse Trip",
                Description = "From Bangkok to Ho Chi Minh City this is a little beauty of a trip.",
                Duration = "12 days",
                Price = 865,
                Countries = "Cambodia, Thailand, Vietnam",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/voyage-en-indochine.jpg"),
                IsSale = true,
                SalePrice = 779
            });
            Trips.Add(new Trip
            {
                Name = "Laos Discovery Tightarse Trip",
                Description =
                    "We've got two weeks to get you around Vietnam, Laos and Northern Thailand. Take a tuk-tuk, cruise on a riverboat, speed along on a songthaew and embrace some pedal power.",
                Duration = "15 days",
                Price = 1560,
                Countries = "Laos, Thailand, Vietnam",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/mother-mekong.jpg"),
                IsSale = true,
                SalePrice = 1326
            });
            Trips.Add(new Trip
            {
                Name = "A Tale of Two Islands",
                Description =
                    "How to steer clear of Bali Belly? Some people swear by drinking a glass of red cordial each morning (worth a shot we reckon).",
                Duration = "14 days",
                Price = 1410,
                Countries = "Indonesia",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/a-tale-of-two-islands.jpg"),
                IsSale = false,
                SalePrice = 0
            });
            Trips.Add(new Trip
            {
                Name = "Ship To Shore",
                Description = "Brush up on your sailing terms for this one.",
                Duration = "4 days",
                Price = 820,
                Countries = "Thailand",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/gtko1.jpg"),
                IsSale = false,
                SalePrice = 0
            });
            Trips.Add(new Trip
            {
                Name = "High Thai'd",
                Description =
                    "There's nothing worse than busting a flip-flop in the middle of your trip. You can always buy a cheap pair of replacements but we all know that ends in blisters.",
                Duration = "7 days",
                Price = 1425,
                Countries = "Thailand",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/highthaid.jpg"),
                IsSale = false,
                SalePrice = 0
            });
            Trips.Add(new Trip
            {
                Name = "Yo-ho-ho and a bottle of rum",
                Description =
                    "Legendary captains: Jack Sparrow, Bluebeard, Han Solo, Cook, Blackbeard, Kirk, America, Hook. By the end of this trip you can include the guy who safely gets you back on solid ground. He'll be so excited.",
                Duration = "9 days",
                Price = 1795,
                Countries = "Burma, Thailand",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/yohoho.jpg"),
                IsSale = true,
                SalePrice = 1346
            });
            Trips.Add(new Trip
            {
                Name = "Vietnam in a Banana Leaf",
                Description =
                    "This is your full-on trip up the coast of Vietnam and into Halong Bay. From hectic Ho Chi Minh City to historic Hanoi. Ready, set, pagoda.",
                Duration = "15 days",
                Price = 945,
                Countries = "Vietnam",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/vietnam-sweetened-conden.jpg"),
                IsSale = true,
                SalePrice = 709
            });
            Trips.Add(new Trip
            {
                Name = "Mother Indochina",
                Description =
                    "Never heard of Indochina? Don't stress. You'll come for Angkor Wat, but you'll stay for the pho/amok/spring rolls (we could go on).",
                Duration = "26 days",
                Price = 1560,
                Countries = "Cambodia, Thailand, Vietnam",
                Image =
                    new Uri(
                        "http://d1kjemm2ytm5a6.cloudfront.net/sites/default/files/imagecache/runwild_trip_thumb/mother-mekong.jpg"),
                IsSale = false,
                SalePrice = 0
            });

            #endregion
        }
    }
}