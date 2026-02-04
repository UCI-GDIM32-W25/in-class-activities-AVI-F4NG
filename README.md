# GDIM32 In Class Activities
## W1

### Activity 1
- Read the rubric carefully, and read the lines one by one. 
- Ask questions when stuck.
- No procrastinating.

### Activity 2

1. 10

2. 2

3. It logs the message "hello world" into the debug console every frame the game runs.

4. MonoBehaviour

5. Logs the message "x = 10" into the debug console when the game starts

6. These are the parameter values that the functions PrintMessage() and Debug.Log() take. Is used to pass input data to the methods.

7. It didn't use the Transform variable defined earlier (_PlayerTransform), and instead uses "Transform" which refers to the transform component of the gameobject this script is attached to.

8. Change "Transform" to "_PlayerTransform".

### Activity 3

[Google doc](https://docs.google.com/document/d/1Ze4Iwr71L5shh5hsj0SjaYT7WLsAfV0lCdb13onncaA/edit?usp=sharing)

## W2

### MG2 Plan
![w2breakdown](https://github.com/user-attachments/assets/a878c74b-827a-4598-ac17-7bf72907495f)

### MG2 Commit
[Minigame 2 Commit (scripts)](https://github.com/UCI-GDIM32-W25/mg2-AVI-F4NG/commit/665d08d0351a172d8ddb9dc035d35a66340ce7a6)

[Minigame 2 Commit (scene and readme)](https://github.com/UCI-GDIM32-W25/mg2-AVI-F4NG/commit/e2cce767ede00d831cf9979673a13cf1ebf91ae4)

## W3

### Questions 0-2
Partner name: Ke-Chieh Chang

### Question 3
![w3breakdown](https://github.com/user-attachments/assets/116882bd-51c0-47a0-8809-22eb836b2949)

## W4

### Question 0

Partner name: Ke-Chieh Chang

### Question 1

All of the Locator components on the GameObjects are destroyed except for one of the GameObjects.

The singleton Locator destroys this Locator component (not the GameObject) when Instance is already set to a different Locator instance, meaning another Locator has already become the singleton.

### Question 2

![w4breakdown](https://github.com/user-attachments/assets/1fcd7319-5b80-4834-ae21-d978023fb4dc)

### Question 3

Created the basic scene (player, ground, pipes, UI, audio source) and empty scripts. 

[Minigame 4 commit](https://github.com/AVI-F4NG/GDIM32-HW4/commit/4002ebe40d05b5c9907ce395fb83fca52155b6f7)

## W5

### Question 1

I would change the function `Damage()` to a non-abstract function, and change `IBreakable` to an abstract class, because: `Damage()` always deducts damage from `_durability`, logs the remaining durability, and checks if the breakable item breaks. If we put them all into a parent abstract class, we won't need to redefine them in the respective child functions.

### Question 2

#### Model

These hold the data/state.

Inventory Item ScriptableObjects: fields like itemName, description

NPC ScriptableObjects: fields like hp, dialogueText

#### View

These render UI and should not decide gameplay rules.

Inventory UI (InventoryUI) script owns the Text UI elements and displays the item names.

Dialogue UI script (DialogueBubble) owns the dialogue Text UI element and displays NPC dialogue.

#### Controller

These handle input and interaction logic and tell the views what to display.

Player / PlayerController: listens for Space input and toggles inventory UI.

NPC interaction controller: detects proximity (trigger/collision/distance check) and triggers showing dialogue.

### Question 3

#### Scenario 1

- Use ScriptableObjects to store beat data: key input, lane/screen position, timestamp in song.

#### Scenario 2

- Use inheritance/polymorphism for shared character basics: health, movement, animation, etc. Separate Attack classes/interfaces since each attack is unique.

- Use an FSM for character modes: idle/run/jump, synced with animations.

#### Scenario 3

- Use polymorphism for many interactables: they all share the "interact" action but behave differently.

- Use an FSM for player actions and animations.

- Use ScriptableObjects for crop growth data, harvest outputs, tool stats, object HP, etc.

### Question 4

Attendance: Jingyi Cheng, Ke-Chieh Chang, Jamin Pinson

[Final project proposal](https://docs.google.com/document/d/1243b-56SntC6QbFu_Eii6tyaacd2RoO3u3ZMJNCXjdw/edit?usp=sharing)