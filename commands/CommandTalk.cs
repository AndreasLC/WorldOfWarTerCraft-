using System.Transactions;

class CommandTalk : BaseCommand, ICommand
{
    public CommandTalk()
    {
        description = "Talk to an NPC in the current room";
    }
    
    public void Execute(Context context, string command, string[] parameters) {
    string npcName = string.Join(" ", parameters); // Joins the word into one string 
    // Gets current space 
    Space currentSpace = context.GetCurrent();

    NPC? npcToTalkTo = null;
    foreach (var npc in currentSpace.GetNPCs()) { // Runs every NPC in current space. 
            if (npc.GetNameNPC().ToLower() == npcName.ToLower()) { // If NPCName/input from user matches NPC in current Space NPCToTalk = npc.
                npcToTalkTo = npc;
                break;
            }
        }
// If there is an NPC with that given Name Provoke its Talk Method. 
    if (npcToTalkTo !=null) {
        npcToTalkTo.Talk();
    } else {
        Console.WriteLine($"There is no one named {npcName} in this room.");
    }
    Console.WriteLine();
    currentSpace.DisplayExits();
    }
}