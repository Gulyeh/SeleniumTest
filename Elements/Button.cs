using OpenQA.Selenium;
using Task3_1.Bases;

namespace Task3_1.Elements
{
    public class Button : BaseElement
    {
        public Button(By Locator, string name) : base(Locator, name)
        {
        }
    }
}