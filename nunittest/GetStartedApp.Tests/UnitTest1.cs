using NUnit.Framework;
using GetStartedApp.ViewModels;

namespace GetStartedApp.Tests
{
    public class MainWindowViewModelTests
    {
        [Test]
        public void Test_AddCommand_LargeIterations()
        {
            var viewModel = new MainWindowViewModel();
            int i = 10;
            int j = 5;
            viewModel.FirstNumber = i.ToString();
            viewModel.SecondNumber = j.ToString();

            viewModel.AddCommand.Execute(null);

            Assert.AreEqual((i + j).ToString(), viewModel.Result);
        }

        [Test]
        public void Test_SubtractCommand_LargeIterations()
        {
            var viewModel = new MainWindowViewModel();
            int i = 10;
            int j = 5;
            viewModel.FirstNumber = i.ToString();
            viewModel.SecondNumber = j.ToString();

            viewModel.SubtractCommand.Execute(null);

            Assert.AreEqual((i - j).ToString(), viewModel.Result);
        }

        [Test]
        public void Test_MultiplyCommand_LargeIterations()
        {
            var viewModel = new MainWindowViewModel();
            int i = 10;
            int j = 5;
            viewModel.FirstNumber = i.ToString();
            viewModel.SecondNumber = j.ToString();

            viewModel.MultiplyCommand.Execute(null);

            Assert.AreEqual((i * j).ToString(), viewModel.Result);
        }

        [Test]
        public void Test_DivideCommand_LargeIterations()
        {
            var viewModel = new MainWindowViewModel();
            int i = 10;
            int j = 5;
            viewModel.FirstNumber = i.ToString();
            viewModel.SecondNumber = j.ToString();

            viewModel.DivideCommand.Execute(null);

            Assert.AreEqual((i / (double)j).ToString(), viewModel.Result);
        }

        [Test]
        public void Test_ClearCommand_AfterOperations()
        {
            var viewModel = new MainWindowViewModel();

            viewModel.FirstNumber = "10";
            viewModel.SecondNumber = "5";

            viewModel.AddCommand.Execute(null);
            Assert.AreEqual("15", viewModel.Result);

            viewModel.ClearCommand.Execute(null);
            Assert.AreEqual(string.Empty, viewModel.FirstNumber);
            Assert.AreEqual(string.Empty, viewModel.SecondNumber);
            Assert.AreEqual(string.Empty, viewModel.Result);
        }
    }
}

