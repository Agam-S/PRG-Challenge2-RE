using System;
using System.Collections.Generic;
using System.Linq;
using CivSem1Challenge2_CarSystem.helpers;
using CivSem1Challenge2_CarSystem.models;

namespace CivSem1Challenge2_CarSystem
{
    public class UI
    {
        public List<CarDealer> CarDealers { get; set; }
        public List<Car> Cars { get; set; }
        public UI() {
            DataHandler dh = new DataHandler();
            this.CarDealers = dh.GetCarDealers();
            this.Cars = dh.GetCars();
            TopMenu();
        }

        public void TopMenu() {
            System.Console.WriteLine("==================================\n Press any key to continue");
            Console.ReadKey();


            Console.WriteLine("\nWelcome to Dod&Gy Car Reg system - Alpha ver");

            Console.WriteLine ("1. Print the ids and Addresses of the Car Dealers");
            Console.WriteLine ("2. Get the number of listings from Car Dealer given Car Dealer Id");
            Console.WriteLine ("3. Print the Make, Model and year of manufacture of a Car given the Rego");
            Console.WriteLine ("4. Print amount of cars in the system");
            Console.WriteLine ("5. Print the total number of listings in all of car dealers together");
            Console.WriteLine ("6. Add a listing");
            Console.WriteLine ("7. (optional) Print all listings under a given price and manufactured before a given year");
            Console.WriteLine ("8. (optional) Print a list of cars NOT listed at a dealer");
            Console.WriteLine ("9. (optional) Print the oldest car with the highest price");
            Console.WriteLine ("10. (optional) Write the current state of the system back to csv files (save)");
            Console.WriteLine ("11. (optional) Print the Dealer and listing details of the car with the highest profit margin");
            System.Console.WriteLine ("x. Exit");

            var input = Console.ReadLine();

            switch(input) {

                case "1":
                    //TODO: from the attribute this.CarDealers, print the ids and Addresses of all of the car dealers
                    // use GetAddress() to do this

                    //----------
                    break;
                
                case "2":
                    System.Console.WriteLine("Please enter the Car Dealer id");
                    int num;
                    while(!int.TryParse(Console.ReadLine(), out num)) {
                        System.Console.WriteLine("Invalid, enter again");
                    }

                    int numCars = this.DealerGetNumListings(num);
                    if(numCars == -1) {
                        System.Console.WriteLine($"Car Dealer {num} doesn't exist");
                        break;
                    }
                    System.Console.WriteLine($"Car Dealer {num} has {numCars} cars/listings");
                    break;

                case "3":
                    System.Console.WriteLine("Please enter a Registration");
                    string rego = Console.ReadLine();

                    string carDetails = this.GetCarDetails(rego);
                    if(carDetails == null) {
                        System.Console.WriteLine($"Car {rego} doesn't exist");
                        break;
                    }
                    System.Console.WriteLine($"Rego: {rego} Details: {carDetails}");
                    break;

                case "4":
                    //TODO: Print the amount of cars in the system
                    // Create and call a method/function named GetNumCars() to do this.
                    break;

                case "5":
                    //TODO: Print the total cost of listings in car dealers.  Not all of the cars are in a delear that is in the CarDealers list
                    numCars = this.GetTotalCostCarDealers();
                    System.Console.WriteLine($"There are a total of {numCars} in the car dealers");
                    break;

                case "6":
                   //TODO: Add a car to the cars List. Then add that car to a valid car dealer
                   this.AddStudent();
                   break;

                case "7":
                    //TODO: Print all listings under a given price and manufactured before a given year
                    // Print all listings with a PRICE of UNDER OR EQUAL TO a given price and manufactured BEFORE a given year"
                    System.Console.WriteLine("Please enter a year of manufacture");
                    while(!int.TryParse(Console.ReadLine(), out num)) {
                        System.Console.WriteLine("Invalid, enter again");
                    }

                    int price;
                    System.Console.WriteLine("Please enter the price to be under");
                    while(!int.TryParse(Console.ReadLine(), out price)) {
                        System.Console.WriteLine("Invalid, enter again");
                    }

                    //TODO: print the listing of PRICE of UNDER OR EQUAL TO a given price and manufactured BEFORE a given year
                    break;

                case "8":
                    //TODO: (optional CREDIT TASK) - Print a list of cars that are not in an existing car dealer
                    // create a method/function called GetNonDealerCars() to do this  
                    break;

                case "9":
                    //TODO: (optional DISTINCTION TASK) - Find and Print the oldest and most expensive car/listing by cost.  ie find oldest cars and print the most expensive by cost
                    break;

                case "10":
                    //TODO: (optional HIGH DISTINCTION TASK) - Write the current state of the system back to the csv files.
                    // add a method to the DataHandler class to do this
                    break;

                case "11":
                    //TODO: (optional HIGH DISTINCTION TASK) - Find the car/listing with the highest profit margin (price - cost).  Print it's dealer, car details and profit margin
        
                    break;

                case "x":
                    System.Console.WriteLine("Bye bye");
                    return;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            this.TopMenu();



            
        }

        //TODO: complete for menu item 5.
        private int GetTotalCostCarDealers()
        {
            return 0;
        }


        //TODO: create the GetNumCars() method/function here


        //---------------------

        private string GetCarDetails(string rego)
        {
            //TODO: write code find the relevant car in this.Cars and return the car's details
            // should use the method GetDetails() from Car
            return null;
        }

        //TODO: complete for menu item 2
        private int DealerGetNumListings(int num)
        {
            //TODO: write code find the relevant car dealer by DealerId in this.CarDealers and return the number of listings
            // if num doesn't exist in CarDealers, return -1
            return -1;
        }

        //TODO:  used for menu item 6
        private void AddStudent()
        {
            string rego;
            string make;
            string model;
            int yom;
            int cost;
            int price;


            int dealerId;

            System.Console.Write("Please enter car rego: ");
            rego = Console.ReadLine();
            System.Console.Write("Please enter car make: ");
            make = Console.ReadLine();
            System.Console.Write("Please enter car model: ");
            model = Console.ReadLine();

            System.Console.Write("Please enter car's year of manufacture: ");
            while(!int.TryParse(Console.ReadLine(), out yom)) {
                System.Console.WriteLine("Invalid, enter again");
            }

            System.Console.Write ("Please enter car's cost: ");
            while (!int.TryParse (Console.ReadLine (), out cost)) {
                System.Console.WriteLine ("Invalid, enter again");
            }

            System.Console.Write ("Please enter car's year of price: ");
            while (!int.TryParse (Console.ReadLine (), out price)) {
                System.Console.WriteLine ("Invalid, enter again");
            }

            //TODO: create and add the new car to the this.Cars list

            System.Console.Write("Enter car dealer id to add the car to: ");
            while(!int.TryParse(Console.ReadLine(), out dealerId)) {
                System.Console.WriteLine("Invalid, enter again");
            }



            //TODO: add the car as a listing to the desired car dealer in this.CarDealers.  
            //      If the dealer doesn't exist let the user know and go back to the main menu.
            // -----------------------
            // (optional - CREDIT TASK)  If the dealer doesn't exist keep asking until a valid dealer id is entered.
            //                           User may enter 9999 for no dealer for the car to be entered into
        }

        //TODO: Create the GetNonDealerCars() method/function here

    }
}