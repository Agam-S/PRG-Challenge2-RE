namespace CivSem1Challenge2_CarSystem.models {

    public class Car {

        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }

        public Car (string registration, string make, string model, int yearOfManufacture) {
            Registration = registration;
            Make = make;
            Model = model;
            YearOfManufacture = yearOfManufacture;
        }

        public string GetDetails() {
            //TODO: complete the below to return the Make and Model of a car
            return $"Make: {null} Model: {null} YearOfManufacture {null}";
        }

    }
}
