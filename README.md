# alu-0x0A-unity-360_video_tour
  ## Overview
  This Unity project is an interactive 360 VR house experience where users can switch between multiple room environments by clicking buttons inside spherical scenes (Living Room, Cube Room, 
  Cantina, Mezzanine). Each room includes buttons that allow transitions to other connected rooms with smooth fade effects. Additional UI panels ( info panels) are also toggleable on click.
## Features
- Scene switching among rooms vi UI buttons in spheres
- Smooth fade-in/fade-out transitions during room changes
- Info panels that toggle on/off when clicked
- Room navigation structure:
       - Living Room: buttons to Cube and Cantina
       - Cantina: buttons to Cube and LivingRoom
       - Cube: buttons to Cantina, LivingRoom, and Mezzanine
       - Mezzanine: button to Cube
  
## Credits
- Unity Engine technologies(XR Interaction toolkit, XR Plugin Management, Etc.)
- Unity version 2022.3.55f1
- Background music: Tech live by Kevin MacLeod
- UI Buttons: FreePik

## Build tools
- Build for and tested in MetaQuest 2(Oculus)
- Note: the video characters might look enlarged because of the sphere scale(50).


