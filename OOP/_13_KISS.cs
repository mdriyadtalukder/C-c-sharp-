using System;
//keep it simple, stupid.
public class PricePercentage
{
    public double price { get; set; }
    public double discountPercentage { get; set; }
    public double taxPercentage { get; set; }
    public double CalculateDiscount()
    {
        double discount = price * discountPercentage / 100;
        return discount;
    }
    public double CalculateTax()
    {
        double tax = price * taxPercentage / 100;
        return tax;
    }
    public double Calculate()
    {
        //Not KISS
        // double discount = price * discountPercentage / 100;
        // double tax = price * taxPercentage / 100;
        // return price - discount + tax;

        //KISS
        double discount = CalculateDiscount();
        double tax = CalculateTax();
        return price - discount + tax;
    }
}
public class Program
{
    public static void Main()
    {

    }
}