using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using BussinesLayer;

namespace Testing
{
    [TestClass]
    public class PlayersUnitTest
    {
        PlayerContext context;
        Player player;

        [TestInitialize]
        public void Setup()
        {
            var context = new PlayersDBContext();
            var _context = new PlayerContext(context);
            this.context = _context;

            Player user = new Player("Hristo", "Stefanov", 18, "HristoStefanov", "HristoStefanov123", "hristostefanov@gmail.com");
            player = user;
        }
        [TestCleanup]
        public void CleanUp()
        {
            //Изтриване
            context.Delete(player);
            //Създаване
            context.Create(player);
        }


        [TestMethod]
        public void CreateTest()
        {
            //Потвърждаване 
            Assert.IsNotNull(context.Read(0));
        }
        [TestMethod]
        public void ReadTest()
        {
            //Вършене
            var data = context.Read(0);

            //Вършене 
            Assert.AreEqual(21, data.Age);
        }
        [TestMethod]
        public void UpdateTest()
        {
            //Вършене
            var newplayer = new Player("Hristo", "Fikiin", 18, "HristoFikiin", "HristoFikiin123", "hristofikiin_j18@schoolmath.eu");
            context.Update(newplayer);

            //Потвърждаване 
            Assert.AreEqual("Hristo", context.Read(0).First_name);
        }
        [TestMethod]
        public void DeleteTest()
        {
            //Вършене 
            context.Delete(0);

            Assert.IsNull(context.Read(0));
        }
        [TestMethod]
        public void ReadAllTest()
        {
            //Вършене
            Assert.IsNotNull(context.ReadAll());
        }
    }
}
