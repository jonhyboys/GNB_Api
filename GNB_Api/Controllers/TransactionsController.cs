using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using GNB_Api.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GNB_Api.Controllers
{
    public class TransactionsController : ApiController
    {
        [Route("Transactions")]
        public async Task<IHttpActionResult> GetTransactionsAsync()
        {
            string address = "http://quiet-stone-2094.herokuapp.com/transactions.json";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(new Uri(address));
                    string responseMessage = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        List<Transaction> transactions = JsonConvert.DeserializeObject<List<Transaction>>(responseMessage);
                        return Ok(transactions);
                    }

                    return NotFound();
                }
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [Route("Rates")]
        public async Task<IHttpActionResult> GetRatesAsync()
        {
            string address = "http://quiet-stone-2094.herokuapp.com/rates.json";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(new Uri(address));
                    string responseMessage = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        List<Rate> rates = JsonConvert.DeserializeObject<List<Rate>>(responseMessage);
                        return Ok(rates);
                    }

                    return NotFound();
                }
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
