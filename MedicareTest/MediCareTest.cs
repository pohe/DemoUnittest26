using DemoUnittest26;

namespace MedicareTest
{
    [TestClass]
    public sealed class MediCareTest
    {
        [TestMethod]
        public void SubsidisedExpenseTest1145_1095()
        {
            //Arrange

            MediCare mc = new MediCare();
            double expense = 1145;
            double expectedResult = 1095;
            //Act

            double actualResult = mc.SubsidisedExpense(expense);

            //Assert
            Assert.AreEqual(expectedResult, actualResult)

        }
    }
}
