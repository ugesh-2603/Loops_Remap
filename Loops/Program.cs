namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool execute = true;
            while (execute)
            {
                Console.WriteLine("Please Choose any one program from below option");
                Console.WriteLine("1.Two_Integers \n2.ODD_Even \n3.Age \n4. Largest_of_three_numbers \n5. Eligibility \n6. AreaofCircle \n7. Date_and_Time \n8. StopWatch \n9. Range_of_Numbers \n10. Person_Name  \n11.Print_1_to_100 \n12.Number_to_String \n13.Present_Absent \n14.Shifting_the_number \n15.Quadratic EQuation \n16.Factorial \n17. Reapted_Element \n18.Array_PrimeNumber \n19.SubString \n20.EXIT");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        if_else1 i = new if_else1();
                        Console.WriteLine();
                        break;

                    case 2:

                        if_else_even_odd2 E_O = new if_else_even_odd2();
                        Console.WriteLine();
                        break;

                    case 3:

                        if_else_Age3 A = new if_else_Age3();
                        Console.WriteLine();
                        break;

                    case 4:

                        if_else4Largestofthreenumbers LON = new if_else4Largestofthreenumbers();
                        Console.WriteLine();
                        break;

                    case 5:

                        if_else5Eligibility E = new if_else5Eligibility();
                        Console.WriteLine();
                        break;

                    case 6:

                        SwitchWeekday switchWeekday = new SwitchWeekday();
                        Console.WriteLine();
                        break;

                    case 7:

                        Switch2Arithimetic_Operations 













    {
                        }
            



                




            }
        }
    }
}