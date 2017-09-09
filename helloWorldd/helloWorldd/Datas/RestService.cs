using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace helloWorldd.Datas
{
    public class RestService
    {
        HttpClient client ;
        public RestService(){

            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www form urlencoded' "));
            }
        public async Task<login> Login(User user)
        {

        }
    }
}
