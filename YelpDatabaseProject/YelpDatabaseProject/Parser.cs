using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace YelpDatabaseProject
{
    class JSON
    {
        List<JObject> results = new List<JObject>();
        string[] exceptions;

        public JSON()
        {
            this.exceptions = new string[] { };
        }

        public JSON(string[] exceptions)
        {
            this.exceptions = exceptions;
        }

        public void ChangeExceptions(string[] exceptions)
        {
            this.exceptions = exceptions;
        }

        public void Convert(string infile, string outfile)
        {
            using (StreamWriter file = new StreamWriter(outfile))
            {
                foreach (var obj in File.ReadAllLines(infile))
                {
                    JsonTextReader reader = new JsonTextReader(new StringReader(obj));
                    int keyOrValueCounter = 0;

                    //file.WriteLine("{");
                    while (reader.Read())
                    {
                        // Exclude certain keys
                        foreach (var ex in exceptions)
                        {   
                            if (reader.Value != null)
                            { // Key, Value pair
                                if (reader.Value.Equals(ex))
                                {
                                    JsonToken ender = JsonToken.None;

                                    // Get the start type
                                    reader.Read();
                                    switch (reader.TokenType)
                                    {
                                        case JsonToken.StartArray:
                                            ender = JsonToken.EndArray;
                                            break;
                                        case JsonToken.StartConstructor:
                                            ender = JsonToken.EndConstructor;
                                            break;
                                        case JsonToken.StartObject:
                                            ender = JsonToken.EndObject;
                                            break;
                                        default:
                                            break;
                                    }

                                    // Go until we find the end 
                                    int innerStuff = 0;
                                    reader.Read();

                                    while (innerStuff != 0 || reader.TokenType != ender)
                                    {
                                        switch (reader.TokenType)
                                        {
                                            case JsonToken.StartArray:
                                                innerStuff++;
                                                break;
                                            case JsonToken.StartConstructor:
                                                innerStuff++;
                                                break;
                                            case JsonToken.StartObject:
                                                innerStuff++;
                                                break;
                                            case JsonToken.EndArray:
                                                innerStuff--;
                                                break;
                                            case JsonToken.EndConstructor:
                                                innerStuff--;
                                                break;
                                            case JsonToken.EndObject:
                                                innerStuff--;
                                                break;
                                            default:
                                                break;
                                        }
                                        reader.Read();
                                    }

                                    // Get rid of End type
                                    reader.Read();
                                }
                            }
                            
                        }
                        if (reader.Value != null)
                        {// Print normal Key, Value
                            if (keyOrValueCounter % 2 == 0)
                            {
                                file.Write("{0} = ", reader.Value);
                            }
                            else
                            {
                                file.WriteLine("{0};", reader.Value);
                            }

                            keyOrValueCounter++;
                        }
                        else
                        {// Only a starting type, so just print it.
                            switch (reader.TokenType)
                            {
                                case JsonToken.StartObject: file.WriteLine("{"); break;

                                case JsonToken.EndObject: file.WriteLine("}"); break;

                                case JsonToken.StartArray: file.WriteLine("["); break;

                                case JsonToken.EndArray: file.WriteLine("]"); break;

                                default: break;
                            }
                            keyOrValueCounter = 0;
                        }
                    }
                    //file.WriteLine("}");
                }
            }
        }
    }
}
