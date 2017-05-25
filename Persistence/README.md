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
    
* RegistryPersist.cna

    * Creates a Custom Registry Key, Value, Type, and Payload Location based on user input for selected beacon
