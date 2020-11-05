using Observer;
using Observer.ObserverDemo2;
using State;
using Strategy;
using System;
using Visitor;
using Visitor.Demo2;
using System.Collections.Generic;
using Facade;
using Facade.Demo2;
using Decorator;
using Decorator.Demo2;
using Adapter;
using Adapter.Demo2;
using Composite;
using Composite.Demo2;

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
            //Behavioral_ObserverDemo2();

            //Behavioral_Visitor();
            //Behavioral_VisitorDemo2();

            // Structural ***********************************************
            //Structural_Facade();
            //Structural_FacadeDemo2();

            //Structural_Decorator();
            //Structural_DecoratorDemo2();

            //Structural_Adapter();
            //Structural_AdapterDemo2();

            //Structural_Composite();
            Structural_CompositeDemo2();


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
            var document = new HtmlDocument();
            document.add(new HeadingNode());
            document.add(new AnchorNode());
            
            document.execute(new HighlightOperation()); // Highlight operation

            document.execute(new PlainTextOperation()); // Plain text Operation

            // If we need to add a new operation just create a new class that implements IOperation interface
        }
        static void Behavioral_VisitorDemo2()
        {
            var wavFile = WavFile.read("myfile.wav");
            wavFile.applyFilter(new NoiseReductionFilter());
            wavFile.applyFilter(new ReverbFilter());
            wavFile.applyFilter(new NormalizeFilter());
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
            var imageView = new ImageView(new Image());
            imageView.apply(new VividFilter());

            // our apply method expects a IFilter object, but CaramelFilter does not implement it,
            // we need an adapter to make it work
            //imageView.apply(new CaramelFilter());
            imageView.apply(new CaramelFilter(new Caramel()));

        }
        static void Structural_AdapterDemo2() 
        {
            var emailClient = new EmailClient();
            //emailClient.addProvider(new GmailClient());
            emailClient.addProvider(new GmailAdapter());
            emailClient.downloadEmails();
        
        }
        static void Structural_Composite()
        {
            var group1 = new Group();
            group1.add(new Shape()); // our imaginary square
            group1.add(new Shape());

            var group2 = new Group();
            group2.add(new Shape()); // our imaginary circle
            group2.add(new Shape());

            // combine those 2 groups in to a new group
            var group = new Group();
            group.add(group1);  // add a group inside a group
            group.add(group2);
            group.render();
            group.move();


        }
        static void Structural_CompositeDemo2() 
        {
            var subTeam1 = new Team();
            subTeam1.add(new Truck());
            subTeam1.add(new HumanResource());
            subTeam1.add(new HumanResource());

            var subTeam2 = new Team();
            subTeam2.add(new Truck());
            subTeam2.add(new HumanResource());
            subTeam2.add(new HumanResource());

            var team = new Team();
            team.add(subTeam1);
            team.add(subTeam2);

            team.deploy();
        }
        static void Structural_Proxy()
        {

        }
        static void Structural_FlyWeight()
        {

        }
        static void Structural_Facade()
        {
            // for the facade patter we introduce a new class to encapsulate all below logic:
            //var server = new NotificationServer1();
            //var connection = server.connect("ip");
            //var authToken = server.authenticate("appID", "key");
            //var message = new Message("Hello World");
            //server.send(authToken, message, "target");
            //connection.disconnect();

            var service = new NotificationService();
            service.send("Hello World", "target");
        }
        static void Structural_FacadeDemo2() 
        {
            //var oauth = new OAuth();
            //var requestToken = oauth.requestToken("appKey", "secret");
            //var accessToken = oauth.getAccessToken(requestToken);

            //var twitterClient = new TwitterClient();
            //var tweets = twitterClient.getRecentTweets(accessToken);

            var twitterAPI = new TwitterAPI("appKey", "secret");
            var tweets = twitterAPI.getRecentTweets();
        }
        static void Structural_Bridge()
        {

        }
        static void Structural_Decorator()
        {
            //var cloudStream = new CloudStream();
            //cloudStream.write("Hello World!");

            // Normal without decorators:
            //storeCreditCard(new CloudStream());

            // EncryptedCloudStream decorator
            //storeCreditCard(new Compress(new EncriptedCloudStream(new CloudStream())));

            // Compress decorator:
            //storeCreditCard(new Compress(new CloudStream()));

            // with 2 decorators: We are adding behavior to an object dynamically
            storeCreditCard(new EncryptedCloudStream(new Compress(new CloudStream())));

        }
        static void storeCreditCard(IStream stream) 
        {
            // stream is transparent or invisible to storeCreditCard method, only needs a stream
            stream.write("1234-1234-1234-1234");
        }
        static void Structural_DecoratorDemo2() 
        {
            var editor = new Editor();
            editor.openProject("...");
        }
        #endregion

    }
}
