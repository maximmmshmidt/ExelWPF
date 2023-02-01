using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1.Controlers;

namespace TestWpfApp
{
    [TestClass]
    public class TestClassRegistration
    {
        //проверка при регестрации 
        [TestMethod]
        public void Cheack_Registration_IsNull()
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
        public void Cheack_Registration_SpecialCharacters()
        {
            //Arrange
            string login, password, passwordTwo;
            login = "@#$%";
            password = "(!!)";
            passwordTwo = "@ ";
            //Act
            bool actual = UsersControlers.Registrration(login, password, passwordTwo);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Cheack_Registration_Space()
        {
            //Arrange
            string login, password, passwordTwo;
            login = " ";
            password = " ";
            passwordTwo = " ";
            //Act
            bool actual = UsersControlers.Registrration(login, password, passwordTwo);
            //Assert
            Assert.IsFalse(actual);
        }
        //проверка на дабовление студента 
        [TestMethod]
        public void Cheack_AddStident_Space()
        {
            //Arrange
            string login, password, passwordTwo;
            login = " ";
            password = " ";
            passwordTwo = " ";
            //Act
            bool actual = UsersControlers.Registrration(login, password, passwordTwo);
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
