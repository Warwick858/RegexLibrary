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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexLibrary
{
    public static class InputValidation
    {
        public static bool Digits(string id)
        {
            string regexStr = @"^[0-9]{5}$";
            Regex regex = new Regex(regexStr);

            //If the string is 5 numbers
            if (regex.IsMatch(id))
            {
                return true;
            }

            return false;
        } // end method Digits()

        public static bool Name(string name)
        {
            string regexStr = @"^(?=[a-zA-Z\s]{2,25}$)(?=[a-zA-Z\s])(?:([\w\s*?])\1?(?!\1))+$";
            Regex regex = new Regex(regexStr);

            //If the string has no numbers, special characters, or white space
            if (regex.IsMatch(name))
            {
                return true;
            }

            return false;
        } // end method Name()

        public static bool MiddleInitial(string middle)
        {
            string regexStr = @"^[A-Z]{1}$";
            Regex regex = new Regex(regexStr);

            //If the string is 1 char of upper or lower alpha
            if (regex.IsMatch(middle))
            {
                return true;
            }

            return false;
        } // end method MiddleInitial()

        public static bool DeptTitle(string valueStr)
        {
            string regexStr = @"^[a-zA-Z\s]+$";
            Regex regex = new Regex(regexStr);

            //If the string only contains upper/lower alpha & spaces
            if (regex.IsMatch(valueStr))
            {
                return true;
            }

            return false;
        } // end method DeptTitle()

        public static bool Compensation(string compensation)
        {
            string regexStr = @"^[0-9]*[.,]?[0-9]*$";
            Regex regex = new Regex(regexStr);

            //If the string is a monetary value
            if (regex.IsMatch(compensation))
            {
                return true;
            }

            return false;
        } // end method Compensation()

        public static bool AlphaNumerics(string courseID)
        {
            string regexStr = @"^[a-zA-Z0-9]*$";
            Regex regex = new Regex(regexStr);

            //If the string is alphanumeric
            if (regex.IsMatch(courseID))
            {
                return true;
            }

            return false;
        } // end method AlphaNumerics()

        public static bool CourseDesc(string courseDesc)
        {
            string regexStr = @"^[a-zA-Z_.#+,/)( ]*$";
            Regex regex = new Regex(regexStr);

            //If the string is alpha or a select set of special characters
            if (regex.IsMatch(courseDesc))
            {
                return true;
            }

            return false;
        } // end method CourseDesc()



    } // end class InputValidation
} // end namespace RegexLibrary
