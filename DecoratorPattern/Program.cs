// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

ICarFunction car = new Car("Mustang");
ICarFunction carWithNewFeatures = new RepairCarDecorator(car);
carWithNewFeatures.speedUp();
carWithNewFeatures.getGas(40);
