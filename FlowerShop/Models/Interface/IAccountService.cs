﻿namespace FlowerShop.Models.Interface;

public interface IAccountService
{
    public Account GetAccountByUsername(string username);
    public Account GetAccountByUsernameNoTracking(string username);
    public bool AddAccount(Account account);
    public bool CheckAccount(string username);
    public bool UpdateAccount(Account account);

    public bool CheckLogin(string username, string password);

}
