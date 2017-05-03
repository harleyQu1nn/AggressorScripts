# AggressorScripts
Collection of Aggressor scripts for Cobalt Strike 3.0+ pulled from multiple sources
* All_In_One.cna v1
    
   * All purpose script to enhance the user's experience with cobaltstrike. Custom menu creation, Logging, Persistence,        Enumeration, and 3rd party script integration.
   * Thanks to @rsmudge, @enigma0x3, @harmj0y, PowerShell Mafia folks, Nathan Wray, @Und3rFl0w, @oldb00t, bluescreenofjeff for all the help and code snippets.
   * Script must reside in /opt/cobaltstrike/ directory. (Location can be changed inside the script)

**All_In_One.cna Dependencies:**

    Parent Folder/Files: 
        /opt/cobaltstrike/All_In_One.cna
        /opt/cobaltstrike/av_hips_executables.txt 
        /opt/cobaltstrike/logs.py
    Sub Folders: 
        /opt/cobaltstrike/scripts/
        /opt/cobaltstrike/Payloads/
        /opt/cobaltstrike/modules/
    Elevate Kit (Licensed Users Only)

* Logger.cna
    
    * Logging script that captures all the Beacon outputs. Formats the Beacon input line to display timestamps. Use with logs.py to export all the logs for each operator.
    * All logs will be created inside the /opt/cobaltstrike/logs/ directory
    
    ![logs](https://cloud.githubusercontent.com/assets/27856212/25580186/b85454fe-2e4c-11e7-91e1-10ab88d4e3fe.png)
    ![logs1](https://cloud.githubusercontent.com/assets/27856212/25580187/ba60dbbe-2e4c-11e7-8a37-7cfb124d99e9.png)

**Logger.cna Dependencies:**

    Parent Folder:
    /opt/cobaltstrike/Logger.cna
    /opt/cobaltstrike/av_hips_executables.txt
    /opt/cobaltstrike/logs.py
    
* UserSchtasksPersist.cna

    * User Schtasks Persistence that runs as current user for the selected beacon
    
    * Meant for quick user level persistence upon initial access
    
    * Thanks to @noone and bluescreenofjeff for assistance
    
* ServiceEXEPersist.cna

    * Admin Level Custom Service EXE Persistence
    
    * Runs as elevated user/SYSTEM for the selected beacon

* logs.py

    * Author: Matthew Merrill @noone
    
    * Python Script to parse all cobalt input/output logs and export into a HTML document
    
    * *Still in Beta Stage
    
    * Syntax: ./logs.py [Teamserver NickName]
