namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input year:");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input month(1-12):");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input day:(1-31)");
        int day = Convert.ToInt32(Console.ReadLine());

        if(day>0 && day < 28)
        {
            day = day + 1;
        }
        if(day == 28)
        {
            if(month == 2) {
                if((year%400==0)||(year%100!=0 || year % 4 == 0))
                {
                    day = 29;
                }
                else
                {
                    day = 1;
                    month = 3;
                }
            }
            else
            {
                day += 1;
            }
        }
        if (day == 30)
        {
            if(month==1||month==3||month==5 ||month==7 || month==8 ||month==10 || month == 12)
            {
                day += 1;
            }
            else
            {
                day = 1;
                month += 1;
            }
        }
        if (day == 31)
        {
            day = 1;
            if (month == 12)
            {
                year += 1;
                month = 1;

            }
            else
            {
                month += 1;
            }
        }
        Console.Write($"The next day in (yyyy-mm-dd): {year}-{month}-{day}");


    }
}