public class ImageProcessor
{
    private readonly IImageProcessingStrategy processingStrategy;

    public ImageProcessor(IImageProcessingStrategy processingStrategy)
    {
        this.processingStrategy = processingStrategy;
    }

    public void ProcessImage(string path)
    {
        var image = LoadImage(path);
        Console.WriteLine("Изображение в обработке..");
        processingStrategy.ProcessImage(image);
        Console.WriteLine("Обработка изображения завершена! ");
    }

    private byte[] LoadImage(string imagePath)
    {
        // Действие происходит
        Console.WriteLine($"Загружаем изображение из файла: {imagePath}");
        // Возвращаем фиктивные байты (выдуманные байты, тестовые)
        return new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05 };
    }
}

public class ImageCompressingStrategy : IImageProcessingStrategy
{
    public void ProcessImage(byte[] imageBytes)
    {
        // Логика сжатия изображения
        Console.WriteLine("Сжатия изображения успешно завершено! ");
    }
}

public class ImageFilterStrategy : IImageProcessingStrategy
{
    public void ProcessImage(byte[] imageBytes)
    {
        // Логика применения фильтров к изображении.
        Console.WriteLine("Добавление фильтров к изображению успешно завершено!");
    }
}

public class ImageResizingStrategy : IImageProcessingStrategy
{
    public void ProcessImage(byte[] imageBytes)
    {
        // Логика изменения размера изображения
        Console.WriteLine("Изменения размера изображения завершено! ");
    }
}