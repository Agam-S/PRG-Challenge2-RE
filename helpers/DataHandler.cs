using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CivSem1Challenge2_CarSystem.models;
using CsvHelper;
using CsvHelper.Configuration;

namespace CivSem1Challenge2_CarSystem.helpers {
    public class DataHandler {


        public List<CarDealer> GetCarDealers () {
            var config = new CsvConfiguration (CultureInfo.InvariantCulture) {
                PrepareHeaderForMatch = args => args.Header.ToLower (),
            };

            IEnumerable<Data> data;
            List<Data> dataList;
            using (var reader = new StreamReader ("car_data_mock.csv"))
            using (var csv = new CsvReader (reader, config)) {
                data = csv.GetRecords<Data> ();
                dataList = data.ToList<Data> ();
            }

            return this.GetDealerHelper (dataList);
        }

        public List<CarDealer> GetDealerHelper (List<Data> data) {

            var config = new CsvConfiguration (CultureInfo.InvariantCulture) {
                PrepareHeaderForMatch = args => args.Header.ToLower (),
            };

            IEnumerable<CarDealer> dealerData;
            List<CarDealer> dealerList;
            using (var reader = new StreamReader ("city_data_mock.csv"))
            using (var csv = new CsvReader (reader, config)) {
                dealerData = csv.GetRecords<CarDealer> ();
                dealerList = dealerData.ToList<CarDealer> ();
            }

            for (int i = 0; i < data.Count; i++) {
                var d = data[i];
                var listing = new Listing(d.Registration, d.Make, d.Model, d.YearOfManufacture, d.Cost, d.Price);
                for (int j = 0; j < dealerList.Count; j++) {
                    CarDealer c = dealerList[j];
                    if (d.DealerId == c.DealerId) {
                        c.Listings.Add (listing);
                        break;
                    }
                }
            }

            return dealerList;

        }

        public List<Car> GetCars () {

            var config = new CsvConfiguration (CultureInfo.InvariantCulture) {
                PrepareHeaderForMatch = args => args.Header.ToLower (),
            };

            IEnumerable<Car> data;
            List<Car> carList;
            using (var reader = new StreamReader ("car_data_mock.csv"))
            using (var csv = new CsvReader (reader, config)) {
                data = csv.GetRecords<Car> ();
                carList = data.ToList<Car> ();
            }

            carList.Shuffle();

            return carList; 
        }

        


    }
}