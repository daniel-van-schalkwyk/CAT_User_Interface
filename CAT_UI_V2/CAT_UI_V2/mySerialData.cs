using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows;

namespace CAT_UI_V2
{
    class MySerialData
    {
        public string GetData(string x, string vname, int state = 0)
        {
            string val = "100";
            string[] datapnts = x.Split(',');
            foreach (string datapnt in datapnts)
            {
                if (datapnt.Contains(vname))
                {
                    val = GetInfo(datapnt, state);
                    break;
                }
            }
            return val;
        }
        private string GetInfo(string x, int c)
        {
            string[] val = x.Split(':');
            switch(c)
            {
                case 1:
                    string state = GetState(val[2]);
                    return state.Trim();
                default:
                    return val[1].Trim();
            }
        }
        private string GetState(string letter)
        {
            if (letter.Contains("C"))
            {
                return "Closed";
            }
            else if (letter.Contains("F"))
            {
                return "Feed";
            }
            else if (letter.Contains("I"))
            {
                return "Isolate";
            }
            else if (letter.Contains("O"))
            {
                return "Open";
            }
            else if (letter.Contains("V"))
            {
                return "Vent";
            }
            else
            {
                return "Unfamiliar state";
            }
        }
    }
}
