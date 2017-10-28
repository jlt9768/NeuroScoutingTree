# NeuroScoutingTree

# How the code works
These scripts work by creating a tree data structure with a depth defined by user input in the command window. The tree starts off with a root node and for each level of depth that is still needed to create it, it adds child nodes to each node at the current depth. It keeps track of neighboring nodes based on what the last created node at the current depth was and the node created after it. It continues this process til it reaches the user inputted depth.

# To compile and run 
Either open up the sln file in visual studio and start the program. 
Or run the .exe file in the Debug folder that is just inside the main TreeExercise folder. This folder is just obtained from the bin folder deeper in the folder directories.

# Organization
The code is organized in a Tree class and a Node Class. The Tree class knows the root node and creates the tree from said root. The node class handles what the parent node of the node is, what the value of the node is, the value of its neighbors, and what nodes are it's children.
The program will start up by creating a tree object and then asking for the depth of the array. When the user inputs a value it will create an a tree of n depth. The program will also check to make sure it is valid input, depth >=1 and if it is actually a number and not a letter. While the tree is created it will print out the values of every node on a given depth on a new line in the console window.
