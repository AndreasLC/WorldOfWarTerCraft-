/* World class for modeling the entire in-game world */
class World {
  private Space river;
  private Context context; 
  public World (Context context) {
    this.context = context; 
    // Initializing all Items
    Item item1  = new Item("Bottle cap"    , "Ingested by marine life, leading to injuries and contributing to microplastics.", 1);
    Item item2  = new Item("Plastic bag"   , "Causes suffocation and digestive blockages in sea turtles and other creatures.", 2);
    Item item3  = new Item("Fishing gear"  , "Abandoned gear entangles marine animals, causing injury and death.", 3);
    Item item4  = new Item("Plastic straw" , "Blockages and harm from ingestion by marine animals.", 4);
    Item item5  = new Item("Cigarette butt", "Toxic chemicals leach into the water, harming marine life.", 5);
    Item item6  = new Item("Balloon"       , "Balloons and their strings cause ingestion and entanglement in marine creatures.", 6);
    Item item7  = new Item("Styrofoam box" , "Breaks into small particles, causing ingestion and toxic exposure.", 7);
    Item item8  = new Item("Wrapper"       , "Contributes to microplastics and is ingested by marine animals.", 8);
    Item item9  = new Item("Cutlery"       , "Ingested by marine life, causing internal damage and environmental pollution.", 9);
    Item item10 = new Item("Gill net"      , "Entangles and kills marine life, continuing to harm even when abandoned.", 10);

    // Intializing a list that holds all Items
    List<Item> items = new List<Item> {
    item1, item2, item3, item4, item5, item6, item7, item8, item9, item10
    };   
    
    // Initalizing Questions
    Question question1 = new Question("How much waste is thrown into the ocean each year? Remember what Ariel told ye!" , 
    ["12 million tons", 
    "260 million tons", 
    "460 million tons", 
    "3 million tons"], 1);

    Question question2 = new Question("How big is the Great Pacific Garbage Patch? (In million square kilometers)" , 
    ["1.01 (Around the size of Egypt)", 
    "1.2", 
    "1.6 (Roughly 3 times the size of Spain)", 
    "1.9 (About the size of Indonesia)"], 3);
    
    Question question3 = new Question("How deep does the microplastics pollute in the ocean?" , 
    ["50 m (Only at the surface level)", 
    "About 150 m", 
    "About 250 m",
    "Over 350 m (Deeper than any human have ever dived)"], 4);
    
    Question question4 = new Question("What is the percentage of microplastics in the ocean out of the total amount of plastic?", 
    ["12%", 
    "33%", 
    "67%", 
    "73%"], 1);

    Question question5 = new Question("What is the most harmful way of fishing in the sea?" , 
    ["Dynamite fishing (Use of explosives to stun fish)", 
    "Drift netting (Huge nets causing widespread bycatch)", 
    "Cyanide fishing (Cyanide stuns fish and poisons the marine environment)", 
    "Bottom trawling (Dragging large nets across the ocean floor)"], 4);
    
    Question question6 = new Question("Which marine creatures die annually due to entanglements?", 
    ["Fish only", 
    "Whales, dolphins, sea lions, seals, sea turtles and many other fish species", 
    "Crabs and lobsters only", 
    "None"], 2);
    
    Question question7 = new Question("What four categories of plastic emission sources did Harold tell you about?", 
    ["Managed coastal waste, managed inland waste, lost fishing gear, macroplastics", 
    "Unmanaged coastal waste, unmanaged inland waste, lost fishing nets, microplastics", 
    "Recycled plastic, organic waste, paper waste, metal waste", 
    "Ocean currents, wind, natural disasters, human activities"], 2);

    Question question8 = new Question("What is the primary polluting continent in the world?" , 
    ["Asia", 
    "Europe", 
    "North America", 
    "Africa"], 1);
    
    Question question9 = new Question("What proportion of the total plastic pollution from rivers to the oceans comes from Asia?", 
    ["12%", 
    "33%", 
    "67%", 
    "73%"], 3);
    
    Question question10 = new Question("Which river is the largest polluter of plastic into the oceans 330.000 annually(2017)?", 
    ["Amazon River", 
    "Nile River", 
    "Yangtze River", 
    "Ganges River"], 3);



    // Initalizing Challenges with their given Reward Item. 
    Challenge challenge1  = new Challenge(context, question1 , item1);
    Challenge challenge2  = new Challenge(context,question2 , item2);
    Challenge challenge3  = new Challenge(context,question3 , item3);
    Challenge challenge4  = new Challenge(context,question4 , item4);
    Challenge challenge5  = new Challenge(context,question5 , item5);
    Challenge challenge6  = new Challenge(context,question6 , item6);
    Challenge challenge7  = new Challenge(context,question7 , item7);
    Challenge challenge8  = new Challenge(context,question8 , item8);
    Challenge challenge9  = new Challenge(context,question9 , item9);
    Challenge challenge10 = new Challenge(context,question10 , item10);


    //Adds instances of Rooms
    river                 = new Space("Yangtze River");
    Space mainBase        = new Space("Coralreef remains");
    Space room1           = new Space("Polluted Paradise" , challenge1);
    Space room2           = new Space("Plastic bottoms" , challenge2);
    Space room3           = new Space("Sandy loam" , challenge3);
    Space room4           = new Space("Rip current" , challenge4);
    Space room5           = new Space("Sargasso Sea of Waste" , challenge5);
    Space room6           = new Space("Sunken shipyard" , challenge6);
    Space room7           = new Space("Plastic trench" , challenge7);
    Space room8           = new Space("The Shimmering Trash Abyss" , challenge8);
    Space room9           = new Space("Hidden Plastic Parasite" , challenge9);
    Space roomFin         = new Space("Cleaned Yangtze River" , challenge10);

    //Adds instances of NPC
    NPC npc1              = new NPC("Ariel Angler"    , "Ahoy, matey! I'm Ariel Angler, but you can just call me Ariel. Have ye noticed these waters are overrun with plastic junk? Shiver me fins, can ye believe it’s a whopping 12 million tons dumped into the ocean each year? We need to chart a new course and protect our oceans!");
    NPC npc2              = new NPC("Billy Blobfish"  , "Hey-hey, turtle, Billy here. Now, I’ve been swimming far and wide, and I’ve seen the plastic on land with my very own eyes. Here’s the kicker though—when it rains, or storms roll in, can you guess where all that plastic ends up? That’s right, right here with us, in the ocean. From what my dolphin brothers have gathered, it's about 1.6 million square kilometers, that's the size of Spain three times!");
    NPC npc3              = new NPC("Casper Clam"     , "Greetings, turtle. My name is Casper, Casper Clam. You know those little bits of plastic we can’t even see? Yeah, I'm talking about microplastics. Studies show that these tiny plastic particles are now found in the deepest parts of the ocean, even the Mariana Trench—far deeper than any human has ever dived, over 350 meters!");
    NPC npc4              = new NPC("Danny Dolphin"   , "Ah, turtle, come for the knowledge I, Danny, hold? Would you believe that a whopping 12% of plastic waste in the ocean is made up of microplastics? This means that when humans eat our fishy friends, they're also consuming tiny bits of plastic waste!");
    NPC npc5              = new NPC("Egor Eel"        , "So, you’re the new turtle, huh? I’m Egor, listen up! Bottom trawling is the most harmful way of fishing out here. These fishing boats drag massive nets across the ocean floor, destroying everything in their path, from coral reefs to seagrass beds, and trapping anything that gets in the way. It’s the most destructive method of fishing, and if we don’t stop it, our home could be lost forever.");
    NPC npc6              = new NPC("Ferb Flyfish"   , "Hi, I’m Ferb, or so the others call me. I’ve been flying, as you might have guessed, and I have seen a lot. On my trips, I’ve seen whales, dolphins, sea lions, sea turtles, and many other marine friends dead and entangled by plastic at the bottom of the sea. There’s still hope for the future, save the ocean!");
    NPC npc7              = new NPC("Gahat Grayling"  , "I am the wise Gahat, I am a grayling. Ariel has told you how much plastic we get each year, now I am here to tell you what we already have. The ocean has many polluters, but the four main categories are unmanaged coastal waste, unmanaged inland waste, lost fishing nets, and microplastics. Go inspire, turtle!");
    NPC npc8              = new NPC("Harold Herring"  , "Turtle, I am Harold, I will keep it short and simple. The main polluters of our glorious and beautiful ocean are Asia first, then Africa second. Hope it helps ya.");
    NPC npc9              = new NPC("Ian Icefish"     , "Hark, turtle, I am Ian, friend of Casper Clam. I have worked with my kin, and we have quite precisely worked out that 67% of pollution in the sea comes from Asia. So, brave turtle if you value your life, do not swim nearby.");
    NPC npcFin            = new NPC("John Dory"       , "You are now near the end of your journey, let me tell you, my name is John. I was born in the Yangtze River. Let me tell you, it was the most polluting river back in 2017, because of that, I had to leave my family behind. So, I counted for a year, and about 330 thousand tons of plastic pass through that river and into the ocean each year. Go back, clean up the river, and make me proud! ");

  // World map
    river.AddEdge("sea", mainBase);

    //Mainbase
    mainBase.AddEdge("home", mainBase);
    mainBase.AddEdge("right", room1);
    mainBase.AddEdge("left", room2, item1);
    mainBase.AddEdge("deeper", room4, item3);


  // Every challenge besides the first one, needs an item to access.
    room1.AddEdge("home", mainBase);

    room2.AddEdge("home", mainBase);
    room2.AddEdge("back", mainBase);
    room2.AddEdge("deeper", room3, item2);

    room3.AddEdge("home", mainBase);
    room3.AddEdge("back", room2);
    
    room4.AddEdge("home", mainBase);
    room4.AddEdge("back", mainBase);
    room4.AddEdge("riptide", room7, item6);
    room4.AddEdge("deeper", room5, item4);

    room5.AddEdge("home", mainBase);
    room5.AddEdge("back", room4);
    room5.AddEdge("shipyard", room6, item5);
    room5.AddEdge("caves", room9, item8);

    room6.AddEdge("home", mainBase);
    room6.AddEdge("back", room5);
    room6.AddEdge("abyss", room8, item7);

    room7.AddEdge("home", mainBase);
    room7.AddEdge("back", room4);
    
    room8.AddEdge("home", mainBase);
    room8.AddEdge("back", room6);

    room9.AddEdge("home", mainBase);
    room9.AddEdge("back", room5);
    room9.AddEdge("river", roomFin, item9);

    // NPCs in spaces
    mainBase.AddNPC(npc1);
    mainBase.AddNPC(npc2); 
    mainBase.AddNPC(npc3); 
    mainBase.AddNPC(npc4); 
    mainBase.AddNPC(npc5); 
    mainBase.AddNPC(npc6); 
    mainBase.AddNPC(npc7); 
    mainBase.AddNPC(npc8); 
    mainBase.AddNPC(npc9); 
    mainBase.AddNPC(npcFin);
  }

  public Space GetRiver() {
    return river;
  }

  public static implicit operator World(string v) {
    throw new NotImplementedException();
  }
}