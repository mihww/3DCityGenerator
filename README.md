# 3DCityGenerator : A 3D Unity project that generates a random set of gameObjects as buildings

## Table of Contents
- [Features](#features)
  - [Post-Processing](#post-processing)
  - [Music and SFX](#music-and-sfx)
  - [Buttons](#buttons)
    - [Music Toggle Button](#music-toggle-button)
    - [Generate City Button](#generate-city-button)
- [Demo](#demo)
- [Setup](#setup)
- [Usage](#usage)

## Features

### Post-Processing
Enhance the visual quality of your game with post-processing effects. These effects include:
- Bloom
- Color Grading
- Motion Blur

### Music and SFX
Improve your game's audio experience with background music and sound effects. The project includes:
- Background music that plays throughout the game.
- Sound effects for specific actions like button clicks and scene changes.

### Buttons

#### Music Toggle Button
An interactive button that allows players to toggle the background music on and off. The button changes its appearance based on the music state:
- **On State:** Music is playing, and the button displays the `onSprite`.
- **Off State:** Music is paused, and the button displays the `offSprite`.

#### Generate City Button
A button that allows players to generate a new city scene. Each time the **"Generate City"** button is pressed:
- A new scene is instantiated.
- A sound effect plays to indicate the generation of the new city.

## Demo

### Music Toggle Button
![Music Toggle On Button](https://github.com/mihww/3DCityGenerator/assets/147138758/ff690900-c543-412f-88a0-dd7c28e78ca7)
![Music Toggle Off Button](https://github.com/mihww/3DCityGenerator/assets/147138758/aa229739-368f-4728-8863-af1f308acad0)

### Generate City Button
![gif (1)](https://github.com/mihww/3DCityGenerator/assets/147138758/14126d8f-aa0c-47c7-9c62-5fb067007344)


## Setup

1. **Clone the Repository:**
    ```sh
    git clone https://github.com/mihww/3DCityGenerator.git
    cd 3DCityGenerator
    ```

2. **Open the Project in Unity:**
    - Open Unity Hub.
    - Click on the **Add** button and select the project directory.

3. **Install Dependencies:**
    - Ensure you have all necessary packages installed, such as the Post-Processing Stack.
    - You can add these through the Unity Package Manager.

4. **Configure Scenes and Build Settings:**
    - Ensure all scenes are added to the build settings.
    - Set the initial scene to load at startup.

## Usage

1. **Playing the Game:**
    - Press the **Play** button in the Unity Editor to start the game.
    - Use the **Music Toggle Button** to play or pause the background music.
    - Press the **Generate City Button** to create a new city scene.

2. **Modifying Assets:**
    - Update the background music and sound effects by replacing the clips in the `AudioManager`.
    - Customize the post-processing effects by modifying the post-processing profiles.

3. **Building the Game:**
    - Go to **File** > **Build Settings**.
    - Select the target platform and click on **Build**.

