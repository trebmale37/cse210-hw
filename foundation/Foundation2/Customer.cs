using System;

public class Customer{
    //Creating a private variable for the class
    private Address _customerAddress;
    private string _customerName;
    
    public Customer(string customerName, Address customerAddress){
        this._customerName = customerName;
        this._customerAddress = customerAddress;
    }

    //Properties of the variable
    public string CustomerName{get {return _customerName;}}
    public Address CustomerAddress{get {return _customerAddress;}}


    //Method to check if customer is in USA
    public string GetAddress(){
        return CustomerAddress.IsInUsa();
    }

    //method for getting the shipping information
    public string ShippingInformation(){
        return $"Customer Name: {CustomerName} \nCustomer Address: \n {CustomerAddress.DisplayAddress()}";
    }
}