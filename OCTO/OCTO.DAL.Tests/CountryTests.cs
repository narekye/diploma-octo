using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCTO.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCTO.DAL.Tests
{
    [TestClass]
    public class CountryTests
    {
        [TestMethod]
        public void FillCountries()
        {
            using (var context = new OctoContext())
            {
                context.Countries.Add(new Country { Name = "Armenia" });
                context.SaveChanges();
            }
        }
    }
}
