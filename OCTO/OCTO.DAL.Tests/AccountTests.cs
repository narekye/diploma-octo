using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCTO.DAL.Filters;
using OCTO.DAL.Models;
using OCTO.DAL.Repositories;

namespace OCTO.DAL.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void GetByFilterTest()
        {
            using (var context = new OctoContext())
            {
                var repo = new AccountRepository(context);

                var filter = new AccountFilter
                {
                    Id = 1
                };

                var items = repo.GetByFilterAsync(filter).GetAwaiter().GetResult();

            }
        }

        [TestMethod]
        public void InitializeSalutations()
        {
            using (var context = new OctoContext())
            {
                var account = new Account
                {
                    Name = "Second account",
                    CountryId = 1
                };

                context.Accounts.Add(account);
                context.SaveChanges();
            }
        }
    }
}
