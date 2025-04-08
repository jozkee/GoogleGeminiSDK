
using Microsoft.Extensions.AI;

namespace GoogleGeminiSDK;
public class ChatReceiveEventArgs : EventArgs
{
	public IList<ChatMessage> Messages { get; }

	internal ChatReceiveEventArgs(IList<ChatMessage> messages) =>
		Messages = messages;
}
