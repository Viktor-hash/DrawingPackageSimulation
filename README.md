# DrawingPackageSimulation
## Introduction

The aim of this project is to develop a c# .net console application to simulate a drawing package.

The application supports 5 widgets (drawing primitives) :

- Rectangle
- Square
- Ellipse
- Circle
- Textbox

They will all have a way of being printed but a different implementation for each fo them. Can be represented by an interface as it is a contract.

They will all have the same standard x y coordinate. Can be represented by an abstract class as it is common to all of them and wouldn't make sense to reimplement it.

Furthermore, circle can inherit from ellipse as it is an ellipse where both diameter(horizontal and vertical) are equal. Same thing for square which can inherit from rectangle and textbox can inherit from rectangle.

## Maintainability

I respected SOLID principles by using interfaces and abstract classes.

If a common behavior is added and should be part of a widget behavior I can then add it to the abstract class.

If a new common behavior is added but must have a different implementation I can either add it to IWidget if it is a widget specific behavior or create a new interface that can be inherited. (multiple interface inheritance is valid)

## Running the application

Please make sure you have the prequisites installed 

.net sdk: 9.0.102

### Test coverage

```
dotnet test
```
