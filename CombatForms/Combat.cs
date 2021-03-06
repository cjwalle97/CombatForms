﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    //Name: Element
    //Type: enum
    //Description: determines what element a Skill/Attack is
    public enum Element
    {
        Fire = 0,
        Ice = 1,
        Electricity = 2,
        Force = 3,
        Dark = 4,
        Light = 5,
        Slash = 6,
        Strike = 7,
        Pierce = 8,
    }
    //Name: Combat
    //Type: class
    //Description: When a Column gets a turn either the Hunter or the Demon will perform an attack or use their skill. 
    //Whichever one performs the action will become "Active" meaning that they will take damage when the Column is targeted for an attack.
    //if either the Hunter or the Demon is "dead" and the Column will from then on be skipped in the turn rotation
    //All Columns will start with the Hunter as the "Active unit"
    //Hunter = Player class
    //Order: Party1 -> Fastest Party1 Column -> Next Column -> Slowest Column -> Party2 -> 
    //Fastest Party2 Column -> Next Column -> Slowest Column. Speed is based on the "Active unit's" Agility
    class Combat
    {
        
    }
}
