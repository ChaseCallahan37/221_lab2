
//Constant Variables
const double CLEANERS_WAGE = 12.37;
const double HOURS_PER_ROOM = 1.25;
//Processing Variable
double hoursToClean;
double occupancyRate;
double costOfCleaners;

System.Console.WriteLine("How many rooms are currently booked?");
double roomsBooked = int.Parse(Console.ReadLine());

System.Console.WriteLine("How many total rooms are there?");
double totalRooms = int.Parse(Console.ReadLine());

occupancyRate = roomsBooked / totalRooms;

hoursToClean = roomsBooked * HOURS_PER_ROOM;

costOfCleaners = hoursToClean * CLEANERS_WAGE;

System.Console.WriteLine($"The occupancy rate is {occupancyRate * 100}%");
System.Console.WriteLine($"The cost of the cleaners is ${costOfCleaners}");
