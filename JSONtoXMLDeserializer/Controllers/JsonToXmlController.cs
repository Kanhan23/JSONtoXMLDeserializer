using JSONtoXMLDeserializer.API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace JSONtoXMLDeserializer.API.Controllers {

    [Route("jsonToXml")]
    public class JsonToXmlController : Controller {

        private readonly IJsonToXmlConverter _converter;

        public JsonToXmlController([FromServices] IJsonToXmlConverter converter) {
            _converter = converter;
        }


        [HttpGet("/")]
        public string JsonToXml([FromQuery] string json) {
            return _converter.JsonToXml(json);
        }

    }
}