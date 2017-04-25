#!/usr/bin/python

import os
import sys
import datetime

operator_path = '/opt/cobaltstrike/logs/operator_logs/operator_input/'
beacon_path = '/opt/cobaltstrike/logs/operator_logs/beacon_output/'
args = sys.argv[1:]
num = 0
date_timestamp = str(datetime.datetime.now().strftime("%Y%b%d"))
log_file_path = date_timestamp+"_"+str(" ".join(args))+"_log.html"

log_file = open(log_file_path,"a+")
log_file.write("""
<!DOCTYPE html>
<html>
<body>
<H3>Logged @ """ + str(datetime.datetime.now().strftime("%Y%b%d %H:%M:%S")) + """</H3>
<table border="1">
  <tr style="background-color:#a0a0ff;font:10pt Tahoma;font-weight:bold;" align="left">
    <th>OperatorName</th>
    <th>TargetIP</th>
    <th>TargetHostname</th>     
    <th>Username</th>
    <th>ProcessId</th>
    <th>Timestamp</th>
    <th>Command</th>
    <th>LogOutput</th>    
  </tr>
""")

for filename in os.listdir(operator_path):
    with open(operator_path+filename,"r")	as log:
        for line in log:
            if " ".join(args) in line:
                num += 1
                cmd_info = line.split(">")[0]
                
                operator_name = cmd_info.split("[")[0]
                ip = str(str(cmd_info.split("[")[1]).split("]")[0]).split("_")[0]
                hostname = str(str(cmd_info.split("[")[1]).split("]")[0]).split("_")[1]
                user = str(str(cmd_info.split("|")[0]).split("]")[1]).split("/")[0]
                pid = str(str(cmd_info.split("|")[0]).split("]")[1]).split("/")[1]                
                timestamp = cmd_info.split("|")[1]
                date = str(timestamp.split(" ")[0])
                
                cmd = line.split(">")[1:]
                table = """
  <tr style="background-color:#e0f0f0;font:10pt Tahoma;">
    <td align="left">%s<span style="height:1px;overflow-y:hidden"></span></td>
    <td align="left">%s<span style="height:1px;overflow-y:hidden"></span></td>
    <td align="left">%s<span style="height:1px;overflow-y:hidden"></span></td>
    <td align="left">%s<span style="height:1px;overflow-y:hidden"></span></td>
    <td align="left">%s<span style="height:1px;overflow-y:hidden"></span></td>
    <td align="left">%s<span style="height:1px;overflow-y:hidden"></span></td>
    <td align="left">%s<span style="height:1px;overflow-y:hidden"></span></td>
    <td align="left"><a href="file://%s%s_%s_%s_output.log">Log Output</a> <span style="height:1px;overflow-y:hidden"></span></td>             
  </tr>                
""" % (operator_name,ip,hostname,user,pid,timestamp,str(' '.join(cmd)),beacon_path,date,ip,hostname)
                log_file.write(table)
log_file.write("""
</table>
<H3>""" + str(num) + """ Log Entries</H3>

</body>
</html>
""")
log_file.close()
