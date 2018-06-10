// ******************************************************************************************************************
//  Regex Library - a repo of useful regex expressions
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static RegexLibrary.Common;

namespace RegexLibraryTest
{
    [TestClass]
    public class CommonTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void PhoneNumbersTest()
        {
            Assert.IsTrue(PhoneNumbers("J. Doe: 248-555-1234"));
            Assert.IsTrue(PhoneNumbers("B. Smith: (313) 555-1234"));
            Assert.IsTrue(PhoneNumbers("A. Lee: (810)555-1234"));
            Assert.IsTrue(PhoneNumbers("M. Jones: 734.555.9999"));
        } // end method PhoneNumbersTest()
        
        [TestMethod]
        public void SocialSecurityTest()
        {
            Assert.IsTrue(SocialSecurity("John Smith: 123-45-6789"));
        } // end method SocialSecurityTest()

        [TestMethod]
        public void IPAddressTest()
        {
            Assert.IsTrue(IPAddress("localhost is 127.0.0.1."));
            Assert.IsFalse(IPAddress("deadend is: 270.300.5.1"));
        } // end method IPAddressTest()

        [TestMethod]
        public void IPAddressCollectionTest()
        {
            Assert.IsTrue(IPAddressCollection("localhost is: 127.0.0.1, server is: 169.58.218.1, proxy is: 105.28.17.14, deadend is: 270.300.5.1"));
        } // end method IPAddressCollectionTest()

        [TestMethod]
        public void ZipCodesTest()
        {
            Assert.IsTrue(ZipCodes("999 1st Avenue, Bigtown, NY, 11222"));
            Assert.IsTrue(ZipCodes("123 High Street, Any City, MI 48034-1234"));
        } // end method ZipCodesTest()

        [TestMethod]
        public void UrlTest()
        {
            Assert.IsTrue(Url(@"http://www.forta.com/blog"));
            Assert.IsTrue(Url(@"https://www.forta.com:80/blob/index.cfm"));
            Assert.IsTrue(Url(@"http://www.forta.com"));
            Assert.IsTrue(Url(@"http://ben:password@www.forta.com/"));
            Assert.IsTrue(Url(@"http://localhost/index.php?ab=1&c=2"));
            Assert.IsTrue(Url(@"http://localhost:8500/"));
        } // end method UrlTest()

        /// <summary>
        /// Data-Driven Unit Test - this example uses a local Sql DB as its data source.
        /// </summary>
        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\Code\C#\RegexLibrary\RegexLibrary\RegexLibraryTest\TestDB1.mdf;Integrated Security=True;Connect Timeout=30;", "dbo.Users", DataAccessMethod.Sequential)]
        [TestMethod]
        public void EmailTest()
        {
            Assert.IsTrue(Email(TestContext.DataRow["Email"].ToString())); // intentionally fails on rows 5 & 6
            Assert.IsTrue(Email("james@gmail.com"));
        } // end method EmailTest()

        [TestMethod]
        public void HtmlCommentsTest()
        {
            Assert.IsTrue(HtmlComments(@"<!-- Start of page --> <html> <!-- Start of head --> <head> <title>My Title</title> </head> <!-- Body --> <body>"));
        } // end method HtmlCommentsTest()

        [TestMethod]
        public void CCommentsTest()
        {
            Assert.IsTrue(CComments("//Main method public void Main() {} // end of main"));
        } // end method CCommentsTest()

        [TestMethod]
        public void CreditCardsTest()
        {
            //Assert.IsTrue(CreditCards("5212345678901234")); // MasterCard
            //Assert.IsTrue(CreditCards("4123456789012")); // Visa 1
            //Assert.IsTrue(CreditCards("4123456789012345")); // Visa 2
            //Assert.IsTrue(CreditCards("371234567890123")); // Amex
            //Assert.IsTrue(CreditCards("601112345678901234")); // Discover
            //Assert.IsTrue(CreditCards("38812345678901")); // Diner's Club
            Assert.IsFalse(CreditCards("0112568"));
        } // end method CreditCardsTest()

    } // end class CommonTest
} // end namespace RegexLibraryTest
