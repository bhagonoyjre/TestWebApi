using System.Web.Mvc;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using System.Net.Http;

using AppLibrary.ViewModels;
namespace ApiClient.Controllers
{

    /// <summary>
    /// A test mvc controller to consume RESTful Api (i.e., SerkoTestWebApi)
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Landing page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            if (TempData["msg"] != null)
                ViewBag.ResultMessage = TempData["msg"].ToString();

            return View();
        }

        /// <summary>
        /// Send request to Web API uri.
        /// Sample valid xml data:
        ///     <expense>
	    ///         <cost_centre>DEV002</cost_centre>
	    ///         <total>890.55</total>
	    ///         <payment_method>Personal Card</payment_method>
        ///     </expense>
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateInput(false)]
        [HttpPost]
        public async Task<ActionResult> SubmitXML(XMLStringVM model)
        {
            if (!string.IsNullOrWhiteSpace(model.XMLString))
            {
                string msgResponse = "";
                var strXml = model.XMLString.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                var content = JsonConvert.SerializeObject(strXml);
                using (var http = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:63643/api/ExpenseClaim");
                    request.Content = new StringContent(content, System.Text.Encoding.UTF8, "application/json");
                    var response = await http.SendAsync(request).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        var stream = response.Content.ReadAsStreamAsync().Result;
                        StreamReader reader = new StreamReader(stream);
                        msgResponse = reader.ReadToEnd().Replace("\"", "");
                    }
                    else
                    {
                        var stream = response.Content.ReadAsStreamAsync().Result;
                        StreamReader reader = new StreamReader(stream);
                        msgResponse = reader.ReadToEnd().Split(':')[1].Replace("\"", "").Replace("}","");
                    }
                }
                TempData["msg"] = msgResponse;
            }
            return RedirectToAction("Index");
        }
        
    }
}