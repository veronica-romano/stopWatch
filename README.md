# stopWatch
Simple stopwatch code made in the balta.io's c# introduction course

## The project

### Main 
The entry point of the program. It displays a "Hello World!" message and then calls the Menu method.

### Menu: 
is a method that displays a menu for the user to choose between seconds (s), minutes (m), or exiting (0s). 
It reads the user's input;
parses it to determine the time and type;
calls the PreStart method with the calculated time.

### PreStart: 
This method displays countdown messages ("Ready...", "Set...", "Go!").
With a delay of one second each using Thread.Sleep. 
After the "Go!" message, it calls the Start method to initiate the actual stopwatch countdown.


