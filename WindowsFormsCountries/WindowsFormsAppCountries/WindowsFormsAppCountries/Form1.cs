using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCountries
{
    public partial class Form1 : Form
    {
        
        public List<Country> lCountries; // dodati na classu, public
        public Form1()
        {
            InitializeComponent(); // kreiranje forme
            /*DATA GRID*/
            lCountries = GetCountries();
            dataGridViewCountries.DataSource = lCountries;

            /*COMBO BOX FILTRIRANJE*/
            List<String> lRegions = lCountries.Where(o => o.sRegion != "").Select(o => o.sRegion).Distinct().ToList(); // spremamo string samo, LinkQ za dohvacanje distinc vrijednost
            lRegions.Insert(0, "Svi kontinenti");
            comboBoxRegion.DataSource = lRegions;

            /*COMBO BOX SORTIRANJE*/
            List<string> lSortCriterias = new List<string>()
                {
                    "‐",
                    "Glavni grad",
                    "Naziv",
                    "Broj stanovnika",
                    "Povrsina"
            };
            comboBox1.DataSource = lSortCriterias;

            /*COMBO BOX NOVA REGIJA*/
            List<string> lNewRegionOptions = lCountries.Where(o => o.sRegion != "").Select(o => o.sRegion).Distinct().ToList();
            lNewRegionOptions.Insert(0, " - ");
            comboBoxChoose.DataSource = lNewRegionOptions;

            // string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"]; // provjra, jel link radi
            //  Debug.WriteLine(sUrl);
            // Trace.WriteLine(sUrl);           
        }
        public List<Country> GetCountries()
        {
            List<Country> lRESTCountries = new List<Country>();
            string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"];
            string sJson = CallRestMethod(sUrl); // iz URL-a spremamo podatke (Url)
            JArray json = JArray.Parse(sJson); // parsiramo podatke
            foreach (JObject item in json)                             //koristimo za button
                                                                       //datagridsorce..
            {
                {
                    // ČITANJE VRIJEDNOSTI IZ JSON-a
                    string code = (string)item.GetValue("alpha2Code");
                    string name = (string)item.GetValue("name");
                    string capital = (string)item.GetValue("capital");
                    int population = (int)item.GetValue("population");
                    float area = -1;
                    if (item.GetValue("area").Type == JTokenType.Null)
                    {
                        area = 0;
                    }
                    else
                    {
                        area = (float)item.GetValue("area");
                    }
                    string region = (string)item.GetValue("region");

                    //DODAVANJE OBJEKTA U LISTU
                    lRESTCountries.Add(new Country
                    {
                        sCode = code,
                        sName = name,
                        sCapital = capital,
                        nPopulation = population,
                        fArea = area,
                        sRegion = region
                    });
                }
            }
            return lRESTCountries;
        }
        public static string CallRestMethod(string url)
        {
            // uključiti, System.IO i System.Net
            url = "https://restcountries.eu/rest/v2/all";
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            //webrequest.Headers.Add("Username", "xyz");
            //webrequest.Headers.Add("Password", "abc");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
            enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sRegion = (string)comboBoxRegion.SelectedItem; // odabrana vrijednost

            lCountries = GetCountries();
            if(sRegion!= "Svi kontinenti")
            {
                lCountries = lCountries.Where(o => o.sRegion == sRegion).ToList(); //
                dataGridViewCountries.DataSource = lCountries;
            }
            else
            {
                dataGridViewCountries.DataSource = lCountries; // ako nema ni jednog, vrati cijelu listu

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSortCriteria = (string)comboBox1.SelectedItem;
            lCountries = GetCountries();

            switch(sSortCriteria)
            {
                case "-":
                    break;
                case "Glavni grad":
                    dataGridViewCountries.DataSource = lCountries.OrderBy(o => o.sCapital).ToList();
           
                    break;
                case "Naziv":
                    dataGridViewCountries.DataSource = lCountries.OrderBy(o => o.sName).ToList();
               
                    break;
                case "Broj stanovnika":
                    dataGridViewCountries.DataSource = lCountries.OrderByDescending(o => o.nPopulation).ToList();
                 
                    break;
                case "Povrsina":
                    dataGridViewCountries.DataSource = lCountries.OrderByDescending(o => o.fArea).ToList();
                    break;

            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sPretrazi = textBoxSearch.Text;
            var vPretrazi = from c in lCountries where c.sName.Contains(sPretrazi) select c;
            List<Country> lPretrazeneDrzave = vPretrazi.ToList();
            dataGridViewCountries.DataSource = lPretrazeneDrzave.OrderBy(o => o.sName).ToList();

        }

        private void btnSave_Click(object sender, EventArgs e) 
        {
            string NewCode = inptCode.Text;
            string NewName = inptName.Text;
            string NewCapital=inptCapitalCity.Text;
            int NewPopulation = Convert.ToInt32(inptNumbPopulation.Text);
            float NewArea = Convert.ToSingle(inptArea.Text);
            string NewRegion = comboBoxChoose.Text;
            Country Zemlja = new Country()
            {
                sCode = NewCode,
                sName = NewName,
                sCapital = NewCapital,
                nPopulation = NewPopulation,
                fArea = NewArea,
                sRegion = NewRegion
            };
            lCountries.Add(Zemlja);
            dataGridViewCountries.DataSource = lCountries;
        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
