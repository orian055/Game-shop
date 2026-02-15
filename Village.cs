using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Game
{
    class Village
    {
        public void runVillage(Hero hero)
        {
            bool village = true;
            while (village)
            {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║          WELCOME TO THE VILLAGE        ║");
            Console.WriteLine("║      Where Legends Rise and Fall       ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("The village is bustling with activity. You see various inhabitants...");
            Console.WriteLine();
            Console.WriteLine("[1] Priest          - Speaks with divine fury");
            Console.WriteLine("[2] Hero            - Gazes at the sky, lost in thought");
            Console.WriteLine("[3] Baker           - Kneads dough with passion");
            Console.WriteLine("[4] Blacksmith      - Hammers forge metalwork");
            Console.WriteLine("[5] Wizard          - Meditates with mysterious energy");
            Console.WriteLine();
            Console.WriteLine("[6] Leave the village");
            
            int talk = ConsoleUtils.ReadInt("Whom will you seek out? ");
            switch (talk)
                {
                    case 1:
                    if (hero.passes.Exists(p => p.Name == "pqc"))
                    {
                    Console.WriteLine("village priest: you saved my life! thank you!");
                    Thread.Sleep(2500);
                    break;
                    }
                    else if (!hero.passes.Exists(p => p.Name == "pq"))
                    {
                        Console.WriteLine("village priest: THE DRAGON IS SATAN!");
                        Thread.Sleep(3000);
                        Console.WriteLine("village priest: HE WAS SENT BY GOD TO KILL US ALL!");
                        Thread.Sleep(2500);
                        Console.WriteLine("village priest: WE SHALL OBEY GOD AND DIE!!!!");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: calm down bruh...");
                        Thread.Sleep(2500);
                        Console.WriteLine("who gave you those drugs");
                        Thread.Sleep(2500);
                        Console.WriteLine("village priest: the wizard gang, he got some magical stuff frfr");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: sign up to rehab center bruv");
                        Thread.Sleep(2500);
                        Console.WriteLine("village priest: write me up?");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: ight");
                        ConsoleUtils.Pause();
                        hero.passes.Add(new Pass("pq"));
                        break;
                    }
                    else
                            {
                                Console.WriteLine("village priest: did you sign me?");
                                if (hero.inv.Exists(i => i.Name == "papers"))
                                {
                                    Console.WriteLine("you: ofc i did");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("village priest: thank you sm");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("he blessed you! +20 dmg!");
                                    ConsoleUtils.Pause();
                                    hero.dmg += 20;
                                    hero.inv.RemoveAll(i => i.Name == "papers");
                                    hero.passes.RemoveAll(p => p.Name == "pq");
                                    hero.passes.Add(new Pass("pqc"));
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("you: no...");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("village priest: GO FUCKING GO!");
                                    Thread.Sleep(2500);
                                    break;
                                }
                            }
                    case 2:
                    if (hero.passes.Exists(p => p.Name == "hqc"))
                            {
                                Console.WriteLine("village hero: thanks for passing by again mate!");
                                Thread.Sleep(2500);
                                break;
                            }
                    else if (hero.passes.Exists(p => p.Name == "hq"))
                            {
                                Console.WriteLine("village hero: you have the beers?");
                                Thread.Sleep(2500);
                                if (hero.inv.Exists(i => i.Name == "beers"))
                                {
                                    Console.WriteLine("you: yeah.");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("village hero: thanks mate. come sit");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("you sat with the hero");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("he gave you his blessed magical overpowerd hand warps");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("+ 20 dmg!");
                                    Thread.Sleep(2500);
                                    hero.dmg += 20;
                                    hero.passes.Add(new Pass("hqc"));
                                    hero.passes.RemoveAll(p => p.Name == "hq");
                                    hero.passes.Add(new Pass("beers"));
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("you: no");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("village hero: go get it man, im waiting");
                                    Thread.Sleep(2500);
                                    break;
                                }
                            }
                        else
                        {    
                        Console.WriteLine("the hero is looking at the dragon in the sky");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: Are you okay?");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: no.");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: what happend?");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: this damn dragon, i didnt even know dragons are real.");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: i used to be respected around here, people looked up to me.");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: i kept them safe, i was their hero.");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: this dragon took everything from me, he is too strong to be stopped");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: everyone will die, begging for me to help");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: but i cant face this dragon, no one can...");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: what can i do to help");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: get me a drink from the bar maybe");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: on it!");
                        Thread.Sleep(2500);
                        Console.WriteLine("village hero: thanks mate, im right here. come back with some beer");
                        hero.passes.Add(new Pass("hq"));
                        ConsoleUtils.Pause();
                        break;
                        }

                    case 3:
                        if (hero.inv.Exists(i => i.Name == "pizza"))
                        {
                            Console.WriteLine("dont be greedy! one pizza at once");
                            Thread.Sleep(2500);
                            break;
                        }
                        
                        if (hero.passes.Exists(p => p.Name == "bakeq") || hero.passes.Exists(p => p.Name == "bakeqc"))
                        {
                            Console.WriteLine("village baker: do you have the sauce?");
                            Thread.Sleep(2500);
                            if (hero.inv.Exists(i => i.Name == "sauce"))
                            {
                                Console.WriteLine("you: yes!");
                                Thread.Sleep(2500);
                                Console.WriteLine("village baker: Wonderful!");
                                Thread.Sleep(2500);
                                Console.WriteLine("you sat with the baker and had a great time");
                                ConsoleUtils.Pause();
                                Console.WriteLine("village baker: dont hesitate to come back for more pizza!");
                                Console.WriteLine();
                                hero.inv.Add(new Item("pizza", ItemType.Consumable, hero.itemstat("pizza")));
                                hero.passes.RemoveAll(p => p.Name == "bakeq");
                                hero.inv.RemoveAll(i => i.Name == "sauce");
                                hero.passes.Add(new Pass("bakeqc"));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("you: no");
                                Thread.Sleep(2500);
                                Console.WriteLine("village baker: its okay! whenever youre ready");
                                Thread.Sleep(2500);
                                break;
                            }
                        }
                        else {
                        Console.WriteLine("the baker is making a pizza");
                        Console.WriteLine("you: YOOO THIS LOOKS FIRE");
                        Thread.Sleep(2500);
                        Console.WriteLine("village baker: merci beaucoup! you want a pizza too?");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: a pizza would be nice");
                        Thread.Sleep(2500);
                        Console.WriteLine("village baker: i would need some tomato sauce! could you get me some?");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: sure!");
                        Thread.Sleep(2500);
                        Console.WriteLine("hes a nice guy");
                        hero.passes.Add(new Pass("bakeq"));
                        ConsoleUtils.Pause();
                        break;
                        }

                    case 4:
                        if (hero.passes.Exists(p => p.Name == "gfqc"))
                        {
                            Console.WriteLine("wait for me at the mountain's top when your ready!");
                            Thread.Sleep(2500);
                            break;
                        }
                        else if (hero.passes.Exists(p => p.Name == "gfq"))
                        {
                            Console.WriteLine("blacksmith: do you have my iron?");
                            Thread.Sleep(2500);
                            if (hero.inv.Exists(i => i.Name == "iron"))
                            {
                                Console.WriteLine("you: yes i do<3");
                                Thread.Sleep(2500);
                                Console.WriteLine("blacksmith: im proud");
                                Thread.Sleep(2500);
                                hero.maxhp += 100;
                                Console.WriteLine("max health increased.");
                                ConsoleUtils.Pause();
                                hero.inv.RemoveAll(i => i.Name == "iron");
                                hero.passes.RemoveAll(p => p.Name == "gfq");
                                hero.passes.Add(new Pass("gfqc"));
                                break;

                            }
                            else
                            {
                                Console.WriteLine("you: no):");
                                Thread.Sleep(2500);
                                Console.WriteLine("then go mine some");
                                Thread.Sleep(2500);
                                break;
                            }
                        }
                        else 
                        {
                        Console.WriteLine("the blacksmith is doing something");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: what are you building there?");
                        Thread.Sleep(2500);
                        Console.WriteLine("blacksmith: an armor, if the hero wont kill this dragon, i will");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: could you make me an armor too? im going after the dragon aswell");
                        Thread.Sleep(2500);
                        Console.WriteLine("blacksmith: im out of iron, get me some and ill make armors for both us");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: are you inviting me to a dragon killing date?");
                        Thread.Sleep(2500);
                        Console.WriteLine("blacksmith: go get the iron, im waiting");
                        Thread.Sleep(2500);
                        Console.WriteLine("(yes the blackmith is a woman)");
                        hero.passes.Add(new Pass("gfq"));
                        ConsoleUtils.Pause();
                        break;
                        }

                    case 5:
                    if (hero.passes.Exists(p => p.Name == "wizqc"))
                        {
                            Console.WriteLine("village wizard: thanks for the za");
                            Thread.Sleep(2500);
                            break;
                        }
                    if (hero.passes.Exists(p => p.Name == "wizq"))
                        {
                            Console.WriteLine("village wizard: do you have my za?");
                            Thread.Sleep(2500);
                            if (hero.inv.Exists(i => i.Name == "za"))
                            {
                                Console.WriteLine("you: fuck yes");
                                Thread.Sleep(2500);
                                Console.WriteLine("village wizard: hell yeah my guy");
                                Thread.Sleep(2500);
                                hero.passes.RemoveAll(p => p.Name == "wizq");
                                hero.passes.Add(new Pass("wizqc"));
                                Console.WriteLine("he showed you how to punch harder");
                                Console.WriteLine("damage incrased by 5!");
                                hero.dmg += 5;
                                ConsoleUtils.Pause();
                                hero.inv.RemoveAll(i => i.Name == "za");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("you: no");
                                Thread.Sleep(2500);
                                Console.WriteLine("village wizard: go get it from the dark ally in town");
                                ConsoleUtils.Pause();
                                break;
                            }
                        }
                        else 
                        {
                        Console.WriteLine("the wizard is yelling magic stuff.");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: YO! are you high? why are you yelling?");
                        Thread.Sleep(2500);
                        Console.WriteLine("village wizard: Perhaps my drugs allow one to see his true self?");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: what?");
                        Thread.Sleep(2500);
                        Console.WriteLine("village wizard: Will you get me some more? me dealer is at the dark ally in the town");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: and what will i get from it?");
                        Thread.Sleep(2500);
                        Console.WriteLine("village wizard: uhhhhhh i could teach you some moves");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: bet.");
                        hero.passes.Add(new Pass("wizq"));
                        ConsoleUtils.Pause();
                        }
                        break;

                    case 6:
                        village = false;
                        break;

                    default:
                        break;

                                                
                }
            }
        }
    }
}