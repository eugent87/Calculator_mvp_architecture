using Moq;
using Calculator;
using NUnit.Framework;

namespace TestProjectCalculator
{
    [TestFixture]
    public class CalculatorPresenterTests
    {
        private Calculator_Presenter _presenter;
        private Mock<ICalculator_View> _mockView;
        private Calculator_Mod _model;

        [SetUp]
        public void Setup()
        {
            _mockView = new Mock<ICalculator_View>();
            _model = new Calculator_Mod();
            _presenter = new Calculator_Presenter(_mockView.Object, _model);
        }

        [Test]
        public void OnNumberButtonClicked_DisplaysNumber()
        {
            // Arrange
            string number = "5";
            _mockView.SetupProperty(v => v.DisplayText, "0");

            // Act
            _mockView.Raise(v => v.Number_button += null, this, number);

            // Assert
            Assert.AreEqual("5", _mockView.Object.DisplayText);
            
        }

        [Test]
        public void OnOperationButtonClicked_StoresFirstNumberAndOperation()
        {
            // Arrange
            _mockView.SetupProperty(v => v.DisplayText, "12");

            // Act
            _mockView.Raise(v => v.Operation += null, this, "+");

            // Assert
            Assert.AreEqual("12", _mockView.Object.DisplayText);
            // ѕровер€ем, что операци€ сохран€етс€ в презентере
        }

        [Test]
        public void OnEqualsButtonClicked_PerformsOperationAndDisplaysResult()
        {
            // Arrange
            _mockView.SetupProperty(v => v.DisplayText, "10");
            _mockView.Raise(v => v.Operation += null, this, "+");
            _mockView.SetupProperty(v => v.DisplayText, "20");

            // Act
            _mockView.Raise(v => v.Calculate += null, this, EventArgs.Empty);

            // Assert
            Assert.AreEqual("30", _mockView.Object.DisplayText);
        }

        [Test]
        public void OnClearButtonClicked_ClearsDisplay()
        {
            // Arrange
            _mockView.SetupProperty(v => v.DisplayText, "123");

            // Act
            _mockView.Raise(v => v.Clear += null, this, EventArgs.Empty);

            // Assert
            Assert.AreEqual("0", _mockView.Object.DisplayText.ToString());
        }
        //[Test]
        //public void OnInvalidOperation_DisplayErrorIsCalled()
        //{
        //    // Arrange
        //    _mockView.SetupProperty(v => v.DisplayText, "10");
        //    _mockView.Raise(v => v.Operation += null, this, "/");
        //    _mockView.SetupProperty(v => v.DisplayText, "0");

        //    // Act
        //    _mockView.Raise(v => v.Calculate += null, this, EventArgs.Empty);

        //    // Assert
        //    _mockView.Verify(v => v.DisplayText = It.Is<string>(s => s.Contains("Error")), Times.Once);
        //}

        [Test]
        public void OnInvalidOperation_DisplayErrorIsCalled()
        {
            // Arrange
            _mockView.SetupProperty(v => v.DisplayText, "10");
            _mockView.Raise(v => v.Operation += null, this, "/");
            _mockView.SetupProperty(v => v.DisplayText, "0");

            // Act
            _mockView.Raise(v => v.Calculate += null, this, EventArgs.Empty);

            // Assert
            _mockView.VerifySet(v => v.DisplayText = It.Is<string>(s => s.Contains("Error")), Times.Once);
        }


    }
}
