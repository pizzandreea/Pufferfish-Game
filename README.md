# Pufferfish-Game
Unity game - where a pufferfish is thrown into the ocean and tries to be the biggest fish out there.


Project Documentation: https://docs.google.com/document/d/1PswUDpJF3nsy51FYXns8xkIrB_WAQc9m6VL-Q1EokHg/edit?usp=sharing

A game demo: https://youtu.be/hN_90HCisMo 


## Team Pufferfish:
* Ioana-Livia Popescu
* Miruna-Maria Vasiliu
* Andreea-Florina Ciurescu

## Story
Everything began with this video:  Pufferfish eats carrot (full video)
The pufferfish is tortured and forced to eat carrots to puff up, so he escapes and falls in the ocean where he aspires to be the biggest fish there is, so no one can tell him what to do or what to eat.

## Characters
* Player - The pufferfish

Moves with WASD. Its main purpose is to become as big as possible in order to not be eaten by the bigger fish in the ocean. Once it encounters an object with a mass less or equal to its own, it is able to eat it, gaining the object’s mass. In the beginning. If it accidentally comes in contact with a fish bigger than its size, the bigger fish wins.

* NPCs - 7 types of fishes with masses from 1.5 to 80.
They move in a straight line for now, from right to left or reverse, when they reach the border, the object is destroyed. They are made from a spawner generated at a random position.

* Carrot - the first and smallest object in the game. Once the game starts and the pufferfish is at its smallest weight, it can only eat carrots. 
* Fish - there are 7 types of fish of different sizes. If they touch the pufferfish when it is smaller than them, they will eat it and the game is over.
* Fish no3 poisonous fish- even though harmless in appearance, this fish will kill you if you touch it.
* Dolphin- the dolphin is the 5th fish by mass and the only one which is harmless. You can decide whether you eat it or not since it will not harm you.


## Build Tool

Unity Build Tool to create and develop the game. 
We mainly used C# scripts.
