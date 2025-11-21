using OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "No Name";
        Welcome = "Welcome {0} to your OOP Adventure!";
        DefaultRoomName = "Room {0} ({1},{2})"; //({1},{2}) = x and Y
        DefaultRoomDescription = "You are in a {0} room with doors to the {1}"; // {0} = roomDescription {1} = cardinal directions (N,E,S,W)
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go that way";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}. ";
        RoomOld = "You returned to {0}. ";
        And = "and";
        Comma = ",";
        Space = " ";
        RoomDescriptions = new List<string>
        {
            
            "normal",
            "cold",
            "warm",
            "dark",
            "scary",
            "strange"
        };
        NoItem = "You don't have {0}";
        Backpack = "Backpack";
        BackpackError = "You don't have anything in ur backpack.";
        BackpackDescription = "Your backpack contains: {0}";
        Chest = "chest";
        UnlockChest = "You unlocked the chest. ";
        Key = "key";
        ChestEmpty = "The chest is empty. ";
        ChestFound = "You found: {0}";
    }
}