using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic.Model
{
    public class FuelMotorBike : MotorBike
    {
        public override void InitalizeEngine(float i_CurrentFuel)
        {
            Engine engine=new FuelEngine(FuelType, i_CurrentFuel,
        }
    }
}
