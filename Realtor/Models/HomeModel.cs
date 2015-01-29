using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using RealtorLogic.RealtorManagers;
using RealtorData;

namespace Realtor.Models
{
    public class HomeModel 
    {
        //
        // GET: /HomeModel/

        
    }
    public class InscriptionsListModel
    {
        public List<String> InscriptionsList { get; set; }


    }

}
