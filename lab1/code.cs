public class Product
{
    public string name;
    public int quantli;

}

public  class PerishableProduct : Product
{
    public string expiration_date;

}
public class CoffeeProduct :PerishableProduct {
public string region;
public string roasting_date;
}
public class Products : Product
{
    public string manufacture date;
}

public class Goods
{
    public string name;
    public int number_ready;
    public int price;
    public int produce();
}

public class Catalogue
{

}

public class Order
{
    public string client_name;
    public int invoice_price;

}
