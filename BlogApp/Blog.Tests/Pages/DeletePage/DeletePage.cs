﻿namespace Blog.Tests.Pages.DeletePage
{
    using Blog.Tests.Pages.Sections.Footer;
    using Blog.Tests.Pages.Sections.Header;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    public partial class DeletePage
    {
        private readonly IWebDriver _driver;
        private readonly string _baseUrl = @"http://localhost:60634/Article/Delete/";

        public DeletePage(IWebDriver driver)
        {
            _driver = driver;
            Header = new Header(_driver);
            Footer = new Footer(_driver);
        }

        public Header Header { get; private set; }
        public Footer Footer { get; private set; }

        public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        public void Navigate(int id) => _driver.Navigate().GoToUrl($"{_baseUrl}{id}");
    }
}
