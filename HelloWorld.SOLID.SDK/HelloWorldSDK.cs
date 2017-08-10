using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.SOLID.Objects;
using RestSharp;

namespace HelloWorld.SOLID.SDK
{
	/// <summary>
	/// This SDK would normally be put into a nuget package to be easily shared/updated
	/// so that the dependent clients could have easy assess to our API with strongly typed objects
	/// and methods.
	/// </summary>
    public class HelloWorldSDK
    {
		/// <summary>
		/// Get a single instance of a message from our api
		/// </summary>
		/// <returns></returns>
	    public Message GetAMessage()
	    {
			var client = new RestClient();
		    
		    var baseURL = SimpleAppSettingHelper.CurrentAppSettings.Get("BaseApiUrl");
		    client.BaseUrl = new System.Uri(baseURL);

		    var request = new RestRequest("messages", Method.GET);
		    request.RequestFormat = DataFormat.Json;
		    var response = client.Execute<Message>(request);
		    if (response.StatusCode != HttpStatusCode.OK)
		    {
			    throw new Exception(response.ErrorMessage);
		    }
		    return response.Data;
	    }
    }

	
}
