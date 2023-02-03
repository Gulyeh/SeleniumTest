using NUnit.Framework;
using OpenQA.Selenium;
using Task3_1.Driver;
using Task3_1.Models;
using Task3_1.Pages;
using Task3_1.Utils;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Task3_1.Steps
{
    [Binding]
    public class TablesStepDefinitions
    {
        private readonly MainPage mainPage;
        private readonly ElementsPage elementsPage;
        private readonly WebTablesPage webTablesPage;
        private readonly IWebDriver driver;
        private RegistrationModel registrationData { get; set; }
        private int numberOfRows { get; set; }

        public TablesStepDefinitions(MainPage mainPage, ElementsPage elementsPage, WebTablesPage webTablesPage)
        {
            this.mainPage = new MainPage();
            this.elementsPage = new ElementsPage();
            this.webTablesPage = new WebTablesPage();
            driver = SeleniumDriver.GetDriver();
            registrationData = new RegistrationModel();
        }

        [Given(@"Navigate to main page")]
        public void GivenNavigateToMainPage()
        {
            driver.Navigate().GoToUrl(Config.ConfigData.Url);
        }

        [When(@"I click on Elements button")]
        public void WhenIClickOnElementsButton()
        {
            mainPage.WaitAndClickElementsButton();
        }

        [When(@"I click on Web Tables button in the menu")]
        public void WhenIClickOnWebTablesButtonInTheMenu()
        {
            elementsPage.WaitAndClickWebTablesButton();
        }

        [Then(@"Page with Web Tables form is open")]
        public void ThenPageWithWebTablesFormIsOpen()
        {
            Assert.IsTrue(webTablesPage.IsPageOpen(), "Web Tables page is not open");
        }

        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            webTablesPage.WaitAndClickAddButton();
        }

        [Then(@"Registration Form has appeared on page")]
        public void ThenRegistrationFormHasAppearedOnPage()
        {
            Assert.IsTrue(webTablesPage.IsRegistrationFormOpen(), "Registration form is not open");
        }

        [When(@"I complete user data form")]
        public void WhenICompleteUserDataForm(Table table)
        {
            registrationData = table.CreateInstance<RegistrationModel>();
            webTablesPage.FillForm(registrationData);
        }

        [When(@"I click Submit button")]
        public void WhenIClickSubmitButton()
        {
            webTablesPage.WaitAndClickFormSubmitButton();
            WaitConditionals.WaitFor(x => !webTablesPage.IsRegistrationFormOpen());
        }

        [Then(@"Registration form has closed")]
        public void ThenRegistrationFormHasClosed()
        {
            Assert.IsFalse(webTablesPage.IsRegistrationFormOpen(), "Registration form is open");
        }


        [Then(@"User data has appeared in the table")]
        public void ThenUserDataHasAppearedInTheTable()
        {
            Assert.IsTrue(webTablesPage.IsUserAddedToTheTable(registrationData), "User does not exist in table");
            numberOfRows = webTablesPage.GetNumberOfFilledRows();
        }

        [When(@"I click delete button in a row which contains user data")]
        public void WhenIClickDeleteButtonInARowWhichContainsUserData()
        {
            webTablesPage.RemoveUserFromTable(registrationData);
        }

        [Then(@"Number of records in table has changed")]
        public void ThenNumberOfRecordsInTableHasChanged()
        {
            Assert.AreNotEqual(webTablesPage.GetNumberOfFilledRows(), numberOfRows);
        }

        [Then(@"User data has been deleted from table")]
        public void ThenUserDataHasBeenDeletedFromTable()
        {
            Assert.IsFalse(webTablesPage.IsUserAddedToTheTable(registrationData), "User still exists in table");
        }
    }
}
