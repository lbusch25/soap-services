using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRestService
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/myBMI?height={height}&weight={weight}")]
        double myBMI(int height, int weight);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/myHealth?height={height}&weight={weight}")]
        BMI myHealth(int height, int weight);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class BMI
    {
        double bmi = 0;
        string risk = "";
        string[] more = new string[3] { "https://www.cdc.gov/healthyweight/assessing/bmi/index.html" ,
        "https://www.nhlbi.nih.gov/health/educational/lose_wt/index.htm", "https://www.ucsfhealth.org/education/body_mass_index_tool/"};

        [DataMember]
        public double Bmi
        {
            get { return bmi; }
            set { bmi = value; }
        }
        [DataMember]
        public string Risk
        {
            get { return risk; }
            set { risk = value; }
        }

        [DataMember]
        public string[] More
        {
            get { return more; }
        }
    }
}
