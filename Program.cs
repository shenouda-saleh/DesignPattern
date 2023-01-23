using ITIDesignPattern.AbstractFactory;
using ITIDesignPattern.AbstractFactory.Classes;
using ITIDesignPattern.Builder;
using ITIDesignPattern.FactoryMethod;
using ITIDesignPattern.SingleTon;

#region Creational Design Patter

#region singleton
Console.WriteLine("************************************SingleTon Design Pattern*******************************************");

var networkCard = NetworkCard.Create();
Console.WriteLine(networkCard.name);
networkCard.name += "Tone";
var networkCard1 = NetworkCard.Create();
Console.WriteLine(networkCard1.name); 
#endregion

#region Factory Method Design Pattern
Console.WriteLine("\n\n************************************Factory Method Design Pattern*******************************************");

ITransport transportRoad = new RoadLogistic().CreateTransport();
if (transportRoad != null)
    transportRoad.deliver();

ITransport transportSea = new SeaLogistic().CreateTransport();
if (transportSea != null)
    transportSea.deliver();

#endregion

#region Abstact Factory Design pattern
Console.WriteLine("\n\n************************************Abstact Factory Design Pattern*******************************************");

var ModernFactory = new ModernFactory();
ModernFactory.CreateSofa();
ModernFactory.CreateChair();

#endregion

#region Builder Design Pattern
Console.WriteLine("\n\n************************************Builder Design Pattern*******************************************");

ModernBuilder builder = new ModernBuilder();
builder.AddGarden();
builder.AddPool();

House house = builder.Build();

#endregion

#endregion


#region Structural Design Pattern

#region MyRegion



#endregion

#endregion
//00:48:13
