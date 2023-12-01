namespace Poiis3.Tests
{
    [TestClass]
    public class CoachTests
    {

        [TestMethod()]
        public void PrintClientListTest()
        {
            var client1 = new Client("Kate", 18, 55, 168, "women",50);
            var client2 = new Client("Egor", 19, 85, 180, "men",75);
            var Bob = new Coach("Bob", "Тренер 5 уровня");
            
            Bob.AddClient(client1);
            Bob.AddClient(client2);
            
            string[] expected =
            {
                "Список клиентов для тренера Bob:",
                "Имя: Kate, Пол: women, Возраст: 18, Вес: 55, Рост: 168",
                "Имя: Egor, Пол: men, Возраст: 19, Вес: 85, Рост: 180"

            };

            var sw = new StringWriter();
            Console.SetOut(sw);

            Bob.PrintClientList();

            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);


        }
    }
}