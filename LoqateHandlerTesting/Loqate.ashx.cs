using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace LoqateHandlerTesting
{
    /// <summary>
    /// Summary description for Loqate
    /// </summary>
    public class Loqate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        static System.Data.DataSet CaptureInteractiveFindv110(string key, string text, bool ismiddleware, string container, string origin, string countries, int limit, string language, bool bias, string filters, string geofence)
        {
            //Build the url
            var url = "https://api.addressy.com/Capture/Interactive/Find/v1.10/dataset.ws?";
            url += "&Key=" + System.Web.HttpUtility.UrlEncode(key);
            url += "&Text=" + System.Web.HttpUtility.UrlEncode(text);
            url += "&IsMiddleware=" + System.Web.HttpUtility.UrlEncode(ismiddleware.ToString(CultureInfo.InvariantCulture));
            url += "&Container=" + System.Web.HttpUtility.UrlEncode(container);
            url += "&Origin=" + System.Web.HttpUtility.UrlEncode(origin);
            url += "&Countries=" + System.Web.HttpUtility.UrlEncode(countries);
            url += "&Limit=" + System.Web.HttpUtility.UrlEncode(limit.ToString(CultureInfo.InvariantCulture));
            url += "&Language=" + System.Web.HttpUtility.UrlEncode(language);
            url += "&Bias=" + System.Web.HttpUtility.UrlEncode(bias.ToString(CultureInfo.InvariantCulture));
            url += "&Filters=" + System.Web.HttpUtility.UrlEncode(filters);
            url += "&GeoFence=" + System.Web.HttpUtility.UrlEncode(geofence);



            // Could convert XML directly to JSON from url or may be ideal to use the dataset code for error detection, then convert to JSON
            //var xml = new XmlDocument();
            //xml.Load(url);
            //string jsonString = Newtonsoft.Json.JsonConvert.SerializeXmlNode(xml);

            //Create the dataset
            var dataSet = new System.Data.DataSet();
            dataSet.ReadXml(url);

            //Check for an error
            if (dataSet.Tables.Count == 1 && dataSet.Tables[0].Columns.Count == 4 && dataSet.Tables[0].Columns[0].ColumnName == "Error")
                throw new Exception(dataSet.Tables[0].Rows[0].ItemArray[1].ToString());

            //Return the dataset
            return dataSet;

            //FYI: The dataset contains the following columns:
            //Id
            //Type
            //Text
            //Highlight
            //Description
        }


        static System.Data.DataSet CaptureInteractiveRetrievev120(string key, string id, string field1format, string field2format, string field3format, string field4format, string field5format, string field6format, string field7format, string field8format, string field9format, string field10format, string field11format, string field12format, string field13format, string field14format, string field15format, string field16format, string field17format, string field18format, string field19format, string field20format)
        {
            //Build the url
            var url = "https://api.addressy.com/Capture/Interactive/Retrieve/v1.20/dataset.ws?";
            url += "&Key=" + System.Web.HttpUtility.UrlEncode(key);
            url += "&Id=" + System.Web.HttpUtility.UrlEncode(id);
            url += "&Field1Format=" + System.Web.HttpUtility.UrlEncode(field1format);
            url += "&Field2Format=" + System.Web.HttpUtility.UrlEncode(field2format);
            url += "&Field3Format=" + System.Web.HttpUtility.UrlEncode(field3format);
            url += "&Field4Format=" + System.Web.HttpUtility.UrlEncode(field4format);
            url += "&Field5Format=" + System.Web.HttpUtility.UrlEncode(field5format);
            url += "&Field6Format=" + System.Web.HttpUtility.UrlEncode(field6format);
            url += "&Field7Format=" + System.Web.HttpUtility.UrlEncode(field7format);
            url += "&Field8Format=" + System.Web.HttpUtility.UrlEncode(field8format);
            url += "&Field9Format=" + System.Web.HttpUtility.UrlEncode(field9format);
            url += "&Field10Format=" + System.Web.HttpUtility.UrlEncode(field10format);
            url += "&Field11Format=" + System.Web.HttpUtility.UrlEncode(field11format);
            url += "&Field12Format=" + System.Web.HttpUtility.UrlEncode(field12format);
            url += "&Field13Format=" + System.Web.HttpUtility.UrlEncode(field13format);
            url += "&Field14Format=" + System.Web.HttpUtility.UrlEncode(field14format);
            url += "&Field15Format=" + System.Web.HttpUtility.UrlEncode(field15format);
            url += "&Field16Format=" + System.Web.HttpUtility.UrlEncode(field16format);
            url += "&Field17Format=" + System.Web.HttpUtility.UrlEncode(field17format);
            url += "&Field18Format=" + System.Web.HttpUtility.UrlEncode(field18format);
            url += "&Field19Format=" + System.Web.HttpUtility.UrlEncode(field19format);
            url += "&Field20Format=" + System.Web.HttpUtility.UrlEncode(field20format);

            //Create the dataset
            var dataSet = new System.Data.DataSet();
            dataSet.ReadXml(url);

            //Check for an error
            if (dataSet.Tables.Count == 1 && dataSet.Tables[0].Columns.Count == 4 && dataSet.Tables[0].Columns[0].ColumnName == "Error")
                throw new Exception(dataSet.Tables[0].Rows[0].ItemArray[1].ToString());

            //Return the dataset
            return dataSet;

            //FYI: The dataset contains the following columns:
            //Id
            //DomesticId
            //Language
            //LanguageAlternatives
            //Department
            //Company
            //SubBuilding
            //BuildingNumber
            //BuildingName
            //SecondaryStreet
            //Street
            //Block
            //Neighbourhood
            //District
            //City
            //Line1
            //Line2
            //Line3
            //Line4
            //Line5
            //AdminAreaName
            //AdminAreaCode
            //Province
            //ProvinceName
            //ProvinceCode
            //PostalCode
            //CountryName
            //CountryIso2
            //CountryIso3
            //CountryIsoNumber
            //SortingNumber1
            //SortingNumber2
            //Barcode
            //POBoxNumber
            //Label
            //Type
            //DataLevel
            //Field1
            //Field2
            //Field3
            //Field4
            //Field5
            //Field6
            //Field7
            //Field8
            //Field9
            //Field10
            //Field11
            //Field12
            //Field13
            //Field14
            //Field15
            //Field16
            //Field17
            //Field18
            //Field19
            //Field20
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}