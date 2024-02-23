# Readme RFT_Project

This project contains the programming scripts and assets for a virtual rod and frame test (RFT). 
It was developed for the 2022/23 experiment "Replication of Field-Dependency and Cybersickness" by J. Josupeit, L. Greim, and S. Sanchez Rivas.

## Description of the Application
In a dark room, participants will see a rectangular frame and a cuboid rod with round dots at both ends. 
At the start of each trial, the rod and frame are rotated on their z-axis (global Unity coordinates) in fixed degrees (frame 33, 0, and -33, rod 22, 11, -11, and -22). 
The task for the virtual RFT is to orientate the rod to verticality, while ignoring the rotation of the frame. 
To rotate the rod left and right, the participant can press the thumb on the left or right side on the controller trackpad. 
When the input is confirmed, the next trial can be started by pulling the trigger at the back of the controller.

After opening the application, the menu shows a text bar to insert the participant number. 
Pressing “Enter” on the numbpad closes the menu and starts the recording. 
“Esc” resets the RFT to starting position, “0” resets to the black background start screen. By right clicking the mouse or closing the window with the cursor the application ends. Closing the application saves the recorded data automatically in a separate folder. 

To download and test the application, go to github.com/JudiJ/Application_RFT

## Program and Scripts
“MyScenes” contains the “RFT.unity” file with the original scene in Unity that was adapted with SteamVR and custom-generated assets. 

“MyScripts” contains the C#-code for the custom-created assets: 
- “CanvasManager.cs” generates a black floating surface in front of the scene for assessing questionnaires between trials
- “Frame.cs” generates a floating 3D object to be rotated in Euler angles
- “Rod.cs” generates a floating 3D object to be rotated in Euler angles
- “Menu.cs” generates a text bar to insert the participant number
- “NotsoBright.mat” reduces the brightness of the rod and frame objects to minimize visual afterimages

“SteamVR”, “SteamVR_Input” contain the generic code for prefabs, materials and action classes from the SteamVR Plugin (v2.3.2). 
“TextMesh Pro” contains the TextMesh Pro! plugin (version 1.0.54, Bouchard 2016): text assets and materials.

### Supplementary
Each file is complemented with a meta-file.

The Unity game engine version is v2019.1.11f1. Steam VR Assets version 2.3.2 were used. Custom assets were created using Blender version 2.90. 
The application was originally run with a Windows 10 (64 bit) computer, NVIDIA GeForce RTX 2070 GPU and Intel Core i7-9700K processor.
