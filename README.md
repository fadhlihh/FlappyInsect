# Flappy-Bird
Flappy Bird is a remake of the original Flappy Bird using the Agate MVC Framework. This Flappy Bird game was made as a sample of a simple game with an MVC(Model View Controller) architecture using the Agate MVC Framework. This game is also an example of implementing an object driven game using the Agate MVC Framework.

## Scene
There are two scenes in this flappy bird game, including:
- Main Menu: Scene that displays the highscore, play game button, and game exit button.
- Gameplay: Scene thar displays the gameplay process of the flappy bird game.

## Modules
### High Score Counter
Layer: Global/Persistent.<br/>

High Score Counter module is used to calculate player's high score in the game. High Score is a module that can be accessed from all scenes to display the player's high score, so this module is in the persistent layer. In this game, the high score data is saved into the save data, so this module is also responsible for saving and loading the high score data to/from the save data.<br/>

Injected Controller:
- ```SaveDataController```, ```HighScoreCounterController``` use API in ```SaveDataController``` to save and load high score data.

Published Message:
- ```UpdateHighScoreMessage```, when there is a change in high score data, the high score counter module will notify other modules that have high score data to display. This message serves to adjust the high score data in other modules..

MVC Component:
- Controller,.
- Model,.

### Save Data
Layer: Global/Persistent.<br/>

Save data module is responsible for saving and creating game data to/from local save data. Game data stored in the save data is the player's high score data. 
This game uses ```PlayerPrefs``` to save and load save data.<br/>

MVC Component:
- Controller,.
- Model,.

### Menu
Layer: Temporary.<br/>
Scene: Main Menu.<br/>

Menu module is used to display player's high score,  play button, and exit game button. In addition, this module also handles the event action of the play button and the game exit button.<br/>

Injected Controller: 
- ```HighScoreCounterController```, This module will use ```HighScoreDataController``` to initialize high score data in ```MenuModel```.

Subscribed Message: 
- ```UpdateHighScoreMessage```, This module will subscribe this message to update high score when there is a change in high score data in ```HighScoreModel```.

MVC Component:
- Controller,.
- Model,.
- View,.

### Tap Input
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Tap input module will handle input from the player. There are two input schemes, namely keyboard & mouse, and touchscreen. In addition, there are also two action maps, namely action maps for UI and character. Both have the same action that is tap action. The difference between UI's tap action and character's tap action is the UI's tap action is used at the start of the game to start playing the game, while the character's tap action is used to move character. Tap actions on UI and character use the same key bindings, namely left click(mouse), space(keyboard), touch press(touchscreen).<br/>

Published Message: 
- ```TapStartMessage```, Notify other module that player has pressed tap input to start the game.
- ```TapMessage```, Notify other module that player has pressed tap input while playing the game.

Subscribed Message: 
- ```BirdDeathMessage```, This message will notify this module that the game is over, after receiving this message, this module will set the tap action for the character action map to be disabled.

MVC Component:
- Controller,.

### Play Game
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

This module has a simple task. The task is to hide the "tap to play" pop up when the player presses the input tap at the beginning of the game.<br/>

Subscribed Message: 
- ```TapStartMessage```, This message is used to notify the module that the player has started the game by using tap input. After this module receive the message, it will remove the "Tap To Start" pop up.

MVC Component:
- Controller,.
- Model,.
- View,.

### Pipe
#### Pipe Spawn
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

The responsibility of the pipe spawn module is to instantiate pipe's prefab. There is a delay for each pipe spawned. The spawn position of the pipe will always increase according to the spawn gap.<br/>

Subscribed Message: 
- ```TapStartMessage```, This message is used to notify the module that the player has started the game by using tap input. After this module receive the message, this module will start spawning pipe object.
- ```BirdDeathMessage```, This message will notify the player that the game is over. After this module receive the message, this module will stop spawning pipe object.

MVC Component:
- Controller,.
- Model,.
- View,.

#### Pipe Scroll
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Pipe module is responsible for the scrolling the pipe which has been spawned in the game. In this game, birds, ground, and background do not move horizontally. To make the level look moving, I scroll the pipe to the left of the screen at a certain speed.<br/>

Subscribed Message: 
- ```TapStartMessage```,.
- ```BirdDeathMessage```,.

MVC Component:
- Controller,.
- Model,.
- View,.

#### Pipe Despawn
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Pipe despawn module is used to detect collisions between the pipe objects and the dispawner object. if any pipe enter the despawner object's trigger, the pipe will be destroyed. this is done to reduce the number of pipes in the video game.<br/>

MVC Component:
- Controller,.
- View,.

### Bird
#### Bird Movement
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Bird movement module will move the bird vertically when the player is playing and presses the tap input. to move the bird, this module will use the bird's rigidbody(physics) reference, then apply a force to the referenced bird.<br/>

Subscribed Message: 
- ```TapStartMessage```,.
- ```TapMessage```,.

MVC Component:
- Controller,.
- Model,.

#### Bird Death
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Bird death module is responsible for detecting any collitions between bird and pipes & ground. If the bird collides with the pipe or ground, it's game over, the score and highscore will be calculated and displayed on game over pop up.<br/>

Injected Controller: 
- ```ScoreCounterController```,.
- ```HighScoreCounterController```,.

Published Message: 
- ```BirdDeathMessage```,.

MVC Component:
- Controller,.
- View,.

#### Bird Add Score
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Bird add score module has the task of checking whether the bird made it through the pipe. if the bird manages to pass the pipe then the score will increase by one.<br/>

Published Message: 
- ```BirdAddScoreMessage```,.

MVC Component:
- Controller,.
- View,.

### Score
#### Score Counter
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

The responsibility of the score counter module is to calculate the player's score in the game.<br/>

Subscribed Message: 
- ```TapStartMessage```,.
- ```BirdAddscoreMessage```,.

MVC Component:
- Controller,.
- Model,.
- View,.

#### Add Score Audio
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Add score audio module will play a sound effect when the bird pass the pipe. The sound effect doesn't actually play, but the event is displayed using ```Debug.Log()```.<br/>

Subscribed Message: 
- ```BirdAddscoreMessage```,.

MVC Component:
- Controller,.

### Game Over
#### Game Over Pop Up
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Game over pop up module has the responsibility to show pop up when game over. On this pop up, player's score and player's high score will be shown. There is also a restart game button and a main menu button. This module will also handle click events for the restart game button and the main menu button.<br/>

Subscribed Message: 
- ```BirdDeathMessage```,. 
- ```UpdateHighScoreMessage```,.

MVC Component:
- Controller,.
- Model,.
- View,.


#### Game Over Audio
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Game over audio module will play a sound effect when the Game Over Pop Up shows. The sound effect doesn't actually play, but the event is displayed using ```Debug.Log()```.<br/>

Subscribed Message: 
- ```BirdDeathMessage```,.

MVC Component:
- Controller,.
