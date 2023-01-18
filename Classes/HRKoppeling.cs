using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public IDictionary<string, string> HaalProjectLedenOp()
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var stringTask = httpClient.GetStringAsync(baseURL + "/employees");

            try
            {
                var jsonString = stringTask.Result;

                IDictionary<string, string>? employeeIndex = JsonSerializer.Deserialize<IDictionary<string, string>>(jsonString);

                if(employeeIndex != null)
                {
                    return employeeIndex;
                }

                Console.WriteLine("Oepsiepoepsie");
            }
            catch(Exception e)
            {
                Console.WriteLine($"HR systeemfout {e}");
            }
            return null;
        }
    }
}
