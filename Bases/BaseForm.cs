using Task3_1.Utils;

namespace Task3_1.Bases
{
    public abstract class BaseForm
    {
        private readonly BaseElement uniqueElement;
        public readonly string name;

        protected BaseForm(BaseElement uniqueElement, string name)
        {
            this.uniqueElement = uniqueElement;
            this.name = name;
        }

        public bool IsPageOpen()
        {
            Logger.Info($"Checking if {name} page is opened");
            return uniqueElement.IsDisplayed();
        }
    }
}