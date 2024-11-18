GroundDetection - Unity Project

This Unity demo project, GroundDetection, demonstrates how to implement ground detection for jump mechanics in both 2D and 3D environments using C#. It includes a single scene showcasing both 2D and 3D examples side by side, making it easy to compare and understand the differences in implementation.
Features

    Unified Scene:
        Contains both 2D and 3D player controllers in a single scene named MainScene.
        Visual indicators show when the player is grounded or airborne using color-coded text.
    2D and 3D Player Controllers:
        PlayerController2D and PlayerController3D scripts handle movement and jumping with realistic ground detection.
        Implemented using Raycasting for accurate detection of ground surfaces.
    Ground Detection Techniques:
        Uses Raycasting for both 2D and 3D environments, leveraging Unity's physics systems for precise collision detection.
        Visual feedback via UI text elements changes color based on whether the player is grounded or airborne.

Requirements

    Unity Version: 2022.3.41f
    Dependencies: TextMeshPro for UI feedback (included in the Unity project)
    GitHub Desktop: Recommended for version control and collaboration

Getting Started
1. Clone the Repository

To get started, clone the project using GitHub Desktop or via the command line:

git clone https://github.com/yourusername/GroundDetection.git

2. Open in Unity

    Open Unity Hub, click "Open Project", and select the folder where you cloned this repository.
    Open the MainScene from the Scenes folder to access the demo.

3. Controls

    Arrow Keys / WASD: Move the player.
    Spacebar: Jump.

Script Overview
PlayerController2D

This script controls a 2D character using Rigidbody2D. It checks if the player is on the ground using Physics2D.Raycast:

    Ground Detection: Uses a raycast from the player's feet to detect ground collision.
    UI Feedback: Text changes color to green when grounded and red when in the air.

PlayerController3D

This script controls a 3D character using Rigidbody and Physics.Raycast:

    Ground Detection: Emits a ray from the player's feet downward to check for ground.
    UI Feedback: A TextMeshPro element displays green when grounded and red when airborne.
    Random Jump Direction: The player jumps with a small random horizontal force for variability.

Educational Goals

This project is designed to help students:

    Understand the core mechanics of ground detection in 2D and 3D games.
    Learn how to implement basic jump mechanics using Unity's physics system.
    Compare and contrast how ground detection differs between 2D and 3D environments.

Usage
Modifying the Scripts

Feel free to explore and modify the PlayerController2D and PlayerController3D scripts to experiment with:

    Different ground detection methods (e.g., Collider triggers).
    Modifying jump force and movement speed in the Unity Inspector.
    Adding new layers or adjusting the Ground LayerMask for different ground types.

Adding New Features

For those who want to extend the project, consider implementing:

    Double jumps or variable jump heights.
    Different jump effects based on the ground type (e.g., ice, trampoline).
    Additional UI elements to display player speed or jump counts.

Contributing

Contributions are welcome! If you find any bugs or have ideas for improvements:

    Fork the repository.
    Create a new branch (feature/your-feature).
    Commit your changes.
    Open a pull request.

License

This project is licensed under the MIT License - see the LICENSE file for more details.
Contact

If you have any questions or need further assistance, please feel free to reach out via GitHub or email at gammeranest.mfernandez@gmail.com
