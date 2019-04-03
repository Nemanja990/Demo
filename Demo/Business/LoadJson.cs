using Demo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Demo.Business
{
    public static class LoadJson
    {
        public static List<Product> LoadAllProducts()
        {
            List<Product> products = null;
            try
            {
                var path = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/JsonProducts.json");
                using (StreamReader rdr = new StreamReader(path))
                {
                    string json = rdr.ReadToEnd();
                    products = JsonConvert.DeserializeObject<List<Product>>(json);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return products;
        }
    }
}