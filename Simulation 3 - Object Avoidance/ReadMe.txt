Created By Cole Kleinebekel, For any questions about the program please DM me on discord @molethecole

Currently the user spawns at (0,7.5,-50) with 4x50 long platforms in front of him.
The player is surrounded by walls, collison with a wall or a object will cause the entire scene to reset.
Objects are 10x10x2 cubes that spawn every 5 seconds, they will spawn at (Random.Range(-5,5), (Random.range(0, 15), player.z + 30).
A Object gets destroyed after its Z is 30 less than the players Z to save profromance.

player controls:
  W and S to move forward and backwards.
  A and D to move left and right.
  UpArrow and DownArrow to move up and down.
  LeftArrow and RightArrow to rotate negatively and positively on the y axis.

Known Bugs:
  After the player reaches the end the mother Object gets destoryed because the player passes it, 
  upon it being destoryed the game can no longer refrance any object to spawn a clone of it so no more objects spawn.

  Rarely happens but the objects can collide with each other casuing them to go crazy and fly everywhere.

  objects sometimes spawn spinning on there x axis negitivly very slightly.
