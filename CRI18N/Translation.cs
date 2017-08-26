using System;


namespace CRUFL_I18N
{

    public class Translation
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public Translation()
        {
        }

        public Translation(string key, string value)
        {
            this.Key = key;
            this.Value = value;

        }


    }
}
