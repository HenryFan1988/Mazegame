///////////////////////////////////////////////////////////
//  Armor.cs
//  Implementation of the Class Armor
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:36 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////

namespace Mazegame.Entity
{
    public class Armor : Item
    {
        private int bonus;

        public Armor(string label, int worth, double weight, string description)
            : base(label, worth, weight, description)
        {
        }


        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
    } //end Armor
} //end namespace Entity