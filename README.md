# C# Dependency Injection with Concrete Classes - Workshop Sample

## Learning Objectives
- Use dependency injection to improve extensibility of a program
- Explain the drawbacks of creating instances of classes inside other classes

## Workshop Sample
Demonstrate  in a C# console app how to instantiate classes and inject concrete classes into them.  Demonstrate overloading with multiple constructors, methods. 
I’ll create  VW solution with a console application called VW.Factory which we will use to create cars & parts.  Constructing cars by passing in parts to the constructor.

Set up instructions
Fork this repository and clone the forked version to your machine
Open the workshop.sln in Visual Studio

![](./images/herby.JPG)


## Introduction

When a class uses an instance of another class, we call that dependency. When Class A uses a method that exists on Class B, Class A is dependent on Class B existing and actually providing the method being used. Class B is the dependency.

Consider the following pseudocode:

```java
class Car {
    public void accelerate() {
        Engine engine = new Engine();
        engine.ignite();
        engine.injectFuel();
    }
}

class Program {
    public static void main() {
        Car car = new Car();
        car.accelerate();
        car.accelerate();
    }
}
```

Every time `car.accelerate()` is called, the car creates a new instance of the engine class, triggers the ignition, and then injects fuel to make it go. Imagine having to give your car a brand-new engine every time a traffic light turned green! The `Car` class is dependent on the `Engine` class.

We can make a simple improvement by moving the engine creation to the car's constructor so it only creates one instance to be used:

```java
class Car {
    Engine engine;
    
    public Car() {
        this.engine = new Engine();
    }
    
    public void accelerate() {
        this.engine.ignite();
        this.engine.injectFuel();
    }
}
```

This is a step in the right direction. At least the car will only ever use one instance of an engine and not replace it every time it accelerates... but what if the engine breaks? What if we need to repair it? As it is right now, we would have to add a method to the car class to repair the engine:

```java
class Car {
    Engine engine;
    
    public Car() {
        this.engine = new Engine();
    }
    
    public void accelerate() {
        this.engine.ignite();
        this.engine.injectFuel();
    }
    
    public void repairEngine() {
        this.engine = new Engine();
    }
}
```

This is quickly breaking one of the earlier rules of OOP: encapsulation. The car class is doing more than it should! This is where *Dependency Injection* can help. We can provide dependencies for classes to use to enable managing them better; we can *inject* dependencies into classes. To do this, we can use a class constructor in the same way we define method parameters:

```java
class Engine {
    public void repair() {}
}

class Car {
    Engine engine;
    
    public Car(Engine engine) {
        this.engine = engine;
    }
    
    public void accelerate() {
        this.engine.ignite();
        this.engine.injectFuel();
    }
}
```

The Car class is still dependent on the Engine class, but it's a lot easier to manage that dependency now. We can provide the car with any instance of the engine class that we want to (it could have a 2 litre capacity, 1.5 litre, anything we like). Additionally, the car is no longer responsible for providing a method to repair the engine.

```java
class Program {
    public static void main() {
        Engine engine = new Engine();
        Car car = new Car(engine);
        
        car.accelerate();
        car.accelerate();
        
        engine.repair();
        
        car.accelerate();
    }
}
```
