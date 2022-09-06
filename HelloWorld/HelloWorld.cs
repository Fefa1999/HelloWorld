namespace HelloWorld;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine("Enter year and press Enter");
        int year = Int32.Parse(Console.ReadLine());
        Boolean isLeapYear = IsLeapYear(year);
            if (isLeapYear) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            } 

    }
    
    public static bool IsLeapYear(int year) {
       if (year % 100 == 0) {
            return (year % 400 == 0);
        }
        return (year % 4) == 0;
    }
}