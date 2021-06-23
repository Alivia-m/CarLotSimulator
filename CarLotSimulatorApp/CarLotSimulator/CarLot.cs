using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
   public class CarLot
    {
        public static int numberOfCars = 0;
        public List<Car> CarLotInventory { set; get;  } = new List<Car>();
    }
}
