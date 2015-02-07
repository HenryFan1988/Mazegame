///////////////////////////////////////////////////////////
//  IMazeData.cs
//  Implementation of the Interface IMazeData
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////


using System;
using Mazegame.Entity;
using Mazegame.Entity.Utility;

namespace Mazegame.Boundary {
	public interface IMazeData  {

		Location GetStartingLocation();
	    String GetWelcomeMessage();
        StrengthTable GetStrengthTable();
        AgilityTable GetAgilityTable();
        WeightLimit GetWeightLimit();


	}//end IMazeData

}//end namespace Boundary