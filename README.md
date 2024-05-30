Welcome to my C# Learning Repository! This repository contains various projects, exercises, and code snippets that I am working on as I learn C# programming.

## Table of Contents
-Exercise - Complete a challenge activity using conditional operators
-Exercise  - Fizzbuzz Challenge

## Introduction

I am an aspiring developer learning C# to enhance my programming skills. This repository serves as a place to document my journey and showcase the projects and exercises I complete along the way. Feedback and contributions are welcome!

## Projects
-Allprojeects will be beginner friendly.

## Exercises
-https://github.com/salehjoseph/mycsharpjjourney24/commit/4569304bc79525f6c95d8bffddf4c229dccd8afe
https://github.com/salehjoseph/mycsharpjjourney24/blob/main/Program.cs

## Code Snippets
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
