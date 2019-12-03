# Project-Website-to-Executable
 C# based Electron-builder program to convert Websites to EXEs for windows ;)


#### What is this thing??

WtE is a C# based Windows Form that automates programming and creation of an Electron package, and automatically converts a websites HTML and other resources to a fully portable EXE file that can work as a Desktop Website

#### How do I use this thing???

To begin, simply find some HTML Files and some other resources that follow (CSS, JS, images, ETC) and zip them all up into a .zip container file.

Next, open my program, select the Open Zip button and locate your zip, the program will setup a basic electron application and extract your website to the proper location.

If you dont have Node or Electron builder installed, just select the links on the right side of the program, but if you have node, but not electron builder, my program will also automatically install and setup a global version of electron builder for you ^-^

Finally, add a projectName, version, and authorName, and hit the Build button.

Wait a couple seconds, let the command windows finish loading (There should be two at some point, and this process takes around a minute or two, also depends on wifi speed)

Finally, a message box should appear telling you the location of your exe, simply grab it, and copy/paste it or upload it from that point on.

### Warnings??

This doesnt support Online Updating, (UNLESS you make your program an iFrame that loads an online page), Im working on supporting custom window sizes, its stuck at 800x600 to follow typical website dimension guidelines.

Also, This program isnt a miracle worker, but it does function. Dont expect a 200 KB exe that instantly loads an HTML file though, the executables created here are only portable because a lightweight mini version of a developer save of Electron is installed into EVERY exe created with WtE, meaning the file is typically over 30 MB :P 

That does also mean that you shouldnt have over a 100mb file, if so, thats because your hosting LARGE videos inlined into your website or something similar, which isnt reccomended by any standards of any website.

It does work well though, and if you need to create a simple desktop web app for your Javascript Game, use this.
