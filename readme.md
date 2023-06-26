# Delivery Driver
Player Drives around in a car picking up deliveries and dropping them off.

## How It's Made:





**Tech used:** 
Unity Game Engine and C#

## Game Mechanics We Need
- Driving car forwards and backwards
- Turning car left and right
- Increase speed up when drive over "Speed ups" 
- Decrease speed when drive over them
- Pick up packages when drive over them
- Deliver package when drive over delivery spot 
- Change car color to show status of package up up

# Game Design

## Player Experience
relaxing driving game 

## Core Mechanic 

## Game Loop

Find and deliver all the package to win 






## Optimizations
*(optional)*


## Lessons Learned:
Using Time.deltaTime Unity tells us how long each frame took to execute
When we multiple something byt the Time.deltaTime it makes the game "Frame Rate Independent"
SerializeField makes is avaivable on the Unity game side. 
SerializeField makes is avaivable on the Unity game side. 



### Changing the Script editor 

Edit -> Preferences 





### Collision 
You need to add a collider as well as a ridig body to the game object to intertact with an object. 

### when adding a rigdge body the gravity is set to zero

Added box collider to our player instead of a capsule collider to give it more of a push

Added Delta Time to allow frame rate Independence

Created a collision script using On Collision Enter
Allows use to do something when collision is detected

### Unity Input System
- taking the players actions(button and keyboard presses) and putting into information for the game
- Unity has the old system and the new system 


### Old input System


to get the to old input system Edit -> project settings -> input Mananger -> vertical and horizontal 

- Keep in mind names MUST be exact!! 
- vertical and horizontal go from -1 to +1 








