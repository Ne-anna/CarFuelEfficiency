namespace CarFuelEfficiency
{
    class Program
    {
        static void Main(string[] args)
        {
            Car favouriteCar = new Car(6.5); //8 km per litre
            favouriteCar.AddFuel(40); //Tank with 40 litres
            favouriteCar.Drive(200); //Driving 200 km
            favouriteCar.GetFuelLevel();
        }
    }
}
