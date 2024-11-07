public class Item
{
    // Atributes 
    private int itemID;
    private int effect;
    // Constructor
public Item (int itemID , int effect)
{
   this.itemID = itemID;
   this.effect = effect; 
}

    public string? itemName;
    public string? itemDescription;

    public static string? FirstCharToUpper(string str)
{
    if (str == null) 
        return null;

    if (str.Length > 1)
        return char.ToUpper(str[0]) + str[1..];

    return str.ToUpper();
}
// methods 
public string GetName() 
    {
switch (itemID)
    { 
    case 1:
        itemName = "Plastic bag";
        break;
    case 2:
        itemName = "Straw";
        break;        
    case 3:
        itemName = "Bottle cap";
        break;
    case 4:
        itemName = "Tire debris";
        break;
    case 5:
        itemName = "Plastic cup";
        break;
    case 6:
        itemName = "Styrofoam box";
        break;
    case 7:
        itemName = "Broken glasses";
        break;
    case 8:
        itemName = "Fishing net";
        break;
    case 9:
        itemName = "Plastic cutlery";
        break;
    }
    return itemName; 
    }


public int GetEffect() 
    {
    return effect; 
    }

public string GetDescription() 
{
    switch (itemID)
    { 
        case 1:
            itemDescription = "'A plasticwrapper of some sort, looks yummy.'";
            break;
        case 2:
            itemDescription = "2";
            break;        
        case 3:
            itemDescription = "3";
            break;
        case 4:
            itemDescription = "4";
            break;
        case 5:
            itemDescription = "5";
            break;
        case 6:
            itemDescription = "6";
            break;
        case 7:
            itemDescription = "7";
            break;
        case 8:
            itemDescription = "'My friend was tragically mudered by this'";
            break;
        case 9:
            itemDescription = "'That could kill someone'";
            break;
    }
    return itemDescription; 
}

public int GetID()
{
    return itemID;
}

    public override string ToString() 
    {
    return $"{FirstCharToUpper(GetName())} \t {GetEffect()} \t\t {GetDescription()}";
    }

    
}
