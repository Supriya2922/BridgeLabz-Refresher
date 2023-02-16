using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class ValidOperation
    {
        public bool checkValidity(String str)
        {
            char[] ch = str.ToCharArray();
            int opr = 0;
            int num = 0;
            for (int i =0;i<str.Length;i++)
            {
                if (ch[i]=='+' || ch[i]=='-' || ch[i]=='*' || ch[i]=='/' || ch[i]=='%') {
                    opr++;
                }
                if (Char.IsDigit(ch[i])){
                    num++;
                }
            }
            if(opr + 1 == num)
            {
                return true;
            }
            return false;
        }
        public  int evaluate(String exp)
        {
            Stack<int> operands= new Stack<int>();
            Stack<char> operation= new Stack<char>();
            for(int i=0;i<exp.Length;i++)
            {
                char c = exp[i];

                if(Char.IsDigit(c))
                {
                    int num = 0;
                    while (Char.IsDigit(c))
                    {
                        num=num*10+(c- '0');
                        i++;
                        if (i < exp.Length)
                        {
                            c = exp[i];
                        }
                        else
                            break;

                    }
                    i--;
                    operands.Push(num);
                }
                else if (isOperator(c))
                {
                    while(operation.Count != 0 && precedence(c)<=precedence(operation.Peek()))
                    {
                int output = performOperation(operands, operation);
                operands.Push(output);

                    }
            operation.Push(c);
                }
            }
    while(operation.Count != 0)
            {
                int output = performOperation(operands, operation);
                operands.Push(output);

            }
    return operation.Pop();

        }
        public static int precedence(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
            }
            return -1;
        }
        public static bool isOperator(char c)
        {
            return (c=='+' || c=='-' || c=='*' || c=='/' || c=='%');
        }
        public static int performOperation(Stack<int> operands,Stack<char> operations)
        {
            int a = operands.Pop();
            int b = operands.Pop();
            char operation=operations.Pop();
            switch(operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                    case '*':
                    return a * b;
                    case '/':
                    if(a==0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        return 0;
                    }
                    return b / a;

            }
            return 0;
        }
    }
}
