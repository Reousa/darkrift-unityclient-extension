public sealed class ExampleMessage : IMessage, IDarkRiftSerializable
{
	public ushort Tag => (ushort)ExampleMessageTag.SpawnUnit;
	
	public int ExampleId;
	public string ExampleName;

	public ExampleMessage(int exampleId, string exampleName)
	{
		ExampleId = exampleId;
		ExampleName = exampleName;
	}

	public ExampleMessage()
	{
	}

	public void Deserialize(DeserializeEvent e)
	{
		ExampleId = e.Reader.ReadInt32();
		ExampleName = e.Reader.ReadString();
	}

	public void Serialize(SerializeEvent e)
	{
		e.Writer.Write(ExampleId);
		e.Writer.Write(ExampleName);
	}
}