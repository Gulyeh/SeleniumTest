using OpenQA.Selenium;
using System.Linq;
using Task3_1.Bases;
using Task3_1.Driver;
using Task3_1.Elements;
using Task3_1.Models;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class WebTablesPage : BaseForm
    {
        private readonly IWebDriver driver;

        public WebTablesPage() : base(new TextField(By.XPath("//div[contains(text(), 'Web Tables')]"), "WebTablesPage Unique Element"), "Web Tables")
        {
            driver = SeleniumDriver.GetDriver();
        }

        private Button addButton = new Button(By.XPath("//button[@id='addNewRecordButton']"), "Add");
        private Button submitButton = new Button(By.XPath("//button[@id='submit']"), "Submit");
        private TextBox firstNameTextBox = new TextBox(By.XPath("//input[@id='firstName']"), "First Name");
        private TextBox lastNameTextBox = new TextBox(By.XPath("//input[@id='lastName']"), "Last Name");
        private TextBox emailTextBox = new TextBox(By.XPath("//input[@id='userEmail']"), "Email");
        private TextBox ageTextBox = new TextBox(By.XPath("//input[@id='age']"), "Age");
        private TextBox salaryTextBox = new TextBox(By.XPath("//input[@id='salary']"), "Salary");
        private TextBox departmentTextBox = new TextBox(By.XPath("//input[@id='department']"), "Department");
        private By formLocator = By.XPath("//div[@id='registration-form-modal']");
        private By deleteLocator = By.XPath(".//span[contains(@id, 'delete-record')]");
        private By filledRowsLocator = By.XPath(".//div[(contains(@class, '-odd') or contains(@class, '-even')) and not(contains(@class, '-padRow'))]");
        private By emailLocator = By.XPath(".//div[contains(text(), '@')]");


        public void WaitAndClickAddButton()
        {
            WaitConditionals.WaitForDisplayed(addButton);
            addButton.Click();
        }

        public void WaitAndClickFormSubmitButton()
        {
            WaitConditionals.WaitForDisplayed(submitButton);
            submitButton.Click();
        }

        public bool IsRegistrationFormOpen() => driver.FindElements(formLocator).Count != 0;

        public void FillForm(RegistrationModel model)
        {
            firstNameTextBox.TypeText(model.FirstName);
            lastNameTextBox.TypeText(model.LastName);
            emailTextBox.TypeText(model.Email);
            ageTextBox.TypeText(model.Age);
            salaryTextBox.TypeText(model.Salary);
            departmentTextBox.TypeText(model.Department);
        }

        public bool IsUserAddedToTheTable(RegistrationModel model) => FindUserInTable(model) is not null;

        public int GetNumberOfFilledRows() => driver.FindElements(filledRowsLocator).Count;

        public void RemoveUserFromTable(RegistrationModel model)
        {
            var user = FindUserInTable(model);
            if (user is null) return;

            var deleteButton = user.FindElements(deleteLocator).FirstOrDefault();
            deleteButton?.Click();
        }

        private IWebElement? FindUserInTable(RegistrationModel model)
        {
            var list = driver.FindElements(filledRowsLocator);
            foreach (var item in list)
            {
                var email = item.FindElements(emailLocator).FirstOrDefault()?.Text;
                if (string.Equals(email, model.Email)) return item;
            }
            return null;
        }
    }
}