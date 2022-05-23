// See https://aka.ms/new-console-template for more information
using FactoryPattern;

CarFactory carFactory = new CarFactory();
ISell notify = carFactory.createSell("Bitcoin");
notify.Sell();
