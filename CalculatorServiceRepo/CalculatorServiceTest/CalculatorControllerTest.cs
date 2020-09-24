using CalculatorService.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorServiceTest
{
    [TestClass]
    public class CalculatorControllerTest
    {
        [TestMethod]
        public void AddShouldReturnValidResultWhenInputIsValid()
        {
            var controller = new CalculatorController();
            
            var result = controller.Add(10, 20);

            var okResult = result.Result as OkObjectResult;
            Assert.IsInstanceOfType(result, typeof(ActionResult<decimal>));
            Assert.AreEqual(30M, okResult.Value);
            Assert.AreEqual(200, okResult.StatusCode);
        }

        [TestMethod]
        public void SubtractShouldReturnValidResultWhenInputIsValid()
        {
            var controller = new CalculatorController();

            var result = controller.Subtract(10, 20);

            var okResult = result.Result as OkObjectResult;
            Assert.IsInstanceOfType(result, typeof(ActionResult<decimal>));
            Assert.AreEqual(-10M, okResult.Value);
            Assert.AreEqual(200, okResult.StatusCode);
        }

        [TestMethod]
        public void MultiplyShouldReturnValidResultWhenInputIsValid()
        {
            var controller = new CalculatorController();

            var result = controller.Multiply(10, 20);

            var okResult = result.Result as OkObjectResult;
            Assert.IsInstanceOfType(result, typeof(ActionResult<decimal>));
            Assert.AreEqual(200M, okResult.Value);
            Assert.AreEqual(200, okResult.StatusCode);
        }

        [TestMethod]
        public void DivideShouldReturnValidResultWhenInputIsValid()
        {
            var controller = new CalculatorController();

            var result = controller.Divide(10, 20);

            var okResult = result.Result as OkObjectResult;
            Assert.IsInstanceOfType(result, typeof(ActionResult<decimal>));
            Assert.AreEqual(0.5M, okResult.Value);
            Assert.AreEqual(200, okResult.StatusCode);
        }
    }
}
