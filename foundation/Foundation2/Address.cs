using System;

public class Address{
    //Creating private variables for the class
    private string _streetName;
    private string _cityName;
    private string _state;
    private string _country;

    //method for getting the country and variables of the address class
    public  Address(string streetName, string cityName, string state, string country){
        this._streetName = streetName;
        this._cityName = cityName;
        this._state = state;
        this._country = country;
    }

    //Properties of the variable class
    public string streetName{get {return _streetName;}}
    public string cityName{get{return _cityName;}}
    public string state{get{return _state;}}
    public string country{get{return _country;}}
    //method for checking if address resides in the USA or not
    public string IsInUsa(){
        if(_country == "USA"){ 
            return $"Yes";
        }
        else{
            return "No";
        }       
    }

    public string DisplayAddress(){
        return $"Street name: {streetName} \n City Name: {cityName} \n State: {state} \n Country: {country}";
    }
}