﻿/* 
 Copyright (c) 2010, NHIN Direct Project
 All rights reserved.

 Authors:
    Umesh Madan     umeshma@microsoft.com
  
Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
Neither the name of the The NHIN Direct Project (nhindirect.org). nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NHINDirect.SmtpAgent
{
    public class NotificationSettings
    {
        const string DefaultText = "Security Agent";
        
        bool m_autoResponse = false;
        string m_productName = DefaultText;
        
        public NotificationSettings()
        {
        }

        [XmlElement]
        public bool AutoResponse
        {
            get
            {
                return m_autoResponse;
            }
            set
            {
                m_autoResponse = value;
            }
        }
        
        [XmlElement]
        public string Text
        {
            get;
            set;
        }
        
        [XmlIgnore]
        public bool HasText
        {
            get
            {
                return (!string.IsNullOrEmpty(this.Text));
            }
        }
        
        [XmlElement]
        public string ProductName
        {
            get
            {
                return m_productName;
            }
            set
            {
                m_productName = string.IsNullOrEmpty(value) ? DefaultText : value;
            }
        }
                        
        public void Validate()
        {
        }
    }
}
