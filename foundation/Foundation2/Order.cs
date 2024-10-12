using System;

public class Order{
    //Declaring variables for the class order
    private Customer _customers;
    private List<Product> _products;

    //methods for getting the list of the customer
    public Order(Customer customer){
        this._customers = customer;
        _products = new List<Product>();
    }

    //Properties for the variables
    public Customer Customer{get {return _customers;}}
    public List<Product> Product{get {return _products;}}

    //Method for getting the list of the product
    public void ProductList(Product product){
        Product.Add(product);
    }

    //Method for calculating the total cost adding the shipping cost too if the 
    //customer is an american
    public double ShippingFee(string IsInUSA){
        if(IsInUSA == "USA"){
            return 15;
        }
        else{
            return 35;
        }
    }

    //Method to calculate the total price 
    public double TotalPrice(double Shipping){
        double totalCost = 0;
        
        foreach(var product in Product){
            totalCost = totalCost + product.Cost()  + Shipping;
        }
        return totalCost;
    }

    //method for Listing the name of product and product id
    public string GetPackingLable(){
        string packingLabel = " ";
        foreach(var product in Product){
            packingLabel = packingLabel + product.PackingLabelInformation();
        }
        return packingLabel;
    }

    //Method for Returning the shipping information of the customer
    public string GetShippingInformation(string shippingInformation){
        return shippingInformation;
    }
}