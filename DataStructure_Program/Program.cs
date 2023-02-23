using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace DataStructure_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Select an Option :");
                Console.WriteLine("1.Unordered List ");
                Console.WriteLine("2.Balanced parenthesis");
                Console.WriteLine("3.Simulate Banking Cash Counter");
                Console.WriteLine("4.Exit");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        String file = "D:\\BridgeRefresher\\BridgeLabz-Refresher\\DataStructure_Program\\UnOrdered.txt";
                        char[] sep = {' ',',','?'};
                        UnOrderedList<String> obj = new UnOrderedList<String>();
                         if(File.Exists(file))
                         {
                             StreamReader Textfile = new StreamReader(file);
                             string line;
                             while ((line = Textfile.ReadLine()) != null)
                             {
                                 var split = line.Split(sep);
                                 
                                 for (int i=0;i<split.Length; i++)
                                {
                                    
                                        obj.add(split[i]);
                                }
                              
                            }
                         
                             Textfile.Close();

                         }
                         Console.WriteLine("Enter word");
                        String w=Console.ReadLine();
                         Console.WriteLine();
                      
                        if (obj.Search(w))
                        {
                            obj.remove(w);
                        }
                        else
                        {
                            obj.add(w);
                        }String f= "D:\\BridgeRefresher\\BridgeLabz-Refresher\\DataStructure_Program\\UnOrdered.txt";
                        String res = obj.listToString();
                        File.WriteAllText(f, res);

                        break;
                    case 2:
                        StackDS<char> s = new StackDS<char>();
                        if (s.validParenthesis())
                        {
                            Console.WriteLine("Balanced parenthesis");
                        }
                        else
                        {
                            Console.WriteLine("Not Balanced parenthesis");
                        }
                        break;
                    case 3:
                        QueueDS q = new QueueDS();
                        for (; ; )
                        {
                            Console.WriteLine("Select an operation");
                            Console.WriteLine("1.Deposit Amount");
                            Console.WriteLine("2.Withdraw Amount");
                            Console.WriteLine("3.Check balance");
                            Console.WriteLine("4.Exit");
                            
                            int opt = Convert.ToInt32(Console.ReadLine());
                            if (opt == 1)
                            {
                                Console.WriteLine("Enter the amount to be deposited");
                                int depAmt = Convert.ToInt32(Console.ReadLine());
                                q.Enqueue(depAmt);
                                

                            }
                            if (opt == 2)
                            {
                                Console.WriteLine("Enter the amount to be withdrawn");
                                int withdrawAmt = Convert.ToInt32(Console.ReadLine());
                                if(withdrawAmt <= q.checkBalance())
                                {
                                   int front = q.Dequeue();
                                    if (front > withdrawAmt)
                                    {
                                        int bal = front - withdrawAmt;
                                        q.Enqueue(bal);
                                    }
                                    

                                }
                               
                                

                            }
                            else if (opt == 3)
                            {
                                q.displayBalance();
                            }
                            else if(opt==4) 
                            {
                                break;
                            }
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
            
        }
    }
}