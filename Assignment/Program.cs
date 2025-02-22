class program
{


    static void Main()

    {
        ////Inheritance


        //Specs myCarSpecs = new Specs();

        //myCarSpecs.Name();
        //myCarSpecs.NameUserInput = Console.ReadLine();
        //myCarSpecs.Type();
        //myCarSpecs.NumberofSeats();
        //myCarSpecs.NumberofSeatsuserInput = Convert.ToInt32(Console.ReadLine());
        //myCarSpecs.specs();


        ////Encapsulation 

        //    Login yourLoginDetails = new Login();



        //    Console.WriteLine("Write your Email here! (Dont worry we will not spam you <3 )");
        //    Console.Write("Email Feild :");
        //    yourLoginDetails.Email = Console.ReadLine();


        //    Console.WriteLine("Write your Password!");
        //    Console.Write("Password Feild :");
        //    yourLoginDetails.Password = Console.ReadLine();


        //}
        ///Polymorphism

        //Vehicles vehicleTyres = new Suzuki();

        //vehicleTyres.transportVehicle();

        //Vehicles vehicleTyre = new Truck();

        //vehicleTyres.transportVehicle();


        //Abstraction
        class Program
    {
        static void Main()
        {
            BankAccount account = new SavingsAccount(1000);
            account.Deposit(500);
            account.Withdraw(300);
            account.ShowBalance();
        }
    }


}
}