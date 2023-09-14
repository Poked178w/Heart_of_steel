using sr;
using UnityEngine;

namespace sr
{
    class BalanceR : MonoBehaviour
    {
        public void Camera()
        {
            RobotsC camera = new RobotsC();

            camera.id = 0;
            camera.speed = 6.4f;
        }

        public void Warrion()
        {
            RobotsC warrion = new RobotsC();

            warrion.id = 1;
            warrion.durability = 66000;
            warrion.speed = 4.4f;
            warrion.wears = 300;

            warrion.sw1.id = 1;
            warrion.sw2.id = 1;
            warrion.sw3.id = 1;

            warrion.sa1.id = 0;
            warrion.sa2.id = 0;
            warrion.sa3.id = 0;
        }

        public void Krolik()
        {
            RobotsC krolik = new RobotsC();

            krolik.id = 2;
            krolik.durability = 40000;
            krolik.speed = 4.62f;
            krolik.wears = 200;

            krolik.sw1.id = 2;
            krolik.sw2.id = 2;

            krolik.sa1.id = 0;
            krolik.sa2.id = 0;
            krolik.sa3.id = 0;

            krolik.ability.name = "Jump";
            krolik.ability.rechange = 6.2F;
            krolik.ability.duration = 2.2F;
        }

        public void Shot()
        {
            RobotsC shot = new RobotsC();

            shot.id = 3;
            shot.durability = 48000;
            shot.speed = 4.42f;
            shot.wears = 250;
            shot.dPS = 16800;

            shot.sw1.id = 3;

            shot.sa1.id = 0;
            shot.sa2.id = 0;
            shot.sa3.id = 0;
        }

        public void Kentaur()
        {
            RobotsC kentaur = new RobotsC();

            kentaur.id = 4;
            kentaur.durability = 79000;
            kentaur.speed = 3.8f;
            kentaur.wears = 450;

            kentaur.sw1.id = 2;
            kentaur.sw2.id = 4;
            kentaur.sw3.id = 2;

            kentaur.sa1.id = 0;
            kentaur.sa2.id = 0;
            kentaur.sa3.id = 0;
        }

        public void Knight()
        {
            RobotsC knight = new RobotsC();

            knight.id = 5;
            knight.durability = 68000;
            knight.speed = 36.8F;
            knight.wears = 450;
            knight.dPS = 44000;

            knight.sw1.id = 5;
            knight.sw2.id = 1;
            knight.sw3.id = 5;

            knight.sa1.id = 0;
            knight.sa2.id = 0;
            knight.sa3.id = 0;
        }

        public void Zwerg()
        {
            RobotsC zwerg = new RobotsC();

            zwerg.id = 6;
            zwerg.durability = 90000;
            zwerg.speed = 38.0f;
            zwerg.wears = 350;

            zwerg.sw1.id = 6;
            zwerg.sw2.id = 6;

            zwerg.sa1.id = 0;
            zwerg.sa2.id = 0;
            zwerg.sa3.id = 0;
        }

        public void Anger()
        {
            WeaponsC anger = new WeaponsC();

            anger.id = 1;
            anger.damage = 264;
            anger.rechange = 12.0f;
            anger.clip = 250;
            anger.rof = 10.0f;
            anger.distance = 40.0f;
            anger.weight = 100;

            anger.sa1.id = 0;
        }

        public void Piner()
        {
            WeaponsC piner = new WeaponsC();

            piner.id = 2;
            piner.damage = 4620;
            piner.rechange = 4.0f;
            piner.clip = 1;
            piner.rof = 0.0f;
            piner.distance = 45.0f;
            piner.weight = 100;

            piner.sa1.id = 0;
        }

        public void Puv()
        {
            WeaponsC puv = new WeaponsC();

            puv.id = 3;
            puv.damage = 19060;
            puv.rechange = 10.2f;
            puv.clip = 1;
            puv.rof = 0.0f;
            puv.distance = 100.0f;
            puv.weight = 250;

            puv.sa1.id = 0;
        }

        public void Penok()
        {
            WeaponsC penok = new WeaponsC();

            penok.id = 4;
            penok.damage = 34000;
            penok.rechange = 10.5f;
            penok.clip = 1;
            penok.rof = 0.0f;
            penok.distance = 45.0f;
            penok.weight = 250;

            penok.sa1.id = 0;
        }

        public void Anger_2()
        {
            WeaponsC anger_2 = new WeaponsC();

            anger_2.id = 5;
            anger_2.damage = 462;
            anger_2.rechange = 12.0f;
            anger_2.clip = 250;
            anger_2.rof = 10.0f;
            anger_2.distance = 40.0f;
            anger_2.weight = 175;

            anger_2.sa1.id = 0;
        }

        public void River()
        {
            WeaponsC river = new WeaponsC();

            river.id = 6;
            river.damage = 977;
            river.rechange = 8.0f;
            river.clip = 90;
            river.rof = 4.5f;
            river.distance = 80.0f;
            river.weight = 175;

            river.sa1.id = 0;
        }

        public void Armor_Kit1()
        {
            AmplifiersC armor_kit1 = new AmplifiersC();

            armor_kit1.id = 1.0f;
            armor_kit1.parameter1 = 3; // Дополнительная прочность в %
        }

        public void Armor_Kit2()
        {
            AmplifiersC armor_kit2 = new AmplifiersC();

            armor_kit2.id = 1.1f;
            armor_kit2.parameter1 = 5; // Дополнительная прочность в %
        }

        public void Armor_Kit3()
        {
            AmplifiersC armor_kit3 = new AmplifiersC();

            armor_kit3.id = 1.2f;
            armor_kit3.parameter1 = 5; // Дополнительная прочность в %
            armor_kit3.parameter2 = 12; // Очки IA 
        }
    }
}
