using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_UI_V2
{
    class DataLogging
    {
        protected FileInfo file;
        private MySerialData Sd = new MySerialData();

        private DateTime filedate;
        private string sep = ",";
        private StringBuilder DataStream = new StringBuilder();
        private string Headings = "TimeStamp,PressSens1,PressSens2,PressSens3,PressSens4,PressSens5,PressSens6,TempSens1,TempSens2,TempSens3,TempSens4,TempSens5,TempSens6,FV1,FV2,FV3,OV1,OV2,OV3,NV1,NV2,PV,FV4,OV4";

        public void OpenFile()
        {
            filedate = DateTime.Now;
            string filetime = filedate.ToString("dd-MM-yy") + "_" + filedate.ToString("HH-mm");
            string path = Directory.GetCurrentDirectory() + "\\Data_Logging\\Data_Log_" + filetime + ".csv";
            file = new FileInfo(path);
            using (StreamWriter sw = file.AppendText())
            {
                sw.WriteLine(Headings);
            }
        }

        public void AppendText(string x)
        {
            string tpass = Sd.GetData(x, "TE");
            filedate = filedate.AddMilliseconds(double.Parse(tpass));
            DataStream.Append(filedate.ToString("HH:mm:ss:fff") + sep);

            DataStream.Append(Sd.GetData(x, "P01") + sep);
            DataStream.Append(Sd.GetData(x, "P02") + sep);
            DataStream.Append(Sd.GetData(x, "P03") + sep);
            DataStream.Append(Sd.GetData(x, "P04") + sep);
            DataStream.Append(Sd.GetData(x, "P05") + sep);
            DataStream.Append(Sd.GetData(x, "P06") + sep);
            DataStream.Append(Sd.GetData(x, "T01") + sep);
            DataStream.Append(Sd.GetData(x, "T02") + sep);
            DataStream.Append(Sd.GetData(x, "T03") + sep);
            DataStream.Append(Sd.GetData(x, "T04") + sep);
            DataStream.Append(Sd.GetData(x, "T05") + sep);
            DataStream.Append(Sd.GetData(x, "T06") + sep);
            DataStream.Append(Sd.GetData(x, "S01") + sep);
            DataStream.Append(Sd.GetData(x, "S02") + sep);
            DataStream.Append(Sd.GetData(x, "S03") + sep);
            DataStream.Append(Sd.GetData(x, "S04") + sep);
            DataStream.Append(Sd.GetData(x, "S05") + sep);
            DataStream.Append(Sd.GetData(x, "S06") + sep);
            DataStream.Append(Sd.GetData(x, "S07") + sep);
            DataStream.Append(Sd.GetData(x, "S08") + sep);
            DataStream.Append(Sd.GetData(x, "S09") + sep);
            DataStream.Append(Sd.GetData(x, "S10") + sep);
            DataStream.Append(Sd.GetData(x, "S11") + sep);
            using (StreamWriter sw = file.AppendText())
            {
                sw.WriteLine(DataStream);
            }
            DataStream.Clear();
        }

    }
}
