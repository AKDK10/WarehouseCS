using WarehouseWorkshop;

var tomato = new Item("Tomato", 1.5m);
var onion = new Item("Onion", 1);
var mango = new Item("Mango", 2.35m);

var tomatoStock = new Stock(tomato, 10);
var onionStock = new Stock(onion, 5);
var mangoStock = new Stock(mango, 2);


Console.WriteLine(mangoStock.Item.Name);
