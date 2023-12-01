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
            var Bob = new Coach("Bob", "������ 5 ������");
            
            Bob.AddClient(client1);
            Bob.AddClient(client2);
            
            string[] expected =
            {
                "������ �������� ��� ������� Bob:",
                "���: Kate, ���: women, �������: 18, ���: 55, ����: 168",
                "���: Egor, ���: men, �������: 19, ���: 85, ����: 180"

            };

            var sw = new StringWriter();
            Console.SetOut(sw);

            Bob.PrintClientList();

            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);


        }
    }
}