# SOLID
The SOLID Design principles are design principles provided with some mechanism that will help implement software designs that are understandable, flexible and maintainable.

The advantages as as follows:

1. Code will be less complex
2. There wll be an increase in readability, extensibility, and maintenance
3. There are less errors
4. Increase code testability
5. Reduce tight coupling

Single Responsibility Principle
A class or a module should have only one reason to change.

Open-Closed Principle
A class or a module or a function should be open for extention, but closed for modification.

Liskov Substitution Principle
If S is a subtype of T, then objects of type of T should be replaced with objects of type of S.

Interface Segregation Principle
Clients should not be forced to implement any methods that they don't use. Rather than one fat interface, numerous little interfaces are preferred based on groups of methods with each interface serving one submodule.

Dependency Inversion Principle
Hig-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions. Abstractions should not depend upon details. Details should depend upon abstractions.