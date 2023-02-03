using OpenQA.Selenium;
using Task3_1.Bases;

namespace Task3_1.Elements
{
    public class TextField : BaseElement
    {
        public TextField(By Locator, string name) : base(Locator, name)
        {

        }
    }
}