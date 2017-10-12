function Get-Proc {
<#
.DESCRIPTION
Cobaltstrike has a great general function for processes: the 'ps' command. Use that if you need to dump ALL the processes w/ arch. 

This solution will show the running processes that have a creation date within the past 1 hour, giving more SA to the operator/analyst than just looking through an entire process list

Both solutions have their place. It is up to you to know how to use which when you need it.

Module info for process list has also been removed because nobody used it in the two years that the survey script was around. If you need to do IR on a box, there are better ways to do so
than by clogging up the screen in a survey. 
#>

param
		(
			[Parameter(Mandatory = $True)]
			[string]$Time
		)

$test3 = gwmi win32_process | sort -Property ProcessID
$q = get-date

"`n[+] Processes created in the past $Time minutes`n"
"{0,-8}{1,-8}{2,-20} {3,-20} {4}" -f "PID","PPID","PID Name","PPID Name","Owner"

foreach ($i in $test3){
    $qq = [Management.ManagementDateTimeConverter]::ToDateTime($i.creationdate)
        if ($qq -gt $q.addminutes(-$Time)){
            $z = $i.ParentProcessId
            "{0,-8}{1,-8}{2,-20} {3,-20} {4}"  -f $i.ProcessId, $i.ParentProcessId, $( if($i.processname.length -gt 20){ $i.processname.substring(0,20)} else{$i.processname}), $($test3 | where {$_.processid -eq $z}).caption , $i.GetOwner().user
        }
    }
}