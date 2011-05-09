FakerSharp
==========

This is the FakerSharp readme file. This is a Port of the so-famous [faker gem](https://github.com/stympy/faker) for ruby, to C# / .NET.

Requirements
------------
* .NET Framework >= 4.0
* Visual Studio 2010 (to open solution file and run tests)

Usage
-----

Add the file FakerSharp.dll as a dependency, and follow the examples below:

	// this will generate something like: "john.doe@gmail.com" or "doe_john@yahoo.com"
	string email = FakerSharp.Internet.GetFreeEmail("John Doe");

	// i.e. 192.168.15.24
	string ipAddress = FakerSharp.Internet.IPV4Address;

For further examples, look and run the unit tests included in the project.
