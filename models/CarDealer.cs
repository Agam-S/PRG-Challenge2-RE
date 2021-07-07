using System.Collections.Generic;

namespace CivSem1Challenge2_CarSystem.models {
    public class CarDealer {

        public int DealerId { get; set; }
        public int StreetNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public List<Listing> Listings { get; set; }

        public CarDealer (int dealerId, int streetNo, string street, string city) {
            this.DealerId = dealerId;
            this.StreetNo = streetNo;
            this.Street = street;
            this.City = city;
            this.Listings = new List<Listing>();
        }

        public string GetAddress () {
            return $"{this.StreetNo} {this.Street} {this.City}";
        }
    }
}