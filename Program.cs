using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("a"=="a ");// This will return false surprisingly the space counts for the case of C#
//Next we have the equality check that lets' users input values suchas Y or y as input and are accepted

string value1= " a";
string value2= "A ";

//output 
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

string text = "The lazy fox jumps over the duck";

Console.WriteLine(text.Contains("fox"));// This returns True for the case of string variables 

int a = 5; 
int b =6;

Console.WriteLine(a!=b);// this reuturn true 

int saleAmount = 1001;
int discount = (saleAmount > 1000 )? 100 : 50;
Console.WriteLine($"Discount: {discount}");
int purchaseValue =1000;

//Discount 
int discount2 = purchaseValue >1000 ? 100 : 50 ;

//output 
Console.WriteLine($"Discount 2: {discount2}");

//Exercise - Complete a challenge activity using conditional operators
// Conditional operator challenge
// In this challenge, you'll implement a conditional operator to simulate a "coin flip". 
// The resulting decision logic will display either heads or tails.

Random coin = new Random();

int flip = coin.Next(0,2);
//result from my conditional statm'nt
string result = (flip == 0 )? "heads":"Tails";
Console.WriteLine($"Result: {result}");

//Alright lets go logical with C#
string permission = "Admin|Manager";
int level = 60;
//permision.Contains('Admin');
 if (level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else if (level <= 55 && level >= 20)
        {
            Console.WriteLine("Welcome, Admin user.");
        }
        else if (level < 20)
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }

        // Check permissions if level is less than 55
        if (!permission.Contains("Admin") && !permission.Contains("Manager"))
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    

