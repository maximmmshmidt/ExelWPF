using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1.Controlers;

namespace TestWpfApp
{
    [TestClass]
    public class TestClassRegistration
    {
        [TestMethod]
        public void Cheack_IsNull()
        {
            //Arrange
            string login, password, passwordTwo;
            login = "";
            password = "";
            passwordTwo = "";
            //Act
            bool actual = UsersControlers.Registrration(login, password, passwordTwo);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Cheack_IsNull()
        {
            //Arrange
            string login, password, passwordTwo;
            login = "";
            password = "";
            passwordTwo = "";
            //Act
            bool actual = UsersControlers.Registrration(login, password, passwordTwo);
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
