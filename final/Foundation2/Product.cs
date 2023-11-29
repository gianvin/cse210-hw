using System;
using System.Collections.Generic;

class Product
{
  //Fields
 private string _name;
 private int _productId;
 private decimal _price;
 private int _quantity;

public string fileName
{
    get {return _name;}
    set { _name = value;}
}
public int ProductId
{
    get { return _productId;}
    set { _productId = value;}
}
public decimal Price
{
    get { return _price;}
    set {_price = value;}
}
public int Quantity
{
    get {return _quantity;}
    set {_quantity = value;}
}
  public decimal CalculateTotalPrice()
  {
    return _price * _quantity;
  }

}