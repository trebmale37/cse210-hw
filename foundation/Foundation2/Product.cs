using System;
using System.Dynamic;
public class Product{
    //Creating a private variable fro the class list
    private string _productName;
    private string _productId;
    private double _productPrice;
    private double _quantityOfProduct;

    public Product(string ProductName, string ProductId, double ProductPrice, double Quantity){
        this._productName = ProductName;
        this._productId = ProductId;
        this._productPrice = ProductPrice;
        this._quantityOfProduct = Quantity;
    }

    //Properties for getting the values of the variables
    public string ProductName{get {return _productName;}}
    public string ProductId{get {return _productId;}}
    public double ProductPrice{get {return _productPrice;}}
    public double QuantityOfProduct{get {return _quantityOfProduct;}}
    //creating a method to calculating the total cost of the quantity
    public double Cost(){
        return ProductPrice * QuantityOfProduct;
    }

    public string PackingLabelInformation(){
        return $"Product Name: {ProductName} Product ID: {ProductId}\n";
    }
}