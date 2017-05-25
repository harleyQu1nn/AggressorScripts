# Persistence 

**Persistence Aggressor Scripts for Cobalt Strike 3.0+**

* Persistence_Menu.cna includes all scripts into one beacon menu

* UserSchtasksPersist.cna

    * User Schtasks Persistence that runs as current user for the selected beacon
    
    * Meant for quick user level persistence upon initial access
    
    * Thanks to @noone and bluescreenofjeff for assistance
    
* ServiceEXEPersist.cna

    * Admin Level Custom Service EXE Persistence
    
    * Runs as elevated user/SYSTEM for the selected beacon
    
* WMICEventPersist.cna
    
    * Generates a Custom WMI Event using WMIC for SYSTEM Level persistence on selected beacon

    * Very syntax heavy, Test first before using on live targets
    
    ![wmic4](https://cloud.githubusercontent.com/assets/27856212/25680015/5eeab692-301d-11e7-8b85-914fe928e426.PNG)
    
* WMIEventPersist.cna

    * Generates a Custom WMI Event using PowerShell for SYSTEM Level persistence on selected beacon

    * Very syntax heavy, Test first before using on live targets

* StartupGPOPersist.cna
   
   * Generates a Local GPO Entry in psscripts.ini to call a .ps1 script file for persistence on selected beacon
   
   * Calls back as SYSTEM
   
   * Check permissions with GPO Enumeration (Successful GroupPolicy Directory Listing) first before executing
   
   * Beacon execution will cause winlogon.exe to hang and the end user can't login. Once the new beacon checks in inject into        another process and kill the original. Update to come out soon.
    
* RegistryPersist.cna

    * Creates a Custom Registry Key, Value, Type, and Payload Location based on user input for selected beacon
