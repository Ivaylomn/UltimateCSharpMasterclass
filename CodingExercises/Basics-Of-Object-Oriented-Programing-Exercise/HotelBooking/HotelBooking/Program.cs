namespace HotelBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hotelBooking = new HotelBooking("Ivaylo", new DateTime(2023, 12, 7, 17, 00, 15), 5);
            Console.WriteLine(hotelBooking.GuestName);
            Console.WriteLine(hotelBooking.StartDate);
            Console.WriteLine(hotelBooking.EndDate);
        }
    }
}
