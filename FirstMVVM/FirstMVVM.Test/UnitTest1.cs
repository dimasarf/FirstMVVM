using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstMVVM.Models;

namespace FirstMVVM.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Xamarin.Forms
            Account account = new Account()
            {
                Username = "Dimas",
                Password = "muhaimin",
                Email = "dimas@yahoo.com"
            };
            App.AccountDb.CreateAccount(account);
        }
    }
}
