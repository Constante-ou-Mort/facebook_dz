using System;
using TechTalk.SpecFlow;

namespace ConsoleApp5
{
    [Binding]
    public class FacebookManePageSteps : RegistrationPom
    {
        [Given(@"Facebook main page is opened")]
        public void GivenFacebookMainPageIsOpened()
        {
            goToPage();
        }
        
        [When(@"I input '(.*)' in name field")]
        public void WhenIInputInNameField(string name)
        {
            fillNameField(name);
        }
        
        [When(@"I input '(.*)' in last name field")]
        public void WhenIInputInLastNameField(string lastName)
        {
            fillLastName(lastName);
        }
        
        [When(@"I input '(.*)' in number field")]
        public void WhenIInputInNumberField(string number)
        {
            fillPhoneNumberOrEmailField(number);
        }
        
        [When(@"I input '(.*)' in password field")]
        public void WhenIInputInPasswordField(string password)
        {
            fillPasswordRegistration(password);
        }
        
        [When(@"I choose '(.*)' in day list")]
        public void WhenIChooseInDayList(string day)
        {
            fillDay(day);
        }
        
        [When(@"I choose '(.*)' in month list")]
        public void WhenIChooseInMonthList(string month)
        {
            fillMonth(month);
        }
        
        [When(@"I choose '(.*)' in year list")]
        public void WhenIChooseInYearList(string year)
        {
            fillYear(year);
        }
        
        [When(@"I choose gender")]
        public void WhenIChooseGender()
        {
            clickFemaleButton();
        }
        
        [When(@"I click on the Registration button")]
        public void WhenIClickOnTheRegistrationButton()
        {
            clickRegistrationButton();
        }
    }
}
