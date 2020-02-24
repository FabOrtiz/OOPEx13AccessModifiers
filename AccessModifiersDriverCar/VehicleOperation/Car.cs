using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOperation
{
    internal class Car
    {

        //Deteils on the operation of a car
        //Lets abstract or hide away these details from another classes
        #region [Private Methods]

        private void InjectedFuel()
        {

        }

        private void Ignition()
        {

        }

        private void IncreaseAirIntake()
        {

        }

        private void DecreaseAirIntake()
        {

        }

        private void IncreaseFuelIntake()
        {

        }

        private void DecreaseFuelIntake()
        {

        }

        private void IncreaseBrakelinePressure()
        {

        }

        private void DecreaseBrakelinePressure()
        {

        }


        #endregion

        #region [Public Methods]

        public void StartEngine()
        {
            this.InjectedFuel();
            this.IncreaseAirIntake();
            this.Ignition();
        }

        public void SpeedUp()
        {
            this.IncreaseAirIntake();
            this.IncreaseFuelIntake();
        }

        public void SlowDown()
        {
            this.DecreaseAirIntake();
            this.DecreaseFuelIntake();
        }

        public void ApplyBrake()
        {
            SlowDown();
            this.IncreaseBrakelinePressure();
        }

        public void Stop()
        {
            ApplyBrake();
            HoldBrake();
        }

        public void HoldBrake()
        {

        }

        #endregion
    }
}
