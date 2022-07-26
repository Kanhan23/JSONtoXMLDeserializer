----JSONtoXMLDeserializer----

	This is an API project that has only one controller with a GET method to convert a JSON array to XML format.

	To convert JSON, Newtonsoft Nuget package has been used under the service layer.
	
	For logging purpose, a simple FileWriter class has been implemented. Log method takes the log message, adds a datetime and writes it to the file called convertLogs.txt under the classpath.
	If file does not exist, it creates a new one.

	Dependencies are injected in constructors using C# built-in IoC in Program.cs