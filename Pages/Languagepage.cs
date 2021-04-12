using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA.Pages
{
    class Languagepage 
    {

        public void LanguageSteps(IWebDriver driver)
        {

            // click on language function
            driver.FindElement(By.XPath("//a[normalize-space()='Languages']")).Click();

            // click on add new button
            driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //click on add language
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("English");

            // click on choose level drop-down
            driver.FindElement(By.XPath("//select[@name='level']")).Click();

            // click on add button
            driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='form-wrapper']")).Click();

            // verify if the language record has created or not
            if (driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text == "English")
            {
                Console.WriteLine("Lnaguage created sucessfully,Test passed");
            }
            else
            {
                Console.WriteLine("language has not created sucessfully,Test faild");
            }

            

           

        }

       public void UpdateLanguage(IWebDriver driver)
       {
            // Write the lines of code that performes udatesteps

            //click on update language button
            driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();

            // enter language
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Germen");

            // update level of the language
            driver.FindElement(By.XPath("//tbody//select[@name='level']")).Click();

            // click on update button
            driver.FindElement(By.XPath("//input[@value='Update']")).Click();

            // verify the updated record
            if (driver.FindElement(By.XPath("//td[normalize-space()='Germen']")).Text == "Germen")
            {
                Console.WriteLine("Record has updated sucessfully,test passed");
            }
            else
            {
                Console.WriteLine("Recored has not updated successfuly, test faild");
            }

       }

        public void DeleteLanguage(IWebDriver driver)
        {
            // write the lines of code that performes deletesteps

            // ** Delete Recored

            // verify the delete record
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));

        }
    }
}
