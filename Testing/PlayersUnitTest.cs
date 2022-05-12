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
            //���������
            context.Delete(player);
            //���������
            context.Create(player);
        }


        [TestMethod]
        public void CreateTest()
        {
            //������������� 
            Assert.IsNotNull(context.Read(0));
        }
        [TestMethod]
        public void ReadTest()
        {
            //�������
            var data = context.Read(0);

            //������� 
            Assert.AreEqual(21, data.Age);
        }
        [TestMethod]
        public void UpdateTest()
        {
            //�������
            var newplayer = new Player("Hristo", "Fikiin", 18, "HristoFikiin", "HristoFikiin123", "hristofikiin_j18@schoolmath.eu");
            context.Update(newplayer);

            //������������� 
            Assert.AreEqual("Hristo", context.Read(0).First_name);
        }
        [TestMethod]
        public void DeleteTest()
        {
            //������� 
            context.Delete(0);

            Assert.IsNull(context.Read(0));
        }
        [TestMethod]
        public void ReadAllTest()
        {
            //�������
            Assert.IsNotNull(context.ReadAll());
        }
    }
}
