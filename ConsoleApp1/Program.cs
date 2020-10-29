using Strategy;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Behavioral ***********************************************
            // Strategy
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

            Console.ReadLine();

            // Structural ***********************************************
            //


            // Creational ***********************************************
            //
        }
    }
}
