using System;

class Account
{

    public double id { get; set; }
    public double balance { get; set; }
    public string name { get; set; } = "kellogg";
    public string address { get; set; } = "24 Cleanwater Drive";
    public List<double> transactions { get; set; } = new List<double>() { };
    public List<double> listings { get; set; } = new List<double>() { };
    private string? signature { get; set; }

    public Account(double id, double balance, string name, string address)
    {
        this.id = id;
        this.balance = balance;
        this.name = name;
        this.address = address;
        this.signature = "id::" + id + " balance::" + balance + " name::" + name + " address::" + address;
    }

    public void sendFunds(double value)
    {
        this.balance -= value;
        this.transactions.Append(-value);
    }

    public void receiveFunds(double value)
    {
        this.balance += value;
        this.transactions.Append(value);
    }

    public void getSignature()
    {
        Console.WriteLine("This is the client's signature:::" + this.signature);
    }
}
