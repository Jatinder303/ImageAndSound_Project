
using ImageAndSound_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Images_UnitTest_Project
{
    [TestClass]
    public class UnitTest_Image
    {
        LogicClass logic_obj = new LogicClass();
        int unit_result;
        [TestMethod]
        public void Test_spin_neg1()
        {
            int spin_unit_data = logic_obj.spin();
            Assert.AreNotEqual(0, spin_unit_data);
        }

        [TestMethod]
        public void test_spin_neg2()
        {
            int spin_unit_data = logic_obj.spin();
            Assert.AreNotEqual(7, spin_unit_data);
        }

        [TestMethod]
        public void test_spin_posi()
        {

            int spin_unit_data = logic_obj.spin();
            if (spin_unit_data >= 1 && spin_unit_data < 7)
            {
                unit_result = 1;
            }
            Assert.AreEqual(1, unit_result);
        }
    }
}
