using NUnit.Framework;
using static System.Collections.Specialized.BitVector32;

namespace LabNUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // сравнение значений длинны отрезка
        [Test]
        public void Length_Returns_Correct_Length()
        {
            // ARRANGE
            Section section = new Section();
            section.Init(1, 2, 4, 6);

            // ACT
            double actualLength = section.Length();

            // ASSERT
            double expectedLength = Math.Sqrt(3 * 3 + 4 * 4);
            Assert.AreEqual(expectedLength, actualLength); 
        }

        // сравнение значений длинны отрезка out
        [Test]
        public void LengthOut_Set_Length_Correct()
        {
            // ARRANGE
            Section section = new Section();
            Section outputSection;

            section.Init(3, 4, 6, 10);

            // ACT
            section.LengthOut(out outputSection);

            // ASSERT
            double expectedLength = Math.Sqrt(3 * 3 + 6 * 6);
            Assert.AreEqual(expectedLength, outputSection.Length());
        }

        // сравнение значений длинны отрезка ref
        [Test]
        public void LengthRef_Set_Length_Correct()
        {
            // ARRANGE
            Section section = new Section();
            section.Init(2, 3, 5, 8);

            // ACT
            section.LengthRef(ref section);

            // ASSERT
            double expectedLength = Math.Sqrt(3 * 3 + 5 * 5);
            Assert.AreEqual(expectedLength, section.GetLenSec());
        }

        // проверка на сложение отрезков
        [Test]
        public void Add_Returns_Sum_Of_Segments()
        {
            // ARRANGE
            Section section1 = new Section();
            Section section2 = new Section();

            section1.Init(1, 2, 3, 4);
            section2.Init(5, 6, 7, 8);

            // ACT
            Section sumSection = section1.Add(section1, section2);

            // ASSERT
            Assert.AreEqual(1, sumSection.GetX1());
            Assert.AreEqual(2, sumSection.GetY1());
            Assert.AreEqual(7, sumSection.GetX2());
            Assert.AreEqual(8, sumSection.GetY2());
        }

        // проверка на корректность значения x1
        [Test]
        public void GetX1_Return_Correct_Coord_X1()
        {
            // ARRANGE
            Section section = new Section();
            section.Init(1, 2, 3, 4);

            // ACT
            double actualX1 = section.GetX1();

            // ASSERT
            Assert.AreEqual(1, actualX1);
        }

        // проверка на корректность значения y1
        [Test]
        public void GetY1_Return_Correct_Coord_Y1()
        {
            // ARRANGE
            Section section = new Section();
            section.Init(1, 2, 3, 4);

            // ACT
            double actualY1 = section.GetY1();

            // ASSERT
            Assert.AreEqual(2, actualY1);
        }

        // проверка на корректность значения x2
        [Test]
        public void GetX2_Return_Correct_Coord_X2()
        {
            // ARRANGE
            Section section = new Section();
            section.Init(1, 2, 3, 4);

            // ACT
            double actualX2 = section.GetX2();

            // ASSERT
            Assert.AreEqual(3, actualX2);
        }

        // проверка на корректность значения y2
        [Test]
        public void GetY2_Return_Correct_Coord_Y2()
        {
            // ARRANGE
            Section section = new Section();
            section.Init(1, 2, 3, 4);

            // ACT
            double actualY2 = section.GetY2();

            // ASSERT
            Assert.AreEqual(4, actualY2);
        }

        // проверка метода Init на корректность устанавливаемых значений
        [Test]
        public void Init_Set_Coords_Correct()
        {
            // ARRANGE
            Section section = new Section();

            // ACT
            section.Init(3, 4, 6, 9);

            // ASSERT
            Assert.AreEqual(3, section.GetX1());
            Assert.AreEqual(4, section.GetY1());
            Assert.AreEqual(6, section.GetX2());
            Assert.AreEqual(9, section.GetY2());
        }

        // проверка на то что метод IsHorizontal возвращает true, если отрезок горизонтален
        [Test]
        public void IsHorizontal_Return_True_If_Section_Horizontal()
        {
            // ARRANGE
            Section horizontalSection = new Section();
            horizontalSection.Init(1, 2, 5, 2);

            // ACT
            bool result = horizontalSection.IsHorizontal();

            // ASSERT
            Assert.IsTrue(result);
        }

        // проверка на то что метод IsHorizontal возвращает false, если отрезок не горизонтален.
        [Test]
        public void IsHorizontal_Return_False_If_Section_NotHorizontal()
        {
            // ARRANGE
            Section nonHorizontalSection = new Section();
            nonHorizontalSection.Init(1, 2, 5, 7);

            // ACT
            bool result = nonHorizontalSection.IsHorizontal();

            // ASSERT
            Assert.IsFalse(result);
        }

    }
}