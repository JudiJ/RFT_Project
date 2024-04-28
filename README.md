# Readme RFT_Project

This project contains the programming scripts and assets for a VR rod and frame test (RFT). 

It was developed for the 2023/24 study "In Rod we Trust - The evaluation of virtual Rod and Frame Test as a cybersickness screening instrument" by J. Josupeit.

To download and test the application, go to [Application_RFT](https://github.com/JudiJ/Application_RFT).

Download the zip-file in this project to get the original Unity scene (v2019.1.11f1), the programming scripts for the custom created assets and the prefab assets used in the environment.

## The Application
A virtual rectangular frame and rod, represented by an opaque cubiod with two white dots at both ends, are presented in a dark room. 
At the start of each trial, the rod and frame are shown rotated around their z-axis in fixed degrees (frame +/-33 or 0, and rod +/-22 or +/-11). Using the controller, the rod can be orientated in clock- and counterclockwise direction. 

### Functions
- rotate the rod clockwise with the right side or counterclockwise with the left side of the controller trackpad
- start next trial by pulling the trigger on the back of the controller
- option to reset rod to starting position for each trial
- record the VR experience
- end the application by simply right-clicking the mouse or closing the window
- save the data of each participant automatically after closing the application in separate folders
- participant number can be inserted in a text bar in the menu before the start

This VR environment is programmed for the HTC Vive controllers. While the application should work with different hardware, other devices may have limited functionality. Oculus devices do not have controller bindings, but should have full visuals.

## Scene and Custom Scripts
The “RFT.unity” file with the original Unity scene can be found in the folder [My Scenes](https://github.com/JudiJ/RFT_Project/tree/main/My%20Scenes). 

The C#-code for the custom-created assets can be found in the folder [My Scripts](https://github.com/JudiJ/RFT_Project/tree/main/My%20Scripts). The custom scripts include: 
- “CanvasManager.cs” generates a black floating surface in front of the scene for assessing questionnaires between trials (3 blocks)
- “Frame.cs” generates a floating 3D object to be rotated in Euler angles
- “Rod.cs” generates a floating 3D object to be rotated in Euler angles
- “Menu.cs” generates a text bar to insert the participant number
- “NotsoBright.mat” reduces the brightness of the rod and frame objects to minimize visual afterimages

### Project Layout
This project is organised in 5 folders:
- "My Scenes" contains the Unity scene with the corresponding meta file.
- "My Scripts" contains the programming scripts for the custom assets created with Blender (version 2.90)
- “SteamVR” contains editor, prefab folders, scripts, and materials from the SteamVR Plugin (v2.3.2).
- “SteamVR_Input” contains actions and action set classes from the SteamVR Plugin. 
- “TextMesh Pro” contains the TextMesh Pro! plugin (version 1.0.54, Bouchard 2016): text assets and materials.

### Supplementary
Each file is complemented with a meta-file.

The scripts were programmed with the Unity game engine version v2019.1.11f1. Steam VR Assets (version 2.3.2) enhanced with custom-designed assets, created in Blender version 2.90. 

The application was originally run with a Windows 10 (64 bit) computer, NVIDIA GeForce RTX 2070 GPU and Intel Core i7-9700K processor.

Bouchard, S. (2016): TextMesh Pro! Advanced Text Rendering for Unity 3D. User Guide. Release 1.0.54

Shield: [![CC BY 4.0][cc-by-shield]][cc-by]

This work is licensed under a
[Creative Commons Attribution 4.0 International License][cc-by].

[![CC BY 4.0][cc-by-image]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://i.creativecommons.org/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY%204.0-lightgrey.svg
