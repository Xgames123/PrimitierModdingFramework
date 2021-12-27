#include "pch-il2cpp.h"

#include <iostream>
#include "helpers.h"
#include "Utilities.h"

namespace PMF 
{

	void Setup() 
	{
		// Initialize thread data - DO NOT REMOVE
		il2cpp_thread_attach(il2cpp_domain_get());

		

		
	}

	void StartConsole()
	{
		il2cppi_new_console();
		LogToConsole("Primitier modding framework starting...");
	}

	void LogToConsole(const char message[])
	{
		std::cout << message << '\n';
	}



	void WiatForSceneToLoad(const char sceneName[])
	{
		char LogMessage[] = "Waiting for scene ";
		strcat_s(LogMessage, sceneName);
		LogToConsole(LogMessage);
		while (true)
		{


		}


	}

}

