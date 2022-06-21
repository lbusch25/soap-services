﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface ISoapService
    {

        [OperationContract]
        double myBMI(int height, int weight);

        [OperationContract]
        BMI myHealth(int height, int weight);

        // TODO: Add your service operations here
    }
}
