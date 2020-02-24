using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOperation
{
    public class Driver
    {
        public void OperateCar()
        {
            Car car = new Car();

            GetKeysOutOfPocket();
            OpenDoor();
            SitDown();

            car.StartEngine();
            car.SpeedUp();
            car.ApplyBrake();
            car.HoldBrake();
        }

        private void OpenDoor() { }
        private void SitDown() { }
        private void GetKeysOutOfPocket() { }
    }
}
