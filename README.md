# Aggressor Scripts
Collection of Aggressor scripts for Cobalt Strike 3.0+ pulled from multiple sources
* All_In_One.cna v1 - Removed and outdated
    
   * All purpose script to enhance the user's experience with cobaltstrike. Custom menu creation, Logging, Persistence,        Enumeration, and 3rd party script integration.
    * Version 2 is currently in development!

* ArtifactPayloadGenerator.cna

    * Generates every type of Stageless/Staged Payload based off a HTTP/HTTPS Listener
    
    * Creates /opt/cobaltstrike/Staged_Payloads, /opt/cobaltstrike/Stageless_Payloads
    
* AVQuery.cna

    * Queries the Registry with powershell for all AV Installed on the target
    
    * Quick and easy way to get the AV you are dealing with as an attacker
    
    ![av](https://user-images.githubusercontent.com/27856212/28275624-7331ab2e-6ae2-11e7-8405-3393e917863e.png)

* CertUtilWebDelivery.cna

    * Stageless Web Delivery using CertUtil.exe 
    
    * Powerpick is used to spawn certutil.exe to download the stageless payload on target and execute with rundll32.exe
    
    ![certutil2](https://user-images.githubusercontent.com/27856212/29992549-12d45854-8f6c-11e7-95c7-c2892582f56f.PNG)
    
* RedTeamRepo.cna

    * A common collection of OS commands, and Red Team Tips for when you have no Google or RTFM on hand.
    
    * Script will be updated on occasion, feedback and more inputs are welcomed!
    
    ![redrepo](https://user-images.githubusercontent.com/27856212/30020754-00fedd70-9133-11e7-80d4-dff3be7ab876.PNG)
    
* ProcessColor.cna

    * Color coded process listing without the file requirement.
    
    * Thanks to @oldb00t for the original version: https://github.com/oldb00t/AggressorScripts/tree/master/Ps-highlight
    
    ![process](https://user-images.githubusercontent.com/27856212/33582815-575d368e-d914-11e7-8d48-fd4c915af5d6.png)
    
