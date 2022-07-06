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


Output:


MVC Component:
- Controller.
- Model.

### Save Data
Responsibility:
- Save data.
- Load data.

Input:


Output:


MVC Component:
- Controller.
- Model.

### Menu
Responsibility:
- Show menu.
- Handle menu button click event.

Input:


Output:


MVC Component:
- Controller.
- Model.
- View.

### Tap Input
Responsibility:
- Handle tap input event to start playing and move bird.

Input:


Output:


MVC Component:
- Controller.

### Play Game
Responsibility:
- Hide tap to start pop up when start playing.

Input:


Output:


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


Output:


MVC Component:
- Controller.
- Model.
- View.

### Bird
#### Bird Movement
Responsibility:
- Move bird when player playing and tap.

Input:


Output:


MVC Component:
- Controller.
- Model.

#### Bird Collision
Responsibility:
- Check if the bird collide with ground or pipe. Publish message if bird collide with ground or pipe.
- Check if the bird passes the pipe. Publish message if the bird passes the pipe.

Input:


Output:


MVC Component:
- Controller.
- View.

### Score
Responsibility:
- Add score when the bird passes the pipe.

Input:


Output:


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


Output:


MVC Component:
- Controller.
- Model.
- View.

### Gameplay Audio
Responsibility:
- Play audio when the bird passes the pipe.
- Play audio when game over.

Input:


Output:


MVC Component:
- Controller
