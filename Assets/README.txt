
	Tuning Changes -
	
	1.) Powerup Drop Chance
	
					Initial		Change 1	Change 2
		Enemy 	0 - 25%  	- > 15%   	- > 10% 
				1 - 50%  	- > 25%   	- > 20%
				2 - 75%  	- > 75%   	- > 40%
				3 - 75%  	- > 50%   	- > 30%
				4 - 100% 	- > 100%  	- > 80%
				
		Rationale:
			The main issue I had with the game is way that too many powerups spawned. I ranked each enemy by how much challenge they
			posed, and tried smaller probabilities, in that order I decided on. My intial attempt still ended up being too many powerups
			overall, so I started with 1 in 10 for the weakest ship, and increased by 10% from there. While I initially felt that based
			on the number of hits Enemy 4 takes to kill, it was fair to leave it at 100%, I ended up just making it 80%, which in practice
			feels like a 'most of the time'. I also initially left Enemy 2 at 75% because it's fairly hard to kill if it gets behind you,
			but the	other changes made powerups didn't quite feel like enough. With the second changes the overall frequency of powerups
			feel a lot better, but some players might feel like there's not much point in killing enemies, especially the weaker ones
			with a low powerup drop chance. For this reason, I plan to add a score counter as one of my additional elements.
	
	2.) Player Movement & Projectile Speed
	
									Initial		Change 1
		Player Movement Speed		30 		- > 40
		Player Projectile Speed		40		- > 60
		
		Rationale:
			Even though I think the initial speed looked good aesthetically, I didn't find the ship very responsive and it didn't feel
			like a skill issue when I tried to weave between the ships moving in parabolic arcs and got hit. At 40, the ship feels much
			more responsive, but when the player moves forward the bullets would be going the same speed and it would look weird. I
			raised the bullet speed, and it looked better, and after playing around a bit I didn't feel that faster bullets made the game
			too much easier.
	
	3.) Fire Rate & Velocity
	
						Initial		Change 1
		Fire Rate
			Blaster		0.2 	- > 0.4
			Spread		0.25 	- > 0.8
		
						Initial		Change 1	Change 2
		Weapon Velocity
			Blaster		0.5 	- > 0.75 	- > 0.65
			Spread		0.5 	- > 1.00 	- > 0.80
			
		Rationale:
			The second main issue I had was that any powerup past the intial blaster had way too much DPS (damage per second). By
			increasing weapon cooldown, players are forced to plan their shots more. Although the DPS is still a bit ridiculous for
			the level 5 weapons, the cooldown combined with the reduced powerup spawn chance makes it so it actually takes a degree
			of skill to get the weapon upgraded that far. Since the spread has 3 times as many bullets, I figured that twice the
			cooldown was fair. If you only land one of your 3 shots, then the DPS is worse than the blaster. If you land two, it's
			the same and if you land all 3 it has better DPS, so in my view this version of the spread weapon rewards player skill.
			I also modified projectile velocity to try and make it less viable for the player to just 'spray and pray', especially
			with higher weapon levels. At higher speeds, the bullets spend less time on the screen, and are less likely to hit a
			target you didn't explicitly aim at, while also making it slightly eaasier to hit an enemy you are aimed at; I see
			both as an improvement. My initial cahnges were too much however, so instead of making the blast 25% faster and the spread
			25% faster than that, I changed it to 15% faster. This felt like it hit the sweet spot for me as far as requiring player
			skill and minimizing time the bullet spends on screen.
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
	
	