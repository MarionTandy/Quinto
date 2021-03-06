﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quinto
{
    public static class Serialisation
    {
        public static void SaveJson(string path, IEnumerable<object> mot)
        {

            JsonSerializer j = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                j.Serialize(writer, mot);
            }
        }
        public static IEnumerable LoadJson(string path, Type type)
        {

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string flux = sr.ReadToEnd();
                object mots = JsonConvert.DeserializeObject(flux, type);
                sr.Close();
                return mots as IEnumerable;

            }
            else
            {
                throw new Exception();
            }
        }
    }
}
