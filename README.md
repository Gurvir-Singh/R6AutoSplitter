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
Sometimes the split starts right after the countdown and stops 1 second in. To fix this you have to restard your game. I think this is because the game for whatever reason sometimes puts up a directX surface that goes straight to your graphics processer. The Splitter uses windows capture tools which bug out completley when dealing with directX surfaces. This is probably the worst bug rn
