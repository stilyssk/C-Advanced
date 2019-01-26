using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, float>> shopStoraheInformation = new Dictionary<string, Dictionary<string, float>>();
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString== "Revision")
                {
                    break;
                }
                else
                {
                    List<string> inputData = inputString
                        .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    string shopName = inputData[0];
                    string productName = inputData[1];
                    float price = float.Parse(inputData[2]);
                    if (!shopStoraheInformation.ContainsKey(shopName))
                    {
                        Dictionary<string, float> newProductData = new Dictionary<string, float>();
                        newProductData.Add(productName, price);
                        shopStoraheInformation.Add(shopName, newProductData);
                    }
                    else
                    {
                        Dictionary<string, float> existProductData = new Dictionary<string, float>();
                        existProductData = shopStoraheInformation[shopName];
                        if (existProductData.ContainsKey(productName))
                        {
                            existProductData[productName] = price;
                        }
                        else
                        {
                            existProductData.Add(productName, price);
                        }
                        shopStoraheInformation[shopName] = existProductData;
                    }


                }
            }
            shopStoraheInformation = shopStoraheInformation.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var shopNameInformation in shopStoraheInformation)
            {
                Console.WriteLine($"{shopNameInformation.Key}->");
                foreach (var shopData in shopNameInformation.Value)
                {
                    Console.WriteLine($"Product: {shopData.Key}, Price: {shopData.Value}");
                }
            }
        }
    }
}
