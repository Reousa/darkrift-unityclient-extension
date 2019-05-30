using DarkRift;
using DarkRift.Client;
using DarkRift.Client.Unity;

public static class DarkRiftUnityClientExstension
{
	/// <summary>
	/// Extension method for quickly sending reliable messages to the server.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="client"></param>
	/// <param name="message">The message to be sent, needs to inherit from IDarkRiftSerializable</param>
	/// <param name="sendMode"></param>
	public static void SendMessageReliable<T>(this UnityClient client, T message)
	where T : IDarkRiftSerializable
	{
		using (DarkRiftWriter writer = DarkRiftWriter.Create())
		{
			writer.Write<T>(message);

			using (Message msg = Message.Create((ushort)message.Tag, writer))
				client.SendMessage(msg, SendMode.Reliable);
		}
	}

	/// <summary>
	/// Extension method for quickly sending unreliable messages to the server.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="client"></param>
	/// <param name="message">The message to be sent, needs to inherit from IDarkRiftSerializable</param>
	public static void SendMessageUnreliable<T>(this UnityClient client, T message)
		where T : IDarkRiftSerializable
	{
		using (DarkRiftWriter writer = DarkRiftWriter.Create())
		{
			writer.Write<T>(message);

			using (Message msg = Message.Create((ushort)message.Tag, writer))
				client.SendMessage(msg, SendMode.Unreliable);
		}
	}

	/// <summary>
	/// Extension method to quickly extract a message from MessageReceivedEventArgs
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="e"></param>
	/// <returns></returns>
	public static T ExtractMessage<T>(this MessageReceivedEventArgs e) where T : IDarkRiftSerializable, new()
	{
		using (Message message = e.GetMessage())
		using (DarkRiftReader reader = message.GetReader())
		{
			return message.Deserialize<T>();
		}
	}
}
