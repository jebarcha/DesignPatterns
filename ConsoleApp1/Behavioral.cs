using Memento;
using Memento.Demo2;
using Observer;
using Observer.ObserverDemo2;
using State;
using Strategy;
using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod;
using TemplateMethod.Demo2;
using Visitor;
using Visitor.Demo2;

namespace ConsoleApp1
{
    static class Behavioral
    {
        public static void Behavioral_Strategy()
        {
            var imageStorageJpeg = new ImageStorage();
            imageStorageJpeg.Store("aDemo", new JpegCompressor(), new BlackAndWhiteFilter());

            var imageStoragePng = new ImageStorage();
            imageStoragePng.Store("bDemo", new PngCompressor(), new HighContrastFilter());

            Console.WriteLine("");
            Console.WriteLine("Strategy Demo 2");
            // StrategyDemo2
            var chatClient = new ChatClient(new AESEncryption());
            chatClient.Send("my demo message 1 AES");

            chatClient = new ChatClient(new DESEncryption());
            chatClient.Send("my demo message 2 DES");
        }
        public static void Behavioral_State()
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
                canvas.SetCurrentTool(tool);
                canvas.MouseDown();
                canvas.MouseUp();
                Console.WriteLine("");
            }

        }
        public static void Behavioral_StateDemo2()
        {
            //This was with the problem approach:
            //var directionService = new DirectionService();
            //directionService.setTravelMode(TravelMode.BICYCLING);
            //directionService.getEta();
            //directionService.getDirection();

            // using the state pattern:
            var service = new DirectionService(new Walking());
            service.GetEta();
            service.GetDirection();
            Console.WriteLine(service.GetTravelMode());

        }

        public static void Behavioral_Observer()
        {
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet(dataSource);
            var sheet2 = new SpreadSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.SetValue(1);

        }
        public static void Behavioral_ObserverDemo2()
        {
            var statusBar = new StatusBar();
            var stockListView = new StockListView();

            var stock1 = new Stock("stock1", 10);
            var stock2 = new Stock("stock2", 20);
            var stock3 = new Stock("stock3", 30);

            // The status bar shows the popular stocks
            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);

            // The stock view list shows all stocks
            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);
            stockListView.AddStock(stock3);

            // Causes both statusBar and stockListView to get refreshed
            stock2.SetPrice(21);

            // Causes only the stockListView to get refreshed. (statusBar
            // is not watching this stock.)
            stock3.SetPrice(9);
        }
        public static void Behavioral_Visitor()
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Execute(new HighlightOperation()); // Highlight operation

            document.Execute(new PlainTextOperation()); // Plain text Operation

            // If we need to add a new operation just create a new class that implements IOperation interface
        }
        public static void Behavioral_VisitorDemo2()
        {
            var wavFile = WavFile.Read("myfile.wav");
            wavFile.ApplyFilter(new NoiseReductionFilter());
            wavFile.ApplyFilter(new ReverbFilter());
            wavFile.ApplyFilter(new NormalizeFilter());
        }

        public static void Behavioral_Memento()
        {
            var editor = new EditorM();
            var history = new History();

            editor.SetContent("A");
            history.Push(editor.CreateState());

            editor.SetContent("B");
            history.Push(editor.CreateState());

            editor.SetContent("C");
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.GetContent());

        }
        public static void Behavioral_MementoDemo2()
        {
            var doc = new Document();
            var history = new DocHistory();

            doc.SetContent("Hello World");
            history.Push(doc.CreateMemento());

            doc.SetFontName("font N1");
            history.Push(doc.CreateMemento());

            doc.SetFontSize(12);

            Console.WriteLine(doc.ToString());

            doc.Restore(history.Pop());
            Console.WriteLine(doc.ToString());

            doc.Restore(history.Pop());
            Console.WriteLine(doc.ToString());

            history.Push(doc.CreateMemento());  // CreateMemento before any change, so you can revert using Restore method
            doc.SetFontName("font N2");
            Console.WriteLine(doc.ToString());

            doc.Restore(history.Pop());
            Console.WriteLine(doc.ToString());


        }
        public static void Behavioral_Iterator()
        {

        }
        public static void Behavioral_TemplateMethod()
        {
            // Transfer Money
            // Generate Report
            var task = new TransferMoneyTask();
            task.Execute();

            var report = new GenerateReportTask();
            report.Execute();

        }
        public static void Behavioral_TemplateMethodDemo2()
        {
            var chatWindow = new ChatWindow();

            chatWindow.close();

        }
        public static void Behavioral_Command()
        {

        }
        public static void Behavioral_Mediator()
        {

        }
        public static void Behavioral_ChainOfResposibility()
        {

        }
        public static void Behavioral_Interpreter()
        {

        }
    }
}
