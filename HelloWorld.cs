using System; 
using RestSharp;

/**
 * dnu install X
 * dnu restore
 * dnx run
 * 
 */

public class Program { 
	public static void Main(string[] args) { 
		Console.WriteLine("Hello Phil, you are awesome!"); 
		
		Console.WriteLine(FetchFeed("http://philwilson.org", "blog/feed/atom"));
	}
	
	private static string FetchFeed(string domain, string resource) {
		var client = new RestClient(domain);
		var request = new RestRequest(resource);
		IRestResponse response = client.Execute(request);
		return response.Content;		
	}
} 