using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarioTest;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Project;
using System.Data;
using System.Xml;


namespace MarioTest
{
    [TestClass]
    public class MarioUnitTest
    {
        [TestMethod]
        public void TocenAdminUser()
        {
            DataTable testTabela = new DataTable();
            Login test = new Login();
            testTabela = test.login("Mario", "lozinka123");
            Assert.AreEqual("admin", testTabela.Rows[0][3].ToString());
        }

        [TestMethod]
        public void TocenObicenUser()
        {
            DataTable testTabela2 = new DataTable();
            Login test = new Login();
            testTabela2 = test.login("Jovan28", "jovan123");
            Assert.AreEqual("user", testTabela2.Rows[0][3].ToString());
        }

        [TestMethod]
        public void istoUsernamePass()
        {
            DataTable testTabela3 = new DataTable();
            Login test = new Login();
            testTabela3 = test.login("user1", "user1");
            Assert.AreEqual("user", testTabela3.Rows[0][3].ToString());
        }

      

        [TestMethod]
        public void adminNOTuser()
        {
            DataTable testTabela4 = new DataTable();
            Login test = new Login();
            testTabela4 = test.login("admin", "123456");
            Assert.AreNotEqual("user", testTabela4.Rows[0][3].ToString());
        }



        [TestMethod]
        public void userNOTadmin()
        {
            DataTable testTabela5 = new DataTable();
            Login test = new Login();
            testTabela5 = test.login("krste", "krsteski");
            Assert.AreNotEqual("admin", testTabela5.Rows[0][3].ToString());
        }

    }
}
