namespace project_1
{
    class Program
    {
        static void Main()
        {
            string ss;
            do
            {
                Console.WriteLine("******* Welcame to ALMADBWLY Console App ********");
                Console.WriteLine("1-Add student data\n2-Show student data\nEnter your choice");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (x == 1)
                {
                    ADD a = new ADD();
                    a.add_Data();
                }
                else if (x == 2)
                {
                    show s = new show();
                    s.show_data();
                }
                else
                {
                    Console.WriteLine("Wrong choice try again");
                }

                Console.WriteLine("you want to make add or show\nEnter yes ");
                ss = Console.ReadLine();
                Console.Clear();

            } while (ss == "yes");
        }
    }
}