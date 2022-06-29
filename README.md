# Flappy-Bird
Flappy Bird is a remake of the original Flappy Bird using the Agate MVC Framework. This Flappy Bird game was made as a sample of a simple game with an MVC(Model View Controller) architecture using the Agate MVC Framework. This game is also an example of implementing an object driven game using the agate MVC framework.

## Scene
There are two scenes in this flappy bird game, including:
- Main Menu: Scene that displays the highscore, play game button, and game exit button.
- Gameplay: Scene thar displays the gameplay process of the flappy bird game.

## Modules
### High Score Counter
Layer: Global/Persistent.<br/>
Injected Controller: ```SaveDataController```.<br/>
Published Message: ```UpdateHighScoreMessage```.<br/>

High Score Counter module is used to calculate player's high score in the game. High Score is a module that can be accessed from all scenes to display the player's high score, so this module is in the persistent layer. In this game, the high score data is saved into the save data, so this module is also responsible for saving and loading the high score data to/from the save data.<br/>

### Save Data
Layer: Global/Persistent.<br/>

Save data module is responsible for saving and creating game data to/from local save data. Game data stored in the save data is the player's high score data. 
This game uses PlayerPrefs to save and load save data.<br/>

### Menu
Layer: Temporary.<br/>
Scene: Main Menu.<br/>
Injected Controller: ```HighScoreCounterController```.<br/>
Subscribed Message: ```UpdateHighScoreMessage```.<br/>

Menu module is used to display player's high score,  play button, and exit game button. In addition, this module also handles the event action of the play button and the game exit button.<br/>

### Tap Input
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Published Message: ```TapStartMessage```,```TapMessage```.<br/>
Subscribed Message: ```BirdDeathMessage```.<br/>

Tap input module will handle input from the player. There are two input schemes, namely keyboard & mouse, and touchscreen. In addition, there are also two action maps, namely action maps for UI and character. Both have the same action that is tap action. The difference between UI's tap action and character's tap action is the UI's tap action is used at the start of the game to start playing the game, while the character's tap action is used to move character. Tap actions on UI and character use the same key bindings, namely left click(mouse), space(keyboard), touch press(touchscreen).<br/>

### Play Game
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Subscribed Message: ```TapStartMessage```.<br/>

This module has a simple task. The task is to hide the "tap to play" pop up when the player presses the input tap at the beginning of the game.<br/>

### Pipe
#### Pipe Spawn
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Subscribed Message: ```TapStartMessage```,```BirdDeathMessage```.<br/>

The responsibility of the pipe spawn module is to instantiate pipe's prefab. There is a delay for each pipe spawned. The spawn position of the pipe will always increase according to the spawn gap.<br/>

#### Pipe Scroll
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Subscribed Message: ```TapStartMessage```,```BirdDeathMessage```.<br/>

Pipe module is responsible for the scrolling the pipe which has been spawned in the game. In this game, birds, ground, and background do not move horizontally. To make the level look moving, I scroll the pipe to the left of the screen at a certain speed.<br/>

#### Pipe Despawn
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Pipe despawn module is used to detect collisions between the pipe objects and the dispawner object. if any pipe enter the despawner object's trigger, the pipe will be destroyed. this is done to reduce the number of pipes in the video game.<br/>

### Bird
#### Bird Movement
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Subscribed Message: ```TapStartMessage```,```TapMessage```.<br/>

Bird movement module will move the bird vertically when the player is playing and presses the tap input. to move the bird, this module will use the bird's rigidbody(physics) reference, then apply a force to the referenced bird.<br/>

#### Bird Death
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Injected Controller: ```ScoreCounterController```,```HighScoreCounterController```.<br/>
Published Message: ```BirdDeathMessage```.<br/>

Bird death module is responsible for detecting any collitions between bird and pipes & ground. If the bird collides with the pipe or ground, it's game over, the score and highscore will be calculated and displayed on game over pop up.<br/>

#### Bird Add Score
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Published Message: ```BirdAddScoreMessage```.<br/>

Bird add score module has the task of checking whether the bird made it through the pipe. if the bird manages to pass the pipe then the score will increase by one.<br/>

### Score
#### Score Counter
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Subscribed Message: ```TapStartMessage```,```BirdAddscoreMessage```.<br/>

The responsibility of the score counter module is to calculate the player's score in the game.<br/>

#### Add Score Audio
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Subscribed Message: ```BirdAddscoreMessage```.<br/>

Add score audio module will play a sound effect when the bird pass the pipe. The sound effect doesn't actually play, but the event is displayed using ```Debug.Log()```.<br/>

### Game Over
#### Game Over Pop Up
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Subscribed Message: ```BirdDeathMessage```, ```UpdateHighScoreMessage```.<br/>

Game over pop up module has the responsibility to show pop up when game over. On this pop up, player's score and player's high score will be shown. There is also a restart game button and a main menu button. This module will also handle click events for the restart game button and the main menu button.<br/>

#### Game Over Audio
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Subscribed Message: ```BirdDeathMessage```.<br/>

Game over audio module will play a sound effect when the Game Over Pop Up shows. The sound effect doesn't actually play, but the event is displayed using ```Debug.Log()```.<br/>
