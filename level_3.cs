﻿namespace project_1;

public class level_3:level
{
    public void Add_Data(string name ,int id,string palace ,string faculty,int age)
    {
        File.AppendAllText("3.txt"," Name is : "+name+"\n "+"ID is : "+id+"\n "+"City : "+palace +"\n "+"Faculty : "+faculty+"\n "+"Age : "+age+"\n   ============================================== \n ");
            
    }
    public void Show_Data()
    {
        Console.WriteLine(File.ReadAllText("3.txt"));
    }
}