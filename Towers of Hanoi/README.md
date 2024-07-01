# Towers of Hanoi

The Towers of Hanoi is a classic mathematical puzzle that involves three pegs and a number of rings of different sizes. The objective of the game is to move the entire stack of rings from one peg to another, obeying the following rules:
1. Only one ring can be moved at a time.
2. A ring can only be moved if it is the uppermost ring on one of the pegs.
3. No ring may be placed on top of a smaller ring.

## Skills Highlighted

- Object-oriented programming in C#
- Console-based user interaction
- Array manipulation and resizing
- Conditional statements and logical operations
- Iterative game logic and control flow

## Implementation Details

This program simulates the Towers of Hanoi game using three pegs and a set number of rings. It initializes the game with the rings on the first peg and allows the user to move rings between the pegs by selecting a source and destination peg for each move. Invalid moves are rejected, and the game board is updated after each valid move.

### Features

- **Peg Class:** Represents each peg on which rings can be stacked. It includes methods to add and remove rings, draw the peg and rings on the console, and determine the size of the top ring.
- **Game Loop:** Continues until all rings are successfully transferred from the first peg to the third peg, counting and displaying the number of moves made by the user.
- **User Input Validation:** Ensures that only valid moves are accepted, adhering to the rules of the Towers of Hanoi puzzle.

### How to Play

1. Run the program.
2. Follow the prompts to specify the source and destination pegs for each move.
3. Continue making valid moves until all rings are on the third peg.
4. The game ends when all rings are successfully moved, and the number of moves taken is displayed.

---

Created by Sean Berlin. For more information about the Towers of Hanoi puzzle, refer to [Wikipedia](https://en.wikipedia.org/wiki/Tower_of_Hanoi).
