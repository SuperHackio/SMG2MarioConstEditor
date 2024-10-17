# SMG2MarioConstEditor
A tool that allows you to edit parameters for playable characters in Super Mario Galaxy 2. These include Mario, Luigi and Yoshi.
Thanks to 3D All-Stars, we got a header file leaked which contained 540 variables. These made the development of the tool possible.

Please note that this program is ONLY for SMG2 since SMG doesnt have Constant files.

Default values are referenced by Mario's parameters. So if you edit a value or load Luigi's / Yoshi's file, you will notice that differing values are highlighted as bold text.

### What do the values do?
Plenty of things, from making Mario jump higher, run faster, or even how long Power-Ups last. But you may not find everything that your heart desires, since some mechanics are simply hardcoded.

### Would you like to help?
We don't exactly know what each value affects. So if you figure out what a value does, open a [New Issue](https://github.com/SuperHackio/SMG2MarioConstEditor/issues) and let me know!
(I've already figured out some of the values, they have been given descriptions)
Also since the leaked file from 3DAS was for SMG, there happen to be 14 additional parameters specifically for SMG2. They are labeled as UNKNOWN0 through UNKNOWN13.

## How to Use
1. Locate `ObjectData/MarioConst.arc`
2. Use [WiiExplorer](https://github.com/SuperHackio/WiiExplorer) to extract `MarioConst.bin`, `LuigiConst.bin`, or `YoshiConst.bin`
3. Open the .bin file with the SMG2 MarioConst Editor
4. Make your edits (All values that aren't default values will be in **BOLD**. In LuigiConst and YoshiConst, you can see which values are different from MarioConst because they will be bold)
5. Save your edits
6. Use [WiiExplorer](https://github.com/SuperHackio/WiiExplorer) to replace the original `MarioConst.bin`, `LuigiConst.bin`, or `YoshiConst.bin` inside the MarioConst archive
7. Save the Archive
8. Run the game

## System Requirements
This application requires .NET 8.0. You may need to [download](https://dotnet.microsoft.com/en-us/download/dotnet/8.0/runtime?) and install it if you haven't already. (Choose to run Desktop apps)


## Video
Here is a video with some sample edits applied.<br/>

[![YouTube Video Link](https://user-images.githubusercontent.com/44330283/154318807-3aa449a9-2655-4100-9458-2b6ac45c0cba.png)](https://www.youtube.com/watch?v=m-rGMPbuA1g)
