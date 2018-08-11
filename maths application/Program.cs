using System;

namespace maths_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program is for a calculator where it can either add,subtract,mutiply or divide");
            Console.WriteLine("please ennter your first number");

            double firstnumb = double.Parse(Console.ReadLine());

            Console.WriteLine("please enter your second number");

            double secondnumb = double.Parse(Console.ReadLine());

            Console.Write("Please enter math operators add,subtraction,multiply,divide");

            string mathoperation = Console.ReadLine();


            //for a do while loop we will set boolean to false

            bool Alltotals = false;
            do while loop

            do
            {

                if (mathoperation == "add")
                {
                    double solution = Addnumbers(firstnumb, secondnumb);
                    Console.Write("Solution is:" + solution);
                    finishedcalculations = true;


                }
                else if (mathoperation == "subtract")
                {
                    double solution = subtractnumbers(firstnumb, secondnumb);
                    Console.Write("Solution is:" + solution);
                    finishedcalculations = true;

                }
                else if (mathoperation == "divide")
                {
                    double solution = dividenumbers(firstnumb, secondnumb);
                    Console.Write("Solution is:" + solution);
                    finishedcalculations = true;
                }
                else if (mathoperation == "multiply")
                {
                    double solution = multiplynumbers(firstnumb, secondnumb);
                    Console.Write("Solution is:" + solution);
                    finishedcalculations = true;
                }
                else
                {
                    Console.WriteLine("please enter a valid opration");
                    mathoperation = Console.ReadLine();
                }
            } while (finishedcalcutions == false));
                    Console.ReadLine();

            /// <remarks
            /// <param name="addfirst">first number</param>
            /// <param name="addsecond">second number</param>
            ///<returns>total</returns>
            
            
           


        }
        private static double Addnumbers(double addfirst, double addsecond)

        {
            double methodsolution = addfirst + addsecond;
            return methodsolution;


        }
        /// <remarks
        /// <param name="subfirst">first number</param>
        /// <param name="subsecond">second number</param>
        ///<returns>total</returns>
        ///

        private static double subtractnumbers(double subfirst, double subsecond)
        {
            double methodsolution = subfirst - subsecond;
            return methodsolution;
        }

        /// <remarks
        /// <param name="multiplyfirst">first number</param>
        /// <param name="multiplysecond">second number</param>
        ///<returns>product</returns>


        private static double multiplynumbers(double multifirst, double multisecond)
        {
            double methodsolution = multifirst * multisecond;
            return methodsolution;
        }


        /// <remarks
        /// <param name="dividefirst">first number</param>
        /// <param name="dividesecond">second number</param>
        ///<returns>quotient</returns>
        private static double dividenumbers(double divifirst, double divisecond)
        {
            double methodsolution = divifirst / divisecond;
            return methodsolution; 
        









