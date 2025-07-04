﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LaBaCS2
{
    public class ModernArtifact : Artifact
    {
        public double TechLevel { get; set; }
        public string Manufacturer { get; set; }


        public override void Serialize(string path)
        {
            string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, json);
        }


        public override string ExportToXml()
        {
            XmlSerializer xmlConverter = new XmlSerializer(typeof(AntiqueArtifact));
            StringBuilder xmlBuilder = new StringBuilder();

            using (TextWriter textWriter = new StringWriter(xmlBuilder))
            {
                xmlConverter.Serialize(textWriter, this);
            }

            return xmlBuilder.ToString();
        }


        public override string ExportToJson()
        {
            return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
