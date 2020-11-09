using Adapter;
using Adapter.Demo2;
using Composite;
using Composite.Demo2;
using Decorator;
using Decorator.Demo2;
using Facade;
using Facade.Demo2;
using Proxy;
using Proxy.Demo2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Structural
    {
        static void Structural_Adapter()
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());

            // our apply method expects a IFilter object, but CaramelFilter does not implement it,
            // we need an adapter to make it work
            //imageView.apply(new CaramelFilter());
            imageView.Apply(new CaramelFilter(new Caramel()));

        }
        static void Structural_AdapterDemo2()
        {
            var emailClient = new EmailClient();
            //emailClient.addProvider(new GmailClient());
            emailClient.AddProvider(new GmailAdapter());
            emailClient.DownloadEmails();

        }
        static void Structural_Composite()
        {
            var group1 = new Group();
            group1.Add(new Shape()); // our imaginary square
            group1.Add(new Shape());

            var group2 = new Group();
            group2.Add(new Shape()); // our imaginary circle
            group2.Add(new Shape());

            // combine those 2 groups in to a new group
            var group = new Group();
            group.Add(group1);  // add a group inside a group
            group.Add(group2);
            group.Render();
            group.Move();


        }
        static void Structural_CompositeDemo2()
        {
            var subTeam1 = new Team();
            subTeam1.Add(new Truck());
            subTeam1.Add(new HumanResource());
            subTeam1.Add(new HumanResource());

            var subTeam2 = new Team();
            subTeam2.Add(new Truck());
            subTeam2.Add(new HumanResource());
            subTeam2.Add(new HumanResource());

            var team = new Team();
            team.Add(subTeam1);
            team.Add(subTeam2);

            team.Deploy();
        }
        static void Structural_Proxy()
        {
            // in this implementation we are loadin 3 ebooks in memory and open 1
            // the problem would be if we have hundreds or thousends of ebooks, we should not load all them in memory because it is costly
            // We can use the Proxy pattern to solve this problem. We should load the ebook on demand only when we need it.

            var library = new Library();
            String[] fileNames = { "a", "b", "c" };

            foreach (var fileName in fileNames)
            {
                library.Add(new LoggingEbookProxy(fileName));
                //library.add(new EbookProxy(fileName));
                //library.add(new RealEBook(fileName));
            }

            library.OpenEbook("a");
            library.OpenEbook("b");

        }
        static void Structural_ProxyDemo2()
        {
            //var dbContext = new DbContext();

            //// We read an object (eg a product) from a database.
            //var product = dbContext.getProduct(1);

            //// We modify the properties of the object in memory.
            //product.setName("Updated Name");

            //// DbContext should keep track of changed objects in memory.
            //// When we call saveChanges(), it'll automatically generate
            //// the right SQL statements to update our database.
            //dbContext.saveChanges();

            //// After saving the changes to the database, we can
            //// change our in-memory object again and save the changes.
            //product.setName("Another name");
            //dbContext.saveChanges();


            var dbContext = new DbContext();
            var product = dbContext.GetProduct(1);
            product.SetName("Updated Name");
            dbContext.SaveChanges();

            product.SetName("Another name");
            dbContext.SaveChanges();

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
            var tweets = twitterAPI.GetRecentTweets();
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
            stream.Write("1234-1234-1234-1234");
        }
        static void Structural_DecoratorDemo2()
        {
            var editor = new Editor();
            editor.openProject("...");
        }
        
    }
}
