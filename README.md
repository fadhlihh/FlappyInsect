# Flappy-Bird
Flappy Bird is a remake of the original Flappy Bird using the Agate MVC Framework. This Flappy Bird game was made as a sample of a simple game with an MVC(Model View Controller) architecture using the Agate MVC Framework. This game is also an example of implementing an object driven game using the Agate MVC Framework.

## Scene
There are two scenes in this flappy bird game, including:
- Main Menu: Scene that displays the highscore, play game button, and game exit button.
- Gameplay: Scene thar displays the gameplay process of the flappy bird game.

## Modules
### High Score
Responsibility:
- Check high score.
- Save high score.
- Load high score.

Input:
- Score. 
- High Score from Save Data Module.

Output:
- High Score data.

MVC Component:
- Controller.
- Model.

### Save Data
Responsibility:
- Save data.
- Load data.

Input:
- High Score data from Game Save Data (PlayerPref).
- High Score data from High Score module.

Output:
- High Score data.

MVC Component:
- Controller.
- Model.

### Menu
Responsibility:
- Show menu.
- Handle menu button click event.

Input: 
- High Score data.

Output:
- High Score text.

MVC Component:
- Controller.
- Model.
- View.

### Tap Input
Responsibility:
- Handle tap input event to start playing and move bird.

Input:
- User Tap input.

Output:
- Start Play Message.
- Move Bird Message.

MVC Component:
- Controller.

### Play Game
Responsibility:
- Hide "Tap to Start" pop up when start playing.

Input:
- Start Play Message.

Output:
- Disactive "Tap to Start" pop up.

MVC Component:
- Controller.
- Model.
- View.

### Pipe Container
Responsibility:
- Spawn pipe when player playing.
- Scroll pipe when player playing.
- Despawn pipe.

Input:
- Start Play Message.
- Game Over Message.

Output:
- Pipe Object
- Scrolling Pipe Container
- Pipe Destroyed

MVC Component:
- Controller.
- Model.
- View.

### Bird
#### Bird Movement
Responsibility:
- Move bird when player playing and tap.

Input:
- Move Bird Message.

Output:
- Bird Move Vertically.

MVC Component:
- Controller.
- Model.

#### Bird Collision
Responsibility:
- Check if the bird collide with ground or pipe. Publish message if bird collide with ground or pipe.
- Check if the bird passes the pipe. Publish message if the bird passes the pipe.

Input:
- Collided or Triggered Collider.

Output:
- Game Over Message.
- Add Score Message.

MVC Component:
- Controller.
- View.

### Score
Responsibility:
- Add score when the bird passes the pipe.

Input:
- Add Score Message.

Output:
- Added Score data.

MVC Component:
- Controller.
- Model.
- View.

### Game Over
Responsibilty:
- Show game over pop up.
- Show score.
- Show high score.
- Handle restart button click.
- Handle main menu button click.

Input:
- Game Over Message.

Output:
- Game Over Pop Up.
- Displayed High Score data.
- Displayed Score data.

MVC Component:
- Controller.
- Model.
- View.

### Gameplay Audio
Responsibility:
- Play audio when the bird passes the pipe.
- Play audio when game over.

Input:
- Add Score Message.
- Game Over Message.

Output:
- Add Score Audio.
- Game Over Audio.

MVC Component:
- Controller
