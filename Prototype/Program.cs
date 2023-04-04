// See https://aka.ms/new-console-template for more information
using static System.Console;
using Prototype.Prototype;

var soldier = new Soldier("Ak47", "CT-Terrorist");
var soldier2 = (Soldier)soldier.Clone();
var soldier3 = (Soldier)soldier.Clone();

soldier.Gun = new Gun("knife");
soldier2.Gun = new Gun("Mk45");

WriteLine($"Soldier 1: {soldier.ToString()}");
WriteLine($"Soldier 2: {soldier2.ToString()}");
WriteLine($"Soldier 3: {soldier3.ToString()}");

ReadLine();