// See https://aka.ms/new-console-template for more information
using ChainOfResponsibiltyPattern;

Home home = new Home("Evim", true, true, true);

DinnerHandler dinnerHandler = new DinnerHandler();
WashHandler washHandler = new WashHandler();
GardenHandler gardenHandler = new GardenHandler();

// Zincirlerin birbirleri ile bağlantısının yapıldığı yerdir.
// JPEG bu işlemi gerçekleştiremezse JPG'e aktarır o da Custom'a aktarır.

dinnerHandler.SetNextHandler(washHandler);
washHandler.SetNextHandler(gardenHandler);

dinnerHandler.HandleRequest(home);