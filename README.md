# 🚲 BikeCo Bicycle Builder (Factory Method Pattern)

This is a C# console application that demonstrates the **Factory Method Design Pattern** through a scenario where a company, **BikeCo**, manufactures different types of bicycles using two types of workshops.

## 🛠 Scenario Overview

BikeCo produces:
- 🏔 Mountain Bikes
- 🏁 Racing Bikes
- 👶 Tricycles

Bicycles are built using the following standardized steps:
1. Create Frame
2. Add Wheels
3. Add Handles
4. Add Brakes
5. Add Pedals
6. Add Seat

BikeCo uses two types of workshops:
- **Steel Frame Workshop**
- **Aluminium Frame Workshop**

## 🧠 Design Pattern Used

The application uses the **Factory Method Pattern**, which helps in encapsulating object creation logic and promoting loose coupling.

### Pattern Components

| Entity            | Description |
|-------------------|-------------|
| `ProductBase`     | Abstract class/interface representing a generic bicycle. |
| `ConcreteProduct` | Concrete implementations like `MountainBike`, `RacingBike`, and `Tricycle`. |
| `FactoryBase`     | Abstract class/interface that defines a method to create bicycles. |
| `ConcreteFactory` | Implementations like `SteelWorkshopFactory` and `AluminiumWorkshopFactory` that create specific bicycle types. |

## 🧩 Class Structure

```
+------------------+      +--------------------------+
|   BicycleBase    |<-----|    MountainBike          |
| (ProductBase)    |<-----|    RacingBike            |
|                  |<-----|    Tricycle              |
+------------------+      +--------------------------+

+------------------------+       +--------------------------------+
|   WorkshopFactoryBase  |<------| SteelWorkshopFactory           |
|  (FactoryBase)         |<------| AluminiumWorkshopFactory       |
+------------------------+       +--------------------------------+
```

## 💡 Features

- Clean separation of concerns using abstract base classes.
- No `new` statements in the `Main()` method.
- Easy to extend with new bicycle types or workshop materials.
- Adheres strictly to the Factory Method pattern principles.

## 🧪 Sample Output

```plaintext
Creating a Mountain Bike in the Steel Workshop...
Creating Steel Frame
Adding Wheels
Adding Handles
Adding Brakes
Adding Pedals
Adding Seat

Creating a Racing Bike in the Aluminium Workshop...
Creating Aluminium Frame
Adding Wheels
Adding Handles
Adding Brakes
Adding Pedals
Adding Seat
```

## 🚀 Getting Started

### Prerequisites
- Visual Studio or any C# IDE

## 👨‍💻 Author

Maselaelo Glen – Final-Year Software Engineering Student

## 📝 License

This project is open-source. Contributions, suggestions, and forks are welcome.
