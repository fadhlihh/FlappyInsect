# Flappy-Bird
Flappy Bird is a remake of the original Flappy Bird using the Agate MVC framework. This Flappy Bird game was made as a sample of a simple game with an MVC(Model View Controller) architecture using the Agate MVC Framework. This game is also an example of implementing an object driven game using the agate MVCc framework.

## Scene
There are two scenes in this flappy bird game, including:
- Main Menu: Scene that displays the highscore, play game button, and game exit button.
- Gameplay: Scene thar displays the gameplay process of the flappy bird game.

## Modules
### High Score Counter
Layer: Global/Persistent.<br/>
Injected Controller: ```SaveDataController```.<br/>
Published Message: ```UpdateHighScoreMessage```.<br/>
High Score Counter module is a module that is used to calculate player's high score in the game. High Score is a module that can be accessed from all scenes to display the player's high score, so this module is in the persistent layer. In this game, the high score data is saved into the save data, so this module is also responsible for saving and loading the high score data to/from the save data.<br/>

### Save Data
Layer: Global/Persistent.<br/>
Save data module is responsible for saving and creating game data to/from local save data. Game data stored in the save data is the player's high score data. 
This game uses PlayerPrefs to save and load save data.<br/>

### Menu
Layer: Temporary.<br/>
Scene: Main Menu.<br/>
Menu module is used to display player's high score,  play button, and exit game button. In addition, this module also handles the event action of the play button and the game exit button.<br/>

### Tap Input
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Handle tap input event (tap start, tap movement).<br/>

### Play Game
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
This module has a simple task. The task is to hide the "tap to play" pop up when the player presses the input tap at the beginning of the game.<br/>

### Pipe
#### Pipe Spawn
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Spawn pipe when player playing.<br/>

#### Pipe Scroll
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Scroll pipe when player playing.<br/>

#### Pipe Despawn
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
This module is responsible for despawn pipe<br/>

### Bird
#### Bird Movement
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Move bird when player playing and tap.<br/>

#### Bird Death
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
- Check if bird collide with ground or pipe.
- Publish message if bird collide with ground or pipe..<br/>

#### Bird Add Score
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
- Check if the bird made it through the pipe
- Publish message if the bird made it through the pipe.<br/>

### Score
#### Score Counter
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Add score when the bird made it through the pipe.<br/>

#### Add Score Audio
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Play audio when the bird made it through the pipe.<br/>

### Game Over
#### Game Over Pop Up
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
- Show game over pop up
- Show score
- Show high score
- Handle restart button click
- Handle main menu button click.<br/>

#### Game Over Audio
Layer: Temporary.<br/>
Scene: Gameplay.<br/>
Play audio when game over.<br/>
