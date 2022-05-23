// See https://aka.ms/new-console-template for more information
using ObserverPattern;

Worker mehmet = new Worker("mehmet");
Worker derya = new Worker("derya");
Worker sema = new Worker("sema");
Worker aleyna = new Worker("aleyna");
// İzlenecek olan sınıf örneği.
Vestel vestel = new Vestel();
// İzlenecek olan sınıfa etkilenecek olan nesnelerin atanması.
vestel.AddObserver(mehmet);
vestel.AddObserver(derya);
vestel.AddObserver(sema);
vestel.AddObserver(aleyna);
vestel.increaseAllSalariesBy();