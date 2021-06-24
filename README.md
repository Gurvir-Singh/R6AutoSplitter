# R6AutoSplitter


## Getting Started

### Note
This only works with the DirectX version of Siege. Vulkan does not work. 

### Opening the app
As of right now to open the application go into the R6AutoSplitter/Debug folder then run the .exe 
or
Open the project in visual studio with the .sln file and build and run it yourself. (This way you can edit the code)

### Working with livesplit
Right now the in order for it to work with livesplit you split key needs to be tilde (~) and your pause key needs to be end. 


## Issues/Missing Features

### Modes
As of right now only thunt works correctly. All thunts is buggy and the two situation options do nothing past the countdown.

### Incorrect Splitting
Sometimes the split starts right after the countdown and stops 1 second in. Enabling V-Sync fixes this. The reason is because without vsync on the gpu is constantly updating the frame buffer and it results in the bmp being corrupted and the split starting at the wrong time. I have yet to find a workaround for this but i think the key is to use directX
