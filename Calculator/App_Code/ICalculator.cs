using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
[ServiceContract]
public interface ICalculator
{
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Addition/{firstvalue}{secondvalue}")]

    double Addition(double firstvalue, double secondvalue);

    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Subtraction/{firstvalue}{secondvalue}")]
    double Subtraction(double firstvalue, double secondvalue);

    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Multiplication/{firstvalue}{secondvalue}")]
    double Multiplication(double firstvalue, double secondvalue);

    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Division/{firstvalue}{secondvalue}")]
    double Division(double firstvalue, double secondvalue);

}
