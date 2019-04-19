﻿
//===============================================================================
//
//  IMPORTANT NOTICE, PLEASE READ CAREFULLY:
//
//  => This code is licensed under the GNU General Public License (GPL v3). A copy of the license is available at:
//        https://www.gnu.org/licenses/gpl.txt
//
//  => As stated in the license text linked above, "The GNU General Public License does not permit incorporating your program into proprietary programs". It also does not permit incorporating this code into non-GPL-licensed code (such as MIT-licensed code) in such a way that results in a non-GPL-licensed work (please refer to the license text for the precise terms).
//
//  => Licenses that permit proprietary use are available at:
//        http://www.cshtml5.com
//
//  => Copyright 2019 Userware/CSHTML5. This code is part of the CSHTML5 product (cshtml5.com).
//
//===============================================================================



namespace System.Windows.Markup
{
    /// <summary>
    /// Indicates that the type supports direct content when used in XAML. A XAML processor
    /// uses this information when processing XAML child elements of XAML representations
    /// of the attributed type. The direct content is converted using the
    /// TypeFromStringConverter class.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = true)]
    public class SupportsDirectContentViaTypeFromStringConvertersAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the SupportsDirectContentViaTypeFromStringConvertersAttribute class.
        /// </summary>
        public SupportsDirectContentViaTypeFromStringConvertersAttribute() { }
    }
}