using CivSem1Challenge2_CarSystem.models;

namespace CivSem1Challenge2_CarSystem.models {
    public class Listing : Car {
        public int Cost { get; set; }
        public int Price { get; set; }
        public Listing (string registration, string make, string model, int yearOfManufacture, int cost, int price) : base (registration, make, model, yearOfManufacture) {
            this.Price = price;
            this.Cost = cost;
        }

    }
}