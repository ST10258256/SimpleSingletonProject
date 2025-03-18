using System;
using System.ComponentModel.DataAnnotations;

public sealed class ConfigurationManager
{
    private static ConfigurationManager? instance = null;
    private static readonly object lockObject = new object();


    private string StoreName;
    private string Currency;
    private double VAT;

    private ConfigurationManager()
    {
        Console.WriteLine("Singleton was created");
        StoreName = "Gadget Galaxy";
        Currency = "ZAR";
        VAT = 15;
        DisplayValues();
    }

    public static ConfigurationManager Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }
    }

    public void DisplayValues(){
        Console.WriteLine($"Store Name:\t{StoreName}\nCurrency:\t{Currency}\nVAT:\t\t{VAT}");
    }

    public void UpdateTaxRate(double newRate)
    {
        VAT = newRate;
        System.Console.WriteLine("VAT value has been changed");
    }
}
