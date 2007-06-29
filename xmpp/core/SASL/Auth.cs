/**********************************************************************************/
/*																				  */
/* XMPP .NET Library Copyright (C) 2006 Dieter Lunn								  */
/*														                          */
/* This library is free software; you can redistribute it and/or modify it under  */
/* the terms of the GNU Lesser General Public License as published by the Free	  */
/* Software Foundation; either version 2.1 of the License, or (at your option)	  */
/* any later version.															  */
/*														                          */
/* This library is distributed in the hope that it will be useful, but WITHOUT	  */
/* ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS  */
/* FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more	  */
/* details.																		  */
/*														                          */
/* You should have received a copy of the GNU Lesser General Public License along */
/* with this library; if not, write to the Free Software Foundation, Inc., 59	  */
/* Temple Place, Suite 330, Boston, MA 02111-1307 USA							  */
/**********************************************************************************/

using System.Xml;
using xmpp.common;

namespace xmpp.core.SASL
{
	[XmppTag("auth", Namespaces.SASL, typeof(Auth))]
	class Auth : Tag
	{
		public Auth(string prefix, XmlQualifiedName qname, XmlDocument doc) : base(prefix, qname, doc)
		{
		}

		public string Mechanism
		{
			get { return GetAttribute("mechanism"); }
			set { SetAttribute("mechanism", value); }
		}

		public string Text
		{
			get { return Value; }
			set { Value = value; }
		}
	}
}