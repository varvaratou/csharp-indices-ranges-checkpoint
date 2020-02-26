using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpIndicesRangesCheckpoint
{
    [TestClass]
    public class TestsBefore
    {
        readonly string[] GRADES = new string[]
            {
                "A", "B", "C", "D", "F"
            };

        [TestMethod]
        public void GetGradeFromEnd_WhenCalledWithValidNumber_ShouldReturnGradeFromEnd()
        {
            string result = getGradeFromEnd(4);

            Assert.AreEqual("B", result);
        }

        private string getGradeFromEnd(int indexFromEnd)
        {
            string item = GRADES[GRADES.Length - indexFromEnd];
            return item;
        }

        [TestMethod]
        public void GetGradeRange_WhenCalledWithStartAndEndIndex_ShouldReturnGradeRange()
        {
            string[] result = getGradeRange(1, 3);

            CollectionAssert.AreEqual(new string[] { "B", "C", "D" }, result);
        }

        private string[] getGradeRange(int startIndex, int endIndex)
        {
            var length = endIndex - startIndex + 1;
            var result = GRADES.Skip(startIndex).Take(length).ToArray();
            return result;
        }
    }
}
