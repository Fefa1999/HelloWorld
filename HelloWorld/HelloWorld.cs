namespace HelloWorld;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine("Enter year and press Enter");
        commandLineInputChecker(Console.ReadLine());
    }

    public static void commandLineInputChecker(String yearAsString){
        try{
            int year = Int32.Parse(yearAsString);
            Boolean isLeapYear = IsLeapYear(year);
            if (isLeapYear) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            } 
        }catch{
            Console.WriteLine("Error - Please enter valid input (int)");
        }
    }
    
    public static bool IsLeapYear(int year) {
        if(year<1582) return false;

        if (year % 100 == 0) {
            return (year % 400 == 0);
        }
        return (year % 4) == 0;
        }
}