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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static RegexLibrary.InputValidation;

namespace RegexLibraryTest
{
    [TestClass]
    public class InputValidationTest
    {
        [TestMethod]
        public void DigitsTest()
        {
            Assert.IsTrue(Digits("12345"));
            Assert.IsFalse(Digits("1d3f4"));
            Assert.IsFalse(Digits("123"));
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.IsTrue(Name("James LoForti"));
            Assert.IsFalse(Name("Mr Roger Dunderfield the first"));
            Assert.IsFalse(Name("J@mes L0F0rti"));
        }

        [TestMethod]
        public void MiddleInitialTest()
        {
            Assert.IsTrue(MiddleInitial("A"));
            Assert.IsFalse(MiddleInitial("a"));
            Assert.IsFalse(MiddleInitial("AB"));
        }

        [TestMethod]
        public void DeptTitleTest()
        {
            Assert.IsTrue(DeptTitle("Operations Mgmt"));
            Assert.IsFalse(DeptTitle("0perations"));
        }

        [TestMethod]
        public void CompensationTest()
        {
            Assert.IsTrue(Compensation("0.10"));
            Assert.IsTrue(Compensation("12,300"));
            Assert.IsFalse(Compensation("18.00.0"));
        }

        [TestMethod]
        public void AlphaNumericsTest()
        {
            Assert.IsTrue(AlphaNumerics("1d5f4d6"));
            Assert.IsFalse(AlphaNumerics("test space"));
            Assert.IsFalse(AlphaNumerics("1#456"));
        }

        [TestMethod]
        public void CourseDescTest()
        {
            Assert.IsTrue(CourseDesc("C++"));
            Assert.IsFalse(CourseDesc("Web_Programming #2"));
            Assert.IsFalse(CourseDesc("Test space+"));
        }
    } // end class InputValidationTest
} // end namespace RegexLibraryTest
