using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
	//todo [君韋] 註解DisplayGrid ///
	public class DisplayGrid
	{
		public static EventHandler Handler;
		public static void DisplayAll(object sender, MessageArgs e)
		{
			if (Handler != null) Handler(sender, e);
		}
	}
	public class MessageArgs : EventArgs
	{
		public string Message { get; set; }
	}
}
