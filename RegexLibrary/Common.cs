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
    public static class Common
    {
        public static void Run()
        {
            IPAddressCollection("localhost is: 127.0.0.1, server is: 169.58.218.1, proxy is: 105.28.17.14, deadend is: 270.300.5.1");
        }

        public static bool PhoneNumbers(string str)
        {
            string pattern = @"[\(.]?[2-9]\d\d[\).]?[ -]?[2-9]\d\d[-.]\d{4}";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(str))
            {
                return true;
            }

            return false;
        } // end method PhoneNumbers()

        public static bool ZipCodes(string str)
        {
            string pattern = @"\d{5}(-\d{4})?";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(str))
            {
                return true;
            }

            return false;
        } // end method ZipCodes()

        public static bool SocialSecurity(string str)
        {
            string pattern = @"\d{3}-\d{2}-\d{4}";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(str))
            {
                return true;
            }

            return false;
        } // end method SocialSecurity()

        public static bool IPAddress(string str)
        {
            string pattern = @"(((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))\.){3}((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(str))
            {
                return true;
            }

            return false;
        } // end method IPAddress()

        public static bool IPAddressCollection(string str)
        {
            string pattern = @"(((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))\.){3}((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                return true;
            }

            return false;
        } // end method IPAddressCollection()

        public static bool Url(string str)
        {
            string pattern = @"https?://(\w*:\w*@)?[-\w.]+(:\d+)?(/([\w/_.]*(\?\S+)?)?)?";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(str))
            {
                return true;
            }

            return false;
        } // end method Url()

        public static bool Email(string str)
        {
            string pattern = @"(\w+\.)*\w+@(\w+\.)+[A-Za-z]+";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            
            if (regex.IsMatch(str))
            {
                return true;
            }

            return false;
        } // end method Email()

        public static bool HtmlComments(string str)
        {
            string pattern = @"<!-{2,}.*?-{2,}>";
            Regex regex = new Regex(pattern);

            string result = regex.Replace(str, " ");
            if (!regex.IsMatch(result)) // if all html comments were removed
            {
                return true;
            }

            return false;
        } // end method HtmlComments()

        public static bool CComments(string str)
        {
            string pattern = @"//.*";
            Regex regex = new Regex(pattern);

            string result = regex.Replace(str, " ");
            if (!regex.IsMatch(result)) // if all C comments were removed
            {
                return true;
            }

            return false;
        } // end method CComments()

        /// <summary>
        /// Matches: MC, Visa 1, Visa 2, Amex, Discover, Diner's Club
        /// </summary>
        public static bool CreditCards(string str)
        {
            string pattern = @"(5[1-5]\d{14})|(4\d{12}(\d{3})?)|(3[47]\d{13})|(6011\d{14})|((30[0-5]|36\d|38\d)\d{11})";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(str))
            {
                return true;
            }

            return false;
        } // end method CreditCards()

    } // end class Common
} // end namespace RegexLibrary
