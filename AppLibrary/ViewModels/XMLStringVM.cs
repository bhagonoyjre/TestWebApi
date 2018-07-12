using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AppLibrary.ViewModels
{
    public class XMLStringVM
    {
        [AllowHtml]
        public String XMLString { get; set; }
    }
}