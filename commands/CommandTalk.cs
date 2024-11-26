using System.Transactions;

class CommandTalk : BaseCommand, ICommand
{
    public CommandTalk()
    {
        description = "Talk to an NPC in the current room";
    }
    
    public void Execute(Context context, string command, string[] args) {
    string npcName = string.Join(" ", args); // Joins the word into one string 
    context.GetCurrent().TalkToNPC(npcName);
    }
}