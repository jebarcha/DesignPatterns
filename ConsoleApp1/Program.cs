﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteBehavioralDemos();

            //ExecuteStructuralDemos();

            //ExecuteCreationalDemos();

            End();
        }
        static void End() 
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }
        static void ExecuteBehavioralDemos() 
        {
            // Behavioral ***********************************************
            //Behavioral.Behavioral_Strategy();

            //Behavioral.Behavioral_State();
            //Behavioral.Behavioral_StateDemo2();

            //Behavioral.Behavioral_Observer();
            //Behavioral.Behavioral_ObserverDemo2();

            //Behavioral.Behavioral_Visitor();
            //Behavioral.Behavioral_VisitorDemo2();

            //Behavioral.Behavioral_Memento();
            //Behavioral.Behavioral_MementoDemo2();

            //Behavioral.Behavioral_TemplateMethod();
            //Behavioral.Behavioral_TemplateMethodDemo2();

            //Behavioral.Behavioral_ChainOfResposibility();
            //Behavioral.Behavioral_ChainOfResponibilityDemo2();

            //Behavioral.Behavioral_Iterator();
            //Behavioral.Behavioral_IteratorDemo2();

            //Behavioral.Behavioral_Command();
            //Behavioral.Behavioral_CommandComposite();
            //Behavioral.Behavioral_CommandUndo();
            //Behavioral.Behavioral_CommandDemo2();

            Behavioral.Behavioral_Mediator();
        }
        static void ExecuteStructuralDemos() 
        {
            // Structural ***********************************************
            //Structural.Structural_Facade();
            //Structural.Structural_FacadeDemo2();

            //Structural.Structural_Decorator();
            //Structural.Structural_DecoratorDemo2();

            //Structural.Structural_Adapter();
            //Structural.Structural_AdapterDemo2();

            //Structural.Structural_Composite();
            //Structural.Structural_CompositeDemo2();

            //Structural.Structural_Proxy();
            //Structural.Structural_ProxyDemo2();

            //Structural.Structural_Bridge();

            //Structural.Structural_FlyWeight();
            Structural.Structural_FlyWeightDemo2();


        }
        static void ExecuteCreationalDemos() 
        { 
        
        }
    }
}
