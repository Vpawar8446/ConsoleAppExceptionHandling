using System;

namespace ConsoleAppExceptionHandling
{
    class ArrayOutOfIndex
    {
        public void Divide()
        {
            int x, y, z=0;
            Console.WriteLine("Enter two numbers ");
            

            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;

            }
            
            catch(DivideByZeroException dze)
            {
                Console.WriteLine(" Can not divide by zero");
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Please check the value and try aging");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(z);
            }
        }
        /*public void CalculateSum()
        {
            int i;
            int sum = 0;
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                for(i=1;i<=5;i++)
                {
                    sum += number[i];
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please check the iteration of the list");
            }
            finally
            {
                Console.WriteLine("Total : {0} " , sum);
            }
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Handling System Exception");
            ArrayOutOfIndex obj = new ArrayOutOfIndex();
            //obj.CalculateSum();
            obj.Divide();
        }
    }
}
