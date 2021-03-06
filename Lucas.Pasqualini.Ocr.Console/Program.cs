// See https://aka.ms/new-console-template for more information

using Lucas.Pasqualini.Ocr;

var imagesPath = args;
var images = new List<byte[]>();

foreach (var imagePath in imagesPath)
{
    var imageBytes = await File.ReadAllBytesAsync(imagePath);
    images.Add(imageBytes);
}

var ocrResults = await new Ocr().ReadAsync(images);

foreach (var ocrResult in ocrResults)
{
    Console.WriteLine($"Confidence :{ocrResult.Confidence}");
    Console.WriteLine($"Text :{ocrResult.Text}");
}