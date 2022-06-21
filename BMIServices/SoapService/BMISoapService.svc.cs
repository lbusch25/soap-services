using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IBMISoapService
    {
        public double myBMI(int height, int weight)
        {
            return calculateBMI(height, weight);
        }

        public BMI myHealth(int height, int weight)
        {
            BMI bMI = new BMI();
            bMI.Bmi = calculateBMI(height, weight);
            bMI.Risk = calculateRisk(bMI.Bmi);
            return bMI;
        }

        private double calculateBMI(int height, int weight)
        {
            return ((double) weight / ((double) height * (double) height)) * 703;
        }

        private string calculateRisk(double bmi)
        {
            if (bmi < 18)
            {
                return "You are underweight - Blue Color ";
            } else if (bmi >= 18 && bmi < 25)
            {
                return "Your weight is normal - Green Color";
            } else if (bmi >= 25 && bmi <= 30)
            {
                return "You are pre-obese – Purple Color";
            }
            return "You are obese - Red Color";
        }
    }
}
