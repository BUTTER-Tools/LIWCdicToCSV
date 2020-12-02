using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;
using System.Text;
using System.IO;
using TSOutputWriter;


namespace LIWCdicToCSV
{
    public partial class LIWCdicToCSV : LinearPlugin
    {


        public string[] InputType { get; } = { "LIWC Dictionary File" };
        public string OutputType { get; } = "CSV File";

        public Dictionary<int, string> OutputHeaderData { get; set; } = new Dictionary<int, string>() { { 0, "TokenizedText" } };
        public bool InheritHeader { get; } = false;

        public string StatusToReport { get; set; } = "";

        #region Plugin Details and Info

        public string PluginName { get; } = "LIWC Dictionary to CSV";
        public string PluginType { get; } = "Dictionary Tools";
        public string PluginVersion { get; } = "1.1.0";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "Converts a LIWC dictionary file (.dic) into a more browsable CSV spreadsheet.";
        public string PluginTutorial { get; } = "Coming Soon";
        public bool TopLevel { get; } = true;


        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion


        private string SelectedEncoding { get; set; } = "utf-8";
        private string IncomingTextLocation { get; set; } = "";
        private string OutputLocation { get; set; } = "";
        private string Delimiter { get; set; } = ",";
        private string Quote { get; set; } = "\"";
        private DictionaryMetaObject DictDataRawMeta { get; set; }

        private string RawDictionaryString { get; set; }
        private string CSVStyle { get; set; } = "Table";
        private int NumCats { get; set; } = 0;

        public void ChangeSettings()
        {

            using (var form = new SettingsForm_LIWCdicToCSV(IncomingTextLocation, OutputLocation, SelectedEncoding, Delimiter, Quote, CSVStyle))
            {


                form.Icon = Properties.Resources.icon;
                form.Text = PluginName;


                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SelectedEncoding = form.SelectedEncoding;
                    IncomingTextLocation = form.InputFileName;
                    OutputLocation = form.OutputFileName;
                    Delimiter = form.Delimiter;
                    Quote = form.Quote;
                    CSVStyle = form.CSVStyle;

                }
            }

        }





        public Payload RunPlugin(Payload Input, int ThreadsAvailable)
        {

            DictionaryData ParsedDict = new DictionaryData();

            try
            {
                DictParser DP = new DictParser();
                ParsedDict = DP.ParseDict(DictDataRawMeta);
            }
            catch
            {
                MessageBox.Show("There was an error trying to parse your dictionary file. Please make sure that your dictionary file is correctly formatted.", "Error Parsing Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (new Payload());
            }
            //ParsedDict.FullDictionary structure
            //--"Wildcards"
            //----int Word Count
            //--------Words
            //----------categories[]
            //--"Standards"
            //----int Word Count
            //--------Words
            //----------categories[]
            NumCats = ParsedDict.NumCats;
            uint WordsProcessed = 0;



            TimeSpan reportPeriod = TimeSpan.FromMinutes(0.01);
            using (new System.Threading.Timer(
                        _ => SetUpdate(WordsProcessed),
                             null, reportPeriod, reportPeriod))
            {


                try
                {
                    using (ThreadsafeOutputWriter OutputWriter = new ThreadsafeOutputWriter(OutputLocation,
                        Encoding.GetEncoding(SelectedEncoding.ToString()), FileMode.Create))
                    {

                        #region set up and write the header
                        string[] header;
                        if (CSVStyle == "Poster")
                        {
                            header = ParsedDict.CatNames;

                        }
                        else
                        {
                            header = new string[ParsedDict.NumCats + 1];
                            header[0] = "Entry";
                            for (int i = 0; i < ParsedDict.NumCats; i++) header[i + 1] = ParsedDict.CatNames[i];
                        }

                        for (int i = 0; i < header.Length; i++) header[i] = Quote + header[i] + Quote;

                        OutputWriter.WriteString(String.Join(Delimiter, header));

                        #endregion

                        if (CSVStyle == "Poster")
                        {
                            #region write poster style csv
                            Dictionary<string, int> CatIndices = new Dictionary<string, int>();
                            //for (int i = 0; i < ParsedDict.CatValues.Length; i++) CatIndices.Add(ParsedDict.CatValues[i], i);

                            for (int i = 0; i < ParsedDict.CatValues.Length; i++)
                            {
                                //we have to make sure that the category mapped key doesn't already exist in the CatIndices variable
                                //otherwise, a person can accidentally re-use the same category number (e.g., 10) for multiple categories,
                                //which will screw things up
                                if (!CatIndices.ContainsKey(ParsedDict.CatValues[i]))
                                {
                                    CatIndices.Add(ParsedDict.CatValues[i], i);
                                }
                                else
                                {
                                    MessageBox.Show("Your dictionary file appears to use the same code to refer to muliple categories (" + ParsedDict.CatValues[i] + "). All categories that use this code will be omitted, except for the first category that used this code.", "Dictionary Formatting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }



                            //initialize our word map
                            List<List<string>> WordMap = new List<List<string>>();
                            for (int i = 0; i < NumCats; i++) WordMap.Add(new List<string>());


                            if (ParsedDict.FullDictionary.ContainsKey("Wildcards"))
                            { 
                                foreach (int wordcount in ParsedDict.FullDictionary["Wildcards"].Keys)
                                {
                                    foreach (string word in ParsedDict.FullDictionary["Wildcards"][wordcount].Keys)
                                    {
                                        for (int i = 0; i < ParsedDict.FullDictionary["Wildcards"][wordcount][word].Length; i++)
                                        {
                                            if (CatIndices.ContainsKey(ParsedDict.FullDictionary["Wildcards"][wordcount][word][i]))
                                            {
                                                WordMap[CatIndices[ParsedDict.FullDictionary["Wildcards"][wordcount][word][i]]].Add(Quote + word.Replace(Quote, Quote + Quote) + Quote);
                                            }
                                            
                                        } 
                                        WordsProcessed++;
                                    }
                                }
                            }
                            if (ParsedDict.FullDictionary.ContainsKey("Standards"))
                            {
                                foreach (int wordcount in ParsedDict.FullDictionary["Standards"].Keys)
                                {
                                    foreach (string word in ParsedDict.FullDictionary["Standards"][wordcount].Keys)
                                    {


                                        for (int i = 0; i < ParsedDict.FullDictionary["Standards"][wordcount][word].Length; i++)
                                        {
                                            if (CatIndices.ContainsKey(ParsedDict.FullDictionary["Standards"][wordcount][word][i]))
                                            {
                                                WordMap[CatIndices[ParsedDict.FullDictionary["Standards"][wordcount][word][i]]].Add(Quote + word.Replace(Quote, Quote + Quote) + Quote);
                                            }
                                        }
                                    
                                    WordsProcessed++;


                                    }
                                }
                            }


                            //now that we've populated the word map, we can clean some things up
                            //first, wipe out the parseddict
                            ParsedDict = new DictionaryData();
                            //now we sort the word lists and figure out our array size that we're going to write
                            int MaxWords = 0;
                            for (int i = 0; i < NumCats; i++)
                            {
                                WordMap[i].Sort();
                                int wordCount = WordMap[i].Count;
                                if (wordCount > MaxWords) MaxWords = wordCount;
                            }

                            //OutputArray[Cols,Rows]
                            string[][] OutputArray = new string[MaxWords][];
                            //initialize array with empty strings
                            for (int i = 0; i < MaxWords; i++)
                            {
                                OutputArray[i] = new string[NumCats];
                                for (int j = 0; j < NumCats; j++) OutputArray[i][j] = "";
                            }

                            //now we populate the array with the words from the word map
                            for (int i = 0; i < NumCats; i++)
                            {
                                for (int j = 0; j < WordMap[i].Count; j++) OutputArray[j][i] = WordMap[i][j];
                            }
                            WordMap.Clear();

                            //finally, write the data
                            for (int i = 0; i < MaxWords; i++)
                            {
                                OutputWriter.WriteString(String.Join(Delimiter, OutputArray[i]));
                            }


                            #endregion


                        }
                        else
                        {
                            #region write table style csv

                            //set up a dictionary to track which columns the output gets written to
                            Dictionary<string, int> CatIndices = new Dictionary<string, int>();
                            for (int i = 0; i < ParsedDict.CatValues.Length; i++)
                            {
                            //we have to make sure that the category mapped key doesn't already exist in the CatIndices variable
                            //otherwise, a person can accidentally re-use the same category number (e.g., 10) for multiple categories,
                            //which will screw things up
                                if (!CatIndices.ContainsKey(ParsedDict.CatValues[i]))
                                { 
                                    CatIndices.Add(ParsedDict.CatValues[i], i + 1); 
                                }
                                else 
                                {
                                    MessageBox.Show("Your dictionary file appears to use the same code to refer to muliple categories (" + ParsedDict.CatValues[i] + "). All categories that use this code will be omitted, except for the first category that used this code.", "Dictionary Formatting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }


                            List<string> WordList = new List<string>();
                            Dictionary<string, string[]> WordListUnpacked = new Dictionary<string, string[]>();
                            #region deconstruct dictionary object
                            //it's kind of taking the long way around to basically read in the dictionary, parse it out into its own object,
                            //then deconstruct that object into additional lists/dictionaries. I might change this in the future, however, I
                            //currently feel that this is a fairly robust way to make sure that everything is parsed out properly before
                            //trying to reassemble into a table. Inefficient? Yes, but it allows me to recycle a lot of other code that I've written
                            foreach (int wordcount in ParsedDict.FullDictionary["Wildcards"].Keys)
                            {
                                foreach (string word in ParsedDict.FullDictionary["Wildcards"][wordcount].Keys)
                                {
                                    WordList.Add(word);
                                    WordListUnpacked.Add(word, ParsedDict.FullDictionary["Wildcards"][wordcount][word]);
                                    WordsProcessed++;
                                }
                            }
                            foreach (int wordcount in ParsedDict.FullDictionary["Standards"].Keys)
                            {
                                foreach (string word in ParsedDict.FullDictionary["Standards"][wordcount].Keys)
                                {
                                    WordList.Add(word);
                                    WordListUnpacked.Add(word, ParsedDict.FullDictionary["Standards"][wordcount][word]);
                                    WordsProcessed++;
                                }
                            }

                            //we can wipe this out now that we're done with it
                            ParsedDict = new DictionaryData();
                            #endregion

                            WordList.Sort();

                            //now we go back and iterate over everything to write it out as a table
                            for (int i = 0; i < WordList.Count; i++)
                            {

                                string word = WordList[i];
                                //initialize new array with empty strings
                                string[] RowToWrite = new string[NumCats + 1];
                                for (int j = 0; j < NumCats + 1; j++) RowToWrite[j] = "";

                                RowToWrite[0] = Quote + word.Replace(Quote, Quote + Quote) + Quote;
                                for (int j = 0; j < WordListUnpacked[word].Length; j++)
                                {
                                    if (CatIndices.ContainsKey(WordListUnpacked[word][j]))
                                    {
                                        RowToWrite[CatIndices[WordListUnpacked[word][j]]] = "X";
                                    }
                                } 

                                OutputWriter.WriteString(String.Join(Delimiter, RowToWrite));

                            }

                            #endregion
                        }


                    }
                }
                catch
                {
                    MessageBox.Show("There was a problem writing your dictionary to a CSV file. Is your CSV file currently open in another application?", "CSV Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            

            return (new Payload());



        }


        //not used
        public Payload RunPlugin(Payload Input)
        {
            return Input;
        }


        public void Initialize()
        {
            try
            {
                DictDataRawMeta = new DictionaryMetaObject("LoadedDict", "Loaded Dictionary", "", "");
                using (var stream = File.OpenRead(IncomingTextLocation))
                using (var reader = new StreamReader(stream, encoding: Encoding.GetEncoding(SelectedEncoding)))
                {
                    DictDataRawMeta.DictionaryRawText = reader.ReadToEnd();
                }
                NumCats = 0;
            }
            catch
            {
                MessageBox.Show("There was a problem opening your LIWC dictionary file. Is it currently open in another application?", "Dictionary Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public bool InspectSettings()
        {
            if (string.IsNullOrEmpty(IncomingTextLocation) || string.IsNullOrEmpty(OutputLocation))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public Payload FinishUp(Payload Input)
        {
            DictDataRawMeta = new DictionaryMetaObject(null, null, null, null);
            return (Input);
        }

        


        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            SelectedEncoding = SettingsDict["SelectedEncoding"];
            IncomingTextLocation = SettingsDict["IncomingTextLocation"];
            OutputLocation = SettingsDict["OutputLocation"];
            Delimiter = SettingsDict["Delimiter"];
            Quote = SettingsDict["Quote"];
            CSVStyle = SettingsDict["CSVStyle"];

        }


        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("SelectedEncoding", SelectedEncoding);
            SettingsDict.Add("IncomingTextLocation", IncomingTextLocation);
            SettingsDict.Add("OutputLocation", OutputLocation);
            SettingsDict.Add("Delimiter", Delimiter);
            SettingsDict.Add("Quote", Quote);
            SettingsDict.Add("CSVStyle", CSVStyle);
            return (SettingsDict);
        }
        #endregion




        private void SetUpdate(uint WordsProcessed)
        {
            StatusToReport = "Processed: " + WordsProcessed.ToString() + " words across " + NumCats.ToString() + " categories";
        }


    }
}
