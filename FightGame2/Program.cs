using System;

Fighter player = new Fighter();
player.name = "Sith";
player.weapon = new Weapon();
player.weapon.name = "Red lightsaber";

Fighter ai = new Fighter();
ai.name = "Jedi";
ai.weapon = new Weapon();
ai.weapon.name = "Blue lightsaber";

Random generator = new Random();

Console.WriteLine($"You are a {player.name}, you are tasked with defeating a {ai.name}");
Console.WriteLine("Press enter to continue");
Console.ReadLine();
Console.WriteLine($"You have equiped a {player.weapon.name},the {ai.name} has equiped a {ai.weapon.name}.");
Console.WriteLine("Press enter to begin the battle!");
Console.ReadLine();
Console.WriteLine("\n-----  THE FIGHT BEGINS  -----");

while (player.hp > 0 && ai.hp > 0)
{
  Console.WriteLine("\n----- ===== NEXT ATTACK ===== -----");
  Console.WriteLine($"{player.name}: {player.hp} -- {ai.name}: {ai.hp}\n");

player.Attack(ai);
ai.Attack(player);

  Console.WriteLine("Press any button to continue.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== THE FIGHT IS OVER ===== -----");

if (player.hp == 0 && ai.hp == 0)
{
  Console.WriteLine("ITS A DRAW");
}
else if (player.hp == 0)
{
  Console.WriteLine($"{ai.name} HAS WON!");
}
else
{
  Console.WriteLine($"{player.name} HAS WON!");
}

Console.WriteLine("Press any key to quit.");
Console.ReadKey();