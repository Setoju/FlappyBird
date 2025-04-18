# Flappy Bird in Unity

This is a simple 2D implementation of the classic game Flappy Bird, created using the Unity game engine. This project was developed as a personal learning exercise to improve my Unity skills and gain a better understanding of game development fundamentals.

## Table of Contents

* [Features](#features)
* [How to Play](#how-to-play)
* [Development](#development)
    * [Tools Used](#tools-used)
    * [Key Concepts Explored](#key-concepts-explored)
* [Future Enhancements](#future-enhancements)

## Features

* **Simple and Addictive Gameplay:** Press space to make the bird flap and navigate through pipes.
* **Score Tracking:** Keeps track of the player's score as they successfully pass through pipes.
* **Personal Best** Keeps your personal best score even after closing the game.
* **Collision Detection:** Implements basic collision detection with pipes and the ground.
* **Game Over State:** Clearly indicates when the game ends and displays the final score.

## How to Play

1.  **Download and Open:** Download the project files and open them in Unity.
2.  **Run the Scene:** Navigate to the main game scene in the Project window and run it.
3.  **Tap to Flap:** Click or tap on the screen to make the bird flap its wings and gain altitude.
4.  **Avoid Obstacles:** Steer the bird through the gaps between the moving pipes.
5.  **Score Points:** Each successfully passed pipe pair increases your score.
6.  **Game Over:** The game ends if the bird collides with a pipe or the ground.

## Development

This project was built using the Unity game engine and primarily utilizes C# scripting for game logic and behavior.

### Tools Used

* **Unity Engine:** Version 6000.0.42f1
* **C#:** Programming language for scripting.

### Key Concepts Explored

Through the development of this Flappy Bird clone, I gained practical experience with the following Unity concepts:

* **Game Objects and Components:** Understanding the fundamental building blocks of a Unity scene.
* **2D Physics:** Implementing gravity, velocity, and collision detection using the built-in 2D physics system (Rigidbody 2D, Collider 2D).
* **Scripting in C#:** Writing scripts to control game object behavior, handle user input, and manage game state.
* **Object Instantiation and Destruction:** Creating and removing game objects dynamically (e.g., pipes).
* **Transform Manipulation:** Moving and positioning game objects in the 2D space.
* **Basic UI (User Interface):** Displaying score and game over messages using Unity's UI system (Canvas, Text).
* **Game State Management:** Implementing logic to track the current state of the game (playing, game over).

## Future Enhancements

Here are some potential features and improvements I might consider adding in the future:

* **Difficulty Scaling:** Gradually increasing the game's difficulty as the player progresses.
* **Multiple Bird Skins:** Allowing players to unlock or choose different bird appearances.
