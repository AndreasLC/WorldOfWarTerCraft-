/* World class for modeling the entire in-game world
 */

class World {
  Space beach ;
  
  public World () {
    Space beach        = new Space("Dirty beach");
    Space mainBase     = new Space("Coralreef remains");
    Space challenge1   = new Space("Polluted Paradise");
    Space challenge2   = new Space("Plastic bottoms");
    Space challenge3   = new Space("Sandy loam");
    Space challenge4   = new Space("Rip current");
    Space challenge5   = new Space("Sargasso Sea of Waste");
    Space challenge6   = new Space("Sunken shipyard");
    Space challenge7   = new Space("Plastic trench");
    Space challenge8   = new Space("The Shimmering Trash Abyss");
    Space challenge9   = new Space("Hidden Plastic Parasite");
    Space challengeFin = new Space("Clean beach");

    Space npc1         = new Space("Ariel Angler -\nAhoy Skipper I’m Ariel Angler, but you can just call me Ariel. Now you might have noticed that these seas and waters have a whole lotta plastic in ‘em. Now would you believe that around 12 million tons get thrown in the ocean, each year? That’s like, a lot.");
    Space npc2         = new Space("Billy Blobfish -\nSo you’re the new turtle, huh? I’m Billy, now well listen up, and listen well. There are these things, fishing boats, they catch fish with their nets. Trouble is, they loose and drop these nets, making the ocean less clean. Now i’ve talked and looked around, and they pollute our ocean with 0.6 million tons of those nylon fishing nets each year, so stay safe, turtle.");
    Space npc3         = new Space("Casper Clam -\nGreeting turtle my name is Casper, Casper Clam, I will keep this short. There is a lot of microplastics in the ocean, a whole 1.5 million tons find their way here each year. From what Ariel told me, that would be 12.5%, so be aware of the invisible killer plastic.");
    Space npc4         = new Space("Danny Dolphin -\nHey-hey turtle, Danny here. Now i’ve been swimming far and wide, and I’ve seen the plastic on land with my very own eyes. Here’s the kicker though, when it rains, or storms come in, can you guess where all that plastic ends up? That’s right, here with us, in the ocean. From what my Dolphin brothers have gathered, its anywhere from 1.15 to 2.41 million tons, each year.");
    Space npc5         = new Space("Egor Eel -\nAh, turtle, come for the knowledge i hold? Well let me tell you, my name is Egor, I was born in the Yangtze river. Let me tell you, it was the most polluted, plastic ridden river I have EVER seen. So I counted for a year, and about 300 thousand tons of plastic passes through that river and into the ocean. Each year of course.");
    Space npc6         = new Space("Ferb Flying fish -\nHi, I’m Ferb, or so the others call me. I’ve been flying, as you might have guessed, and I have seen, a lot. The main polluters of our glorious and beautiful ocean are Asia first, then Africa second. Hope it helps ya.");
    Space npc7         = new Space("Gahat Ganges shark -\nI am the wise Gahat, i am a Ganges shark. Ariel has told you how much plastic we get each year, now I am here to tell you what we already have. The oceans have around 260 millions tons of plastic. Now go turtle, and come back ever so slightly more wise.");
    Space npc8         = new Space("Harold Herring -\nTurtle, i am Harold. I have worked with my kin, and we have quite precisely worked out that 67% of pollution in the sea, comes from Asia. So brave turtle, if you value your life, do not go near the seas of Asia.");
    Space npc9         = new Space("Ian Icefish -\nHark Turtle, I am Ian, friend of Casper Clam. For my friend, I searched far and wide for the source of the microplastics. I have come to the conclusion that it is a breakdown of textiles, rubber and wear from other plastics. It is also made when they make other plastics. Go inspire, brave little turtle.");
    Space npcFin       = new Space("John Dory -\nTurtle, I am John Dory. If you want the next generation of turtles to go through less hardships, and trash, you must rally your turtle kin and clean the beach. Be warned, your turtle brethren will require proof of leadership, in the form of knowledge.");

    Space item1        = new Space("Plastic wrapper");
    Space item2        = new Space("Plastic wrapper");
    Space item3        = new Space("Plastic wrapper");
    Space item4        = new Space("Plastic wrapper");
    Space item5        = new Space("Plastic wrapper");
    Space item6        = new Space("Plastic wrapper");
    Space item7        = new Space("Plastic wrapper");
    Space item8        = new Space("Plastic wrapper");
    Space item9        = new Space("Plastic wrapper");

    //world map
    beach.AddEdge("sea", mainBase);
    mainBase.AddEdge("home", mainBase);
    mainBase.AddEdge("right", challenge1);
    mainBase.AddEdge("left", challenge2);
    mainBase.AddEdge("deeper", challenge4);

    //every challange besides the first one, needs an item to access.
    challenge1.AddEdge("home", mainBase);

    challenge2.AddEdge("home", mainBase);
    challenge2.AddEdge("deeper", challenge3);

    challenge3.AddEdge("back", challenge2);
    challenge3.AddEdge("home", mainBase);
    
    challenge4.AddEdge("deeper", challenge5);
    challenge4.AddEdge("riptide", challenge7);
    challenge4.AddEdge("home", mainBase);

    challenge5.AddEdge("shipyard", challenge6);
    challenge5.AddEdge("home", mainBase);
    challenge5.AddEdge("back", challenge4);
    challenge5.AddEdge("caves", challenge9);

    challenge6.AddEdge("abyss", challenge8);
    challenge6.AddEdge("home", mainBase);
    challenge6.AddEdge("back", challenge5);

    challenge7.AddEdge("back", challenge4);
    challenge7.AddEdge("home", mainBase);
    
    challenge8.AddEdge("home", mainBase);
    challenge8.AddEdge("back", challenge6);

    challenge9.AddEdge("home", mainBase);
    challenge9.AddEdge("back", challenge5);
    challenge9.AddEdge("beach", challengeFin);

    challengeFin.AddEdge("back", challenge9);
    challengeFin.AddEdge("home", mainBase);

    
    //npcs in mainBase
    mainBase.AddEdge("ariel", npc1);
    mainBase.AddEdge("billy", npc2); 
    mainBase.AddEdge("casper", npc3); 
    mainBase.AddEdge("danny", npc4); 
    mainBase.AddEdge("egor", npc5); 
    mainBase.AddEdge("ferb", npc6); 
    mainBase.AddEdge("gahat", npc7); 
    mainBase.AddEdge("harold", npc8); 
    mainBase.AddEdge("ian", npc9); 
    mainBase.AddEdge("john", npcFin);

        npc1.AddEdge("back", mainBase);
        npc2.AddEdge("back", mainBase);
        npc3.AddEdge("back", mainBase);
        npc4.AddEdge("back", mainBase);
        npc5.AddEdge("back", mainBase);
        npc6.AddEdge("back", mainBase);
        npc7.AddEdge("back", mainBase);
        npc8.AddEdge("back", mainBase);
        npc9.AddEdge("back", mainBase);
        npcFin.AddEdge("back", mainBase);

        this.beach = beach;

  //Items in world
  challenge1.AddEdge("trash", item1);
    item1.AddEdge("back", challenge1);
    item1.AddEdge("home", mainBase);

  challenge2.AddEdge("trash", item2);
    item2.AddEdge("back", challenge2);
    item2.AddEdge("home", mainBase);

  challenge3.AddEdge("trash", item3);
    item3.AddEdge("back", challenge3);
    item3.AddEdge("home", mainBase);

  challenge4.AddEdge("trash", item4);
    item4.AddEdge("back", challenge4);
    item4.AddEdge("home", mainBase);

  challenge5.AddEdge("trash", item5);
    item5.AddEdge("back", challenge5);
    item5.AddEdge("home", mainBase);

  challenge6.AddEdge("trash", item6);
    item6.AddEdge("back", challenge6);
    item6.AddEdge("home", mainBase);

  challenge7.AddEdge("trash", item7);
    item7.AddEdge("back", challenge7);
    item7.AddEdge("home", mainBase);

  challenge8.AddEdge("trash", item8);
    item8.AddEdge("back", challenge8);
    item8.AddEdge("home", mainBase);

  challenge9.AddEdge("trash", item9);
    item9.AddEdge("back", challenge9);
    item9.AddEdge("home", mainBase);
  }
  
  public Space GetBeach() {
    return beach;
  }
}
