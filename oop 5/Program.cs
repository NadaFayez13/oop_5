namespace oop_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            //Q1  Object Copying

            //a) What happens when you assign one object variable to another object variable?
            //only the reference is copied, not the object itself.

            //b) Does assigning one object to another create a new object? Explain.
            //no , both variables end up pointing to the same object on the heap, so no new object is allocated.

            //c) What is the difference between copying an object and copying its reference?
            //copying an object creates a new instance of the object with the same values,
            //while copying a reference only copies the memory address of the object, so both variables point to the same object.


            //Q2  Shallow Copy vs Deep Copy

            //a) What is a Shallow Copy?
            //shallow copy creates a new object that is a copy of the original object,
            //but it only copies the references to the objects that are contained within the original object.

            //b) What is a Deep Copy?
            //Deep Copy creates completely new object and recursively copies all fields,
            //So the original and the copy are fully independent , changing one does not affect the other.

            //c) What happens to reference-type members when a Shallow Copy is created?
            //reference-type members are not copied. Only their references are copied.
            //So both the original and the shallow copy will point to the same reference-type members.

            //d) What happens to reference-type members when a Deep Copy is created?
            //reference-type members are also copied,
            //so the original and the deep copy will have their own separate copies of the reference-type members.

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //Deep Copy would be safer when you want to create a copy of an object that contains mutable reference-type members,
            #endregion

    

            #region Make sure all functionality from Assignment 04 still works
            DeliveryAddress address = new DeliveryAddress("Alexandria", "123 Main St", 21500);

            StandardShipment standard = new StandardShipment("SH001", "Books", 3.0m, 50.0m, address);

            ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 1.5m, 60.0m, address, 20.0m);

            InternationalShipment international = new InternationalShipment("SH003", "Laptop", 2.5m, 100.0m, address, "Canada", 150.0m);

            DeliveryCenter center = new DeliveryCenter("Alexandria Hub");
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            Console.WriteLine("Delivery Center");
            Console.WriteLine();

            center.PrintAllShipments();

            Console.WriteLine("Tracking Status");
            Console.WriteLine();

            center.PrintTrackingStatuses();

            Console.WriteLine("Insurance");
            Console.WriteLine();

            Console.Write("Standard Shipment Insurance : ");
            DeliveryReport.PrintInsurance(standard);

            Console.Write("Express Shipment Insurance  : ");
            DeliveryReport.PrintInsurance(express);

            Console.Write("International Shipment Insurance : ");
            DeliveryReport.PrintInsurance(international);

            Console.WriteLine("ITrackable Array - Tracking Statuses");

            ITrackable[] trackableShipments = new ITrackable[] { standard, express, international };

            foreach (ITrackable trackable in trackableShipments)
            {
                Console.WriteLine(trackable.GetTrackingStatus());
            }

            Console.WriteLine("IInsurable Array - Insurance Values");

            IInsurable[] insurableShipments = new IInsurable[] { standard, express, international };

            foreach (IInsurable insurable in insurableShipments)
            {
                Console.WriteLine($"Insurance Value: {insurable.CalculateInsurance()} EGP");
            }
            #endregion

            #region Demonstrate reference assignment between two shipment variables.
            StandardShipment shipment1 = new StandardShipment("0021", "Book", 2.0m, 40.0m, address);

            Shipment shipment2 = shipment1;

            Console.WriteLine("Before Modification");
            Console.WriteLine($"Shipment 1 Weight: {shipment1.Weight} KG");
            Console.WriteLine($"Shipment 2 Weight: {shipment2.Weight} KG");

            shipment2.UpdateWeight(5.5m);

            Console.WriteLine("\n After Modifying Weight via Shipment 2");
            Console.WriteLine($"Shipment 1 Weight: {shipment1.Weight} KG");
            Console.WriteLine($"Shipment 2 Weight: {shipment2.Weight} KG");

            bool isSameObject = ReferenceEquals(shipment1, shipment2);
            Console.WriteLine($" {isSameObject}");
            #endregion

            #region Create a Shallow Copy using MemberwiseClone().

            Console.WriteLine("shallow copy demonstration");

            StandardShipment shallowOriginal = new StandardShipment("0133", "tablet", 1.2m, 35.0m, address);

            Shipment shallowCopied = shallowOriginal.ShallowCopy();

            bool isSameShipment = ReferenceEquals(shallowOriginal, shallowCopied);
            Console.WriteLine($"{isSameShipment}"); // false cause we just copied the reference of the original object

            Console.WriteLine($"Original Tracking Code : {shallowOriginal.TrackingCode}");
            Console.WriteLine($"Copied Tracking Code   : {shallowCopied.TrackingCode}");

            #endregion


        }
    }
}
