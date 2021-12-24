
//New format on NET version 6

var macAddress = "00:30:67:D5:8D:56"; // Test device MAC address
await SampleWakeOnLanConsoleAppForNetCore.WakeOnLanClass.WakeOnLan(macAddress);
Console.WriteLine("Package Sending!");
Console.WriteLine("Press any key for close!");
Console.ReadKey();
Console.WriteLine("Closing");



// OLD FORMAT on NET version 5
//namespace SampleWakeOnLanConsoleAppForNetCore
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MainAsync().GetAwaiter().GetResult();
//            Console.WriteLine("Package Sending!");
//            Console.WriteLine("Press any key for close!");
//            Console.ReadKey();
//            Console.WriteLine("Closing");
//        }

//        private static async Task MainAsync()
//        {
//            var macAddress = "00:30:67:D5:8D:56";
//            await WakeOnLanClass.WakeOnLan(macAddress);
//        }
//    }
//}
