using System.Xml;
using System.Xml.Linq;
using JSONtoXMLDeserializer.API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ILogger = JSONtoXMLDeserializer.API.Services.Abstract.ILogger;

namespace JSONtoXMLDeserializer.API.Services.Concrete {
    public class JsonToXmlConverter : IJsonToXmlConverter {
        private readonly ILogger _logger;


        public JsonToXmlConverter([FromServices] ILogger logger) {
            _logger = logger;
        }

        public string JsonToXml(string json) {
            string result;

            try {
                //var node = JsonConvert.DeserializeXNode(json);
                XmlNode node = JsonConvert.DeserializeXmlNode($"{{\"node\":{json}}}", "root") ?? new XmlDocument();
                result = XElement.Parse(node.OuterXml).ToString();
                _logger.Log("Çevirme başarılı.");
            }
            catch (Exception ex) {
                _logger.Log($"JSON metni XML'e çevrilirken hata oluştu: {ex.Message}\n{ex.StackTrace}");
                throw;
            }

            return result ?? "";
        }
    }
}