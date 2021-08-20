using System;
using System.Collections.Generic;
using System.Text;

namespace XMLToJSONAdapter
{
    public class JSONAdapter : ITarget
    {
        private readonly XMLService _service;
        public JSONAdapter(XMLService xmlService)
        {
            _service = xmlService;
        }
        public string GetJSONFormatData()
        {
            var xmlData = _service.GetDataInXMLFormat();

            return $"{{\"key\":{xmlData}}}";

        }
    }
}
