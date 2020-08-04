![One-Off Coder Logo](logo.png "One-Off Coder")

# Purpose

A tool that you may use to log off idle users at the console. This tool is not tested or intended
to work with users that are logged in remotely (e.g. Terminal Services). You should
use this tool as specified by this [article](https://4sysops.com/archives/automatically-log-off-idle-users-in-windows/).
There are [other ways](https://michlstechblog.info/blog/windows-automatically-logout-a-user-on-inactive/) to accomplish this goal as well.

# Releases

Download a release of [NoIdle.exe](https://github.com/oneoffcoder/NoIdle/releases).

# Citation

```
@misc{noidle_oneoffcoder_2020, 
title={NoIdle}, 
url={https://github.com/oneoffcoder/NoIdle/}, 
journal={GitHub},
author={One-Off Coder}, 
year={2020}, 
month={Aug}}
```

# Copyright Stuff

```
Copyright 2020 One-Off Coder

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```


# Contact

One-Off Coder

* [Website](https://www.oneoffcoder.com)
* [Twitter](https://twitter.com/oneoffcoder)
* [Facebook](https://www.facebook.com/oneoffcoder)
* [YouTube](https://www.youtube.com/channel/UCCCv8Glpb2dq2mhUj5mcHCQ)

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