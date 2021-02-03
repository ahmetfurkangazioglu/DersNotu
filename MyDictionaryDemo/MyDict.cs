using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDict<Keys,Values>
    {
        Keys[] keys;
        Values[] values;
        Keys[] tkeys;
        Values[] tvalues;
        public MyDict()
        {
            keys = new Keys[0];
            values = new Values[0];              
        }
        public void Add(Keys key, Values value) 
        {
            tkeys = keys;
            tvalues = values;
            keys = new Keys[keys.Length + 1];
            values = new Values[values.Length + 1];
            for (int i = 0; i < tkeys.Length; i++)
            {
                keys[i] = tkeys[i];
                values[i] = tvalues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public Keys[] Keyreturn
        {
            get { return keys; }
        }
        public Values[] Valuesturn
        {
            get { return values; }
        }
    }
}
