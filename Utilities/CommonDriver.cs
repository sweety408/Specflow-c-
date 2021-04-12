using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace MarsQA.Utilities
{
    class CommonDriver
    {
        // Initialize common driver globally
        public static IWebDriver Driver { set; get; } 
    }
}
