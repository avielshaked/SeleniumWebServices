using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Net;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using OpenQA.Selenium.Remote;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.IO;



namespace SeleniumAdvanced
{
    [TestFixture]
    class WeatherApiTests
    {
        private IWebDriver _webDriver;
        string BaseUrl = "http://api.openweathermap.org/data/2.5/weather?q=";


        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
        }


        [Test]
        public void TestCity1()
        {
            const string cityString = "London,uk";
            ApiResponse apiResponse = new ApiResponse();
            string expectedResult = apiResponse.GetResponse(cityString);
            Thread.Sleep(5000);
            Console.WriteLine("-------------------- Web Page Displayed ------------------");
            _webDriver.Navigate().GoToUrl(BaseUrl + cityString);
            IWebElement responseElement = _webDriver.FindElement(By.TagName("pre"));
            string displayedResponse = responseElement.Text;
            Console.WriteLine(displayedResponse);
            // Assert.IsTrue(expectedResult.Equals(displayedResponse));
        }
        [Test]
        public void TestCity2()
        {
            const string cityString = "Baltimore,usa";
            ApiResponse apiResponse = new ApiResponse();
            string expectedResult = apiResponse.GetResponse(cityString);
            Thread.Sleep(5000);
            Console.WriteLine("-------------------- Web Page Displayed ------------------");
            _webDriver.Navigate().GoToUrl(BaseUrl + cityString);
            IWebElement responseElement = _webDriver.FindElement(By.TagName("pre"));
            string displayedResponse = responseElement.Text;
            Console.WriteLine(displayedResponse);
            // Assert.IsTrue(expectedResult.Equals(displayedResponse));
        }


        [Test]
        [AspNetDevelopmentServer("nba", "http://localhost:62949/NBA.asmx")]
        public void TestWS()
        {

            WebRequest request = WebRequest.Create("http://localhost:62949/NBA.asmx");
            request.Method = "GET";
            WebResponse response = request.GetResponse();

            NbaService.NBASoapClient client = new NbaService.NBASoapClient();
            var list = client.GetPlayerData("PF");
            Assert.AreEqual(list.Count(), 2);
           
        }

        [Test]
        public void customerService()
        {
            WebRequest req = WebRequest.Create("http://localhost:62949/CustomersService.asmx");
            req.Method = "GET";
            WebResponse Response = req.GetResponse();

            accountsService.CustomersServiceSoapClient client = new accountsService.CustomersServiceSoapClient();
            accountsService.CustomerData cus = client.GetCustomerById(123456789);
        }

        [Test]
        public void TestWS2()
        {
            WebRequest request = WebRequest.Create("http://localhost:62949/NBA.asmx");
            request.Method = "GET";
            WebResponse response = request.GetResponse();

            NbaService.NBASoapClient client = new NbaService.NBASoapClient();
            var list = client.GetPlayerDatajson(1);

            var serializer = new JavaScriptSerializer();

            dynamic data = serializer.Deserialize<object>(list);
            List<playerData> data2 = (List<playerData>)serializer.Deserialize(list, typeof(List<playerData>));
        }


        [Test]
        public void MakeRequest()
        {
            try
            {
                HttpWebRequest request = WebRequest.Create("http://services.groupkt.com/country/get/iso2code/IN") as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).",
                        response.StatusCode,
                        response.StatusDescription));
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    Response jsonResponse
                    = objResponse as Response;

                    JsonSerializer ser = new JsonSerializer();
                    var res = response.GetResponseStream();

                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage respone1 = client.GetAsync("http://services.groupkt.com/country/get/iso2code/IN").Result;

                    if (respone1.IsSuccessStatusCode)
                    {
                        string strjson = respone1.Content.ReadAsStringAsync().Result.ToString();
                        string adsas = JsonConvert.SerializeObject(strjson);

                        RootObject root = new RootObject();
                        //root.RestResponse =  new JsonConvert.DeserializeObject<RootObject>(adsas);
                        //RootObject jObj = new JsonConvert.DeserializeObject<RootObject>(adsas);
                        root = JToken.Parse(strjson).ToObject<RootObject>();

                    }

                    dynamic stuff = JsonConvert.DeserializeObject("{ 'Name': 'Jon Smith', 'Address': { 'City': 'New York', 'State': 'NY' }, 'Age': 42 }");

                    //RestResponse r = new RestResponse();
                    //r.msg.Add("asdsdasdsad");
                    //r.msg.Add("dsadsad");
                    //r.result = new Result { name = "bbb", alpha2_code = "in", alpha3_code = "ind" };

                    //string sttt = JsonConvert.SerializeObject(r);

                    //RestResponse jObj2 = JsonConvert.DeserializeObject<RestResponse>(sttt);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }


        [Test]
        public void RestTest()
        {
            Uri uri = new Uri("http://services.groupkt.com/state/get/IND/all");
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();

            var outObject = JsonConvert.DeserializeObject<RootObject>(responseData);


        }

        public class Currency
        {
            public string code { get; set; }
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Language
        {
            public string iso639_1 { get; set; }
            public string iso639_2 { get; set; }
            public string name { get; set; }
            public string nativeName { get; set; }
        }

        public class Translations
        {
            public string de { get; set; }
            public string es { get; set; }
            public string fr { get; set; }
            public string ja { get; set; }
            public string it { get; set; }
            public string br { get; set; }
            public string pt { get; set; }
        }

        public class RootObject1
        {
            public string name { get; set; }
            public List<string> topLevelDomain { get; set; }
            public string alpha2Code { get; set; }
            public string alpha3Code { get; set; }
            public List<string> callingCodes { get; set; }
            public string capital { get; set; }
            public List<string> altSpellings { get; set; }
            public string region { get; set; }
            public string subregion { get; set; }
            public int population { get; set; }
            public List<double> latlng { get; set; }
            public string demonym { get; set; }
            public double area { get; set; }
            public double gini { get; set; }
            public List<string> timezones { get; set; }
            public List<string> borders { get; set; }
            public string nativeName { get; set; }
            public string numericCode { get; set; }
            public List<Currency> currencies { get; set; }
            public List<Language> languages { get; set; }
            public Translations translations { get; set; }
            public string flag { get; set; }
            public List<object> regionalBlocs { get; set; }
        }



        public class Result
        {
            public string country { get; set; }
            public string name { get; set; }
            public string abbr { get; set; }
            public string area { get; set; }
            public string largest_city { get; set; }
            public string capital { get; set; }
        }

        public class RestResponse
        {
            public List<string> messages { get; set; }
            public List<Result> result { get; set; }
        }

        public class RootObject
        {
            public RestResponse RestResponse { get; set; }
        }


        public class playerData
        {
            public int playerid { get; set; }
            public string name { get; set; }
            public string position { get; set; }
            public int teamid { get; set; }
        }


        public class Employee
        {
            public string name;
            public int age;
        }


        [TearDown]
        public void Teardown()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }
    }
}
