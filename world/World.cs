/* World class for modeling the entire in-game world
 */

class World {
  Space beach ;
  
  private Challenge challenge;
  private Context context;
  public World () {
    //Adds instances of Rooms
    beach       = new Space("Dirty beach");
    Space mainBase    = new Space("Coralreef remains");
    Space room1       = new Space("Polluted Paradise");
    Space room2       = new Space("Plastic bottoms");
    Space room3       = new Space("Sandy loam");
    Space room4       = new Space("Rip current");
    Space room5       = new Space("Sargasso Sea of Waste");
    Space room6       = new Space("Sunken shipyard");
    Space room7       = new Space("Plastic trench");
    Space room8       = new Space("The Shimmering Trash Abyss");
    Space room9       = new Space("Hidden Plastic Parasite");
    Space roomFin     = new Space("Clean beach");

    //Adds instances of NPC
    NPC npc1          = new NPC("Ariel Angler"        , "Ahoy Skipper I’m Ariel Angler, but you can just call me Ariel. Now you might have noticed that these seas and waters have a whole lotta plastic in ‘em. Now would you believe that around 12 million tons get thrown in the ocean, each year? That’s like, a lot.");
    NPC npc2          = new NPC("Billy Blobfish"      , "So you’re the new turtle, huh? I’m Billy, now well listen up, and listen well. There are these things, fishing boats, they catch fish with their nets. Trouble is, they loose and drop these nets, making the ocean less clean. Now i’ve talked and looked around, and they pollute our ocean with 0.6 million tons of those nylon fishing nets each year, so stay safe, turtle.");
    NPC npc3          = new NPC("Casper Clam"         , "Greeting turtle my name is Casper, Casper Clam, I will keep this short. There is a lot of microplastics in the ocean, a whole 1.5 million tons find their way here each year. From what Ariel told me, that would be 12.5%, so be aware of the invisible killer plastic.");
    NPC npc4          = new NPC("Danny Dolphin"       , "Hey-hey turtle, Danny here. Now i’ve been swimming far and wide, and I’ve seen the plastic on land with my very own eyes. Here’s the kicker though, when it rains, or storms come in, can you guess where all that plastic ends up? That’s right, here with us, in the ocean. From what my Dolphin brothers have gathered, its anywhere from 1.15 to 2.41 million tons, each year.");
    NPC npc5          = new NPC("Egor Eel"            , "Ah, turtle, come for the knowledge i hold? Well let me tell you, my name is Egor, I was born in the Yangtze river. Let me tell you, it was the most polluted, plastic ridden river I have EVER seen. So I counted for a year, and about 300 thousand tons of plastic passes through that river and into the ocean. Each year of course.");
    NPC npc6          = new NPC("Ferb Flying fish"    , "Hi, I’m Ferb, or so the others call me. I’ve been flying, as you might have guessed, and I have seen, a lot. The main polluters of our glorious and beautiful ocean are Asia first, then Africa second. Hope it helps ya.");
    NPC npc7          = new NPC("Gahat Ganges shark"  , "I am the wise Gahat, i am a Ganges shark. Ariel has told you how much plastic we get each year, now I am here to tell you what we already have. The oceans have around 260 millions tons of plastic. Now go turtle, and come back ever so slightly more wise.");
    NPC npc8          = new NPC("Harold Herring"      , "Turtle, i am Harold. I have worked with my kin, and we have quite precisely worked out that 67% of pollution in the sea, comes from Asia. So brave turtle, if you value your life, do not go near the seas of Asia.");
    NPC npc9          = new NPC("Ian Icefish"         , "Hark Turtle, I am Ian, friend of Casper Clam. For my friend, I searched far and wide for the source of the microplastics. I have come to the conclusion that it is a breakdown of textiles, rubber and wear from other plastics. It is also made when they make other plastics. Go inspire, brave little turtle.");
    NPC npcFin        = new NPC("John Dory"           , "Turtle, I am John Dory. If you want the next generation of turtles to go through less hardships, and trash, you must rally your turtle kin and clean the beach. Be warned, your turtle brethren will require proof of leadership, in the form of knowledge.");

    context = new Context(beach);

    // Adds all challenges
    Challenge ch1     = new Challenge(context);
    ch1.AddQuestion(new Question("This is a quiz1" , ["Forkert" , "Rigtigt" , "Forkert" , "Forkert", "Forkert"] , 2));

    Challenge ch2     = new Challenge(context);
    ch2.AddQuestion(new Question("This is a quiz2" , ["Forkert" , "Forkert" , "Forkert" , "Rigtigt", "Forkert"] , 4));

    Challenge ch3     = new Challenge(context);
    ch3.AddQuestion(new Question("This is a quiz3" , ["Forkert" , "Rigtigt" , "Forkert" , "Forkert", "Forkert"] , 2));

    Challenge ch4     = new Challenge(context);
    ch4.AddQuestion(new Question("This is a quiz4" , ["Forkert" , "Forkert" , "Forkert" , "Forkert", "Rigtigt"] , 5));

    Challenge ch5     = new Challenge(context);
    ch5.AddQuestion(new Question("This is a quiz5" , ["Forkert" , "Forkert" , "Rigtigt" , "Forkert", "Forkert"] , 3));

    Challenge ch6     = new Challenge(context);
    ch6.AddQuestion(new Question("This is a quiz6" , ["Rigtigt" , "Forkert" , "Forkert" , "Forkert", "Forkert"] , 1));

    Challenge ch7     = new Challenge(context);
    ch7.AddQuestion(new Question("This is a quiz7" , ["Forkert" , "Forkert" , "Forkert" , "Forkert", "Rigtigt"] , 5));

    Challenge ch8     = new Challenge(context);
    ch8.AddQuestion(new Question("This is a quiz8" , ["Rigtigt" , "Forkert" , "Forkert" , "Forkert", "Forkert"] , 1));

    Challenge ch9     = new Challenge(context);
    ch9.AddQuestion(new Question("This is a quiz9" , ["Forkert" , "Rigtigt" , "Forkert" , "Forkert", "Forkert"] , 2));

    Challenge chFin   = new Challenge(context);
    chFin.AddQuestion(new Question("This is a quiz10" , ["Forkert" , "Forkert" , "Forkert" , "Rigtigt", "Forkert"] , 4));

  // World map
    beach.AddEdge("sea", mainBase);

    //Mainbase
    mainBase.AddEdge("home", mainBase);
    mainBase.AddEdge("right", room1);
    mainBase.AddEdge("left", room2);
    mainBase.AddEdge("deeper", room4);


  // Every challenge besides the first one, needs an item to access.
    room1.AddEdge("home", mainBase);

    room2.AddEdge("home", mainBase);
    room2.AddEdge("deeper", room3);

    room3.AddEdge("back", room2);
    room3.AddEdge("home", mainBase);
    
    room4.AddEdge("home", mainBase);
    room4.AddEdge("riptide", room7);
    room4.AddEdge("deeper", room5);

    room5.AddEdge("home", mainBase);
    room5.AddEdge("back", room4);
    room5.AddEdge("shipyard", room6);
    room5.AddEdge("caves", room9);

    room6.AddEdge("home", mainBase);
    room6.AddEdge("back", room5);
    room6.AddEdge("abyss", room8);

    room7.AddEdge("home", mainBase);
    room7.AddEdge("back", room4);
    
    room8.AddEdge("home", mainBase);
    room8.AddEdge("back", room6);

    room9.AddEdge("home", mainBase);
    room9.AddEdge("back", room5);
    room9.AddEdge("beach", roomFin);

    roomFin.AddEdge("home", mainBase);
    roomFin.AddEdge("back", room9);

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

    // Challenges in world
    room1.AddChallenge(ch1);
    room2.AddChallenge(ch2);
    room3.AddChallenge(ch3);
    room4.AddChallenge(ch4);
    room5.AddChallenge(ch5);
    room6.AddChallenge(ch6);
    room7.AddChallenge(ch7);
    room8.AddChallenge(ch8);
    room9.AddChallenge(ch9);
    roomFin.AddChallenge(chFin);
    }

  public Space GetBeach() {
    return beach;
  }
}
