class Program
{
    static void Main()
    {
        ConfigurationManager s1 = ConfigurationManager.Instance;
        ConfigurationManager s2 = ConfigurationManager.Instance;
        
        s1.DisplayValues();

        System.Console.WriteLine("\n\n\n");

        s1.UpdateTaxRate(18);

        System.Console.WriteLine("Same? " + (s1 == s2));

        System.Console.WriteLine("\n\n\n");

        s1.DisplayValues();
        s2.DisplayValues();

        System.Console.WriteLine("Same? " + (s1 == s2));

        
    }
}

