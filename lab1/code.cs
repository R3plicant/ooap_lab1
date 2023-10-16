abstract public class AProduct
{
    public int quantity;
   
    public bool consume(int num)
    {
        if(quantity > num)
        {
            quantity -= num;
            return true
        } else if {
            return false;
        }
    }
};
public  class PerishableProduct : AProduct
{
    public string expiration_date;

}
public class CoffeeProduct : PerishableProduct
 {
    public string region;
    public string roasting_date;
}
public class Product : AProduct
{
    public string manufacture_date;
}

public class Roaster
{
    public CoffeeProduct roast_coffee(PerishableProduct green_coffee, int num)
    {
        private int roasting_amount;

        if((num <= roasting_amount) && green_coffee.consume(num))
        {
            CoffeeProduct roasted_coffee();
            return roasted_coffee;
        }   
        else {return false;}
    }
}
public class Goods
{
    public int number_ready;
    public int price;
    private AProduct[] consumable_products;

    public int produce(int num)
    {
        int produced;
        for (int produced = 0; produced < num; i++)
        {
            produced += consumable_products.consume();
        }
        
        return produced;
    }

    public bool consume(int num)
    {
        if(number_ready > num)
        {
            number_ready -= num;
            return true;
        } else if {
            return false;
        }
    }
}

public class Catalogue
{
    private Goods[] goods;
    
    public bool sell(int num)
    {
        if()
        {
            goods.consume();
        } else {
            goods.produce();
        }
    }
}

public class Order
{
    public string client_name;
    public string invoice;
    public int invoice_price;

    public bool pay(){}

}

public class CoffeeShop
{
    private Catalogue catalogue;
    private Order[] orders;

    public Order CreateOrder()
    {
        private Order order;
        
        return order;
    }
}