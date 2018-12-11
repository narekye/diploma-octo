namespace OCTO.BLL.Models.Filters
{
    public class AccountFilterModel
    {
        public int? Id { get; set; }
        public string Zip { get; set; }
        public string Name { get; set; }

        public int? CountryId { get; set; }
    }
}
