# Blue Game Project

# Game Design Document

Created by: BlueGame Team


## Overview

### Gameplay
You fly a Space ship from left to right. The screen will automatically scroll and you can move around on it.
The ship will shoot a basic projectile automatically. On your way you will find consumables and upgrades.
Enemies Will come from the right side of the screen in various patterns.
There will be various obstacles in your way like meteors or you will fly through a planet dodging rocks.
At the end of a level there will be some sort of boss or bigger enemy.
There will be milestones the player can reach wich allows him to unlock new ships aswell as upgrades, weapons and consumables wich he can find along the way.

### Enemies
Each World with have their own themes in enemies. They will be diffent types of enemies, both flying and stationary / moving on the ground or on the ceiling.
The player won't be able to kill them off screen, giving us more freedom in creating crazy weapon attack and also force the player to focus on what's on screen at all times.
The enemies will be pre-positioned in every stage, so they will always be in the same place when the player repeats the level.
Since the player will be rewardedd for clreaing the stage, enemies will not take any damage and won't be destroyed by any means but the player's attacks.

### Target Platform
We will focus on a PC Version first.
This game will be very easy to port to other decives, so an android / iOS version will be made if desired by the developers.

### Visual Style
The Visuals will be CLEAN and GEOMETRICAL. Sharp edges, no outlines, no pixel art.
We will have a mix of 2D and 3D art aswell as some VFX to go along with them. This will give the game a more modern feel, since the genre itself had it's peak in the mid 90's I feel like that is the right way to go.
The player and the enemies will be kept in 2D while other objects in the background aswell as weapons (ex. Rockets, Lasers, Energy Blades) will be mainly in a low-poly 3D style. This will give us the most freedom in our visual representation.
The various themes of the worlds (explained below) will also enable us to experiment with this mix of 2D and 3D.

### Audio Style
Audio in generell will be CLEAN aswell.
The music will have an oldschool Trance / Techno vibe. Very electronic in nature. I will be upbeat and fast to make it feel energetic and make you feel like there's a space fight with action going on.
Every sound in the game will be made by a synthesizer. There will be no samples to enforce the abstract, electronical nature of the visuals.
Explosions, laser sounds ect. will also play a big part in the game to make the unlocked weaponry exciting and statisfying.

### Starting Out / Main Menu
Game start – Main Menu – Character Selection/Creation
- The game will start out with our Logo, then the Logo of the game and a loading bar
- After that, you will be in the main menu right away. The graphics will be clean and minimalistic. There will be a Continue, Start New and exit button in the middle. To the left and the right there will be arrows. Those will lead to the Upgrades and Ships menus. in the upper right corner there will e a cogwheel for an options menu. there you can adjust the music / sound volume, edit window or fullscreen resolutions and reset your progress completely.
- in the Ship selection menu there will be icons for each ship. when you click on them you will see their stats and how to unlock them.
- in the upgrades menu there will be the same (but with the upgrages of course), aswell as the option to lock / unlock the upgrades you can find along the way.
- The cosumables, power-ups and limited weapons can then be randomly found along the way by destroying enemies.

### Game Start and Intro
- When you first start, you will be in the first level straight away. A message will pop open, telling you that enemies are comming and that you need to kill them. After 3 groups of enemies, your first upgrade will appear. When collected another message will pop open, telling you that there will be way more out there and that you have to kill more enemies and look for them to find them.
- that will be all the tutorial we need for now

### In-Game HUD & Menus
- In the upper left there will be a health / life bar, telling you how many hits you can take before a game over.
In the upper right there will be a bar that is telling you how many enemies you killed / missed
In the upper center it will show you your current usable upgrades (some ammo / cooldown based)
- You can access a pause menu when ESC is pressed (menu button on android) that will pause the game, giving you the option to continue, restart or quit to main menu. More information about the game / player will be shown here.


![UI and Upgrade](https://github.com/GraphicEdit/BlueProject/blob/master/GDD_files/UI%20and%20Upgrade.png)

### Multiplayer
If any Multiplayer at all, i suggest a solution, where 1 player can host and another can join. Enemy health will be x1.8 or something then. (needs playtesting)

### Game Over Screen
When all health is gone, the player needs to restart the current level.
when all lifes are gone, the player needs to restart the game but keeps his unlocked ships / upgrades.


### Level Types:
We will aim for 5 Different worlds, devided each by 3 stages.
2 basic stages that you have to get through, while killing at least some amount of enemies
The third stage will be a bit shorter and have a Boss fight at the end.
each world will have it's own unique colour scheme and music theme. Also each world will have different enemies.
There will be 2 types of levels: completely open field and about 20% levels with objects in your path, comming from the upper and lower end of the screen, that you will need to avoid. (like going though a mechanical fortress or through a planet)


### Mechanics
The basic controls will be up, down, left and right movement. A basic projectile will be shooting rather quickly by the first ship you have unlocked as a base, but it has low damage. The consumables and limited weapons you find along the way will be displayed in the upper middle of the screen and can be used by pressing 1-4 (or touching them on touchscreen). Every ship will have a unique ability like going faster, but less health, aswell as it's own unique starting weapon.
Examples of limited weapons / skills / consumables would be A missle swarm attack, a big charging laser, a fast dash, or a simple heal or temporary shield.

### Modes
When the game is finished the player will unlock a HELL mode where enemies are stronger in some capacity (more health / shoot faster)
I'm also thinking of an unlimited mode where you can just keep going endlessly but we will see about that.

### Winning
The player wins a normal stage by reaching it's end.
The player will win a boss stage by defeating the boss.

### Currency
This is something i would put in a free android version only. the player can earn currency to unlock things instead of getting it as random drops or unlocking them by beating bosses or getting archievements. We can then have the player watch ads for more currency or make him pay to unlock every / get more currency.


### Missions and Achievements
The side-mission besieds reaching the end of the game will always be trying to clear 100% of enemies in the stage.
We will have something like a 3 star rating system to inform the player on how many enemies he has killed.
Archievement will also play a big roll in this game, since they will allw you to unlock a SECOND starting weapon or ability (besides the weapon that each unique ship comes with already). Examples for archievements are Not getting hit, Not missing a shot, only using base weapons, surving a level with 1 health point and 1 life remaining ect...

## Assets
The player ships.
A LOT of different enemy sprites.
Background art and moving pieces for the background.
Sound and music.
Well... we need pretty much everything i discribed above.

### Characters
Our ships will be our "characters" for this, thuus making it important to make every ship that can be unlocked look unique with a fitting weapon and color to go onlong with. examples beeing a pointy ship with sharp edges that uses an energy blade or a big, rounder ship with a bigger health pool

### Weapons
We need code to make every weapon unique. Heat seeking missles, lasers, rockets, bombs ect.
Also some enemies will shoot at you. Maybe they will use the weapons that you can unlock along the way to give you a taste of them.
Also saves a bit of workload.


### Story and Cinematics
- Wont be needed since this is a pretts simple game
- if added, a simple pause + display text option should be enough and not too hard to add.


THANK YOU all for reading this. And THANK YOU for working with us on this project.
I would love to hear any suggestions on our Discord server.

