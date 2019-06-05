using UnityEngine;

public class ExampleMonoBehaviour : MonoBehaviour
{
	private UnityClient client;

	private void Awake()
	{
		client = this.GetComponent<UnityClient>();
	}

	public void ExampleSendMessage()
	{
		ExampleMessage msg = new ExampleMessage(1, "ExampleData");
		client.SendMessageReliable(msg);
	}
}