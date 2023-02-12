namespace project_1;

public class show
{
    public void show_data()
    {
        Console.WriteLine("1-Show student data from level 1\n2-Show student data from level 2\n3-Show student data from level 3\n4-Show student data from level 4");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (x == 1)
        {
            level_1 l = new level_1();
          l.Show_Data();
        }else if (x == 2)
        {
            level_2 l = new level_2();
            l.Show_Data();
        }else if (x == 3)
        {
            level_3 l = new level_3();
            l.Show_Data();
        }
        else if (x==4)
        {
            level_4 l = new level_4();
            l.Show_Data();
        }
        else
        {
            Console.WriteLine("Wrong choice try again");
        }
    }
}