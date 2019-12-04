using System.Collections.Generic;

namespace DesignPatternDemo
{
    public class Factory<TF, TV> where TF : new()
    {
        protected Factory()
        {
            KeyValues = new Dictionary<string, TV>();
        }

        public static TF Instance { get; set; } = new TF();

        private Dictionary<string, TV> KeyValues { get; }

        public TV GetItem(string key)
        {
            KeyValues.TryGetValue(key, out TV find);

            return find;
        }
        public void Register(string key, TV t)
        {
            UnRegister(key);
            KeyValues.Add(key, t);
        }

        public void UnRegister(string key)
        {
            if (KeyValues.ContainsKey(key)) KeyValues.Remove(key);
        }
    }
}