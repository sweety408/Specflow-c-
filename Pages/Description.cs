using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA.Pages
{
    class Description
    {
        public void DescriptionSteps(IWebDriver driver)
        {
            // Click on Create discription icon
            driver.FindElement(By.XPath("//h3[normalize-space()='Description']")).Click();

            //Enter Discription Details
            driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).SendKeys("i have completed bacholer degree in computer application");

            // click on savebutton
            driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);

            // verify the discription
            driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        }

        public void UpdateDescription(IWebDriver driver)
        {
            // click on update description icon
            driver.FindElement(By.XPath("//h3[normalize-space()='Description']")).Click();

            //Update description
            driver.FindElement(By.XPath("//span[contains(text(),'my name is sweety Patel I have completed masters i')]")).SendKeys("");

            //click on save button
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //verify the updated language
            if (driver.FindElement(By.XPath("//div[@class='eight wide column']//div[@class='content']//div")).Text == "my name is sweety Patel I have completed masters in computer application")
            {
                Console.WriteLine("Description updated successfully,Test Passed");
            }
            else
            {
                Console.WriteLine("Description has not updated successfully,Test faild");
            }


        }

    }
}






          
