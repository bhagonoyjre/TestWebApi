using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Xml.Linq;

using AppLibrary.ViewModels;

namespace AppLibrary.Utilities
{

    /// <summary>
    /// This class validates an xml string.
    /// </summary>
    public class XmlValidator
    {
        /// <summary>
        /// Validates if the xml is well formed.
        /// </summary>
        /// <param name="xmlString">The xml string receive.</param>
        /// <returns>TRUE, when valid xml; FALSE, otherwise.</returns>
        public static bool Validate(string xmlString)
        {
            var model = new ExpenseClaimVM();
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(xmlString);
                XmlNodeList xnList = xdoc.SelectNodes("/");
                foreach (XmlNode xn in xnList)
                {
                    XmlNode anode = xn.SelectSingleNode("expense");
                    if (anode != null)
                    {
                        model.CostCentre = string.IsNullOrEmpty(anode["cost_centre"].InnerText) ? "UNKNOWN" : anode["cost_centre"].InnerText;
                        model.Total = string.IsNullOrEmpty(anode["total"].InnerText) ? 0 : decimal.Parse(anode["total"].InnerText);
                        model.PaymentMethod = anode["payment_method"].InnerText;
                    }
                }
                // Validate returned total value.
                return (model.Total > 0);
            }
            catch(Exception ex)
            {
                string errMsg = ex.Message;
                return false;
            }
        }
        
    }
}