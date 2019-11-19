﻿using System;
using System.Reflection;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using RestSharp;

namespace Mobile.Nunit.Tests
{
    [TestFixture]
    public class MobileBrowserIOSTests : BaseMobileTest
    {
        [Test]
        public void MobileBrowser_iOS12_ShouldPass()
        {
            browserCapabilities.SetCapability("platformVersion", "12.4");
            browserCapabilities.SetCapability("platformName", "iOS");
            _driver = new RemoteWebDriver(new Uri(RdcServerUrlUs), browserCapabilities,
                TimeSpan.FromSeconds(600));
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
            Assert.IsTrue(_driver.Url.Contains("saucedemo.com"));
        }
        [Test]
        public void MobileBrowser_iOS13_2_ShouldPass()
        {
            browserCapabilities.SetCapability("platformVersion", "13.2");
            browserCapabilities.SetCapability("platformName", "iOS");
            _driver = new RemoteWebDriver(new Uri(RdcServerUrlUs), browserCapabilities,
                TimeSpan.FromSeconds(600));
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
            Assert.IsTrue(_driver.Url.Contains("saucedemo.com"));
        }
        [Test]
        public void MobileBrowser_iOS11_4_1_ShouldPass()
        {
            browserCapabilities.SetCapability("platformVersion", "11.4.1");
            browserCapabilities.SetCapability("platformName", "iOS");
            _driver = new RemoteWebDriver(new Uri(RdcServerUrlUs), browserCapabilities,
                TimeSpan.FromSeconds(600));
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
            Assert.IsTrue(_driver.Url.Contains("saucedemo.com"));
        }
    }
}