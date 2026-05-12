using System;
//“A thread is the smallest execution unit of a process that allows multiple tasks to run concurrently within a program.”
class Database
{
    // static object
    private static Database instance;
    public static readonly object _lock = new object();

    // private constructor
    private Database()
    {
        Console.WriteLine("Database object created");
    }

    // static method
    public static Database GetInstance()
    {
        // if (instance == null)
        // {
        //     instance = new Database();
        // }

        // return instance;

        //multiple thread ashleo ekbr print hbe
        if (instance == null)
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new Database();
                }
            }
        }
        return instance;

    }
}

class Program
{
    static void Main(string[] args)
    {
        // Database d1 = Database.GetInstance();

        // Database d2 = Database.GetInstance();

        // Console.WriteLine(d1 == d2);
        Thread thread = new Thread(() =>
        {
            Database log = Database.GetInstance();
        });
        Thread thread2 = new Thread(() =>
        {
            Database log2 = Database.GetInstance();
        });
        thread.Start();
        thread2.Start();//2 ta thread e ek sthe jabe and ek sthe sob line e dukbe Database er..2 tai instance == null dekhabe and obj create krbe.. tai 2 bar created print hbe

        thread.Join();
        thread2.Join();
    }
}