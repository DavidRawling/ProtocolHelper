# Protocol Helper
A helper application to allow creation and processing of URLs using custom protocols
[![Build status](https://ci.appveyor.com/api/projects/status/54x4y0jktr9nfr74?svg=true)](https://ci.appveyor.com/project/DavidRawling/protocolhelper)

Have you ever wanted to define a link on a webpage to open a specific, different browser? Perhaps you have a corporate application that only supports Firefox (or Chrome) but your main application set works only in IE.

Well, in Windows at least, you can define your very own custom protocols - Microsoft describes [how to do that at MSDN](https://msdn.microsoft.com/en-us/library/aa767914.aspx). In fact as you can see at the bottom, they even have some sample code.

The problem with that particular implementation is that it relies on the application being called knowing how to process the "custom" protocol. So Firefox would have to know that a firefox://www.google.com URL should really be interpreted as http://www.google.com.

So instead I've written a more generic handler application that lets you define your own mapping of custom protocol to application+real protocol. Any application that allows Windows to "do its thing" with a URL should be able to find and execute the custom handler, which identifies the correct program to run and loads it up with the corrected URL.

An example may help.

Configure your custom URL protocols in the app.config file.  There are three parts to a setting - the custom protocol, the application path and the "true" protocol - that is, the protocol that the application understands and expects - usually http or https for a web browser.

These settings are stored in the form:

        CustomProtocol=Application Path,Protocol

For example, to handle URIs with a new protocol called "cisco" you might define a setting as shown:

        cisco=C:\Program Files\PuTTY\putty.exe,ssh

Assuming the appropriate [registry settings](https://msdn.microsoft.com/en-us/library/aa767914.aspx) are in place, calling ProtocolHelper with the command line

        cisco://10.1.4.54

would then cause this command to be run:

        C:\Program Files\PuTTY\putty.exe ssh://10.1.4.54
