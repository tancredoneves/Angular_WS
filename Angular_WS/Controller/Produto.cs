using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Angular_WS
{
    public class Produto
    {
        static void Main(string[] args)
        {
            try
            {
                Rodar();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static async void Rodar()
        {
            try
            {
                HttpClient cliente = new HttpClient();

                string resultado = await cliente.GetStringAsync("http://www.macoratti.net/vbn_jqsm.htm");
                Console.WriteLine(resultado);
            }
            catch
            {
                throw;
            }
        }

    }
}