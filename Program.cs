using System;

class CafeBusiness
{
    public static decimal CalculateVAT(string productType, int price)
    {
        int vatRate;

        if (productType == "music")
        {
            vatRate = 6; 
        }
        else if (productType == "food")
        {
            vatRate = 12;
        }
        else if (productType == "alcohol")
        {
            vatRate = 26;
        }
        else
        {
            
            throw new ArgumentException("Invalid product type. Choose 'music', 'food', or 'alcohol'.");
        }

        
        decimal vatAmount = price + vatRate / 100m * price;
        

        return vatAmount;
    }

    
    static void Main()
    {
        decimal musicVAT = CalculateVAT("music", 100);
        Console.WriteLine("VAT for music: " + musicVAT);  

        decimal foodVAT = CalculateVAT("food", 200);
        Console.WriteLine("VAT for food: " + foodVAT);   

        decimal alcoholVAT = CalculateVAT("alcohol", 50);
        Console.WriteLine("VAT for alcohol: " + alcoholVAT);  
    }
}

