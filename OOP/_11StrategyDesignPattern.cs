using System;
using System.Collections.Generic;
/*
 #it is --ager codebase ami change na kre notun feature add krbo.like PushNodify add krsi without changing any previous codebase
👉 It is a behavioral design pattern.it allows you to -Define multiple algorithms/behaviors separately and switch between them at runtime.
👉 "Switching at runtime" means the program can dynamically change its behavior or algorithm during execution without modifying existing code.
*/
public interface INotify //got SRP violate
{
    public void Send();
    public void Log();
    public void Save();
}
public class EmailNotify : INotify
{
    public string Email { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending email to " + Email);
    }
    public void Log()
    {
        Console.WriteLine("Logging email to " + Email);
    }
    public void Save()
    {
        Console.WriteLine("Saving db to " + Email);
    }
}
public class SMSNotify : INotify
{
    public string Phone { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending SMS to " + Phone);
    }
    public void Log()
    {
        Console.WriteLine("Logging SMS to " + Phone);
    }
    public void Save()
    {
        Console.WriteLine("Saving db to " + Phone);
    }
}
public class PushNodify : INotify
{
    public string Token { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending Token to " + Token);
    }
    public void Log()
    {
        Console.WriteLine("Logging Token to " + Token);
    }
    //got ISP violate
    public void Save() { } //dont need to implement it here but u need to write it this way as it is included in interface otherwise it get error..its called Interface Segregation problem.
}
//kokhn kon funtion call krte hbe..then sob ek shthe call krbo nki alada alada..ei bishoy hide krte hbe developer theke.
//.jdi ei process change krte hy tahole just eikhne eshe change krbo without anything change in coding.
public class NodifyContext
{
    public INotify nodify { get; set; }
    public NodifyContext(INotify nodify)
    {
        this.nodify = nodify;
    }
    public void Process()
    {
        nodify.Send();
        nodify.Log();
        nodify.Save();
    }
}
public class Program
{
    static void Main()
    {
        //Method-1
        // INotify emailNotify = new EmailNotify { Email = "riyad@gmail.com" };
        // emailNotify.Send();
        // INotify smsNotify = new SMSNotify { Phone = "01783472892" };
        // smsNotify.Send();

        //Method-2
        // IList<INotify> notifies = new List<INotify> //Interface e list tai IList hyse
        // {
        //     new EmailNotify { Email = "riyad@gmail.com" }, //EmailNotify k ei list e rakhlam
        //     new SMSNotify { Phone = "01783472892" } //SMSNotify k ei list e rakhlam
        // };

        // //list er sob elem er funtion gula call krlm
        // foreach (var nodify in notifies) //developer dekhte pacche kokhn ki call hocce
        // {
        //     nodify.Send();
        //     nodify.Log();
        //     nodify.Save();

        // }

        //method-3 hiding from developer and just change in NodifyContext if needed

        INotify emailNotify = new EmailNotify
        {
            Email = "riyad@gmail.com"
        };
        INotify sMSNotify = new SMSNotify
        {
            Phone = "01783472892"
        };
        INotify pushNotify = new PushNodify
        {
            Token = "974gdj1232vax45"
        };

        NodifyContext emailNodifyContext = new NodifyContext(emailNotify);
        NodifyContext smsNodifyContext = new NodifyContext(sMSNotify);
        NodifyContext PushNodifyContext = new NodifyContext(pushNotify);

        // IList<NodifyContext> notifyContexts = new List<NodifyContext>();
        // notifyContexts.Add(emailNodifyContext);
        // notifyContexts.Add(smsNodifyContext);

        IList<NodifyContext> notifyContexts = new List<NodifyContext>
        {
            emailNodifyContext,
            smsNodifyContext,
            PushNodifyContext

        };


        foreach (NodifyContext nodifyContext in notifyContexts)
        {
            nodifyContext.Process();
        }



    }
}