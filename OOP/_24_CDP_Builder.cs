using System;
using System.Collections.Generic;
/*
#Builder Pattern is a creational design pattern used to construct a complex object step by step.
.Instead of creating an object in one go with a large constructor, 
the Builder Pattern lets you build it gradually by setting different parts one at a time.
Builder Pattern is used when:

an object has many fields
construction is complex
you want to build the object step by step
you want clean and readable object creation

*/

// ================= PRODUCT =================
public class HttpRequest
{
    public string Method;
    public string Uri;
    public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();
    public string Body;

    // Large constructor (hard to manage)
    // public HttpRequest(
    //     string method,
    //     string uri,
    //     Dictionary<string, string> headers,
    //     string body)
    // {
    //     Method = method;
    //     Uri = uri;
    //     Headers = headers;
    //     Body = body;
    // }

    public void Send()
    {
        Console.WriteLine("Sending request...");
        Console.WriteLine("Method: " + Method);
        Console.WriteLine("Uri: " + Uri);

        Console.WriteLine("Headers:");
        foreach (var h in Headers)
        {
            Console.WriteLine($"{h.Key}: {h.Value}");
        }

        Console.WriteLine("Body: " + Body);
    }
}
public class HttpRequestBuilder
{
    private HttpRequest request = new HttpRequest();

    public HttpRequestBuilder SetMethod(string method)
    {
        request.Method = method;
        return this;
    }

    public HttpRequestBuilder SetUri(string uri)
    {
        request.Uri = uri;
        return this;
    }

    public HttpRequestBuilder AddHeader(string key, string value)
    {
        request.Headers.Add(key, value);
        return this;
    }

    public HttpRequestBuilder SetBody(string body)
    {
        request.Body = body;
        return this;
    }

    public HttpRequest Build()
    {
        return request;
    }
}
class Program
{
    static void Main(string[] args)
    {
        HttpRequest request = new HttpRequestBuilder()
            .SetMethod("POST")
            .SetUri("https://api.example.com/login")
            .AddHeader("Content-Type", "application/json")
            .AddHeader("Authorization", "Bearer token123")
            .SetBody("{ \"user\": \"admin\" }")
            .Build();

        request.Send();
    }
}