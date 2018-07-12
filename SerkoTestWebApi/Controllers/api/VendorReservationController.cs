using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using AppLibrary.Utilities;
using SerkoTestWebApi.Models.Repositories;

namespace SerkoTestWebApi.Controllers.api
{

    /// <summary>
    /// Vendor reservations method and processes.
    /// </summary>
    public class VendorReservationController : ApiController
    {

        /// <summary>
        /// Receive and process block of string containing xml data.
        /// </summary>
        /// <param name="value">Block of string which contains xml data.</param>
        /// <returns>Returns newly created row id if successful.</returns>
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
