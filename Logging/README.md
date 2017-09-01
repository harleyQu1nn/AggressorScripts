# Logging Scripts

**Logger.cna Dependencies:**

    Parent Folder:
    /opt/cobaltstrike/Logger.cna
    /opt/cobaltstrike/av_hips_executables.txt
    /opt/cobaltstrike/logs.py

* logs.py

    * Author: Matthew Merrill @merrillmatt011
    
    * Python Script to parse all cobalt input/output logs and export into a HTML document
    
    * *Still in Beta Stage
    
    * Syntax: ./logs.py [Teamserver NickName]
    
* Logger.cna
    
    * Logging script that captures all the Beacon outputs. Formats the Beacon input line to display timestamps. Use with logs.py to export all the logs for each operator.
    * All logs will be created inside the /opt/cobaltstrike/logs/ directory
    
    ![logs](https://cloud.githubusercontent.com/assets/27856212/25580186/b85454fe-2e4c-11e7-91e1-10ab88d4e3fe.png)
    ![logs1](https://cloud.githubusercontent.com/assets/27856212/25580187/ba60dbbe-2e4c-11e7-8a37-7cfb124d99e9.png)
