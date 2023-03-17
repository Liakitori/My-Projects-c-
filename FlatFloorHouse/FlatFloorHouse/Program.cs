namespace FlatFloorHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n = 5;
            int[] k = {rnd.Next(1,10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10)};
            House house = new(n, k);

            Console.WriteLine(house.GetNumberOfFloors());
            Console.WriteLine(house.GetNumberOfFlatsInTheHouse());
            for (int i = 0; i < house.GetNumberOfFlatsInTheHouse(); i++)
            {
                house.GetFlat(i).SetSquareOfFlat((i+1) * 50);
                Console.WriteLine(house.GetFlat(i).GetSquareOfFlat());
            }
            for (int i = 0; i < house.GetNumberOfFlatsInTheHouse(); i++)
            {
                Console.Write(house.GetSortMass()[i] + " ");
            }
        }
    }
}