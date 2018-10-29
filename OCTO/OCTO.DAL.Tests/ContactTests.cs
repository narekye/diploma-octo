using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCTO.DAL.Models;
using OCTO.DAL.Repositories;
using OCTO.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCTO.DAL.Tests
{
    [TestClass]
    public class ContactTests
    {
        private IContactRepository _contactRepository;

        [TestInitialize]
        public void Initialize()
        {
            var context = new OctoContext();
            _contactRepository = new ContactRepository(context);
        }

        [TestMethod]
        public void AddContact()
        {
            var contact = new Contact
            {
                AccountId = 1,
                CountryId = 1,
                Email = "sampleEmail@mail.com",
                FirstName = "Bob",
                LastName = "Jones",
                SalutationId = 1,
                DecisionMaker = false,
                Department = "Office",
                City = "Yerevan"
            };
            _contactRepository.EnsureTransaction();

            _contactRepository.Add(contact);
            var saveResult = _contactRepository.SaveChangesAsync();

            var taskResult = saveResult.Result;

            Assert.IsTrue(saveResult.IsCompleted);
        }
    }
}
