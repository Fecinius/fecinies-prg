using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class Program
    {

        static Dictionary<string, Dictionary<string, int>> items = new Dictionary<string, Dictionary<string, int>>
        {
            { "Consumables", new Dictionary<string, int>
                {
                    // Subcategory: Drinks
                    { "Beer", 2 },
                    { "Vodka", 4 },
                    { "Whiskey", 6 },
                    { "Wine", 2 },
                    { "Rum", 6 },
                    { "Tequila", 8 },
                    { "Cider", 3 },
                    { "Mead", 4 },
                    { "Sake", 6 },
                    { "Absinthe", 10 },

                    // Subcategory: Powder
                    { "White Powder", 400 }
                }
            },
            { "Tools and Objects", new Dictionary<string, int>
                {
                    { "Empty Bottle", 1 },
                    { "Car Keys", 50 },
                    { "Magic Wand", 100 },
                    { "Phone", 100 }
                }
            },
            { "Miscellaneous", new Dictionary<string, int>
                {
                    { "Random Guy’s Boxers", 15 },
                    { "Block of Cheese", 5 }
                }
            }
        };

        static string YeserAndNoer()
        {
            string answer = Console.ReadLine();
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Invalid input! Please type 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            return answer;
        }

        static int NumberAnswerGetter(int MaxOptions)
        {
            int answer = 0;
            while (answer < 1 || answer > MaxOptions)
            {
                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please type a number between 1 and " + MaxOptions + ".");
                }
            }
            return answer;
        }



        // Fight function(generated with AI)
        static void Fight(Drinker player, List<Enemy> enemies)
        {
            Random rng = new Random();
            List<object> participants = new List<object> { player };
            participants.AddRange(enemies);

            while (player.HealthChecker() > 0 && enemies.Any(e => e.HealthChecker() > 0))
            {
                // Shuffle the participants for random attack order
                participants = participants.OrderBy(_ => rng.Next()).ToList();

                foreach (var participant in participants)
                {
                    if (participant is Drinker && player.HealthChecker() > 0)
                    {
                        Console.WriteLine("Player's turn! Enemies still alive:");
                        // Display the list of enemies with unique numbers
                        int index = 1;
                        foreach (var enemy in enemies.Where(e => e.HealthChecker() > 0))
                        {
                            Console.WriteLine($"{index}. {enemy.GetType().Name} (HP: {enemy.HealthChecker()})");
                            index++;
                        }

                        // Player chooses an enemy to attack
                        Console.WriteLine("Choose an enemy to attack by entering the corresponding number:");
                        int choice = NumberAnswerGetter(index - 1); // Helper method to get a valid number
                        var target = enemies.Where(e => e.HealthChecker() > 0).ElementAtOrDefault(choice - 1);

                        if (target != null)
                        {
                            Console.WriteLine($"Player attacks {target.GetType().Name}!");
                            player.Attack(target);
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice or no enemy selected.");
                        }
                    }
                    else if (participant is Enemy enemy && enemy.HealthChecker() > 0)
                    {
                        // Enemy attacks player
                        Console.WriteLine($"{enemy.GetType().Name} attacks!");
                        enemy.Attack(player);
                    }
                }

                // Display stats
                player.StatTyper();
                foreach (var enemy in enemies)
                {
                    enemy.StatTyper();
                }
            }

            // Check the outcome
            if (player.HealthChecker() <= 0)
            {
                Console.WriteLine("You died!");
            }
            else if (enemies.All(e => e.HealthChecker() <= 0))
            {
                Console.WriteLine("You defeated all the enemies! You get " + rng.Next(1,10000) + "coins");
            }
        }
        static int MainSquare(Drinker player)//Main square
        {
            
            Console.WriteLine("You find urself on an empty town square unsure where u want to go there are multiple options:\n1. U can try to go into a random street and see where that takes u");
            Console.WriteLine("2. U can go to the bar and get some booze");
            Console.WriteLine("3. U can go to the shop and buy some stuff");
            Console.WriteLine("4. U can go to the park and relax");
            Console.WriteLine("5. U can go to the alley and see what happens");
            Console.WriteLine("6. U can go to the church and pray for forgiveness");
            Console.WriteLine("7. U can go to the town hall and see what happens");
            Console.WriteLine("8. U can go to the library and read some books");
            Console.WriteLine("9. U can go to the brothel and have some fun");
            Console.WriteLine("10. U dig through ur inventory and see what u have");
            Console.WriteLine("What do you want to do?");
            return NumberAnswerGetter(9);
        }
        //1. option random street functions
        static void RandomStreet(Drinker player)//Random street
        {
            Random rng = new Random();
            int encounterType = rng.Next(1, 4); // Randomly choose between 1, 2, or 3

            Console.WriteLine("You walk into a random street and see a shady figure in the distance.\n");

            switch (encounterType)
            {
                case 1: // Merchant Encounter(AI generated) 
                    Console.WriteLine("You approach the figure and see that it's a merchant selling various items.\n");
                    Console.WriteLine("Do you want to buy something? (y/n)");
                    string answer = YeserAndNoer();
                    if (answer == "y")
                    {
                        Console.WriteLine("The merchant shows you his wares and you see the following items:\n");
                        Console.WriteLine("0. Nothing");

                        // Display items for sale
                        int index = 1;
                        foreach (var category in items)
                        {
                            Console.WriteLine($"Category: {category.Key}");
                            foreach (var item in category.Value)
                            {
                                Console.WriteLine($"{index}. {item.Key} - {item.Value} coins");
                                index++;
                            }
                        }

                        Console.WriteLine("What do you want to buy?");
                        int choice = NumberAnswerGetter(index - 1);
                        if (choice == 0)
                        {
                            Console.WriteLine("You decide not to buy anything and walk away.");
                        }
                        else
                        {
                            // Find and purchase the item
                            int currentIndex = 1;
                            foreach (var category in items)
                            {
                                foreach (var item in category.Value)
                                {
                                    if (currentIndex == choice)
                                    {
                                        if (player.Coins >= item.Value)
                                        {
                                            player.Coins -= item.Value;
                                            Console.WriteLine($"You purchased {item.Key}!");
                                            player.inventory.AddItem(item.Key,1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("You don't have enough coins!");
                                        }
                                        return;
                                    }
                                    currentIndex++;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You decide to leave the merchant and walk away.");
                    }
                    break;

                case 2: // Weirdly Shaped Tree
                    Console.WriteLine("As you get closer, you realize the shady figure is just a weirdly shaped tree.\n");
                    Console.WriteLine("You feel a bit silly and walk away.");
                    return; // End the interaction

                case 3: // Aggressive Homeless Guy
                    Console.WriteLine("As you approach, you realize the figure is an aggressive man who charges at you!");
                    List<Enemy> enemies = new List<Enemy>();
                    enemies = EnemyFactory.GetRandomEnemies(player.lvlChecker(),rng.Next(2,10));           
                    Fight(player, enemies);
                    break;

                default:
                    Console.WriteLine("You decide to ignore the figure and move along.");
                    break;
            }
        }

        //2. option Bar functions
        static void Bar(Drinker player) // In the bar
        {
            Console.WriteLine("You enter the bar and see a bartender behind the counter. He greets you and asks what you want to drink.\n");
            Console.WriteLine("What do you want to drink?");
            Console.WriteLine("0. Nothing");

            // Display available drinks and their costs
            int index = 1;
            foreach (var item in items["Consumables"])
            {
                Console.WriteLine($"{index}. {item.Key} - {item.Value} coins");
                index++;
            }

            // Get the player's choice
            int choice = NumberAnswerGetter(index - 1);

            if (choice == 0)
            {
                Console.WriteLine("You decide to not drink anything.");
                return;
            }

            if (choice > 0 && choice <= items["Consumables"].Count)
            {
                var selectedItem = items["Consumables"].ElementAt(choice - 1);//(yees this ity bitty part was git hub copilot again)
                int drinkCost = selectedItem.Value;

                if (player.Coins >= drinkCost)
                {
                    player.Coins -= drinkCost;
                    Console.WriteLine("You order a" +selectedItem.Key+". It costs"+ drinkCost+"coins. You now have"+ player.Coins+" coins left.");
                }
                else
                {
                    Console.WriteLine("You don't have enough coins for that drink.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
        static void BarEncounter(Drinker player)//bar entry encounter
        {
            Random rng = new Random();
            Console.WriteLine("u walked for raoughly" + rng.Next(1, 15) + "minutes and u find urself in front of a bar.\nGuarding the front dore there stands 2," + rng.Next(0, 98) + "meters tall giant bouncer\n\n");
            Console.WriteLine("Do u want to try to enter the bar? (y/n)");
            string answer =  YeserAndNoer();

            if (answer == "y")
            {
                BarBouncer bouncer = new BarBouncer(rng.Next(0, 5));
                Console.WriteLine("You walk up to the bouncer and attempt to enter");
                if (bouncer.KickOut(player))
                {
                    Console.WriteLine("You reek of booze you a***e, yells the bouncer and kicks you right out. Do you want to force yourself in? (y/n)");
                    answer = YeserAndNoer();
                    switch (answer)
                    {
                        case "y":
                            Fight(player, new List<Enemy> { bouncer });
                            if (player.HealthChecker() > 0)
                            {
                                Console.WriteLine("You defeated the bouncer and entered the bar.");
                                Bar(player);
                            }
                            else
                            {
                                Console.WriteLine("You died!");
                            }
                            break;
                        case "n":
                            Console.WriteLine("You decide to leave the bar and go back to the town square.");
                            break;
                    }
                }
                else
                {
                    Bar(player);
                }
            }
            else//u leave lol
            {
                Console.WriteLine("You decide to leave the bar and go back to the town square.");
            }


        }
        // option 3. shop functions (randomization generated by AI)
        static void Shop(Drinker player, Dictionary<string, Dictionary<string, int>> items)
        {
            Random rng = new Random();
            Console.WriteLine("Welcome to the shop! Here's what we have for sale:");

            // Create a randomized list of available items
            Dictionary<string, Dictionary<string, int>> availableItems = new Dictionary<string, Dictionary<string, int>>();
            foreach (var category in items)
            {
                // Add a random subset of items from each category
                Dictionary<string, int> randomizedCategory = new Dictionary<string, int>();
                foreach (var item in category.Value)
                {
                    int chance = rng.Next(1, 101); // Random chance between 1 and 100

                    // Define rarity logic
                    bool isRare = item.Key == "Car Keys" && chance <= 4; // 1 in 25 chance
                    bool isUncommon = chance <= 50; // 50% chance for most items
                    bool alwaysAvailable = chance <= 100; // 100% for common items

                    if (isRare || isUncommon || alwaysAvailable)
                    {
                        randomizedCategory[item.Key] = item.Value;
                    }
                }
                if (randomizedCategory.Count > 0)
                {
                    availableItems[category.Key] = randomizedCategory;
                }
            }

            // Display the randomized shop inventory
            int index = 1;
            foreach (var category in availableItems)
            {
                Console.WriteLine($"\nCategory: {category.Key}");
                foreach (var item in category.Value)
                {
                    Console.WriteLine($"{index}. {item.Key} - {item.Value} coins");
                    index++;
                }
            }

            Console.WriteLine("\nEnter the number of the item you'd like to buy or 0 to leave:");
            int choice = NumberAnswerGetter(index - 1);
            if (choice == 0)
            {
                Console.WriteLine("You decide to leave the shop without buying anything.");
                return;
            }

            // Find the selected item by index
            int currentIndex = 1;
            foreach (var category in availableItems)
            {
                foreach (var item in category.Value)
                {
                    if (currentIndex == choice)
                    {
                        if (player.Coins >= item.Value)
                        {
                            player.Coins -= item.Value;
                            Console.WriteLine($"You purchased {item.Key}!");
                            player.inventory.AddItem(item.Key,1);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough coins!");
                        }
                        return;
                    }
                    currentIndex++;
                }
            }

            Console.WriteLine("Invalid choice!");
        }

        // option 4. park functions
        static void Park(Drinker player)
        {
            Console.WriteLine("You sit on a park bench and strike up a conversation with an old man.");
            Console.WriteLine("Old Man: 'Ah, the tales I could tell from my youth... but these days, it's all about finding peace.'");
            Console.WriteLine("You feel a sense of calm wash over you.");
            player.refreshment(); 
        }
        // option 5. alley functions
        static void Alley(Drinker player)
        {
            Console.WriteLine("You walk into a dark alley and hear a strange noise.");
            Console.WriteLine("Do you want to investigate? (y/n)");
            string answer = YeserAndNoer();
            if (answer == "y")
            {
                Console.WriteLine("You walk further into the alley and see a cat stuck in a trash can.");
                Console.WriteLine("Do you want to help the cat? (y/n)");
                answer = YeserAndNoer();
                if (answer == "y")
                {
                    Console.WriteLine("You free the cat from the trash can and it runs away.");
                    Console.WriteLine("You feel a sense of accomplishment.");
                }
                else
                {
                    Console.WriteLine("You decide to leave the alley and go back to the town square.");
                }
            }
            else
            {
                Console.WriteLine("You decide to leave the alley and go back to the town square.");
            }
        }
        // option 6. church functions
        static void Church(Drinker player)
        {
            Console.WriteLine("You enter the church and see a priest standing at the altar.");
            Console.WriteLine("Priest: 'Welcome, my child. How can I help you today?'");
            Console.WriteLine("Do you want to pray for forgiveness? (y/n)");
            string answer = YeserAndNoer();
            if (answer == "y")
            {
                Console.WriteLine("You kneel down and pray for forgiveness for your sins.");
                Console.WriteLine("You feel a sense of peace and tranquility.");
                player.refreshment();
            }
            else
            {
                Console.WriteLine("You decide to leave the church and go back to the town square.");
            }
        }
        // option 7. town hall functions
        static void TownHall(Drinker player)
        {
            Random rng = new Random();
            Console.WriteLine("You enter the town hall and see a group of people gathered around a notice board.");
            Console.WriteLine("You walk up to the notice board and see various announcements and events posted.");
            Console.WriteLine("Do you want to read the announcements? (y/n)");
            string answer = YeserAndNoer();
            if (answer == "y")
            {
               
                switch (rng.Next(1, 3))
                {
                    case 1:
                        Console.WriteLine("You read through the announcements and see information about a local charity event.");
                        Console.WriteLine("You feel a sense of compassion and empathy.");
                        player.refreshment();
                        break;
                    case 2:
                        Console.WriteLine("You read through the announcements and see information about upcoming festival.You are so excited, that u jump all around and nearly break ur leg");
                        player.TakeDamage(rng.Next(10,15));
                        break;
                    default:
                        Console.WriteLine("You read through the announcements and see that there has been bounty playced on ur head");
                        Console.WriteLine("sudenly a bounty hunter apears out of the corner");
                        List<Enemy> enemies = new List<Enemy>
                        {
                            new BountyHunter(rng.Next(4,150))
                        };
                        Fight(player, enemies);
                        break;
                }
                Console.WriteLine("You read through the announcements and see information about upcoming festivals and gatherings.");
                Console.WriteLine("You feel a sense of community and belonging.");
                player.refreshment();
            }
            else
            {
                Console.WriteLine("You decide to leave the town hall and go back to the town square.");
            }
        }
        // option 8. library functions
        static void Library(Drinker player)
        {
            Console.WriteLine("You stumble into the library and attempt to read a book.");
            if (player.DrunkValueChecker() > 50)
            {
                Console.WriteLine("You're too drunk to make sense of the words. You give up and leave.");
            }
            else
            {
                Console.WriteLine("You manage to read a bit and feel smarter. You gain some experience!");
                player.Learning(10);
            }
        }
        // option 9. brothel functions
        static void Brothel(Drinker player)
        {
            Console.WriteLine("You enter the brothel. A hostess greets you with a warm smile and asks if you'd like to 'relax' for 20 coins.");
            Console.WriteLine("Do you accept? (y/n)");
            string answer = YeserAndNoer();
            if (answer == "y" && player.Coins >= 20)
            {
                player.Coins -= 20;
                Console.WriteLine("You enjoy a relaxing time and leave feeling rejuvenated. You gain experience!");
                player.Learning(20); // Example method to add XP
            }
            else if (answer == "y" && player.Coins < 20)
            {
                Console.WriteLine("You don't have enough coins. The hostess shakes her head and sends you away.");
            }
            else
            {
                Console.WriteLine("You leave the brothel.");
            }
        }
        // option 10. inventory functions
        static void Inventory(Drinker player)
        {
            Console.WriteLine("You check your inventory and see the following items:");
            player.inventory.InventoryTyper(); // Display the player's inventory
            Console.WriteLine("Do you want to use an item? (y/n)");
            string answer = YeserAndNoer();

            if (answer == "y")
            {
                Console.WriteLine("Enter the name of the item you want to use:");
                string itemName = Console.ReadLine();

                if (player.inventory.CheckItem(itemName))
                {
                    // Handle item usage based on name
                    switch (itemName)
                    {
                        // Drinks
                        case "Beer":
                        case "Vodka":
                        case "Whiskey":
                        case "Wine":
                        case "Rum":
                        case "Tequila":
                        case "Cider":
                        case "Mead":
                        case "Sake":
                        case "Absinthe":
                            player.Drink(itemName);
                            player.inventory.RemoveItem(itemName,1);
                            break;

                        // Powder
                        case "White Powder":
                            Console.WriteLine("You consumed White Powder... and feel strangely energized!");
                            player.Learning(50); // Example: Grants experience
                            player.TakeDamage(-10); // Example: Reduces health
                            player.inventory.RemoveItem(itemName, 1);
                            break;

                        // Tools and Objects
                        case "Empty Bottle":
                            Console.WriteLine("You throw the empty bottle away. It's of no use.");
                            player.inventory.RemoveItem(itemName, 1);
                            break;

                        case "Car Keys":
                            Console.WriteLine("You check the car keys, but you don't see a car nearby.");
                            break;

                        case "Magic Wand":
                            Console.WriteLine("You wave the magic wand. Nothing happens... or does it?");
                            break;

                        case "Phone":
                            Console.WriteLine("You try using your phone, but it has no signal.");
                            break;

                        // Miscellaneous
                        case "Random Guy’s Boxers":
                            Console.WriteLine("You look at the Random Guy’s Boxers. Weird, but oddly comforting.");
                            break;

                        case "Block of Cheese":
                            Console.WriteLine("You eat the block of cheese aaaaaand......\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n......... nothing happend........");
                            
                            player.inventory.RemoveItem(itemName, 1);
                            break;

                        default:
                            Console.WriteLine("This item cannot be used");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have that item in your inventory.");
                }
            }
            else
            {
                Console.WriteLine("You decide to keep your items and go back to the town square.");
            }
        }
        static void Main(string[] args)
        {
            Drinker player = new Drinker(100, 100, 5, 50);

            Console.WriteLine("lets start the gameeeee......\nFor exit close the console or die......\n\n\n");
            Console.WriteLine("You woke up witha hangover and a note from your neighbor saying that you were too loud last night.\nYou decide to go out and get some booze to forget about the note.\n\n\n");
            Console.WriteLine("You find urself on an empty town square unsure where u want to go there are multiple options:    1. U can try to go into a random street and see where that takes u");
            while(player.HealthChecker()>0)
            {
                int choice = MainSquare(player);
                switch (choice)
                {
                    case 1:
                        RandomStreet(player);
                        Console.ReadKey();
                        break;
                    case 2:
                        BarEncounter(player);
                        Console.ReadKey();

                        break;
                    case 3:
                        Shop(player, items);
                        Console.ReadKey();
                        break;
                    case 4:
                        Park(player);
                        Console.ReadKey();
                        break;
                    case 5:
                        Alley(player);
                        Console.ReadKey();
                        break;
                    case 6:
                        Church(player);
                        Console.ReadKey();
                        break;
                    case 7:
                        TownHall(player);
                        Console.ReadKey();
                        break;
                    case 8:
                        Library(player);
                        Console.ReadKey();
                        break;
                    case 9:
                        Brothel(player);
                        Console.ReadKey();
                        break;
                    case 10:
                        Inventory(player);
                        Console.ReadKey();
                        break;
                }
            }

            

            Console.ReadKey();
        }
    }
}
