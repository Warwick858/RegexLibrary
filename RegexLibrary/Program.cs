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
using System.Threading.Tasks;

namespace RegexLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string signature = "	  ____.           .____             _____  _______ \n";
            signature += "	 |    |           |    |    ____   /  |  | \\   _  \\ \n";
            signature += "	 |    |   ______  |    |   /  _ \\ /   |  |_/  /_\\  \\ \n";
            signature += "     /\\__|    |  /_____/  |    |__(  <_> )    ^   /\\  \\_/   \\ \n";
            signature += "     \\________|           |_______ \\____/\\____   |  \\_____  / \n";
            signature += "                                  \\/          |__|        \\/ \n";
            signature += " *************************************************************** \n";
            Console.WriteLine(signature);






        } // end method Main()
    } // end class Program
} // end namespace RegexLibrary

//Definitions:
// Special Characters (require escape if literal representation is needed):
//  [ ] ( ) \ . * + ^ ? | { } $
//
// \ escape special character
// ^ beginning of string
// [^abc] NOT a, b, or c
// $ end of string
// * zero or more
// + one or more
// ? zero or one
// {3} three
// {3,} three or more
// {3,5} three to five
// \c control character (a non-printable character)
// \s white space
// \S NOT white space
// \d digit
// \D NOT digit
// \w word (alpha, numerics, or underscore)
// \W NOT word
// \x hexadecimal digit
// \O octal digit
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
