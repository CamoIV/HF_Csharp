﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        public Player(Game game, Point location)
                            : base(game, location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                // see if the weapon is nearby, and possibly pick it up
                if(Nearby(game.WeaponInRoom.Location, 10))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if(equipedWeapon != null)
            {
                if(equipedWeapon is IPotion)
                {
                    if(equipedWeapon == "BluePotion")
                    {
                        BluePotion currentWeapon = equipedWeapon as BluePotion;
                        currentWeapon.Attack(direction, random);
                        equipedWeapon = null;
                    }
                    else
                    {
                        RedPotion currentWeapon = equipedWeapon as RedPotion;
                        currentWeapon.Attack(direction, random);
                        equipedWeapon = null;
                    }
                }
                else
                {
                    equippedWeapon.Attack(direction, random);
                }
            }
        }
    }
}
