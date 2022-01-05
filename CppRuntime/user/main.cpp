// Generated C++ file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
// Custom injected code entry point

#include "pch-il2cpp.h"

#define WIN32_LEAN_AND_MEAN
#include <Windows.h>
#include "il2cpp-appdata.h"
#include "helpers.h"
#include "Utilities.h"

using namespace app;

// Set the name of your log file here
extern const LPCWSTR LOG_FILE = L"il2cpp-log.txt";

// Custom injected code entry point
void Run()
{
    PMF::Setup();

    PMF::StartConsole();


    //PMF::WiatForSceneToLoad("Mian");


    Scene__Boxed* gameScene = nullptr;

  
    SceneManager_GetSceneAt_Injected(1, (Scene*)gameScene, nullptr);
   

    if (Scene_get_isLoaded(gameScene, nullptr)) {
        PMF::LogToConsole("Game Loaded");
    }
    

    
}

void OnSceneLoaded(const char sceneName[])
{
    char logMessage[] = "scene loaded ";
    strcat_s(logMessage, sceneName);
    PMF::LogToConsole(logMessage);

    auto gameObject = GameObject_CreatePrimitive(PrimitiveType__Enum::Cube, nullptr);

    PMF::LogToConsole("Created cube");

}