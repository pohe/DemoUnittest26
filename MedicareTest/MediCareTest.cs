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
            Assert.AreEqual(expectedResult, actualResult, 0.01, "Fail 1145");

        }

        [TestMethod]
        public void SubsidisedExpenseTest0_0()
        {
            //Arrange

            MediCare mc = new MediCare();
            double expense = 0;
            double expectedResult = 0;
            //Act

            double actualResult = mc.SubsidisedExpense(expense);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, 0.01, "Fail 0");

        }


        [TestMethod]
        public void SubsidisedExpenseTestNegativeAmountException()
        {
            //Arrange

            MediCare mc = new MediCare();
            double expense = -100;

            //Act  & Assert

            Assert.ThrowsExactly<ArgumentException>(() =>
            {
                mc.SubsidisedExpense(expense);
            }
            );

        }

    }
}
