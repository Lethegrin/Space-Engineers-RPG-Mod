//Automatic Agression Response Program (A.A.R.P.)
 
 
//initialzize factions to be at peace with players and each other
 
//if((player's distance from center < 4000  )
//{
//MyAPIGateway.Utilities.ShowNotification( "Approach the station at an indirect angle or reduce your speed to 25 meters per second.", 2000, MyFontEnum.White);
//}
 
//if((player's movement vector is facing !owned ||!shared || !pirate || !samefaction largeblock) && speed difference > 55  && distance from center < 1000  && no agression point has been awarded within 10 seconds)
//{
//agression + 1
//MyAPIGateway.Utilities.ShowNotification( "Your speed does not comply with galactic law.", 2000, MyFontEnum.Red);
//}
//if((player's movement vector is facing !owned || !pirate || !shared || !samefaction largeblock) && speed difference > 35  && distance from center < 600  && no agression point has been awarded within 10 seconds)
//{
//agression + 1
//MyAPIGateway.Utilities.ShowNotification( "Your speed does not comply with galactic law.", 2000, MyFontEnum.Red);
//}
 
//if((player's movement vector is facing !owned || !pirate || !shared || !samefaction largeblock) && speed difference > 25  && distance from center < 200  && no agression point has been awarded within 10 seconds)
//{
//agression + 3
//MyAPIGateway.Utilities.ShowNotification( "You did not reduce your speed in time, have a nice day.", 2000, MyFontEnum.Red);
//}
 
 
 
//if(player's weapons block isWorking && player is !sheriff && (distance from !owned || !pirate || !shared ||!samefaction largeblock is <1500)
//{
//MyAPIGateway.Utilities.ShowNotification( "Power off your weapons systems to comply with galactic law.", 2000, MyFontEnum.Red);
//agression + 1
//}
 
//if(player's weapons block isWorking && player is !sheriff && (distance from !owned || !pirate || !shared ||!samefaction largeblock is <1000)
//{
//MyAPIGateway.Utilities.ShowNotification( "Power off your weapons systems to comply with galactic law.", 2000, MyFontEnum.Red);
//agression + 1
//}
 
//if(player's weapons block isWorking && player is !sheriff && (distance from !owned || !pirate || !shared ||!samefaction largeblock is <1000)
//{
//MyAPIGateway.Utilities.ShowNotification( "You did not power off your weapons in time, have a nice day.", 2000, MyFontEnum.Red);
//agression + 3
//}
 
//if((player's front is facing !owned || !pirate || !shared || !samefaction smallblock > 3 seconds) && weapons are online && distance from center of small block is < 850 && no agression point has been awarded within 10 seconds)
//{
//MyAPIGateway.Utilities.ShowNotification( "Attacking a member of the Galactic Federation is strictly prohibited.", 2000, MyFontEnum.Red);
//agression + 3
//}
 
 
//// Bounties
//*Bounties are placed on players for having an agression level 3 or higher
 
//if(bounty > 0 && player is !pirate
//{
//player is atwar attacked faction
//reduces bounty by 500 every 60 minutes
//}
//else if(bounty >0 && player is pirate
//{
//player is atwar with attacked faction
//}
 
//if(bounty = 0 && player !pirate)
//{
//player is peaceful with all !pirate factions
//stop removing bounty
////cannot have a negative bounty
//}
 
//*If(bountied ship's integrity is <33% && player is <1000m from bountied ship center && bountied ship is atwar && player's weapons are online)
//{
//split bounty between all qualifying players
//}
 
 
//// Fines
//Players will receive fines for miner infractions.
//*Unlike bounties, will not make player at war with faction
//*If left unpaid for 48 hours, will add 3 agression levels to the player
 
 
 
 
////Agression
 
//1:
//*MyAPIGateway.Utilities.ShowNotification("Your agression level with %faction% has increased to yellow", 2000, MyFontEnum.Yellow);
//Add 100 credits fine
//MyAPIGateway.Utilities.ShowNotification( "Your current fine is %playerfine%", 2000, MyFontEnum.Red);
 
 
//2:
//MyAPIGateway.Utilities.ShowNotification( "Your agression level with %faction% has increased to orange ", 2000, MyFontEnum.Orange);
//add 200 credits fine
//MyAPIGateway.Utilities.ShowNotification( "Your current fine is %playerfine%", 2000, MyFontEnum.Red);
 
//3:
//*Add 1000 credits bounty
//MyAPIGateway.Utilities.ShowNotification( "Your agression level with %faction% has increased to red", 2000, MyFontEnum.Red);
//MyAPIGateway.Utilities.ShowNotification( "Your current bounty is %playerbounty%", 2000, MyFontEnum.Red);
 
//4:
//*Add 2000 credits bounty
//MyAPIGateway.Utilities.ShowNotification( "Your current bounty is %playerbounty%", 2000, MyFontEnum.Red);
 
//5:
//*Add 4000 credits bounty
 
//MyAPIGateway.Utilities.ShowNotification( "Your current bounty is %playerbounty%", 2000, MyFontEnum.Red);
 
//6:
//*Add  8000 credits bounty
//Player and and every other player in their faction is now a pirate
//MyAPIGateway.Utilities.ShowNotification( "Your current bounty is %playerbounty%", 2000, MyFontEnum.Red);
 
 
////Pirates
 
//if player is a pirate
//*MyAPIGateway.Utilities.ShowNotification( "You and all in your faction have been branded as a pirate.  Galactic law no longer applies in your favor.", 2000, MyFontEnum.Red);
//*bounty does not decrease
//*"PIRATE" added to beginning of faction name
//*cannot be peaceful with any other faction
//*bounties are doubled
//*Players can attack them without gaining a bounty
//*Special pirate mechanics:
//        -each ship destroyed awards the pirate a prize of 500 credits that doubles each kill within 24 hours i.e. kill 1: 500 kill 2: 1000 kill 3: 2000 etc.
//        -each Sheriff destroyed triples current bounty
//        -if Pirate is killed, multiplier is reset
//    -each base claimed by their faction awards a prize of 30000 credits/the number of members in that faction
 
 
////Sheriffs
 
//*Players can become sheriffs by collecting the bounty of 10 pirate ships
//*Have access to special areas in stations which have reduced price for repairs and specialized ship type
//*Can have weapons online near stations
//*Players that attack them get fined with a double bounty
//*Agression levels are halved
//*If a bounty is placed on their head, lose the sheriff status
 
 
////Bounty Hunter
 
//*Become bounty hunter by collecting the bounty of 20 non-pirate players
//*Have access to the bounty hunter station, of which the hidden location is reveiled after becoming a Bounty Hunter. This station provides cheap repairs and a specialized ship type/weapons
//*Can have weapons online at the bounty hunter station
//*Have a 50% increase in bounties collected
//*Can use "warrent radar" once every 10 minutes to gain the locations of bountied players within 10,000 meters
 
 
////Prospector
 
//*Become a Prospector by selling 5000 credits worth of ore
//*Gain access to special trade centers spread accross the map which buys ore at a increased price and has a specialized ship
//*trade centers are conveniently placed near high yield asteroids which are protected by gatling stations
//*Can use "EMP" which disables thrusters and weapons of any bountied or pirate ship in a 1 km radius for 30 seconds ( can be used as a support ship )