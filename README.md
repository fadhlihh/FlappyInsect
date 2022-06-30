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
- ```SaveDataController```, ```HighScoreCounterController``` use ```Save(int highScore)``` and ```Load()``` API in ```SaveDataController``` to save and load high score data.

Published Message:
- ```UpdateHighScoreMessage```, when there is a change in high score data, the high score counter module will notify other modules that have high score data to display. This message serves to adjust the high score data in other modules..

MVC Component:
- Controller, this component serve logic to calculate high score like update high score, check high score, and load high score.
- Model, this component is where the high score data is located.

### Save Data
Layer: Global/Persistent.<br/>

Save data module is responsible for saving and creating game data to/from local save data. Game data stored in the save data is the player's high score data. 
This game uses ```PlayerPrefs``` to save and load save data.<br/>

MVC Component:
- Controller, serve logic to save and load game data.
- Model, serve data from save data.

### Menu
Layer: Temporary.<br/>
Scene: Main Menu.<br/>

Menu module is used to display player's high score,  play button, and exit game button. In addition, this module also handles the event action of the play button and the game exit button.<br/>

Injected Controller: 
- ```HighScoreCounterController```, this module will use ```HighScore``` data from ```HighScoreDataController``` to initialize high score data in ```MenuModel```.

Subscribed Message: 
- ```UpdateHighScoreMessage```, this module will subscribe this message to update high score when there is a change in high score data in ```HighScoreModel```.

MVC Component:
- Controller, serve logic to initialize high score data to be show on the view, update ```HighScore``` data in ```MenuModel``` when receiving ```UpdateHighScoreModel```, set event for start game button and exit game button.
- Model, serve high score data to be show on the view.
- View, show high score data from model.

### Tap Input
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Tap input module will handle input from the player. There are two input schemes, namely keyboard & mouse, and touchscreen. In addition, there are also two action maps, namely action maps for UI and character. Both have the same action that is tap action. The difference between UI's tap action and character's tap action is the UI's tap action is used at the start of the game to start playing the game, while the character's tap action is used to move character. Tap actions on UI and character use the same key bindings, namely left click(mouse), space(keyboard), touch press(touchscreen).<br/>

Published Message: 
- ```TapStartMessage```, notify other module that player has pressed tap input to start the game.
- ```TapMessage```, notify other module that player has pressed tap input while playing the game.

Subscribed Message: 
- ```BirdDeathMessage```, this message will notify this module that the game is over, after receiving this message, this module will set the tap action for the character action map to be disabled.

MVC Component:
- Controller, serve logic to publish ```TapStartMessage``` when player has pressed tap input to start the game, disable UI action map and enable character action map. this component also publish ```TapMessage``` when player has pressed tap input while playing the game to move bird and disable character action map after receiving ```BirdDeathMessage```.

### Play Game
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

This module has a simple task. The task is to hide the "tap to play" pop up when the player presses the input tap at the beginning of the game.<br/>

Subscribed Message: 
- ```TapStartMessage```, this message is used to notify the module that the player has started the game by using tap input. After this module receive the message, it will remove the "Tap To Start" pop up.

MVC Component:
- Controller, serve logic to set ```IsPlaying``` data to true when receiving ```TapStartMessage```.
- Model, serve ```IsPlaying``` data.
- View, hide "tap to play" pop up when ```IsPlaying``` data is true.

### Pipe
#### Pipe Spawn
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

The responsibility of the pipe spawn module is to instantiate pipe's prefab. There is a delay for each pipe spawned. The spawn position of the pipe will always increase according to the spawn gap.<br/>

Subscribed Message: 
- ```TapStartMessage```, this message is used to notify the module that the player has started the game by using tap input. After this module receive the message, this module will start spawning pipe object.
- ```BirdDeathMessage```, this message will notify the player that the game is over. After this module receive the message, this module will stop spawning pipe object.

MVC Component:
- Controller, serve logic to spawn pipe prefab and set spawn position. this component also set ```IsPlaying``` data to true when receiving ```TapStartMessage```, and set ```IsPlaying``` data to false when receiving ```BirdDeathMessage```.
- Model, serve data ```IsPlaying```, serve data to spawn pipe prefab, including ```SpawnPoint```, ```SpawnRate```, ```SpawnGap```, etc.
- View, invoke spawn pipe logic callback when ```IsPlaying``` data is true.

#### Pipe Scroll
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Pipe module is responsible for the scrolling the pipe which has been spawned in the game. In this game, birds, ground, and background do not move horizontally. To make the level look moving, I scroll the pipe to the left of the screen at a certain speed.<br/>

Subscribed Message: 
- ```TapStartMessage```, this message is used to notify the module that the player has started the game by using tap input. After this module receive the message, this module will start scrolling pipe object.
- ```BirdDeathMessage```, this message will notify the player that the game is over. After this module receive the message, this module will stop scrolling pipe object.

MVC Component:
- Controller, serve logic to move pipe position to the left by moving ```Position``` data. this component also set ```IsPlaying``` data to true when receiving ```TapStartMessage```, and set ```IsPlaying``` data to false when receiving ```BirdDeathMessage```.
- Model, serve data ```IsPlaying```, serve data to move pipe position, including ```Position``` and ```ScrollSpeed```.
- View, set the position according to ```Position``` data on the model.

#### Pipe Despawn
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Pipe despawn module is used to detect if pipe objects enter dispawner's trigger. If any pipe enter the despawner's trigger, the pipe will be destroyed. this is done to reduce the number of pipes in the video game.<br/>

MVC Component:
- Controller, serve logic to destroy pipe object when enter despawner's trigger.
- View, check if pipe object enter despawner's trigger, invoke destroy pipe logic if pipe object enter despawner's trigger.

### Bird
#### Bird Movement
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Bird movement module will move the bird vertically when the player is playing and presses the tap input. to move the bird, this module will use the bird's rigidbody(physics) reference, then apply a force to the referenced bird.<br/>

Subscribed Message: 
- ```TapStartMessage```, this message is used to notify the module that the player has started the game by using tap input. After this module receive the message, this module will set bird gravity.
- ```TapMessage```, this message is used to notify the module that player has pressed tap input while playing the game. After this module receive the message, this module will apply force vertically to referenced bird.

MVC Component:
- Controller, serve logic to apply gravity when reveiving ```TapStartMessage```, and apply force to the referenced bird when receiving ```TapMessage```.
- Model, serve ```Force``` and ```GravityScale``` data.

#### Bird Death
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Bird death module is responsible for detecting any collitions between bird and pipes & ground. If the bird collides with the pipe or ground, it's game over, the score and highscore will be calculated and displayed on game over pop up.<br/>

Injected Controller: 
- ```ScoreCounterController```, this module will use ```ScoreCounterController``` to get player's score data from ```ScoreCounterModel```. player's score data will be send with ```BirdDeathMessage```.
- ```HighScoreCounterController```, this module will use ```HighScoreCounterController``` to get player's high score data from ```HighScoreCounterModel```. player's high score data will be send with ```BirdDeathMessage```.

Published Message: 
- ```BirdDeathMessage```, notify other module that the game is over.

MVC Component:
- Controller, serve logic to check high score and publish ```BirdDeathMessage``` when bird object collide with ground object or pipe object.
- View, check collision between bird object and ground object or pipe object, invoke bird death logic if there is a collision between bird object and ground object or pipe object.

#### Bird Add Score
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Bird add score module has the task of checking whether the bird made it through the pipe. if the bird manages to pass the pipe then the score will increase by one.<br/>

Published Message: 
- ```BirdAddScoreMessage```, notify other module that the bird made it through the pipe.

MVC Component:
- Controller, serve logic to publish ```BirdAddScoreMessage``` when bird object enter pipe hole's trigger.
- View, check if bird object enter pipe hole's trigger, invoke add score logic if bird object enter pipe hole's trigger.

### Score
#### Score Counter
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

The responsibility of the score counter module is to calculate the player's score in the game.<br/>

Subscribed Message: 
- ```TapStartMessage```, this message is used to notify the module that the player has started the game by using tap input. After this module receive the message, this module will show score.
- ```BirdAddscoreMessage```, this message is used to notify the module that the bird made it through the pipe. After this module receive the message, this module will add score by one.

MVC Component:
- Controller, serve logic to show text when receiving ```TapStartMessage```, and add score logic when receiving ```BirdAddScoreMessage```.
- Model, serve ```Score``` data.
- View, show ```Score``` data from model.

#### Add Score Audio
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Add score audio module will play a sound effect when the bird pass the pipe. The sound effect doesn't actually play, but the event is displayed using ```Debug.Log()```.<br/>

Subscribed Message: 
- ```BirdAddscoreMessage```, this message is used to notify the module that the bird made it through the pipe. After this module receive the message, this module will add score sound effect.

MVC Component:
- Controller, serve logic to play add score audio sound effect when receiving ```BirdAddScoreMessage```.

### Game Over
#### Game Over Pop Up
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Game over pop up module has the responsibility to show pop up when game over. On this pop up, player's score and player's high score will be shown. There is also a restart game button and a main menu button. This module will also handle click events for the restart game button and the main menu button.<br/>

Subscribed Message: 
- ```BirdDeathMessage```, this message is used to notify the module that the game is over. After this module receive the message, this module will show game over pop up, including player's score and player's high score. 
- ```UpdateHighScoreMessage```, this module will subscribe this message to update high score when there is a change in high score data in ```HighScoreModel```.

MVC Component:
- Controller, serve logic to set ```Score``` and ```HighScore``` data from model according to data in ```BirdDeathMessage``` and show game over pop up when receiving ```BirdDeathMessage```. this component also serve logic to handle click events from restart game button and main menu button.
- Model, serve ```Score``` and ```HighScore``` data.
- View, show game over pop up, ```Score``` and ```HighScore``` data from model.


#### Game Over Audio
Layer: Temporary.<br/>
Scene: Gameplay.<br/>

Game over audio module will play a sound effect when the Game Over Pop Up shows. The sound effect doesn't actually play, but the event is displayed using ```Debug.Log()```.<br/>

Subscribed Message: 
- ```BirdDeathMessage```, this message is used to notify the module that the game is over. After this module receive the message, this module will play game over sound effects.

MVC Component:
- Controller, serve logic to play game over audio sound effect when receiving ```BirdDeathMessage```.
