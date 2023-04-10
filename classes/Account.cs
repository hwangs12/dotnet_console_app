using System;

class Account
{
    public double balance { get; set; }
    public string name { get; set; } = "kellogg";
    public string address { get; set; } = "24 Cleanwater Drive";
    public List<double>? listings { get; set; }

    public void printBalance()
    {
        Console.WriteLine("The account balance is " + this.balance);
    }
}
