
/// Homework No.__ Exercise No.__
/// File Name:     HW9.sln
/// @author:       Upendra Samaranayake
/// Date:          Nov. 09, 2020
///
/// Problem Statement: Create a person class and a truck class that extends a vehicle class and input values.
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create person class with getters and setters.
/// 2. Create vehicle class the same way.
/// 3. Extend the vehicle class with a truck class.
/// 4. Create a driver that tests all the methods.

///

using System;

namespace HW_9
{
    class Program
    {
		public static void Main(string[] args)
		{

			Person p = new Person("Upendra Samaranayake");

			Truck t = new Truck("Ford Bronco", 21, p, 45.32, 45);

			Console.WriteLine(t.ToString());
		}

		public class Person
		{
			private string name;
			public Person(string theName)
			{
				name = theName;
			}
			public Person(Person thePerson)
			{
				name = thePerson.name;
			}
			public virtual string Name
			{
				get
				{
					return name;
				}
				set
				{
					name = value;
				}
			}

			public override string ToString()
			{
				return "Name = " + name;
			}
			public override bool Equals(object other)
			{
				if (other is Person)
				{
					Person p = (Person)other;
					return name.Equals(p.name);
				}
				return false;
			}
		}

		public class Vehicle
		{
			// instance variables

			private string manufacturerName;
			private int numCylinder;
			private Person owner;

			public Vehicle(string maString, int n, Person person)
			{
				manufacturerName = maString;
				numCylinder = n;
				owner = new Person(person);
			}

			public virtual string ManufacturerName
			{
				get
				{
					return manufacturerName;
				}
				set
				{
					this.manufacturerName = value;
				}
			}

			public virtual int NumCylinder
			{
				get
				{
					return numCylinder;
				}
				set
				{
					this.numCylinder = value;
				}
			}
			public virtual Person Owner
			{
				get
				{
					return owner;
				}
				set
				{
					this.owner = value;
				}
			}
			public override string ToString()
			{
				return "Manufaturer Name: " + manufacturerName + "\n" + "Number of Cylinder: " + numCylinder + "\n" + "Owner: " + owner.ToString();
			}
			public override bool Equals(object obj)
			{
				if (obj is Vehicle)
				{
					Vehicle v = (Vehicle)obj;
					if (manufacturerName.Equals(v.manufacturerName) && numCylinder == v.numCylinder && owner.Equals(v.owner))
					{
						return true;
					}
				}
				return false;
			}

		}
		public class Truck : Vehicle
		{

			private double loadCapacity;
			private int towingCApacity;


			public Truck(string maString, int n, Person person, double load, int tow) : base(maString, n, person)
			{

				loadCapacity = load;
				towingCApacity = tow;
			}

			public virtual double LoadCapacity
			{
				get
				{
					return loadCapacity;
				}
				set
				{

					this.loadCapacity = value;
				}
			}

			public virtual int TowingCApacity
			{
				get
				{
					return towingCApacity;
				}
				set
				{
					this.towingCApacity = value;
				}
			}
			public override bool Equals(object obj)
			{
				if (obj is Truck)
				{
					Truck t = (Truck)obj;
					if (base.Equals(t) && loadCapacity == t.loadCapacity && towingCApacity == t.towingCApacity)
					{
						return true;
					}
				}
				return false;
			}
			public override string ToString()
			{
				return base.ToString() + "\n" + "Load Capacity: " + loadCapacity + "\n" + "Towing Cpacity: " + towingCApacity;
			}
		}

	}
}
