using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DriverSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("C:\\Windows\\System32\\drivers\\", "*.*", SearchOption.AllDirectories);
            System.Collections.Hashtable matches = new System.Collections.Hashtable();
            Console.WriteLine("[*] Twitter: @r3dQu1nn");
            Console.WriteLine("[*] Checking for installed EDR Products... [*]");
            foreach (string filepath in files)
            {
                string filename = Path.GetFileName(filepath);
                switch (filename.ToLower())
                {
                    case "wdnisdrv.sys":
                        matches.Add(filename, "Windows Defender Found!");
                        break;
                    case "fekern.sys": case "wfp_mrt.sys":
                        matches.Add(filename, "FireEye Found!");
                        break;
                    case "eaw.sys":
                        matches.Add(filename, "Raytheon Cyber Solutions Found!");
                        break;
                    case "rvsavd.sys":
                        matches.Add(filename, "CJSC Returnil Software Found!");
                        break;
                    case "dgdmk.sys":
                        matches.Add(filename, "Verdasys Inc. Found!");
                        break;
                    case "atrsdfw.sys":
                        matches.Add(filename, "Altiris (Symantec) Found!");
                        break;
                    case "mbamwatchdog.sys":
                        matches.Add(filename, "Malwarebytes Found!");
                        break;
                    case "edevmon.sys": case "ehdrv.sys":
                        matches.Add(filename, "ESET Found!");
                        break;
                    case "sentinelmonitor.sys":
                        matches.Add(filename, "SentinelOne Found!");
                        break;
                    case "edrsensor.sys": case "hbflt.sys": case "bdsvm.sys": case "gzflt.sys": case "bddevflt.sys": case "avckf.sys": case "atc.sys": case "avc3.sys": case "trufos.sys": case "bdsandbox.sys":
                        matches.Add(filename, "BitDefender Found!");
                        break;
                    case "hexisfsmonitor.sys":
                        matches.Add(filename, "Hexis Cyber Solutions Found!");
                        break;
                    case "cyoptics.sys": case "cyprotectdrv32.sys": case "cyprotectdrv64.sys":
                        matches.Add(filename, "Cylance Inc. Found!");
                        break;
                    case "aswsp.sys":
                        matches.Add(filename, "Avast Found!");
                        break;
                    case "mfeaskm.sys": case "epdrv.sys": case "mfencfilter.sys": case "mfencoas.sys": case "mfehidk.sys": case "swin.sys": case "hdlpflt.sys": case "mfprom.sys": case "mfeeeff.sys":
                        matches.Add(filename, "McAfee Found!");
                        break;
                    case "groundling32.sys": case "groundling64.sys":
                        matches.Add(filename, "Dell Secureworks Found!");
                        break;
                    case "avgtpx86.sys": case "avgtpx64.sys":
                        matches.Add(filename, "AVG Technologies Found!");
                        break;
                    case "pgpwdefs.sys": case "geprotection.sys": case "diflt.sys": case "sysmon.sys": case "ssrfsf.sys": case "emxdrv2.sys": case "reghook.sys": case "spbbcdrv.sys": case "bhdrvx86.sys": case "bhdrvx64.sys": case "SISIPSFileFilter.sys": case "symevent.sys": case "vxfsrep.sys": case "virtfile.sys": case "symafr.sys": case "symefasi.sys": case "symefa.sys": case "symefa64.sys": case "symhsm.sys": case "evmf.sys": case "gefcmp.sys": case "vfsenc.sys": case "pgpfs.sys": case "fencry.sys": case "symrg.sys":
                        matches.Add(filename, "Symantec Found!");
                        break;
                    case "safe-agent.sys":
                        matches.Add(filename, "SAFE-Cyberdefense Found!");
                        break;
                    case "cybkerneltracker.sys":
                        matches.Add(filename, "CyberArk Software Found!");
                        break;
                    case "klifks.sys": case "klifaa.sys": case "klifsm.sys":
                        matches.Add(filename, "Kaspersky Found!");
                        break;
                    case "savonaccess.sys": case "sld.sys":
                        matches.Add(filename, "Sophos Found!");
                        break;
                    case "ssfmonm.sys":
                        matches.Add(filename, "Webroot Software, Inc. Found!");
                        break;
                    case "carbonblackk.sys": case "Parity.sys": case "cbk7.sys": case "cbstream.sys":
                        matches.Add(filename, "Carbon Black Found!");
                        break;
                    case "crexecprev.sys":
                        matches.Add(filename, "Cybereason Found!");
                        break;
                    case "im.sys": case "csagent.sys": case "CSBoot.sys": case "CSDeviceControl.sys": case "cspcm2.sys":
                        matches.Add(filename, "CrowdStrike Found!");
                        break;
                    case "cfrmd.sys": case "cmdccav.sys": case "cmdguard.sys": case "cmdmnefs.sys": case "mydlpmf.sys":
                        matches.Add(filename, "Comodo Security Solutions Found!");
                        break;
                    case "psinproc.sys": case "psinfile.sys": case "amfsm.sys": case "amm8660.sys": case "amm6460.sys":
                        matches.Add(filename, "Panda Security Found!");
                        break;
                    case "fsgk.sys": case "fsatp.sys": case "fshs.sys":
                        matches.Add(filename, "F-Secure Found!");
                        break;
                    case "esensor.sys":
                        matches.Add(filename, "Endgame Found!");
                        break;
                    case "csacentr.sys": case "csaenh.sys": case "csareg.sys": case "csascr.sys": case "csaav.sys": case "csaam.sys":
                        matches.Add(filename, "Cisco Found!");
                        break;
                    case "tmums.sys": case "hfileflt.sys": case "tmumh.sys": case "acdriver.sys": case "sakfile.sys": case "sakmfile.sys": case "fileflt.sys": case "tmesflt.sys": case "tmevtmgr.sys": case "tmfileencdmk.sys":
                        matches.Add(filename, "Trend Micro Inc Found!");
                        break;
                    case "epregflt.sys": case "medlpflt.sys": case "dsfa.sys": case "cposfw.sys":
                        matches.Add(filename, "Check Point Software Technologies Found!");
                        break;
                    case "psepfilter.sys": case "cve.sys":
                        matches.Add(filename, "Absolute Found!");
                        break;
                    case "brfilter.sys": case "brcow_x_x_x_x.sys":
                        matches.Add(filename, "Bromium Found!");
                        break;
                    case "lragentmf.sys":
                        matches.Add(filename, "LogRhythm Found!");
                        break;
                    case "libwamf.sys":
                        matches.Add(filename, "OPSWAT Inc Found!");
                        break;
                    default:
                        break;
                }  
            }
            
            if (matches.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("[+] No EDR Products found. [+]");
                Console.WriteLine("[+] Keep in mind that Cloud-Based EDR solutions could be present. [+]");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("[!] Alert!! The following EDR products were found:");
                Console.WriteLine("[!] Be careful what you execute!");
                Console.WriteLine("[!] Vendor Information:");
                Console.WriteLine();
                foreach (string key in matches.Keys)
                {
                    Console.WriteLine("\t{0} - {1}", key, matches[key]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("[+] Done!");
            Console.WriteLine("[+] Happy Hacking!");
        }
    }
}
