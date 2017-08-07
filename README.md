# File Info Comparer - short description
I needed a tool to compare the informaiton of two files from different locations oin my hard disc. Something like "I have a version of a .dll on my disc c:\ and I havbe the same .dll on my disc g:\ and now I want to see, if there are any metadata differences between those .dll's"
So you can imagine it somehting like a diff tool for File Information. 

# How do I use it?
It's pretty straight forward. Just pick your two folders, where your file(s) is located. 
The available files from the folder are loaded right away. in the DataGrids, pick select the Files you want to compare.
Their file information is loaded in the PropertyGrid below.

# For Developers - What can I do as enhancements?
Well, there isn't enough file info available yet (right now, for the beginning, I'm just using the FileInfo class from System.IO)
It would be also pretty cool to have a diff tool inside for text files.
And some more colors would be awesome, like - what infomations actually differs?
If you have any ideas by yourself, just go ahead and work on it! Feel free to use this as a basis for your own comparing Tools, and if it's something what can be useful for many other peopel, please dom't forget to commit your stuff into the master bracnh, so everyone can benefit of it.

# For Developers - how is the code structured?
I used WPF and C#.
Following Libraries/Tools were used:
- DevExpress.Mvvm as a basic for Mvvm
- xceed WPFToolkit for WatermarktTextboxes and PropertyGrids
- icon8 for Icons (free of charge)
- Ooki.Dialogs.Wpf for Folder Selection (instead of the defult .NET dialogs)

I didn't structured the solution that much. If you plan to let that Tool grow, feel free to add some structure. Or, if you're too lazy, leave a note and I'll structurize it myself ;)
