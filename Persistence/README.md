# Persistence 

**Persistence Aggressor Scripts for Cobalt Strike 3.0+**

* Persistence_Menu.cna
   
   * Includes all scripts into one beacon menu

* UserSchtasksPersist.cna

    * User Schtasks Persistence that runs as current user for the selected beacon
    
    * Meant for quick user level persistence upon initial access
    
    * Thanks to @noone and bluescreenofjeff for assistance
    
    ![schtasks](https://cloud.githubusercontent.com/assets/27856212/26449039/2b43a742-411e-11e7-8ac4-f003c8060654.PNG)
    
* ServiceEXEPersist.cna

    * Admin Level Custom Service EXE Persistence
    
    * Runs as elevated user/SYSTEM for the selected beacon
    
    ![service](https://cloud.githubusercontent.com/assets/27856212/26449045/2e4a13c2-411e-11e7-83e4-2b57babdbbdd.PNG)
    
* WMICEventPersist.cna
    
    * Generates a Custom WMI Event using WMIC for SYSTEM Level persistence on selected beacon

    * Very syntax heavy, Test first before using on live targets
    
    ![wmic4](https://cloud.githubusercontent.com/assets/27856212/25680015/5eeab692-301d-11e7-8b85-914fe928e426.PNG)
    
* WMIEventPersist.cna

    * Generates a Custom WMI Event using PowerShell for SYSTEM Level persistence on selected beacon

    * Very syntax heavy, Test first before using on live targets
    
    ![wmipersist1](https://cloud.githubusercontent.com/assets/27856212/26449054/36d33172-411e-11e7-818d-7f0702a40712.PNG)

* StartupGPOPersist.cna
   
   * Generates a Local GPO Entry in psscripts.ini to call a .ps1 script file for persistence on selected beacon
   
   * Calls back as SYSTEM
   
   * Check permissions with GPO Enumeration (Successful GroupPolicy Directory Listing) first before executing
   
   * Beacon execution will cause winlogon.exe to hang and the end user can't login. Once the new beacon checks in inject into        another process and kill the original. Update to come out soon.
   
   ![gpo](https://cloud.githubusercontent.com/assets/27856212/26449031/1ffb0aba-411e-11e7-9138-f23de966ac4b.PNG)
    
* RegistryPersist.cna

   * Creates a Custom Registry Key, Value, Type, and Payload Location based on user input for selected beacon
    
    ![registry](https://cloud.githubusercontent.com/assets/27856212/26449228/14f41a48-411f-11e7-8690-3ce3c1541738.PNG)
    
* HKCURunKeyPSRegistryPersist.cna

   * Creates two Custom Registry Run Key entries in HKCU
   
   * The Payload is a base64 encoded powershell payload based off your HTTP/HTTPS listener
   
   ![hkcu](https://user-images.githubusercontent.com/27856212/28122833-5bee8d72-66ed-11e7-8d0b-332f32627c62.png)
