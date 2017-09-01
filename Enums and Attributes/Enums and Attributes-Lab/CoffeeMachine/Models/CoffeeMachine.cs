using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private int money;
    private IList<CoffeeType> coffeeSold;

    public IEnumerable<CoffeeType> CoffeesSold
    {
        get { return this.coffeeSold; }
    }

    public CoffeeMachine()
    {
        this.coffeeSold = new List<CoffeeType>();
    }

    public void InsertCoin(string coin)
    {
        Coin moneyToAdd = (Coin)Enum.Parse(typeof(Coin), coin);

        this.money += (int)moneyToAdd;
    }

    public void BuyCoffee(string size, string type)
    {
        CoffeePrice coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
        CoffeeType coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

        if (this.money >= (int)coffeePrice)
        {
            this.coffeeSold.Add(coffeeType);

            this.money = 0;
        }
    }
}

