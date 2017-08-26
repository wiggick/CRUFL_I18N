using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Runtime.InteropServices;


namespace CRUFL_I18N
{

    [ComVisible(true), ClassInterface( ClassInterfaceType.None ), GuidAttribute("87E4519B-37B0-46E1-8185-8D8EFF0D2530")]
    public class Translator: ITranslatorUfl
    {

        public Translator()
        {
        }

        public string GetTranslation( string key, string json )
        {
            IList<Translation> translations = new List<Translation>();

            JObject objJSON = JObject.Parse(json);
           
            IList<JToken> parsedTranslations = objJSON["Translations"].Children().ToList();

            foreach (JToken parsedTranslation in parsedTranslations)
             {
                // JToken.ToObject is a helper method that uses JsonSerializer internally
                Translation translation = parsedTranslation.ToObject<Translation>();
                translations.Add( translation );
             }

            foreach( Translation translation in translations )
            {
                if ( key == translation.Key )
                {
                    return translation.Value;
                }


            }

            return key;
        }


    }

}
