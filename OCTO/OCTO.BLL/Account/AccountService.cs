using AutoMapper;
using OCTO.BLL.Core;
using OCTO.BLL.Interfaces.Account;
using OCTO.BLL.Models;
using OCTO.BLL.Models.Filters;
using OCTO.DAL.Filters;
using OCTO.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.BLL.Account
{
    public class AccountService : ServiceBase, IAccountService
    {
        private IAccountRepository _accountRepository;
        private IMapper _mapper;

        public AccountService(IAccountRepository accountRepository, IMapper mapper) : base(accountRepository)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public async Task<AccountModel> GetAccountByIdAsync(int accountId)
        {
            var account = await _accountRepository.GetByIdAsync(accountId);
            var accountModel = _mapper.Map<AccountModel>(account);
            return accountModel;
        }

        public async Task<IEnumerable<AccountModel>> GetAccountsAsync()
        {
            var accounts = await _accountRepository.GetAllAsync();
            var models = _mapper.Map<IEnumerable<AccountModel>>(accounts);
            return models;
        }

        public async Task<IEnumerable<AccountModel>> GetAccountsAsync(AccountFilterModel accountFilterModel)
        {
            var accountFilter = _mapper.Map<AccountFilter>(accountFilterModel);
            var accounts = await _accountRepository.GetByFilterAsync(accountFilter);
            return _mapper.Map<IEnumerable<AccountModel>>(accounts);
        }
    }
}
