Game Design Document: Merge Arena
1. Game Overview
Genre: Merge Arena (Strategy)
Platform: PC (expandable to mobile)
Target Audience: Strategy and casual gamers
Gameplay Mode: Single-player vs AI
Inspiration: Based on LUDUS - Merge Arena PvP, but with AI.
2. Core Objective
Players summon random units from a deck of five equipped cards onto a grid, using gold as a resource. Units of the same type and level can be merged to upgrade their levels (up to level 4). The objective is to strategically manage unit placement, merging, and tile buffs to defeat the AI.

3. Gameplay Mechanics
3.1. Currency:
Gold: The primary resource for summoning units. Each summon costs 3 gold.
Players earn gold throughout the game to continue summoning.
3.2. Unit Summoning:
Players have 5 equipped cards that represent potential units.
For 3 gold, a random unit from the equipped deck is summoned onto a random empty tile on the grid.
Units start at level 1.
3.3. Merging Units:
Units of the same type and level can be merged, but they do not need to be adjacent.
Units can be merged up to level 4, after which they cannot be upgraded further.
Merging increases a unit’s stats (e.g., health, attack power) and may enhance its abilities.
3.4. Grid and Tiles:
The game board is a grid (e.g., 5x5 or 6x6), where units are placed randomly.
Some tiles may provide buffs that affect unit stats or abilities, such as increased attack, defense, or special effects.
3.5. Tile Buffing:
Certain units buff specific tiles either when summoned or after a merge.
Buffs might include:
Increased attack/defense for units placed on a buffed tile.
AoE effects that impact units in adjacent tiles.
Buffs last for a set number of turns or until the unit is merged or removed.
3.6. AI Opponent:
The AI follows the same rules, summoning units and merging them to increase their level.
AI difficulty can scale based on progression, with more advanced AI using better strategies to merge units and take advantage of tile buffs.
3.7. Win Condition:
The player wins by defeating the AI’s units or by having the strongest units after a set number of turns.
Losing occurs if the AI overwhelms the player by creating more powerful units or strategic tile placements.
4. Cards & Units
4.1. Card System:
Players can equip 5 cards before the match begins.
Cards determine the units that can be summoned, each with unique stats and abilities.
Cards may be upgradeable to make units stronger at the start.
4.2. Sample Units:
Knight:
Health: High
Damage: Medium
Ability: Buffs surrounding units with increased defense when merged.
Archer:
Health: Low
Damage: High (ranged)
Ability: Can attack enemies multiple tiles away.
Mage:
Health: Medium
Damage: High (AoE magic)
Ability: Buffs nearby tiles with AoE magic effects.
5. Core Loops
5.1. Player Turn:
Spend 3 gold to summon a random unit from the deck onto an empty tile.
Merge units of the same type and level up to level 4 to increase their strength.
Buff or utilize tiles for tactical advantage.
5.2. AI Turn:
The AI performs similar actions, summoning and merging units, utilizing buffs to outmaneuver the player.
5.3. Resource and Unit Management:
Players must strategically decide when to merge units to reach higher levels without sacrificing too much board control.
6. Game Modes
Single-player Campaign: Progress through levels of increasing AI difficulty.
Skirmish Mode: A one-off battle against AI with customizable difficulty and deck setups.
7. Art & Audio
Art Style: Simple, colorful 2D/3D assets.
Animations: Basic animations for unit actions (spawning, merging, attacking).
Sound Effects: Each unit type has distinct sounds for summoning, merging, and attacking.
8. Technical Features
8.1. Test-Driven Development (TDD):
Unit tests for:
Unit summoning
Merging up to level 4
AI behavior
Tile buffing system
Testing all edge cases (e.g., no adjacent merging required, cap at level 4).
8.2. AI Scaling:
AI difficulty increases as players progress, implementing more advanced tactics like strategic merging and buff usage.
9. Development Milestones
Phase 1: Core Mechanics Implementation (4 weeks)
Summoning, merging (up to level 4), and basic AI.
Test cases for all core mechanics.
Phase 2: Tile Buffs and Advanced AI (3 weeks)
Implement tile buffing system and AI improvements.
Phase 3: Balance & Tuning (2 weeks)
Fine-tune unit stats, AI difficulty, and merging mechanics.
Phase 4: Playtesting & Final Adjustments (2 weeks)
Comprehensive playtesting, bug fixing, and UI/UX improvements.
