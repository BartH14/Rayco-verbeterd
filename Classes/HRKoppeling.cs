using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rayco_Planner.Classes
{
    internal class HRKoppeling
    {
        private readonly string baseURL;
        private readonly HttpClient httpClient = new HttpClient();

        private static HRKoppeling instantie;
                
        //singleton pattern
        public static HRKoppeling GetInstantie()
        {
            if (instantie == null)
            {
                instantie = new HRKoppeling("http://127.0.0.1:8008");
            }
            return instantie;
        }

        //private constructor die de base url van de API als parameter neemt
        private HRKoppeling(string baseURL)
        {
            this.baseURL = baseURL;
        }

        //methode die een list met projectleden objecten ophaalt van de API
        public List<ProjectLid> HaalProjectLedenOp()
        {
            //instantieert een lijst om de objecten in op te slaan
            List<ProjectLid> list = new List<ProjectLid>();
            //haalt alle headers weg van de httpclient en voegt een "accept" header toe met de waarde "application/json"
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            //maakt een get request richting de api met de base url en het "/employees" eindpunt
            var stringTask = httpClient.GetStringAsync(baseURL + "/employees");

            try
            {
                //krijgt de response van de api als een string
                var jsonString = stringTask.Result;
                Console.WriteLine(jsonString);

                // Deserialize the JSON string naar een list van ProjectLid objecten
                list = JsonSerializer.Deserialize<List<ProjectLid>>(jsonString);
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine($"HRKoppeling fout: {e.Message}");
            }
            return null;
        }
    }
}
