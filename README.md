![Screenshot 2024-09-27 103019](https://github.com/user-attachments/assets/89d944b6-c0cc-4ec1-a77a-badd43790cc1)# The Scavenger

![home screen](https://github.com/user-attachments/assets/73050d7c-95b7-4987-9847-4564b6643243)

# Table of Contents 
- [Table of Contents](#Table-of-Contents)
- [User Documentation](#User-Documentation)
- [How to play the game](#How-to-play-the-game)
- [The aim of the game](#The-Aim-of-the-game)
- [Walkthrough](#Walk-through)
- [Developer Documentation](#Developer-Documentation)
- [What I intended to create](#What-I-intended-to-create)
- [Characters](#Characters)
- [Level Design](#Level-Design)
- [Bibliography](#Bibliography---Tutorials-used)
- [Assets](#Assets)

# User Documentation

## How to play the game
On keyboard, the player can use the A & D keys to move to the left or the right ( A to the left, D to the right). The space-bar, when pressed, will allow the player to jump in the air, an the LEFT MOUSE button will swing the players sword, damaging any enemies in its radius.

![20240924_164043](https://github.com/user-attachments/assets/28c8e391-ba78-46db-953e-fd857ca48220)

On controller, the player can use the left joystick to move to the left or right. The A button, when pressed, will allow the player to jump in the air, and the right trigger button will swing the players sword, damaging any enemies in its radius. 

![Untitled drawing](https://github.com/user-attachments/assets/99b6d252-5315-48e8-9c37-5a84d93baa91)

## The Aim of the game
The aim of the game is to return home to your apocalyptic bunker after spending all day scavenging for food. Collect as many food items as you can along the way, but be warned, many retched creatures still live in amongst the rubble, and their hungry too!

## Walk through

https://youtu.be/x_jfCNGDfUc

# Developer Documentation

## What I intended to create
I worked with a multimedia student who helped me come up with the idea and basis of the game. We planned to create a world where the world has been struck by climate change so severely that it becomes apocalyptic. The main character is left to wonder about this world, they get to explore the wreckage and kill enemies as well as collect supplies like meat to survive, as they attempt to tavel back home to his apocalyptic bunker. The world they wander is isolated and plagued by monsters created by adapting to these harsh conditions left by the effects of climate change. 
### Intention for enemies
For the different levels we decided on having the main character travel through different seasons, e.g summer transitions to autumn wich transitions to winter and then to spring. As the seasons change different enemies will apear to try and attack the player. These animals have become mutant, adapting to their new-found environment. For example, a Walrus that stands up on two legs, or a kangaroo with a fur coat. 
### Intention for Collectables
Throughout the game the player will need to colect as many collectables as possible. These collectables will be in the form of scrap metal or food supplies. At the end of the game it will display how many of these supplies the player has collected. This is the underlying goal of the game, other than getting back to your bunker. 

## The Aim of the task 
The aim of the task is to design and develop a 2D game in unity. I must apply my understanding of programming and game engines to complete a fully functioning 2D game. I also need to produce a READ.md that promotes the game and our development skills to a future employer. I worked with a multimedia student who designed and drew, using the Piskel app, all of the sprites and assets that I used in the game. Below is some examples of the assets that where producede and used. 

## Characters

### Player
The player is a person who is living in an apocalyptic landscape, scavenging for food and supplies to bring back to his bunker. He is designed to look scrapy, as clothing is scarse in a barren wasteland. The player can move left, right, and jump up in the air to avoid spiked or climb objects. The player has a sword as well, unsheathing it when the left mouse button is clicked to kill enemies. The player has a substantial amount of health, able to take quite a few blows from enemies, as well as land on a couple spikes before dying.  

### Enemies/Boss Fight 
There are two main enemies in this game, both of which, are mutated hyenas, who roam the landscape in search of prey. One of them is located at the end of level one, and the other, the end of level two. The enemies move between two patrol points, going back and forth until a player is in sight. When any of the hyenas see the player, they will enter a 'chase mode', where they will not stop attacking the player until they or the player are dead. When the hyenas come into collision with the player, it knocks them back, while also doing a signifigant amount of damage. Not only that, but the hyenas have a signifigant amount of health as well, being able to take many blows from the player. 

## Level Design

### Level 1 
level one is based around the season of autumn. The ground is a brown dirt colour, covered in orange leaves. I used a Particle system and imported a leave texture to make the scene look even more realistic by making it look like autumn leaves are falling from the trees in the background. Throughout the level, there are spikes which damage you. These are the main obstacles which apear throughout the game, and the player has to avoid these by jumping over them or finding routes around them. There are also meat pickups which are scattered around the level. When you pick them up, a counter at the top of the screen adds +1. At the end of the game there is a boss fight. The boss is a mutant hyena who chases you and does damage. Once you kill the boss, it will drop some meat to pick up. 
-Here are the settings for the particles: 

![Screenshot 2024-09-27 102014](https://github.com/user-attachments/assets/912b6f89-fc2c-4476-8a96-3e1965828863)
![Screenshot 2024-09-27 101939](https://github.com/user-attachments/assets/d482269e-a161-4a84-99dd-108848d10e0a)

-Here is the code for the pickups:

![Screenshot 2024-09-27 102639](https://github.com/user-attachments/assets/ace07100-5c64-4ebc-b7d3-9f88eff1d08e)

### Level 2
Level 2 is based around the season of winter. The ground is a snowy colour and the background is a winter scene. I Also used particles in this level, but this time, I created and imported a snowflake texture so it looked like it was snowing the whole way throught the level. In the level there are the same spikes, but re-textured to look like icycles. They do the same amount of damage and are placed all around the map as obstacles as you try to make it through. Half way through the level there are some rickety bridges. The first bridge has a script that zomms out the camera, showing a bigger picture and letting the player sus-out their bearings. The next bridge, once tocuhed, brakes and makes you fall into a cave. The cave is very dimly lit, and you have to navigate your way out by following the torches. I used the Unity's light source to make the cave dark and to lght up the torches.
-Here are the settings for the particles
![Screenshot 2024-09-27 103057](https://github.com/user-attachments/assets/16ce0963-6454-4054-a46b-7fc99eef037d)
![Screenshot 2024-09-27 103044](https://github.com/user-attachments/assets/08d12f7b-0838-4b6f-81d4-9e5f625c3184)
-Here is the code for the falling bridge
![Screenshot 2024-09-27 103019](https://github.com/user-attachments/assets/7af342a2-c9f4-47e9-94b9-cd97bf77395c)

### Bibliography - Tutorials used

- https://www.youtube.com/watch?v=BLfNP4Sc_iA health bar link
- https://www.youtube.com/watch?v=bRcMVkJS3XQ&t=45s better health bar link (with damaging players) 
- https://www.youtube.com/watch?v=pKFtyaAPzYo game over screen 
- https://www.youtube.com/watch?v=hkaysu1Z-N8 player animation 
- https://www.youtube.com/watch?v=5GWRPwuWtsQ&t=49s PICKUPS
- https://www.youtube.com/watch?v=pARkG6TupWM leave
- https://www.youtube.com/watch?v=sPiVz1k-fEs melee animation and attack 
- https://www.youtube.com full enemy tutorial 
- https://www.fontspace.com/doom-2016-font-f43672 Fonts
- https://www.youtube.com/watch?v=n-eLq6tVaN8 Fire effect
- https://www.youtube.com/watch?v=yaQlRvHgIvE Camera 
- https://www.youtube.com/watch?v=QUbW6me4D1w UI transitions


## Assets

### Player 
![Screenshot 2024-09-26 124437](https://github.com/user-attachments/assets/b8cfc144-8367-46ff-a7be-bac84a44252d)
![Screenshot 2024-09-26 124457](https://github.com/user-attachments/assets/ea8dd923-e7ae-4bb7-bea9-8717c402d124)
![MainCharacter](https://github.com/user-attachments/assets/2adeb6e0-288a-440e-816b-909ea4b601ae)
![Character (2)](https://github.com/user-attachments/assets/a574f7be-25a6-4240-a63b-00460f8b6354)
![Character falling animation](https://github.com/user-attachments/assets/04639106-0aef-4584-89cf-9bb5864c67bb)
![Character idle ](https://github.com/user-attachments/assets/30688c87-d1fb-49df-8788-383966de6030)


## Enemies

![Hyena Hyde Idle](https://github.com/user-attachments/assets/4151ebf0-f2cb-4282-bc1c-e6eadfef3aed)
![Hyena Hyde death](https://github.com/user-attachments/assets/b4b770ce-cc28-4d6e-8429-737c1c8e71ee)
![Hyena Hyde Damage](https://github.com/user-attachments/assets/85013b47-f1e9-4162-80b9-6f8f2782b3ab)


## UI

![Screenshot 2024-09-26 124359](https://github.com/user-attachments/assets/2f0ff579-48fa-4512-901c-9624dbf27290)
![Screenshot 2024-09-26 192518](https://github.com/user-attachments/assets/7cbc390a-e350-4ac4-a4a3-a7cf1036cc39)
![Screenshot 2024-09-26 192508](https://github.com/user-attachments/assets/b41a2d4e-eadc-4342-b355-e66280794848)


### Tiles 

![Screenshot 2024-09-26 124420](https://github.com/user-attachments/assets/6322ea56-87c3-4b2f-af9f-e58182a4ceaa)

### Environment

![Screenshot 2024-09-26 182732](https://github.com/user-attachments/assets/d109b7a4-0f71-4ccc-90fa-5104cb9e2c74)
![Screenshot 2024-09-26 182722](https://github.com/user-attachments/assets/d9defe92-97b8-42ee-a33f-afe2ee3b447d)
![Screenshot 2024-09-26 182524](https://github.com/user-attachments/assets/0c7721be-3f8a-4690-aee1-2789c7cc0cd0)
![Screenshot 2024-09-26 182619](https://github.com/user-attachments/assets/1c5fa3e7-a5bd-4221-98e1-ee90fb229690)
![Screenshot 2024-09-26 182658](https://github.com/user-attachments/assets/ebea989a-80d5-425b-924a-2af2d07f95b9)

# Tools Used in this game

## Unity

**Unity Game engine**
_____________________________
![unity](https://github.com/user-attachments/assets/d5f2a8ab-d88f-4eca-a5c2-eae42b922da6)

![snowig](https://github.com/user-attachments/assets/b2d028ae-cf82-4d51-a184-142b1b0f74a5)


## Piskel

**Piskel sprite creator**
_____________________________
![Pikskel](https://github.com/user-attachments/assets/7d78a18c-7c21-4ccb-ae8a-43a847539745)
![iskels](https://github.com/user-attachments/assets/3d4cb44e-b408-43f1-a917-e6ba207f7669)

## Visual Studio Code 

**Coding tool**
_____________________________
![vidual studio](https://github.com/user-attachments/assets/7427443e-6378-471c-ad5a-145eafc0b726)

