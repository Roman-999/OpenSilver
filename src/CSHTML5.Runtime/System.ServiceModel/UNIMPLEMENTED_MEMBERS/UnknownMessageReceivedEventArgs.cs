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



#if WCF_STACK

#if UNIMPLEMENTED_MEMBERS

using System;
using System.ServiceModel.Channels;

namespace System.ServiceModel
{
    /// <summary>
    /// Contains the message received by a channel and cannot be associated with
    /// any callback operation or pending request.
    /// </summary>
    public sealed partial class UnknownMessageReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the unknown message that caused the event.
        /// </summary>
        public Message Message
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

#endif

#endif