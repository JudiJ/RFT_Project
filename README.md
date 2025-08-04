# Readme RFT_Project

This project contains the programming scripts and assets for the Virtual Rod and Frame Test (RFT). 

It was developed for the 2023/24 study "In Rod we Trust - The evaluation of virtual Rod and Frame Test as a cybersickness screening instrument" by J. Josupeit.

Download the zip folder to get the original Unity scene (requires v2019.1.11f1), the corresponding scripts, and the prefabs used for the VR application.

To download and test the application, go to [App_RFT](https://github.com/JudiJ/App_RFT).

## The Application
In a dark room, a rectangular frame and a rod, represented by an opaque rectangle with two spheres as child objects attached to both ends, are presented.
At the start of each trial, the rod and frame are shown rotated around their z-axis in fixed degrees (frame +/-33 or 0, and rod +/-22 or +/-11). Using the trackpad of the HCT Vive controller, the rod can be rotated in clock- or counterclockwise direction along the z-axis. 

### Functions
- participant's code can be inserted in a text bar in the menu before the start, the data of each session will be logged automatically after confirmation (ENTER Numpad)
  - automatic log:
     - the the system time ("yy/MM/dd HH:mm:ss:fffff")
     - the trial number
     - the event of pulling the trigger (unequal to the trial number in cases, in which resetting a trial is necessary)
     - the z-rotational axis of the frame and the rod in global Unity coordinates
     - the input on the x- and y-axis of the controller
     - the position and rotation of the virtual camera in global Unity coordinates
- the rod can be rotated clockwise by pressing the right side or counterclockwise by pressing the left side of the HTC Vive controller trackpad
- the next trial can be started by pulling the trigger of the HTC Vive controller
- option to reset each trial

Key bindings are programmed for HTC Vive controllers. To ensure compatibility with other devices, check the key bindings in Steam VR. 

## Scene and Custom Scripts
The “RFT.unity” file with the original Unity scene can be found in the folder [My Scenes](https://github.com/JudiJ/RFT_Project/tree/main/My%20Scenes). 

The C#-code can be found in the folder [My Scripts](https://github.com/JudiJ/RFT_Project/tree/main/Assets/My%20Scripts). 

The custom scripts include: 
- “CanvasManager.cs” disables the input field after a button click
- “Rod.cs”  contains the rationale for rotating the rod each trial and the respective reset function
- “Frame.cs” contains the rationale for rotating the frame each trial and the respective reset function
- “Menu.cs” enables the constellation switches between every trial, diplayes the grey plane for the 3 blocks, and starts the main scene (ENTER on the Numpad) 
- “Output.cs” contains the logging routine and works in the editor, as well as in the built application (adjust the path according to your own needs)

Additionally, custom material is included: 
- “NotsoBright.mat” is a dim-light version of white, the custom material used for the rod and frame objects to minimize the likelihood of afterimages

### Project Layout
This project is organized into 5 main folders:
- "My Scenes" contains the RFT scene with the corresponding meta files
- "My Scripts" contains the scripts and the custom material
- “SteamVR” contains assests from the SteamVR Plugin (v2.3.2).
- “SteamVR_Input” contains action set classes from the SteamVR Plugin. 
- “TextMesh Pro” contains the TextMesh Pro! plugin (version 1.0.54, Bouchard 2016): text assets and materials.

### Supplementary
Each file is complemented with the respective meta-file.

To open the scene in the editor Unity game engine version v2019.1.11f1. is required. 

The application was originally run with a Windows 10 (64 bit) computer, NVIDIA GeForce RTX 2070 GPU and Intel Core i7-9700K processor.

Bouchard, S. (2016): TextMesh Pro! Advanced Text Rendering for Unity 3D. User Guide. Release 1.0.54

## License
Shield: [![CC BY 4.0][cc-by-shield]][cc-by]

This work is licensed under a
[Creative Commons Attribution 4.0 International License][cc-by].

[![CC BY 4.0][cc-by-image]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://i.creativecommons.org/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY%204.0-lightgrey.svg
