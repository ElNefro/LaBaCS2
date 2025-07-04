﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBaCS2
{
    public abstract class Artifact : IExportable
    {
        public enum Rarity
        {
            Common, Rare, Epic, Legendary
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public Rarity rarity { get; set; }

        public abstract void Serialize(string path);


        public abstract string ExportToJson();

        public abstract string ExportToXml();
    }
}
