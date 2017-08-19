using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ETDA.Invoice.Api.Helpers;

namespace ETDA.XMLGenerator.UnitTests
{
    [TestClass]
    public class DateHelperTests
    {
        [TestMethod]
        public void TestConvert_ValidDate_ReturnBuddhistEraDateTime()
        {
            var validDateTimes = new[] { "27/04/2560", "27-04-2560", "2560-04-27", "2560/04/27" };                       
         
            Array.ForEach(validDateTimes, dateTime =>
            {
                var actual = DateHelper.ConvertToDateTime(dateTime);
                
                var expected = new DateTime(2017, 04, 27);
                Assert.AreEqual(expected, actual);
            });
        }

        [TestMethod]
        public void TestConvert_InvalidDate_ReturnDateTimeAsWrongYear()
        {
            var validDateTimes = new[] { "27/04/2017", "27-04-2017", "2017-04-27", "2017/04/27" };

            Array.ForEach(validDateTimes, dateTime =>
            {
                var actual = DateHelper.ConvertToDateTime(dateTime);

                var expected = new DateTime(2017, 04, 27);
                Assert.AreNotEqual(expected, actual);
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvert_WithNull_ThrowArgumentException()
        {
            DateHelper.ConvertToDateTime(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvert_WithEmpty_ThrowArgumentException()
        {
            DateHelper.ConvertToDateTime(string.Empty);
        }

        [TestMethod]
        public void TestGetThaiDateText_WithNull_ReturnNull()
        {
            var actual = DateHelper.GetThaiDateText(null);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void TestGetThaiDateText_WithEmpty_ReturnNull()
        {
            var actual = DateHelper.GetThaiDateText(string.Empty);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void TestGetThaiDateText_WithValidDate_ReturnNull()
        {
            var actual = DateHelper.GetThaiDateText("05/04/2560");
            var expected = "05 เมษายน 2560";
            Assert.AreEqual(expected, actual);
        }
    }
}
