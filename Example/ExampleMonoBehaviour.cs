using UnityEngine;

public class ExampleMonoBehaviour : MonoBehaviour
{
	private UnityClient client;

	private void Awake()
	{
		client = this.GetComponent<UnityClient>();
	}
	
	private void Update()
	{
		ExampleSendMessage();
	}

	public void ExampleSendMessage()
	{
		//Construct the message.
		ExampleMessage msg = new ExampleMessage(1, "ExampleData");
		//Send the message.
		client.SendMessageReliable(msg);
	}
}
