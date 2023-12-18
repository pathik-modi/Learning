using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayPract;

  public enum ShippingMethod
  {
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
  } 
  class Program
  {
      static void Main(string[] args)
      {
        var method = ShippingMethod.Express;
        System.Console.WriteLine((int)method);
        var methodId = 3;
        System.Console.WriteLine((ShippingMethod)methodId);
      }
  }




