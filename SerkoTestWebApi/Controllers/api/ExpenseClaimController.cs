using System;
using System.Web.Http;

using AppLibrary.Utilities;
using SerkoTestWebApi.Models.Repositories;

namespace SerkoTestWebApi.Controllers.api
{

    /// <summary>
    /// Expense claim methods and processes.
    /// </summary>
    public class ExpenseClaimController : ApiController
    {

        /// <summary>
        /// Receive and process block of string containing xml data.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public IHttpActionResult Post([FromBody]string value)
        {
            if (!XmlValidator.Validate(value))
                return BadRequest("Invalid XML form!");

            Guid rowId = Guid.Empty;
            using (VendorReservationRepository repo = new VendorReservationRepository())
            {
                rowId = repo.ProcessXMLData(value);
            }
            return Ok<string>("Well done!");            
        }

    }
}
