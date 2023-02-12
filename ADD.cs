namespace project_1;

public class ADD
{
    public void add_Data()
    {
        Console.WriteLine("1-Add student data from level 1\n2-Add student data from level 2\n3-Add student data from level 3\n4-Add student data from level 4");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter name of student");
        string name = Console.ReadLine();
        Console.WriteLine("Enter ID of student");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter age of student");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Faculty of student");
        string faculty = Console.ReadLine();
        Console.WriteLine("Enter City of student");
        string pa =Console.ReadLine();
        if (x == 1)
        {
            level_1 l = new level_1();
            l.Add_Data(name,id,pa,faculty,age);
            Console.WriteLine("Done");
        }else if (x == 2)
        {
            level_2 l = new level_2();
            l.Add_Data(name,id,pa,faculty,age);
            Console.WriteLine("Done");
        }else if (x == 3)
        {
            level_3 l = new level_3();
            l.Add_Data(name,id,pa,faculty,age);
            Console.WriteLine("Done");
        }
        else if (x==4)
        {
            level_4 l = new level_4();
            l.Add_Data(name,id,pa,faculty,age);
            Console.WriteLine("Done");
        }
        else
        {
            Console.WriteLine("Wrong choice try again");
        }
    }
}