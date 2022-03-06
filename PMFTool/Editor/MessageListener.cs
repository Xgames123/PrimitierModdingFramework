using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Editor
{
	public class MessageListener
	{

		private MessageQueue messageQueue;

		public MessageListener(string queueName)
		{
			messageQueue = new MessageQueue(".\\Private$\\" + queueName);
		}


		public void PullMessage()
		{
			var message = messageQueue.Receive();

		}


	}
}
