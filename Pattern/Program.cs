// Путь к изображению
string pathImage = @"C:\Users\User\Pictures\Picture.png";

// Все стратегии которые реализуют контракт с интерфейсом самой стратегии
IImageProcessingStrategy compressingStrategy = new ImageCompressingStrategy();
IImageProcessingStrategy resizingStrategy = new ImageResizingStrategy();
IImageProcessingStrategy filterStrategy = new ImageFilterStrategy();

/* 
 * Каждый процессор занимается своей ответственностью, в данном случае три процессора, один может выполнять задачу по стратегии сжатия изображения
 * второй по стратегии изменения размера, другой по стратегии фильтрации 
 */

ImageProcessor imageCompressingProcessor = new ImageProcessor(compressingStrategy);
ImageProcessor imageResizingProcessor = new ImageProcessor(resizingStrategy);
ImageProcessor imageFilterProcessor = new ImageProcessor(filterStrategy);

/*
 * Сама фишка в том, что по желанию можем 
 */
imageCompressingProcessor.ProcessImage(pathImage);

imageResizingProcessor.ProcessImage(pathImage);

imageFilterProcessor.ProcessImage(pathImage);
