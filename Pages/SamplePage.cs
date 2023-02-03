using OpenQA.Selenium;
using Task3_1.Bases;
using Task3_1.Elements;

namespace Task3_1.Pages
{
    public class SamplePage : BaseForm
    {
        public SamplePage() : base(new TextField(By.XPath("//h1[text()='This is a sample page']"), "SamplePage Unique Element"), "Sample")
        {
        }
    }
}