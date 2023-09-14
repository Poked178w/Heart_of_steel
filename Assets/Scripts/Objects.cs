using JetBrains.Annotations;
using sr;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sr
{
    class RobotsC
    {
        public int id;
        public int durability;
        public float speed;
        public int wears;
        public int dPS; // Прочность физического щита
        public int dES; // Прочность энергетического щита
        private float rES = 0.03F; // Ремонт энергетического щита в %

        public SlotW sw1;
        public SlotW sw2;
        public SlotW sw3;
        public SlotW sw4;

        public SlotA sa1;
        public SlotA sa2;
        public SlotA sa3;

        public Ability ability;
    }

    class WeaponsC
    {
        public int id;
        public int damage;
        public float rechange;
        public int clip;
        public float rof; // Скорострельность
        public float distance;
        public int weight;
        // public ProjectileType projectileT;
        // public WeaponType weaponT;
        public SlotA sa1;
    }

    class AmplifiersC
    {
        public float id;
        public int parameter1;
        public int parameter2;
        public int parameter3;
    }

    class SlotW
    {
        public int id;
        public string name;
    }

    class SlotA
    {
        public int id;
        public string name;
        public enum weight : byte
        {
            Beta,
            Alpha,
            Gamma
        }
    }

    class Ability
    {
        public string name;
        public float rechange;
        public float duration;
    }
}
