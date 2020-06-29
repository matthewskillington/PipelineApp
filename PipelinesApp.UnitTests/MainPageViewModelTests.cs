using System;
using PipelineApp;
using Xunit;

namespace PipelinesApp.UnitTests
{
    public class MainPageViewModelTests
    {
        [Fact]
        public void EntryTextString_InitializesProperly()
        {
            //Arrange:
            var vm = new MainPageViewModel("Click me");

            //Assert:
            Assert.Equal(vm.EntryText, "Enter some text to change the button");
        }

        [Fact]
        public void ButtonText_OnPress_ChangesToInputText()
        {
            //Arrange:
            var vm = new MainPageViewModel("Click me");

            //Act:
            vm.EntryText = "Some new text";
            vm.ButtonClickedCommand.Execute(null);

            Assert.Equal(vm.ButtonText, "Some new text");
            Assert.Equal(vm.ButtonText, vm.EntryText);
        }
    }
}
