using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp5
{
    public class RegistrationPom : SeleniumWrapper
    {
        //internal static By emailOrNumberLogInField = By.Id("email");
        //internal static By passwordLogInField = By.Id("pass");
        //internal static By logInButton = By.Id("u_0_8");
        //internal static By forgotPassword = By.XPath("//*[@id=\"login_form\"]/table/tbody/tr[3]/td[2]/div/a");
        internal static By nameField = By.Name("firstname");
        internal static By lastNameField = By.Name("lastname");
        internal static By phoneNumberOrEmailField = By.Name("reg_email__");
        internal static By passwordRegistration = By.Name("reg_passwd__");
        internal static By emailRepeat = By.CssSelector("#u_0_v");
        internal static By day = By.Id("day");
        internal static By month = By.Id("month");
        internal static By year = By.Id("year");
        internal static By femaleButton = By.ClassName("_58mt");
        internal static By maleButton = By.Id("u_0_7");
        internal static By registrationButton = By.Name("websubmit");

        public void goToPage()
        {
            OpenPage("https://www.facebook.com/");
        }

        //public RegistrationPom fillEmailOrNumberLogin(string email)
        //{
        //    FindElement(emailOrNumberLogInField).SendKeys(email);
        //    return this;
        //}
        //public RegistrationPom fillPasswordLogInField(string passwordLogIN)
        //{
        //    FindElement(emailOrNumberLogInField).SendKeys(passwordLogIN);
        //    return this;
        //}
        //public void clickLogIn()
        //{
        //    FindElement(logInButton).Click();
        //}
        //public void clickForgotPassword()
        //{
        //    FindElement(forgotPassword).Click();
        //}
        public RegistrationPom fillNameField(string name)
        {
            FindElement(nameField).SendKeys(name);
            return this;
        }
        public RegistrationPom fillLastName(string lastName)
        {
            FindElement(lastNameField).SendKeys(lastName);
            return this;
        }
        public RegistrationPom fillPhoneNumberOrEmailField(string email)
        {
            FindElement(phoneNumberOrEmailField).SendKeys(email);
            return this;
        }
        public RegistrationPom fillPasswordRegistration(string password)
        {
            FindElement(passwordRegistration).SendKeys(password);
            return this;
        }
        public RegistrationPom fillEmailRepeat(string email)
        {
            FindElement(emailRepeat).SendKeys(email);
            return this;
        }
        //ПОМЕНЯТЬ СО СТРИНГ В ИНТ если не сработает
        public RegistrationPom fillDay(string day)
        {
            new SelectElement(FindElement(By.Id("day"))).SelectByText(day);
            return this;
        }
        public RegistrationPom fillMonth(string month)
        {
            new SelectElement(FindElement(By.Id("month"))).SelectByText(month);
            return this;
        }
        public RegistrationPom fillYear(string year)
        {
            new SelectElement(FindElement(By.Id("year"))).SelectByText(year);
            return this;
        }
        public void clickFemaleButton()
        {
            FindElement(femaleButton).Click();
        }
        public void clickRegistrationButton()
        {
            FindElement(registrationButton).Click();
        }










    }
}
