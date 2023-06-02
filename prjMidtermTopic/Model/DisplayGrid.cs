using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{

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
