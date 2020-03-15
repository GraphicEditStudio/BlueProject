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
There will be milestones the player can reach wich allows him to unlock new ships and upgrades / consumables wich he can find along the way.

---

Player space ship must destroy some determined number of enemies and collect the **hyper space particles** that jump into hyperspace where will fight vs boss from hyperspace dimension, which atack subspace dimension(usual space).  
This means if you lazy ass, then you can fly long time without kill enough enemies but level will be not switched to boss.  
The boss battle have some fractals or sinus fast left to right flying curves and fast flying colored lines on background.  

The player space ship have three weapon styles:
- **energy impulse/ laser ray** etc weapon. Can be turned on/off on right side of screen for mobile, and some keyboard shortcut and mouse button for desktop  
- **rockets** , can be upgraded from one per shot to 5 per shot or shooted rockets depend of ship. Shooted uses right side of mobile screen , or space and other mouse button for keyboard. In shot time rockets first flying from ship hull along one vertical line. First rocket on ship center level other 4 upper and lower than center with similar distance and parallel trajectory, and than fly parallel forward. Rockets can be collected or buyed in menu before level started  
- **hyper space particles plasma ball** , can be collected on level, after destroy enemies, which use it as fuel that jump into our space. Very effective vs boss, but usual weapon enough too that damage boss. Plasma ball just flying forward, after some sfx and vfx effects of charging process.

There is three type of ship:
- fast moving with low armor (tiny hp) and minimal size. Triangle star based can be enough good.  
- intermedial moving with medium armor and medium size. More tube styled with wings in one plane etc.  
- slow moving with strong armor (big hp) and maximum size. "Fat boy" , with short wings or without wings.  

Just other sprite/model and other characteristics, nothing especial.

The fast ship need less **hyper space particles** 25% for hyper jump into boss space, the slow ship need more **hyper space particles** 100%.

Fast ship shoot one rocket per shot.  
Slow ship shoot 5 rockets per shot.

---

### Target Platform
We will focus on a PC Version first.
This game will be very easy to port to other decives, so an android / iOS version will be made if desired by the developers.

### Visual Style
The Visuals will be CLEAN and GEOMETRICAL. Sharp edges, no outlines.
The background will be filled with abstract geometrical shapes but still looks like a galaxy / night sky.

### Audio Style
Audio in generell will be CLEAN aswell.
The music will have an oldschool Trance / Techno vibe. Very electronic in nature.
Every sound in the game will be made by a synthesizer. There will be no samples to enforce the abstract, electronical nature of the visuals.

### Starting Out / Main Menu
Game start – Main Menu – Character Selection/Creation
- The game will start out with our Logo, then the Logo of the game and a loading bar
- After that, you will be in the main menu right away. The graphics will be clean and minimalistic. There will be a Continue, Start New and exit button in the middle. To the left and the right there will be arrows. Those will lead to the Upgrades and Ships menus. in the upper right corner there will e a cogwheel for an options menu. there you can adjust the music / sound volume, edit window or fullscreen resolutions and reset your progress completely.
- in the Ship selection menu there will be icons for each ship. when you click on them you will see their stats and how to unlock them.
- in the upgrades menu there will be the same (but with the upgrages uf course), aswell as the option to lock / unlock the upgrades you can find along the way.
- The upgrades can then be randomly found along the way by destroying enemies.

### Game Start and Intro
- When you first start, you will be in the first level straight away. A message will pop open, telling you that enemies are comming and that you need to kill them. After 3 groups of enemies, your first upgrade will appear. When collected another message will pop open, telling you that there will be way more out there and that you have to kill more enemies and look for them to find them.
- that will be all the tutorial we need for now

### In-Game HUD & Menus
- In the upper left therre will be a health / life bar, telling you how many hits you can take before a game over.
In the upper right there will be a bar that is telling you how many enemies you killed / missed
In the upper center it will show you your current usable upgrades (some ammo / cooldown based)
- You can access a pause menu when ESC is pressed (menu button on android) that will pause the game, giving you the option to continue, restart or quit to main menu. More information about the game / player will be shown here.

### Multiplayer
If any Multiplayer at all, i suggest a solution, where 1 player can host and another can join. Enemy health will be x1.8 or something then. (needs playtesting)

### Game Over Screen
When all health is gone, the player needs to restart the current level.
when all lifes are gone, the player needs to restart the game but keeps his unlocked ships / upgrades.


### Level Types:
There will be 2 types of levels: completely open field and about 20% levels with objects in your path, comming from the upper and lower end of the screen, that you will need to avoid. (like going though a mechanical fortress or through a planet)


### Mechanics
The basic controls will be up, down, left and right movement. A basic projectile will be shot automatically rather quickly, but it has low damage. The usable upgrades will be displayed on the upper middle of the screen and can be used by pressing 1-4 (or touching them on touchscreen). Every ship will have a unique ability like going faster, but less health. slower but stronger basic projectile.
Examples of upgrades would be A missle swarm attack, a laser instead of a basic projectile, a fast dash or shooting 2 bullets instead of 1.


### Modes
When the game is finished the player will unlock a HELL mode where enemies are stronger in some capacity (more health / shoot faster)

### Winning
The player wins, whe he reaches the end of the level / defeats the final enemy. He will then also be informed how many enemies he killed / missed.

### Currency
This is something i would put in a free android version only. the player can ern currency to unlock things instead of getting it as random drops or unlocking them by beating bosses / levels. We can then have the player watch ads for more currency or make him pay to unlock every / get more currency.


### Missions and Achievements
The player will be informed that he is getting an archievement for clearing 100% of enemies on each stage.

## Assets
The player ships.
A LOT of different enemy sprites.
Background art and moving pieces for the background.
Sound and music.
Well... we need pretty much everything i discribed above.

### Characters
Art for each ship and enemy is required.

### Weapons
We need code to make every weapon unique. Heat seeking missles, lasers, rockets, bombs.
Also some enemies will shoot at you. Maybe they will use the weapons that you can unlock along the way to give you a taste of them.
Also saves a bit of workload.


### Story and Cinematics
- Wont be needed since this is a pretts simple game



THANK YOU all for reading this. And THANK YOU for working with us on this project.
I would love to hear any suggestions on our Discord server.

