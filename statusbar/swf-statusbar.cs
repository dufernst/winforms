//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Authors:
//      Jackson Harper (jackson@ximian.com)
//
// Copyright (C) Novell Inc., 2004
//


using System;
using System.Windows.Forms;

namespace StatusBarTests {

	public class Test1 : Form {

		public Test1 ()
		{
			StatusBar sb1;
			sb1 = new StatusBar ();
			sb1.Width = 300;
			sb1.ShowPanels = true;
			Controls.Add (sb1);

			StatusBarPanel p = new StatusBarPanel ();
			p.AutoSize = StatusBarPanelAutoSize.Spring;
			p.Text = "test";
			sb1.Panels.Add (p);

			StatusBarPanel p2 = new StatusBarPanel ();
			p2.AutoSize = StatusBarPanelAutoSize.Contents;
			p2.Text = "i am an apeman";
			sb1.Panels.Add (p2);

			StatusBarPanel p3 = new StatusBarPanel ();
			p3.AutoSize = StatusBarPanelAutoSize.Spring;
			p3.Text = "test";
			sb1.Panels.Add (p3);
		}

		public static void Main ()
		{
			Application.Run (new Test1 ());
		}
	}

}



			

			
