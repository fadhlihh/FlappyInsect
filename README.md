# Flappy-Bird
Flappy Bird is a remake of the original Flappy Bird using the Agate MVC Framework. This Flappy Bird game was made as a sample of a simple game with an MVC(Model View Controller) architecture using the Agate MVC Framework. This game is also an example of implementing an object driven game using the Agate MVC Framework.

## Scene
There are two scenes in this flappy bird game, including:
- Main Menu: Scene that displays the highscore, play game button, and game exit button.
- Gameplay: Scene thar displays the gameplay process of the flappy bird game.

To give an idea about the scene flow in this game, you can see sceneflow diagram below.

![FlappyBird - Scene Flow Diagram drawio](https://user-images.githubusercontent.com/43397593/177526548-a36c89ae-2aa4-43ea-8c52-c09beef09aaf.png)

## Architecture Layer Design
There are four layers in this game including: Framework Layer, Global / Persistence Layer, and Scene / Temporary Layer. Each layer has access restrictions on other layers. To be able to explain the layers and their access restrictions, you can see the architecture layer diagram below.

## Module Communication
The modules in this game uses two methods to communicate with each other. The communication methods between modules used in this video game are Dependency Injection(DI) and Publish - Subscribe.

### Dependency Injection
To explain the dependencies between modules in this game you can see the dependency diagram below.

![FlappyBird - Dependency Diagram-All drawio](https://user-images.githubusercontent.com/43397593/177510004-a91698cb-c7f6-411c-9acc-a7ba02575b71.png)

### Publish - Subscribe
To explain all Publish - Subscribe process in video game you can see the signal diagram below.

![FlappyBird - Signal Diagram-StartPlay](https://user-images.githubusercontent.com/43397593/177519286-eba8408f-a097-4992-a1ad-d40212d0dd0a.png)

![FlappyBird - Signal Diagram-MoveBird](https://user-images.githubusercontent.com/43397593/177519389-2e04851b-1c34-4103-9d21-3bce073d4bee.png)

![FlappyBird - Signal Diagram-AddScore](https://user-images.githubusercontent.com/43397593/177519417-98685dc9-36d3-4d80-9bbe-6813ac3a8030.png)

![FlappyBird - Signal Diagram-GameOver](https://user-images.githubusercontent.com/43397593/177521427-ea26f48e-202b-48a3-b722-27ba034ac589.png)

![FlappyBird - Signal Diagram-UpdateScore](https://user-images.githubusercontent.com/43397593/177521527-3ecccbd8-d51a-4911-9a9f-469a8f5c146f.png)

![FlappyBird - Signal Diagram-UpdateHighScore](https://user-images.githubusercontent.com/43397593/177521535-e7746397-685f-45e9-9c04-18c82565d06b.png)

## Game Process Flow
To explain overall game process you can see flowchart diagram below.

## Module List
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
