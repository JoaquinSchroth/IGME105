using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace TierList_Testing
{
    internal class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "C:\\Users\\jokol\\OneDrive\\Desktop\\testeandowebadas\\input.txt"; // Change this to your input file path
        string outputDirectory = "C:\\Users\\jokol\\OneDrive\\Desktop\\testeandowebadas\\Tags"; // Change this to your output directory

        if (!Directory.Exists(outputDirectory))
            Directory.CreateDirectory(outputDirectory);

        try
        {
            string[] names = File.ReadAllLines(inputFilePath);

            int imageSize = 200; // Size of the square image (pixels)

            foreach (string name in names)
            {
                string outputPath = Path.Combine(outputDirectory, $"{name}.png");

                if (name.Contains('1') ||
                    name.Contains('2') ||
                    name.Contains('3') ||
                    name.Contains('4') ||
                    name.Contains('5') ||
                    name.Contains('6') ||
                    name.Contains('7') ||
                    name.Contains('8') ||
                    name.Contains('9') ||
                    name.Contains('0')
                    ) continue;

                using (Bitmap bitmap = new Bitmap(imageSize, imageSize))
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Fill the background with a light color
                    graphics.Clear(ColorTranslator.FromHtml("#0F0F0F"));

                    // Draw the name in the center of the image
                    using (Font font = new Font("Arial", 28))
                    using (Brush brush = new SolidBrush(ColorTranslator.FromHtml("#ED3664")))
                    {
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        RectangleF rect = new RectangleF(0, 0, imageSize, imageSize);
                        graphics.DrawString(name, font, brush, rect, stringFormat);
                    }

                    bitmap.Save(outputPath, ImageFormat.Png);
                }
            }

            Console.WriteLine("Images created successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}
}