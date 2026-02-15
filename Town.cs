using System;

namespace Game
{
    public class Town
    {
        public void runtown(Hero hero, Battle bat, Random rnd, Save save)
        {
            bool town = true;
            while (town)
            {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║            WELCOME TO TOWN             ║");
            Console.WriteLine("║        Where Fortune and Danger        ║");
            Console.WriteLine("║           Walk Hand in Hand            ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("The town bustles with all manner of activities and inhabitants...");
            Console.WriteLine();
            Console.WriteLine("[1] Dark Alley      - Shadowy and mysterious");
            Console.WriteLine("[2] Market          - Vendors and traders");
            Console.WriteLine("[3] Mine            - Dark depths below");
            Console.WriteLine("[4] Bar             - Where friendships are tested");
            Console.WriteLine("[5] Bench           - A peaceful place to rest");
            Console.WriteLine("[6] Rehab Center    - Salvation lies here");
            Console.WriteLine();
            Console.WriteLine("[7] Leave town");
                                
            int choice = ConsoleUtils.ReadInt("Where do you venture? ");
            switch (choice)
                {
                    case 1:
                    Console.WriteLine("You venture into the dark alley... lantern light flickers in the distance.");
                    Thread.Sleep(1500);
                    if (!hero.passes.Exists(p => p.Name == "wizq"))
                        {
                            Console.WriteLine("nothing to look for there");
                            Thread.Sleep(2500);
                            break;
                        }
                    if (hero.inv.Exists(i => i.Name == "za"))
                        {
                            Console.WriteLine("you got the za, give it to the wizard");
                            Thread.Sleep(2500);
                            break;
                        }
                    if  (hero.passes.Exists(p => p.Name == "wizqc"))
                        {
                            Console.WriteLine("you completed the quest!");
                            Thread.Sleep(2500);
                            break;
                        }
                            
                    else
                    {     
                    Console.WriteLine("You went inside.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Some weird guy came to you");
                    Thread.Sleep(2500);
                    Console.WriteLine("Weird Guy: do you want some za?");
                    Thread.Sleep(2500);
                    Console.WriteLine("you: of course, what other fucking reason would i have to come into this weird ahh dark ally of yours. its not like i woke up in the morning and said to myself: OH I CANT WAIT TO GET RAPED TODAY! fuck you just give me the za already so that weird wizard will stop annoying me");
                    Thread.Sleep(2500);
                    Console.WriteLine("Weird Guy: k. thats 5000000$");
                    Thread.Sleep(2500);
                    bat.runbattle(rnd, hero, "Weird Guy", 10, 2, "5000000$?");
                    Console.WriteLine("you beated the living shit out of him");
                    Thread.Sleep(2500);
                    Console.WriteLine("za added to inventory");
                    Thread.Sleep(2500);
                    hero.inv.Add(new Item("za", ItemType.Quest));
                    break;
                    }

                    case 2:
                    Console.WriteLine("You walk toward the bustling market... voices haggle over prices.");
                    Thread.Sleep(1500);
                    bool market = true;
                    while (market)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Market ===");
                        Console.WriteLine("[1] Pizza sauce - $15");
                        Console.WriteLine("[2] Other items (coming soon)");
                        Console.WriteLine("[3] Exit");

                        int buy = ConsoleUtils.ReadInt("Choose an item: ");
                        switch (buy)
                        {
                            case 1:
                                if (hero.Money < 15)
                                {
                                    Console.WriteLine("You don't have enough money.");
                                    Thread.Sleep(1200);
                                    break;
                                }
                                hero.inv.Add(new Item("sauce", ItemType.Quest));
                                hero.Money -= 15;
                                Console.WriteLine("You bought pizza sauce.");
                                Thread.Sleep(1000);
                                break;
                            case 2:
                                Console.WriteLine("No other items available right now.");
                                Thread.Sleep(1000);
                                break;
                            case 3:
                                market = false;
                                break;
                            default:
                                Console.WriteLine("Please choose 1-3.");
                                Thread.Sleep(800);
                                break;
                        }
                    }
                    break;

                    case 3:
                    Console.WriteLine("You descend into the deep mine... pickaxes echo in the darkness below.");
                    Thread.Sleep(1500);
                    if (hero.passes.Exists(p => p.Name == "gfqc"))
                    {
                    Console.WriteLine("you comepleted the quest!");
                    Thread.Sleep(2500);
                    break;
                    }
                    else if (!hero.inv.Exists(i => i.Name == "iron"))
                    {
                    Console.WriteLine("you walked trough the mine");
                    Thread.Sleep(2500);
                    Console.WriteLine("Evil rapist: yo");
                    Thread.Sleep(2500);
                    bat.runbattle(rnd, hero, "Evil rapist", 30, 4, "you are disgusting");
                    Console.WriteLine("you took is iron.");
                    Thread.Sleep(2500);
                    hero.inv.Add(new Item("iron", ItemType.Quest));
                    break;
                    }
                    else
                        {
                            Console.WriteLine("you already have iron, leave the rapist alone");
                            Thread.Sleep(2500);
                            break;
                        }

                    case 4:
                    Console.WriteLine("You push through the bar doors... warm ale and laughter fill the air.");
                    Thread.Sleep(1500);
                    bool bar = true;
                    while (bar)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Bar ===");
                        Console.WriteLine("[1] Buy beers - $30");
                        Console.WriteLine("[2] Start a fight");
                        Console.WriteLine("[3] Leave");

                        int choice1 = ConsoleUtils.ReadInt("Choose: ");
                        switch (choice1)
                        {
                        case 1:
                        if (hero.passes.Exists(p => p.Name == "addict"))
                        {
                        Console.WriteLine("you are NOT buying more beers");
                        Thread.Sleep(2500);
                        break;
                        }
                        if (hero.Money < 30)
                        {
                        Console.WriteLine($"Broke! you have {hero.Money}"); 
                        Thread.Sleep(2500);
                        break;
                        }
                        else { 
                        Console.WriteLine("bought beers!");
                        Thread.Sleep(2500);
                        hero.passes.Add(new Pass("addict"));
                        hero.inv.Add(new Item("beers", ItemType.Miscellaneous));
                        hero.Money -= 30;
                        break;
                        }

                        case 2:
                        if (hero.passes.Exists(p => p.Name == "dontfuckwithme"))
                        {
                        Console.WriteLine("yeah bro i had enough");
                        Thread.Sleep(2500);
                        break;
                        }
                        else
                        {    
                        Console.WriteLine("drunk dude: FUCK YOU");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: fuck did i do?");
                        Thread.Sleep(2500);
                        Console.WriteLine("drunk dude: you fucked my wife i saw you!");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: fuck no i didnt");
                        Thread.Sleep(2500);
                        Console.WriteLine("drunk dude: I KNOW YOU DID! IM GONNA KILL YOU!");
                        bat.runbattle(rnd,hero,"drunk dude", 50,20,"are you calling me liar?");
                        Console.WriteLine("you fucked him up like you did to his wife");
                        Thread.Sleep(2500);
                        Console.WriteLine("you: I DIDNT FUCK HIS WIFE");
                        Thread.Sleep(2500);
                        Console.WriteLine("prove it then boy!");
                        bat.runbattle(rnd,hero,"narrator", 100, 1, "im sick of you");
                        Console.WriteLine("im sorry mate... take some upgrades");
                        Thread.Sleep(2500);
                        hero.passes.Add(new Pass("dontfuckwithme"));
                        hero.dmg += 10;
                        hero.maxhp += 10;
                        hero.health += 10;
                        hero.Money += 100;
                        break;
                        }
                          
                        case 3:
                        bar = false;
                        break;

                        default:
                        break;
                                             
                        }
                        }
                    break;

                    case 5:
                    Console.WriteLine("You approach the bench... moonlight casts silver shadows across its weathered wood.");
                    Thread.Sleep(1500);
                    bool bench = true;
                    while (bench)
                    {
                        Console.Clear();
                        Console.WriteLine("═══════════════════════════════=");
                        Console.WriteLine("          🌙  Rest Stop  🌙");
                        Console.WriteLine("═══════════════════════════════=");
                        Console.WriteLine();
                        Console.WriteLine("You find a peaceful bench beneath the stars.");
                        Console.WriteLine("The air is crisp, and the world feels quiet.");
                        Console.WriteLine();
                        Console.WriteLine("[1] Sleep and save your progress");
                        Console.WriteLine("[2] Rest for a moment");
                        Console.WriteLine("[3] Leave");
                        Console.WriteLine();

                        int yo = ConsoleUtils.ReadInt("What will you do? ");
                        switch (yo)
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("You drift to sleep under the moonlight...");
                                Thread.Sleep(1000);
                                Console.WriteLine("*Saving progress...*");
                                save.SaveGame(hero);
                                Thread.Sleep(500);
                                Console.WriteLine("You wake up feeling refreshed.");
                                ConsoleUtils.Pause();
                                break;
                            case 2:
                                Console.WriteLine();
                                Console.WriteLine("You sit on the bench and take a deep breath.");
                                Thread.Sleep(800);
                                hero.stamina += 10;
                                hero.motivation += 10;
                                Console.WriteLine("You feel energized. +10 stamina +10 motivation");
                                Thread.Sleep(1200);
                                break;
                            case 3:
                                Console.WriteLine("You leave the bench and continue on.");
                                bench = false;
                                break;
                            default:
                                Console.WriteLine("You're not sure what to do.");
                                Thread.Sleep(600);
                                break;
                        }
                    }
                    break;
                            
                    

                    case 6:
                    Console.WriteLine("You approach the rehab center... a place of second chances and redemption.");
                    Thread.Sleep(1500);
                    if (hero.inv.Exists(i => i.Name == "papers"))
                    {
                    Console.WriteLine("you have papers, give them to the priest!");
                    break;
                    }
                    
                    else if (hero.passes.Exists(p => p.Name == "pqc"))
                            {
                                Console.WriteLine("Quest completed!");
                                break;
                            }

                    else if (!hero.passes.Exists(p => p.Name == "pq"))
                            {
                                Console.WriteLine("the russian guard not letting you in.");
                                Thread.Sleep(2500);
                                Console.WriteLine("you dont really have a reason to be there too..");
                                Thread.Sleep(2500);
                                break;
                            } 
                     else
                            {
                                Console.WriteLine("russian guard: Вы туда не войдете.");
                                bat.runbattle(rnd, hero, "russian guard", 50, 10, "What the fuck did you just say to me?");
                                Console.WriteLine("you: bitch!");
                                Thread.Sleep(2500);
                                Console.WriteLine("you went inside the rehab center");
                                Thread.Sleep(2500);
                                Console.WriteLine("you: yo sign the priest from the village to this stinky place");
                                Thread.Sleep(2500);
                                Console.WriteLine("rehab manager: Dima get this guy out of here!");
                                Thread.Sleep(2500);
                                Console.WriteLine("you: he is dead outside, now sign the priest.");
                                Thread.Sleep(2500);
                                Console.WriteLine("you got papers. give them to the priest!");
                                hero.inv.Add(new Item("papers", ItemType.Quest));
                                ConsoleUtils.Pause();
                                break;
                            }
                
                               

                    case 7:
                    Console.WriteLine("You turn away from the town, heading toward the horizon...");
                    Thread.Sleep(1500);
                    town = false;
                    break;

                    default:
                    Console.WriteLine("The town streets seem to shift around you, uncertain of your path.");
                    Thread.Sleep(1500);
                    break; 
                }
            }
        }
    }
}