using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Storage;
using Newtonsoft.Json.Linq;

namespace WinRTGridViewDataTemplateTechniques.DataModel
{
    public class Trip
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public float Price { get; set; }
        public string Countries { get; set; }
        public Uri Image { get; set; }
        public bool IsSale { get; set; }
        public float SalePrice { get; set; }
    }
}