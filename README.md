# SecondReality v1.0.2 ("Realipony" codename)

I started research as my small experiment of running Eric Mooneys' remake of Second Reality 
[WinRT edition](https://github.com/noxo/SecondRealityponyWinRT)... and, in result, 
I assembled this fun UWP app... ;) 

The goal was Win10/11 Desktop-compatible UWP app and even W10M-compatible app, because 
of Second Reality is [c]oolest [d]emoscene deal !

## Screenshots
![W11](Images/shot1.png)
![W11](Images/shot2.png)
![W10M](Images/shot3.png)

## GameTech I used
- I "assembled" (prepared) and used my own "UAP 10240" (Astoria-compatible) Monogame (& SharpDX) "framework" as "graphics backend". 
- XNA Content is "included" (precompiled) with project.


## Main changes / My progress 
- Microsoft.XNA framework -> Monogame XNA framework +
- Xna.VideoPlayer -> Windows.UI.Xaml.Controls.MediaElement + 
- Monogame XNA Content Pipeline fight - not needed :)
- System.Threading.Thread -> System.Threading.Tasks.Task +
- Min. Win. OS build (SDK) = 10240
- Content decreased a little (because of huge size)
- Tested targets: x64, ARM32

## Potential hardware/os/software problems/bugs
- If you will use very old PC/notebook without DX11 support, then last 3D scene will be empty (black screen).
- If you will use Lumia phone (950/950XL) and Win10Mobile, then some system UI drawing bugs/freezes will accur on SecondReality exiting.

## How to build the code / assemble this solution
- Should compile nicely with Visual Studio 2022 Preview Community for Windows 10/11. 
- Find and download MonoGame3_6_Setup.exe (from offical monogame.net site , etc.) 
and install it *before* the secondreality building.

## References
- https://github.com/noxo/SecondRealityponyWinRT Original SecondRealityponyWinRT project
- https://github.com/noxo noxo, SecondRealityponyWinRT C# Developer

## ..
As is. No support. RnD only. DIY

## .
[m][e] 2023
