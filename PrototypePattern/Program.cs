// See https://aka.ms/new-console-template for more information
using PrototypePattern.Entities;

Plane plane = new Plane("HürKuş", "Boeing-477", "Boeing");
Plane clonePlane = plane.Clone();

Console.WriteLine(plane == clonePlane); //output: false
