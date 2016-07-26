using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using BitfontWizard.JSONExport;

namespace BitfontWizard
{
    public partial class Form1
    {
        string jsonPath;

        private void exportMenuItem_Click(object sender, EventArgs e)
        {
            jsonSaveDialog.ShowDialog();
        }

        private void jsonSaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            jsonPath = jsonSaveDialog.FileName;
            Bitfont2JasonOpenDialog.ShowDialog();
        }

        private void Bitfont2JasonOpenDialog_FileOk(object sender, CancelEventArgs e)
        {
            string[] paths = Bitfont2JasonOpenDialog.FileNames;
            ExportBitfontsToJSONCollection(paths, jsonPath);
        }

        public void ExportBitfontsToJSONCollection(string[] paths, string jsonPath)
        { 
            int arraySize = paths.Length;
            string JSON = "[";
            Bitfont[] bitfonts = new Bitfont[arraySize];
            Bitfont2JSON[] fontOut = new Bitfont2JSON[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                using (BinaryReader br = new BinaryReader(File.Open(paths[i], FileMode.Open)))
                {

                    bitfonts[i] = new Bitfont();
                    bitfonts[i].Deserialise(br);

                    fontOut[i] = new Bitfont2JSON(bitfonts[i]);
                    JSON += SerialiseUE4JSON(fontOut[i], i,false, i >= arraySize-1);
                    if (i < arraySize - 1)
                        JSON += ",\n";
                }
            }
            JSON += "\n]";

            using (TextWriter tw = File.CreateText(jsonPath))
            {
                tw.Write(JSON);
                tw.Close();
            }
        }

        string SerialiseUE4JSON(Bitfont2JSON obj2JSON, int row, bool capArray = true, bool endOfArray = false)
        {
            //string JSON = JsonConvert.SerializeObject(obj2JSON,Formatting.Indented);
           // JSON = JSON.Insert(1, string.Format("\"Name\":\"{0}\",\n\"EntryID\":\"{0}\",", row.ToString()));
            string JSON = obj2JSON.ParseIntoJSON(row,!endOfArray);
            if (capArray)
                JSON += "\n]";
            return JSON;
        }
    }
}
