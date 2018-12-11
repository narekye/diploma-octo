using System;
using System.Collections.Generic;
using System.Text;

namespace OCTO.BLL.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
        public string Notes { get; set; }

        public int CountryId { get; set; }
    }
}
