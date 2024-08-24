using System;


namespace Classes__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Pelle = new Human("Pelle","Svensson","Blue",46);
            Pelle.IntroduceMyself();

            Human Kalle = new Human("Kalle","Carlsson","Black");
            Kalle.IntroduceMyself();

            Human Arb = new Human( "Arb","Arbsson");
            Arb.IntroduceMyself();

            Human Haha = new Human("Haha");
            Haha.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();
        }



    }
}