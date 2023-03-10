
namespace ProgramAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("\n\nSelect an option:");
                Console.WriteLine("1.Factorial of a number ");
                Console.WriteLine("2.Print 1-100 witout using loop");
                Console.WriteLine("3.Find roots of Quadratic equation");
                Console.WriteLine("4.Number to String");
                Console.WriteLine("5.Check presence of a,e,p");
                Console.WriteLine("6.Find average of float numbers");
                Console.WriteLine("7.Find Prime numbers");
                Console.WriteLine("8.Shift zeros to the end of array");
                Console.WriteLine("9.Find first repeated element in an array");
                Console.WriteLine("10.Valid arithmetic expression");
                Console.WriteLine("11.Length of longest substring");
                Console.WriteLine("12.Delete Element at the desired position in an array");
                Console.WriteLine("13.Second largest element in an array");
                Console.WriteLine("14.Remove duplicates from an array");
                Console.WriteLine("15.Smallest gap between the numbers of an array");
                Console.WriteLine("16.Flip Coin-Heads and Tails percentage");
                Console.WriteLine("17.Check leap year");
                Console.WriteLine("18.Power of 2");
                Console.WriteLine("19.Harmonic number");
                Console.WriteLine("20.Prime factors of n");
                Console.WriteLine("21.Find quotient and remainder");
                Console.WriteLine("22.Swap two nummbers");
                Console.WriteLine("23.Check if number is even or odd");
                Console.WriteLine("24.Check if alphabet is vowel or constant");
                Console.WriteLine("25.Largest among 3 numbers");
                Console.WriteLine("26.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Factorial obj1 = new Factorial();
                        Console.WriteLine("Enter a number:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        long ans = obj1.factorial(n);
                        Console.WriteLine("Factorial is :" + ans);
                        break;
                    case 2:
                        PrintTill100 obj2 = new PrintTill100();
                        Console.WriteLine("Numbers from 1-100 without using loop :");
                        obj2.print(1);
                        break;
                    case 3:
                        QuadraticEqn obj3 = new QuadraticEqn();
                        Console.WriteLine("Enter value of a :");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of c:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        obj3.findRoots(a, b, c);
                        break;
                    case 4:
                        NumberToString obj4 = new NumberToString();
                        Console.WriteLine("Enter number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The equivalent string is:");
                        obj4.checkFactors(num);
                        break;
                    case 5:
                        CheckLetters obj5 = new CheckLetters();
                        Console.WriteLine("Enter the string :");
                        String str = Console.ReadLine();
                        obj5.Check(str);
                        break;
                    case 6:
                            Average obj6= new Average();
                        obj6.findAverage();
                        break;
                    case 7:
                            PrimeNumber obj7= new PrimeNumber();
                        obj7.findPrime();
                        break;
                    case 8:
                        ShiftZeros obj8=new ShiftZeros();
                        obj8.ShiftZerosFunc();
                        break;
                    case 9:
                        RepeatedElement obj9= new RepeatedElement();
                        obj9.FirstRepeatElement();
                        break;

                    case 10:
                        ValidOperation obj10= new ValidOperation();
                        Console.WriteLine("Enter the expression:");
                        String exp=Console.ReadLine();
                        obj10.checkValidity(exp);
                        break;

                    case 11:
                        LongestSubstring obj11=new LongestSubstring();
                        Console.WriteLine("Enter the string:");
                        String word = Console.ReadLine();
                        obj11.findSubstring(word);
                        break;
                    case 12:
                        DeleteItem obj12= new DeleteItem();
                        obj12.deleteElem();
                        break;
                    case 13:
                        SecondLargestElement obj13= new SecondLargestElement();
                        obj13.findSecondLargest();
                        break;
                    case 14:
                        RemoveDuplicates obj14= new RemoveDuplicates();
                        obj14.remove();
                        break;
                    case 15:
                        SmallestGap obj15= new SmallestGap();
                        obj15.findGap();
                        break;
                        case 16:
                            FlipCoin    obj16= new FlipCoin();
                        obj16.percentageHeadsTails();
                        break;
                    case 17:
                        LeapYear obj17= new LeapYear(); 
                        obj17.checkLeapYear();
                        break;
                    case 18:
                        PowerOf2 obj18= new PowerOf2();
                        obj18.printPower();
                        break;
                    case 19:
                        HarmonicNumber obj19= new HarmonicNumber();
                        obj19.printHarmonicSum();
                        break;
                    case 20:
                        PrimeFactors obj20=new PrimeFactors();
                        obj20.primeFactors();
                        break;
                    case 21:
                        QuotientRemainder obj21= new QuotientRemainder();
                        obj21.findQuotientReminder();
                        break;
                    case 22:
                        Swap obj22=new Swap();
                        obj22.swap();
                        break;
                    case 23:
                        OddEven obj23= new OddEven();
                        obj23.findOddEven();
                        break;
                    case 24:
                        VowelOrConstant obj24= new VowelOrConstant();
                        obj24.findVowelOrConstant();
                        break;
                    case 25:
                        LargestNumber obj25= new LargestNumber();
                        obj25.findLargest();
                        break;
                    case 26:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;



                }

            }
        }
    }
}