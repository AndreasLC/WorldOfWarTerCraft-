/* World class for modeling the entire in-game world
 */



class World {
  private Space beach;
  private Context context; 
  public World (Context context) {
    this.context = context; 
    // Initializing all Items
    Item item1 = new Item("Bottle cap", "Ingested by marine life, leading to injuries and contributing to microplastics.", 1);
    Item item2 = new Item("Plastic bag", "Causes suffocation and digestive blockages in sea turtles and other creatures.", 2);
    Item item3 = new Item("Fishing gear", "Abandoned gear entangles marine animals, causing injury and death.", 3);
    Item item4 = new Item("Plastic straw", "Blockages and harm from ingestion by marine animals.", 4);
    Item item5 = new Item("Cigarettes", "Toxic chemicals leach into the water, harming marine life.", 5);
    Item item6 = new Item("Balloon", "Balloons and their strings cause ingestion and entanglement in marine creatures.", 6);
    Item item7 = new Item("Styrofoam box", "Breaks into small particles, causing ingestion and toxic exposure.", 7);
    Item item8 = new Item("Wrapper", "Contributes to microplastics and is ingested by marine animals.", 8);
    Item item9 = new Item("Cutlery", "Ingested by marine life, causing internal damage and environmental pollution.", 9);
    Item item10 = new Item("Gill net", "Entangles and kills marine life, continuing to harm even when abandoned.", 10);

    // Intializing a list that holds all Items
    List<Item> items = new List<Item> {
    item1, item2, item3, item4, item5, item6, item7, item8, item9, item10
    };   
    
    // Initalizing Questions ADD QUESTIONS ABOUT PLASTIC WASTE IN THE SEA!!
    Question question1 = new Question("How much plastic waste gets thrown in the ocean annually? The answers will all be in Megatons/Millions of tons unless stated otherwise." , ["14" , "12" , "10" , "8", "7"] , 2);
    Question question2 = new Question("How much does fishing gear pollute the oceans, primarily fishing nets?" , ["0.6", "0.7", "0.8", "0.9", "0.1"], 1);
    Question question3 = new Question("How much microplastic goes in the ocean each year?" , ["1.0", "1.4", "1.5", "1.7", "2.1"], 3);
    Question question4 = new Question("How much plastic goes in the ocean with water runoff?" , ["1.02-2.19", "1.15-2.41", "1.32-2.68", "2.12-2.52", "0.90-1.88"], 2);
    Question question5 = new Question("What river is the most polluted with plastic of them all?" , ["Yangtze", "Ganges", "Nile", "Amazon", "Gondor"], 1);
    Question question6 = new Question("What countrys pollutes the most plastic waste into the ocean? The order of the two countries does not matter." , ["China, USA", "China, India", "India, USA", "USA, Germany", "India, Germany"], 2);
    Question question7 = new Question("How much accumulated plastic waste is in our oceans?" , ["220", "230", "245", "260", "275"], 4);
    Question question8 = new Question("What is the square root of 64?" , ["6", "7", "8", "9", "10"], 3);
    Question question9 = new Question("How much microplastic waste are the result of secondary microplast? The answer is in tons." , ["68.500-275.000", "70.000-290.500", "72.400-280.600", "66.000-260.500", "65.500-260.000"], 1);
    Question question10 = new Question("Who painted the Mona Lisa?" , ["Van Gogh", "Picasso", "Da Vinci", "Michelangelo", "Rembrandt"], 3);

    // Initalizing Challenges with their given Reward Item. 
    Challenge challenge1 = new Challenge (context, question1 , item1);
    Challenge challenge2 = new Challenge(context,question2 , item2);
    Challenge challenge3 = new Challenge(context,question3 , item3);
    Challenge challenge4 = new Challenge(context,question4 , item4);
    Challenge challenge5 = new Challenge(context,question5 , item5);
    Challenge challenge6 = new Challenge(context,question6 , item6);
    Challenge challenge7 = new Challenge(context,question7 , item7);
    Challenge challenge8 = new Challenge(context,question8 , item8);
    Challenge challenge9 = new Challenge(context,question9 , item9);
    Challenge challenge10 = new Challenge(context,question10 , item10);


    //Adds instances of Rooms
    beach       = new Space("Dirty beach");
    Space mainBase    = new Space("Coralreef remains");
    Space room1       = new Space("Polluted Paradise" , challenge1);
    Space room2       = new Space("Plastic bottoms" , challenge2);
    Space room3       = new Space("Sandy loam" , challenge3);
    Space room4       = new Space("Rip current" , challenge4);
    Space room5       = new Space("Sargasso Sea of Waste" , challenge5);
    Space room6       = new Space("Sunken shipyard" , challenge6);
    Space room7       = new Space("Plastic trench" , challenge7);
    Space room8       = new Space("The Shimmering Trash Abyss" , challenge8);
    Space room9       = new Space("Hidden Plastic Parasite" , challenge9);
    Space roomFin     = new Space("Clean beach" , challenge10);

    //Adds instances of NPC
    NPC npc1          = new NPC("Ariel Angler"        , "Ahoy Skipper I’m Ariel Angler, but you can just call me Ariel. Now you might have noticed that these seas and waters have a whole lotta plastic in ‘em. Now would you believe that around 12 million tons get thrown in the ocean, each year? That’s like, a lot.");
    NPC npc2          = new NPC("Billy Blobfish"      , "So you’re the new turtle, huh? I’m Billy, now well listen up, and listen well. There are these things, fishing boats, they catch fish with their nets. Trouble is, they loose and drop these nets, making the ocean less clean. Now i’ve talked and looked around, and they pollute our ocean with 0.6 million tons of those nylon fishing nets each year, so stay safe, turtle.");
    NPC npc3          = new NPC("Casper Clam"         , "Greeting turtle my name is Casper, Casper Clam, I will keep this short. There is a lot of microplastics in the ocean, a whole 1.5 million tons find their way here each year. From what Ariel told me, that would be 12.5%, so be aware of the invisible killer plastic.");
    NPC npc4          = new NPC("Danny Dolphin"       , "Hey-hey turtle, Danny here. Now i’ve been swimming far and wide, and I’ve seen the plastic on land with my very own eyes. Here’s the kicker though, when it rains, or storms come in, can you guess where all that plastic ends up? That’s right, here with us, in the ocean. From what my Dolphin brothers have gathered, its anywhere from 1.15 to 2.41 million tons, each year from runoff.");
    NPC npc5          = new NPC("Egor Eel"            , "Ah, turtle, come for the knowledge i hold? Well let me tell you, my name is Egor, I was born in the Yangtze river. Let me tell you, it was the most polluted, plastic ridden river I have EVER seen. So I counted for a year, and about 300 thousand tons of plastic passes through that river and into the ocean. Each year of course.");
    NPC npc6          = new NPC("Ferb Flying fish"    , "Hi, I’m Ferb. I’ve been flying, as you might have guessed, and I have seen, a lot. The main polluters of our glorious and beautiful oceans are Asia first, then Africa second.  With China being the main polluter followed by India.");
    NPC npc7          = new NPC("Gahat Ganges shark"  , "I am the wise Gahat, i am a Ganges shark. Ariel has told you how much plastic we get each year, now I am here to tell you what we already have. The oceans have around 260 millions tons of plastic. Now go turtle, and come back ever so slightly more wise.");
    NPC npc8          = new NPC("Harold Herring"      , "Turtle, i am Harold. I have worked with my kin, and we have quite precisely worked out that 67% of pollution in the sea, comes from Asia. So brave turtle, if you value your life, do not go near the seas of Asia.");
    NPC npc9          = new NPC("Ian Icefish"         , "Hark Turtle, I am Ian, friend of Casper Clam. For my friend, I searched far and wide for the source of the microplastics. I have come to the conclusion that it is a breakdown of textiles, rubber and wear from other plastics. It is also made when they make other plastics. These are called secondary microplastics, and it accounts for 68.500-275.000 tons of plastic.");
    NPC npcFin        = new NPC("John Dory"           , "Turtle, I am John Dory. If you want the next generation of turtles to go through less hardships, and trash, you must rally your turtle kin and clean the beach. Be warned, your turtle brethren will require proof of leadership, in the form of knowledge.");

  // World map
    beach.AddEdge("sea", mainBase);

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
    room9.AddEdge("beach", roomFin, item9);

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

  public Space GetBeach() {
    return beach;
  }

  public static implicit operator World(string v) {
    throw new NotImplementedException();
  }
}
