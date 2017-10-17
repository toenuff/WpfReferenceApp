using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1;
using System.Windows.Input;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorViewModelTest
    {
        [TestMethod]
        public void CanCreateCalculatorViewModel()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
        }
        [TestMethod]
        public void CanInputSum()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            viewModel.input = "1+1";
            Assert.AreEqual("1+1", viewModel.input);
        }
        [TestMethod]
        public void CanCalculate()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            ICommand command = viewModel.CalculateCommand;
            command.Execute(null);
        }

        [TestMethod]
        public void CanCalculateOnePlusOne()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            viewModel.input = "1+1";
            ICommand command = viewModel.CalculateCommand;
            command.Execute(null);
            Assert.AreEqual(2, viewModel.Result);
        }
        [TestMethod]
        public void ResultNotificationIsFired()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            bool hasFired = false;
            viewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "Result")
                {
                    hasFired = true;
                }
            };
            viewModel.input = "1+1";
            ICommand command = viewModel.CalculateCommand;
            command.Execute(null);
            Assert.IsTrue(hasFired);
        }
    }
}
