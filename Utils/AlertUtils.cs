using System;
using Task3_1.Driver;

namespace Task3_1.Utils
{
    public static class AlertUtils
    {
        public static bool AlertTextEqualsText(string? text)
        {
            try
            {
                Logger.Info($"Checking if {text} equals alert text");
                if (text is null) return false;

                return string.Equals(SeleniumDriver.GetDriver().SwitchTo().Alert().Text, text);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void AcceptAlert()
        {
            Logger.Info("Accepting alert");
            SeleniumDriver.GetDriver().SwitchTo().Alert().Accept();
        }

        public static bool AlertIsPresent()
        {
            try
            {
                Logger.Info("Checking if alert is present");
                SeleniumDriver.GetDriver().SwitchTo().Alert();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static void EnterTextIntoPrompt(string? text)
        {
            Logger.Info("Sending text into alert's prompt");
            SeleniumDriver.GetDriver().SwitchTo().Alert().SendKeys(text);
        }
    }
}