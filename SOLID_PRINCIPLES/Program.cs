using SOLID_PRINCIPLES.DIP;
using SOLID_PRINCIPLES.ISP;
using SOLID_PRINCIPLES.Model;
using SOLID_PRINCIPLES.SRP;

JsonMenuLoader menuLoader = new JsonMenuLoader();
CsvMenuLoader csvMenuLoader = new CsvMenuLoader();
VendingMachine vendingMachine = new VendingMachine(menuLoader);
HighPerformanceVendingMachine highPerformanceVendingMachine = new HighPerformanceVendingMachine(menuLoader);

FriendlyVendingMachine friendlyVendingMachine = new FriendlyVendingMachine(csvMenuLoader);

friendlyVendingMachine.Start();