using OpenQA.Selenium;
using Task3_1.Bases;

namespace Task3_1.Elements
{
    public class TextBox : BaseElement
    {
        private readonly string name;

        public TextBox(By Locator, string name) : base(Locator, name)
        {
            this.name = name;
        }

        public void TypeText(string text) => FindElement().SendKeys(text);

        public void ClearText() => FindElement().Clear();
    }
}