# Readme RFT_Project

This project contains the source code and assets for a virtual rod and frame test (RFT). 
It was developed for the 2023/24 study "In Rod we Trust - The evaluation of virtual Rod and Frame Test as a cybersickness screening instrument" by J. Josupeit.

## Description of the Application
In a dark room, participants will see a rectangular frame and a rod represented by an opaque cubiod with two dots at the ends. 
At the start of each trial (40 trials in total), the rod and frame are rotated around their z-axis (global Unity z-coordinates) in fixed degrees (frame +/-33 or 0, and rod +/-22 or +/-11). 
The task for the participant is to adjust the rotated rod to their subjective vertical, regardless of the frame's rotation. 
To rotate the rod clockwise the right side of the trackpad needs to be pressed, for counterclockwise rotation the left side. When the adjustment of the rod is confirmed by pulling the trigger, the next trial starts. 

After opening the application, the menu shows a text bar to insert the participant number. 
Pressing “Enter” on the numbpad closes the menu and starts the recording. 
“Esc” resets the rod to starting position of the respective trial. Right clicking the mouse or closing the window with the cursor ends the application. Closing the application saves the recorded data automatically in a separate folder. 

To download and test the application, go to github.com/JudiJ/Application_RFT

## Program and Scripts
“MyScenes” contains the “RFT.unity” file. It opens the original scene that was adapted with SteamVR and custom-designed assets in Unity. 

“MyScripts” contains the C#-code for the custom-created assets: 
- “CanvasManager.cs” generates a black floating surface in front of the scene for assessing questionnaires between trials (3 blocks)
- “Frame.cs” generates a floating 3D object to be rotated in Euler angles
- “Rod.cs” generates a floating 3D object to be rotated in Euler angles
- “Menu.cs” generates a text bar to insert the participant number
- “NotsoBright.mat” reduces the brightness of the rod and frame objects to minimize visual afterimages

“SteamVR” contains editor, prefab folders, scripts, and materials from the SteamVR Plugin (v2.3.2).

“SteamVR_Input” contains actions and action set classes from the SteamVR Plugin. 

“TextMesh Pro” contains the TextMesh Pro! plugin (version 1.0.54, Bouchard 2016): text assets and materials.

### Supplementary
Each file is complemented with a meta-file.

The Unity game engine version is v2019.1.11f1. Steam VR Assets were employed (version 2.3.2) and enhanced with custom-designed assets created using Blender version 2.90. 
The application was originally run with a Windows 10 (64 bit) computer, NVIDIA GeForce RTX 2070 GPU and Intel Core i7-9700K processor.

Bouchard, S. (2016): TextMesh Pro! Advanced Text Rendering for Unity 3D. User Guide. Release 1.0.54

Shield: [![CC BY 4.0][cc-by-shield]][cc-by]

This work is licensed under a
[Creative Commons Attribution 4.0 International License][cc-by].

[![CC BY 4.0][cc-by-image]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://i.creativecommons.org/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY%204.0-lightgrey.svg
