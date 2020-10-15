using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace serializejson
{
    [Serializable]
     public  class  Lexique : List<string>
    {
        private string _motfacile;
        private string _motdifficile;
        private string _motexpert;

        public string Motfacile { get => _motfacile; set => _motfacile = value; }
        public string Motdifficile { get => _motdifficile; set => _motdifficile = value; }
        public string Motexpert { get => _motexpert; set => _motexpert = value; }

        

        public Lexique() { }

        string[] listedemot = { "bateau", "chaise", "film", "taxi", "montagne", "stylo", "couleur", "bille", "cadeau", "fille", "garcon", "homme", "femme" };


       


        public bool SaveJson(string pathRepDocument)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string fluxjson = JsonConvert.SerializeObject(listedemot, settings);
            using FileStream file = new FileStream($@"{pathRepDocument}\Lexique.json", FileMode.Create, FileAccess.Write, FileShare.Read);
            using StreamWriter txtwriter = new StreamWriter(file);
            txtwriter.Write(fluxjson);
            return true;
        }

        public bool LoadJson(string pathRepDocument)
        {
            using FileStream fs = new FileStream($@"{pathRepDocument}\Lexique.json",
                    FileMode.Open, FileAccess.Read, FileShare.Read);
            using StreamReader sr = new StreamReader(fs);
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            this.AddRange(JsonConvert.DeserializeObject<Lexique>(sr.ReadToEnd(), settings));
            return true;
        }


        public bool loadjson(string pathRepDocument)
        {
            FileStream Chad = new FileStream($@"{pathRepDocument}\Lexique.json", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(Chad);
            JsonSerializer Jason = new JsonSerializer();
            Jason.Deserialize(sr, typeof(List<Lexique>));
            return true;
        }
        
    }
}
