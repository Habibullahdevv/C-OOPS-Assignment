﻿using System;


//////Inheritance
//class Car

//{

//    public void Name()
//    {

//        Console.WriteLine("What is the name of your car?");
//    }

//    public string NameUserInput { get; set; }

//    public void Type()
//    {

//        Console.WriteLine($"Ooh! its {NameUserInput}");

//    }

//};


//class Specs : Car

//{
//    public void NumberofSeats()
//    {

//        Console.WriteLine("How many seats do your car have?");

//    }

//    public int NumberofSeatsuserInput
//    {

//        get; set;

//    }

//    public void specs()
//    {

//        Console.WriteLine($"This car is {NameUserInput} and it has {NumberofSeatsuserInput} seats");

//    }

//}

////Encapsulation

//class Login
//{

//    private string _email;

//    public string Email
//    {
//        get { return _email; }

//        set
//        {
//            if (!string.IsNullOrEmpty(value))
//            {

//                _email = value;
//            }
//            else
//            {
//                Console.WriteLine("Email feild Cannot be empty");



//            }

//        }
//    }

//    private string _password;

//    public string Password
//    {
//        get { return _password; }

//        set
//        {
//            if (!string.IsNullOrEmpty(value))
//            {

//                _password = value;

//                Console.WriteLine("HAHAHA is was Lying (X your account is our's now...");

//            }
//            else
//            {
//                Console.WriteLine("Password feild Cannot be empty");



//            }

//        }
//    }


//}

//Polymorhism


//class Vehicles 

//{
//    public virtual void transportVehicle() 
//    {

//        Console.WriteLine("Usually small transport vehicles has 4 tyres");
    
//    }
//}

//class Suzuki : Vehicles 
//{
//    public override void transportVehicle()
//    {

//        Console.WriteLine("Truck has 4 tyres");

//    }


//}

//class Truck : Vehicles
//{
//    public override void transportVehicle()
//    {

//        Console.WriteLine("A Truck has 6 tyres");

//    }


//}
