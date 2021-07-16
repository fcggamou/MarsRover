# Solution to the Mars Rover problem using C# and .NET Core 5
Simple yet elegant solution to the Mars Rover programming problem.
- Follows SOLID principles.
- Uses Command design pattern.
- Uses Factory desiign pattern.
- Unit tested using MOQ.


# Requirements
You need to code a program to validate the commands that will be sent to a new Rover in Mars. Each Rover is included in a square and can receive the next commands: Advance (A), Turn left (L), Turn Right (R). The program must validate that the Rover will be within the bounds of the square and must indicate the final orientation.
The program will receive the dimensions of the square (width x height) and can assume that the coordinate (0,0) is the bottom left corner. Additionally, will receive initial coordinates of the Rover and its initial orientation (N, S, E, W).
Also, it will receive a set of commands like the next one; AALAARALA. There is not fixed limit of number of input commands. It can be assumed that there are not obstacles in the square. The program must validate that all the commands can be executed without being out of the defined bounds and must also return True or False indicating if the commands are valid. Additionally, it must return the orientation and final coordinates of the Rover As example: True, N, (4,5).
