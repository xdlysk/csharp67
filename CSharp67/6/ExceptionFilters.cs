using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class ExceptionFilters
    {
        public void DoSomethingWithException()
        {
            try
            {
                using (var sr = new StreamReader("a not exist file"))
                {

                }
            }
            catch (IOException ex)
            when (ex.Message.IndexOf("未能找到", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                throw;
            }
            catch(FileNotFoundException ex)
            when (false)
            {
                //never reach here
            }
            catch(Exception ex)
            {

            }
        }

        public static async Task<string> MakeRequestWithNotModifiedSupport()
        {
            var client = new System.Net.Http.HttpClient();
            var streamTask = client.GetStringAsync("https://localHost:10000");
            try
            {
                var responseText = await streamTask;
                return responseText;
            }
            catch (System.Net.Http.HttpRequestException e) when (e.Message.Contains("301"))
            {
                return "Site Moved";
            }
            catch (System.Net.Http.HttpRequestException e) when (e.Message.Contains("304"))
            {
                return "Use the Cache";
            }
        }
    }
}
