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



using System;

#if MIGRATION
namespace System.Windows.Controls.Primitives
#else
namespace Windows.UI.Xaml.Controls.Primitives
#endif
{
    /// <summary>
    /// Specifies the preferred location for positioning a ToolTip relative to a visual element.
    /// </summary>
    public enum PlacementMode
    {
        /// <summary>
        /// Indicates that the preferred location of the tooltip is at the bottom of the target element.
        /// </summary>
        Bottom = 2,

        /// <summary>
        /// Indicates that the preferred location of the tooltip is at the right of the target element.
        /// </summary>
        Right = 4,

        /// <summary>
        /// Indicates that the preferred location of the tooltip is at the mouse pointer location.
        /// </summary>
        Mouse = 7,

        /// <summary>
        /// Indicates that the preferred location of the tooltip is at the left of the target element.
        /// </summary>
        Left = 9,

        /// <summary>
        /// Indicates that the preferred location of the tooltip is at the top of the target element.
        /// </summary>
        Top = 10,
    }
}