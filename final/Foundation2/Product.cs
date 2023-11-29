using System;
using System.Collections.Generic;

class Product
{
  //Fields
  private string Name {get; set;}
  private int ProductId {get; set;}
  private decimal Price {get; set;}
  private int Quantity {get; set;}

  public decimal CalculateTotalPrice()
  {
    return Price * Quantity;
  }

}