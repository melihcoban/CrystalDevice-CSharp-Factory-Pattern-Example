# CrystalDevice

A basic example of factory method and abstract factory design patterns made with C#. Devices, which shares common properties, are inherited from base Device class and then provided to client through a factory method pattern. Screen, which is another property shared by all those devices, is implemented using abstract factory pattern, and added to the devices using dependency inversion principle.

# Factory / Abstract Factory Pattern Explained

[Head First Design Patterns - Chapter 4. The Factory Pattern](https://www.oreilly.com/library/view/head-first-design/0596007124/ch04.html)

The Factory Method Pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses. Factory Method Pattern gives us a way to encapsulate the instantiations of concrete types. 

An Abstract Factory gives us an interface for creating a family of products. By writing code that uses this interface, we decouple our code from the actual factory that creates the products. That allows us to implement a variety of factories that produce products meant for different contexts—such as different regions, different operating systems, or different look and feels.


# Target Framework
.NET Framework v4.7.2
