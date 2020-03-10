using System;
using System.Collections.Generic;

namespace FlowerShop {
    class Program {
        static void Main (string[] args) {

            Rose miniRose = new Rose ();
            miniRose.Color = "Pink";
            miniRose.Cost = 1.50;
            miniRose.Fragrant = true;
            miniRose.Name = "Mini Rose";
            miniRose.Thorny = true;
            miniRose.Type = "rose";
            miniRose.Water = "weekly";

            Tulip yellowTulip = new Tulip ();
            yellowTulip.Color = "Yellow";
            yellowTulip.Cost = 1.99;
            yellowTulip.Fragrant = false;
            yellowTulip.Name = "Yellow Belly";
            yellowTulip.Thorny = false;
            yellowTulip.Type = "tulip";
            yellowTulip.Water = "daily";

            Carnation pinkCarnation = new Carnation ();
            Sunflower sunflower = new Sunflower ();

            FlowerShop myFlowerShop = new FlowerShop ();
            List<IGetWell> arrangement = myFlowerShop.MakeGetWellArr ();
        }
    }
}