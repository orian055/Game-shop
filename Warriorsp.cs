using System;

namespace Game
{
    public class Warriorspath
    {
        int yapcounter = 0;
        int yapcounter2 = 0;
        int yapcounter3 = 0;
        public void runWarrior(Random rnd, Hero hero, Battle bat)
        {
            Console.WriteLine("its a dojo i guess");
            Thread.Sleep(2500);
            if (!hero.passes.Exists(p => p.Name == "warrior"))
            {
             Console.WriteLine("eyal golan's biggest fan: hi");
             bat.runbattle(rnd, hero, "eyal golan's biggest fan", 5, 1, "you: eyal golan is overrated");
             hero.passes.Add(new Pass("warrior"));
            }
            else
            {
                if (hero.passes.Exists(p => p.Name == "pushups"))
                {
                Console.WriteLine("Awsome chinese sensei: ni hao");
                Thread.Sleep(2000);
                bool chinese = true;
                while (chinese)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Awsome chinese sensei ===");
                        Console.WriteLine("[1] who are you?");
                        Console.WriteLine("[2] what is this place?");
                        Console.WriteLine("[3] how do i kill the dragon?");
                        Console.WriteLine("[4] bye");

                        int choice = ConsoleUtils.ReadInt("Choose: ");
                        switch (choice)
                        {
                            case 1:
                            if (yapcounter == 3)
                            {
                            Console.WriteLine("sang-wu: SANG-WU! SANG-WU! HOW MANY MORE TIMES ARE YOU GONNA FUCKING ASK THAT");
                            Thread.Sleep(2500);
                            break;
                            }
                            else
                            {
                            Console.WriteLine("Awsome chinese sensei: i am sang-wu, i am the worlds best kung fu sensi!");
                            Thread.Sleep(2500);
                            Console.WriteLine("you: woah! could you teach me?");
                            Thread.Sleep(2500);
                            Console.WriteLine("Awsome chinese sensei: FUCK NO");
                            Thread.Sleep(2500);
                            yapcounter++;
                            break;
                            }

                            case 2:
                            if (yapcounter2 == 3)
                            {
                            Console.WriteLine("Awsome chinese sensei: WARRIORS PATH! YOU ARE IN WARRIORS PATH OKAY?");
                            Thread.Sleep(2500);
                            break;
                            }
                            else
                                {
                                    Console.WriteLine("Awsome chinese sensei: this is warriors path");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("Awsome chinese sensei: it was built for the dragon.");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("Awsome chinese sensei: so only those who are strong enough to pass could face him");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("Awsome chinese sensei: but he went to the mountains top instead");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("Awsome chinese sensei: now anyone can face him");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("Awsome chinese sensei: fuckass dragon");
                                    yapcounter2++;
                                    Thread.Sleep(2500);
                                    break;
                                }
                            
                            case 3:
                            if (yapcounter3 == 1)
                                {
                                    Console.WriteLine("Awsome chinese sensei: do you have dementia?");
                                    Thread.Sleep(2500);
                                    break;
                                }
                                else
                                {
                            Console.WriteLine("Awsome chinese sensei: why would you want to do that?");
                            Thread.Sleep(2500);
                            Console.WriteLine("you: he is evil and wants to kill everyone, he is also muslim");
                            Thread.Sleep(2500);
                            Console.WriteLine("Awsome chinese sensei: oh no its a common missconsemption");
                            Thread.Sleep(2500);
                            Console.WriteLine("Awsome chinese sensei: he is a pet actually, his owner recently died");
                            Thread.Sleep(2500);
                            Console.WriteLine("you: i guess thats why he wants to kill everyone?");
                            Thread.Sleep(2500);
                            Console.WriteLine("Awsome chinese sensei: that actually makes sense, anyways there is no magic way to kill him, just swing your fists as hard as you can");
                            Thread.Sleep(4500);
                            yapcounter3++;
                            break;
                                }

                            case 4:
                            chinese = false;
                            break;

                            default:
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("complete the training (main menu)");
                    Thread.Sleep(2500);
                    Console.WriteLine("hint: try resting at the bench");
                    Thread.Sleep(2500);
                    Console.ReadLine();
                }
                
                
            }
        }
    }
}
        
        
    
    