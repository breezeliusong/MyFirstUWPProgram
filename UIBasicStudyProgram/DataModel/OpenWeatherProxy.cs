using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace UIBasicStudyProgram.DataModel
{
    class OpenWeatherProxy
    {
        public async static Task<RootObject> GetWeather(string city)
        {
            var http = new HttpClient();
            string ss = string.Format("http://wthrcdn.etouch.cn/weather_mini?city={0}", city);
            var response = await http.GetAsync(new Uri(ss));
            var result = await response.Content.ReadAsStringAsync();
            var testresult = result.ToString();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;


            //    //var http = new HttpClient();
            //    //var response = await http.GetAsync("http://api.openweathermap.org/data/2.5/weather?lat=32.77&lon=-96.79&units=imperial");
            //    var result = await response.Content.ReadAsStringAsync();
            //    var serializer = new DataContractJsonSerializer(typeof(RootObject));
            //    //List<Forecast> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RootObject>>(result);
            //    var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //    var data = (RootObject)serializer.ReadObject(ms);

            //    return data;
        }
        //public async static Task<RootObject> GetWeather()
        //{
        //    var http = new HttpClient();
        //    var response = await http.GetAsync(new Uri("https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22nome%2C%20ak%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys"));
        //    var result = await response.Content.ReadAsStringAsync();
        //    var serializer = new DataContractJsonSerializer(typeof(RootObject));
        //    var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
        //    var data = (RootObject)serializer.ReadObject(ms);
        //    return data;
        //}
    }
    [DataContract]
    public class Forecast
    {
        [DataMember]
        public string fengxiang { get; set; }
        [DataMember]
        public string fengli { get; set; }
        [DataMember]
        public string high { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string low { get; set; }
        [DataMember]
        public string date { get; set; }
    }
    [DataContract]
    public class Yesterday
    {
        [DataMember]
        public string fl { get; set; }
        [DataMember]
        public string fx { get; set; }
        [DataMember]
        public string high { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string low { get; set; }
        [DataMember]
        public string date { get; set; }
    }

    [DataContract]
    public class Data
    {
        [DataMember]
        public string wendu { get; set; }
        [DataMember]
        public string ganmao { get; set; }
        [DataMember]
        public List<Forecast> forecast { get; set; }
        [DataMember]
        public Yesterday yesterday { get; set; }
        [DataMember]
        public string aqi { get; set; }
        [DataMember]
        public string city { get; set; }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public string desc { get; set; }
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public Data data { get; set; }
    }




    //[DataContract]
    //public class Units
    //{
    //    public string distance { get; set; }
    //    public string pressure { get; set; }
    //    public string speed { get; set; }
    //    public string temperature { get; set; }
    //}
    //[DataContract]
    //public class Location
    //{
    //    public string city { get; set; }
    //    public string country { get; set; }
    //    public string region { get; set; }
    //}
    //[DataContract]
    //public class Wind
    //{
    //    public string chill { get; set; }
    //    public string direction { get; set; }
    //    public string speed { get; set; }
    //}
    //[DataContract]
    //public class Atmosphere
    //{
    //    public string humidity { get; set; }
    //    public string pressure { get; set; }
    //    public string rising { get; set; }
    //    public string visibility { get; set; }
    //}
    //[DataContract]
    //public class Astronomy
    //{
    //    public string sunrise { get; set; }
    //    public string sunset { get; set; }
    //}
    //[DataContract]
    //public class Image
    //{
    //    public string title { get; set; }
    //    public string width { get; set; }
    //    public string height { get; set; }
    //    public string link { get; set; }
    //    public string url { get; set; }
    //}
    //[DataContract]
    //public class Condition
    //{
    //    public string code { get; set; }
    //    public string date { get; set; }
    //    public string temp { get; set; }
    //    public string text { get; set; }
    //}
    //[DataContract]
    //public class Forecast
    //{
    //    public string code { get; set; }
    //    public string date { get; set; }
    //    public string day { get; set; }
    //    public string high { get; set; }
    //    public string low { get; set; }
    //    public string text { get; set; }
    //}
    //[DataContract]
    //public class Guid
    //{
    //    public string isPermaLink { get; set; }
    //}
    //[DataContract]
    //public class Item
    //{
    //    public string title { get; set; }
    //    public string lat { get; set; }
    //    public string @long { get; set; }
    //    public string link { get; set; }
    //    public string pubDate { get; set; }
    //    public Condition condition { get; set; }
    //    public List<Forecast> forecast { get; set; }
    //    public string description { get; set; }
    //    public Guid guid { get; set; }
    //}
    //[DataContract]
    //public class Channel
    //{
    //    public Units units { get; set; }
    //    public string title { get; set; }
    //    public string link { get; set; }
    //    [DataMember]
    //    public string description { get; set; }
    //    public string language { get; set; }
    //    public string lastBuildDate { get; set; }
    //    public string ttl { get; set; }
    //    public Location location { get; set; }
    //    public Wind wind { get; set; }
    //    public Atmosphere atmosphere { get; set; }
    //    public Astronomy astronomy { get; set; }
    //    public Image image { get; set; }
    //    public Item item { get; set; }
    //}
    //[DataContract]
    //public class Results
    //{
    //    [DataMember]
    //    public Channel channel { get; set; }
    //}
    //[DataContract]
    //public class Query
    //{
    //    [DataMember]
    //    public int count { get; set; }
    //    public string created { get; set; }
    //    public string lang { get; set; }
    //    [DataMember]
    //    public Results results { get; set; }
    //}
    //[DataContract]
    //public class RootObject
    //{
    //    [DataMember]
    //    public Query query { get; set; }
    //}

}
