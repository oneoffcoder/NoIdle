![One-Off Coder Logo](logo.png "One-Off Coder")

# Purpose

A tool that you may use to log off idle users at the console. This tool is not tested or intended
to work with users that are logged in remotely (e.g. Terminal Services). You should
use this tool as specified by this [article](https://4sysops.com/archives/automatically-log-off-idle-users-in-windows/).
There are [other ways](https://michlstechblog.info/blog/windows-automatically-logout-a-user-on-inactive/) to accomplish this goal as well.


# References

This project draws on information from around the internet.

* https://stackoverflow.com/questions/14466373/log-off-a-windows-user-locally-using-c-sharp
* https://stackoverflow.com/questions/1037595/c-sharp-detect-time-of-last-user-interaction-with-the-os
* https://stackoverflow.com/questions/3197138/how-to-get-currently-logged-users-session-id
* https://docs.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-wtsgetactiveconsolesessionid?redirectedfrom=MSDN
* https://www.pinvoke.net/default.aspx/kernel32.wtsgetactiveconsolesessionid
* https://stackoverflow.com/questions/9795326/system-idle-time-windows-service
* https://stackoverflow.com/questions/6494436/getting-user-idle-time-in-c
* https://4sysops.com/archives/automatically-log-off-idle-users-in-windows/
* https://michlstechblog.info/blog/windows-automatically-logout-a-user-on-inactive/