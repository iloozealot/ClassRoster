

//Console application?
//Add Students to class roster?
//Until there are no more students?
//Print the count to the Console?

List<string> students = new List<string>();
bool isRegistering = true;

Console.WriteLine("Welcome to the application: ClassRoster");
Console.WriteLine("This application was created by: Justin Spencer");
Console.WriteLine("--------------------------------------------------\n");

do
{
	Console.Write("Please enter your first name: ");
	string? input = Console.ReadLine();

	if (!string.IsNullOrEmpty(input))
	{
		students.Add(input);
	}
	else
	{
		Console.WriteLine("Please enter a valid name.");
	}

	Console.Write("Is there another student y/n? ");

	input = Console.ReadLine();

	if (input == "y")
	{
		continue;
	}
	else if (input == "n")
	{
		isRegistering = false;
	}
} while (isRegistering);

	Console.WriteLine($"Currently there are {students.Count} students enrolled."); 