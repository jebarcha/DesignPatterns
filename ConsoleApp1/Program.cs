using Observer;
using Observer.ObserverDemo2;
using State;
using Strategy;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Behavioral ***********************************************
            //Behavioral_Strategy();

            //Behavioral_State();
            //Behavioral_StateDemo2();

            //Behavioral_Observer();
            Behavioral_ObserverDemo2();

            // Structural ***********************************************
            //


            // Creational ***********************************************
            //


            End();
        }
        static void End() 
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }

        #region Behavioral
        static void Behavioral_Strategy()
        {
            var imageStorageJpeg = new ImageStorage();
            imageStorageJpeg.store("aDemo", new JpegCompressor(), new BlackAndWhiteFilter());

            var imageStoragePng = new ImageStorage();
            imageStoragePng.store("bDemo", new PngCompressor(), new HighContrastFilter());

            Console.WriteLine("");
            Console.WriteLine("Strategy Demo 2");
            // StrategyDemo2
            var chatClient = new ChatClient(new AESEncryption());
            chatClient.send("my demo message 1 AES");

            chatClient = new ChatClient(new DESEncryption());
            chatClient.send("my demo message 2 DES");
        }
        static void Behavioral_State()
        {
            // 1.  one by one
            //Console.WriteLine("Selection Tool------------------");
            //var canvas = new Canvas();
            //canvas.setCurrentTool(new SelectionTool());
            //canvas.mouseDown();
            //canvas.mouseUp();

            //Console.WriteLine("");
            //Console.WriteLine("Brush Tool----------------------");
            //canvas.setCurrentTool(new BrushTool());
            //canvas.mouseDown();
            //canvas.mouseUp();

            //***************************************************************************
            // If We want to support a new tool, all We need to do is to add a new class
            // that implements the ITool interface.
            //***************************************************************************

            //Console.WriteLine("");
            //Console.WriteLine("Erase Tool----------------------");
            //canvas.setCurrentTool(new EraserTool());
            //canvas.mouseDown();
            //canvas.mouseUp();


            // 2. with a list of tools
            var myTools = new List<ITool>() { new SelectionTool(), new BrushTool(), new EraserTool() };
            var canvas = new Canvas();
            foreach (var tool in myTools) 
            {
                canvas.setCurrentTool(tool);
                canvas.mouseDown();
                canvas.mouseUp();
                Console.WriteLine("");
            }

        }
        static void Behavioral_StateDemo2() 
        {
            //This was with the problem approach:
            //var directionService = new DirectionService();
            //directionService.setTravelMode(TravelMode.BICYCLING);
            //directionService.getEta();
            //directionService.getDirection();

            // using the state pattern:
            var service = new DirectionService(new Walking());
            service.getEta();
            service.getDirection();
            Console.WriteLine(service.getTravelMode());

        }

        static void Behavioral_Observer() 
        {
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet(dataSource);
            var sheet2 = new SpreadSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.addObserver(sheet1);
            dataSource.addObserver(sheet2);
            dataSource.addObserver(chart);

            dataSource.setValue(1);

        }
        static void Behavioral_ObserverDemo2() 
        {
            var statusBar = new StatusBar();
            var stockListView = new StockListView();

            var stock1 = new Stock("stock1", 10);
            var stock2 = new Stock("stock2", 20);
            var stock3 = new Stock("stock3", 30);

            // The status bar shows the popular stocks
            statusBar.addStock(stock1);
            statusBar.addStock(stock2);

            // The stock view list shows all stocks
            stockListView.addStock(stock1);
            stockListView.addStock(stock2);
            stockListView.addStock(stock3);

            // Causes both statusBar and stockListView to get refreshed
            stock2.setPrice(21);

            // Causes only the stockListView to get refreshed. (statusBar
            // is not watching this stock.)
            stock3.setPrice(9);
        }
        static void Behavioral_Visitor()
        {

        }
        static void Behavioral_Memento()
        {

        }
        static void Behavioral_Iterator()
        {

        }
        static void Behavioral_TemplateMethod()
        {

        }
        static void Behavioral_Command()
        {

        }
        static void Behavioral_Mediator()
        {

        }
        static void Behavioral_ChainOfResposibility()
        {

        }
        static void Behavioral_Interpreter()
        {

        }

        #endregion


        #region Creational
        static void Creational_Singleton()
        {

        }
        static void Creational_Factory()
        {

        }
        static void Creational_AbstractFactory()
        {

        }
        static void Creational_Builder()
        {

        }
        static void Creational_Prototype()
        {

        }
        #endregion


        #region Structural
        static void Structural_Adapter()
        {

        }
        static void Structural_Composite()
        {

        }
        static void Structural_Proxy()
        {

        }
        static void Structural_FlyWeight()
        {

        }
        static void Structural_Facade()
        {

        }
        static void Structural_Bridge()
        {

        }
        static void Structural_Decorator()
        {

        }
        #endregion

    }
}
