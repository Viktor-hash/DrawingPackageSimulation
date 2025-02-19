# DrawingPackageSimulation
## Introduction

The aim of this project is to develop a c# .net console application to simulate a drawing package. It is only displaying the parameters of each widget in the console app without UI.

The application supports 5 widgets (drawing primitives) :

- Rectangle
- Square
- Ellipse
- Circle
- Textbox

They will all have a way of being printed but a different implementation for each fo them. Can be represented by an interface as it is a contract.

They will all have the same standard x y coordinate. Can be represented by an abstract class as it is common to all of them and wouldn't make sense to reimplement it.

Furthermore, circle can inherit from ellipse as it is an ellipse where both diameter(horizontal and vertical) are equal. Same thing for square which can inherit from rectangle and textbox can inherit from rectangle.

Integer units are used by default for all dimensions.

I implemented a check in the contructors to have widths, heights and diameter positive.

The inputs are hardcoded in the Main method and displayed using a class called DrawingSimulation to simplify the tests.

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
### Test required

#### Hardcoded in the Main as input
```
rectangle x=10, y=10, width=30 height=40
square x=15, y=30, size=35
ellipse x=100, y=150, horizontal diameter=300, vertical diameter=200
circle x=1, y=1, size=300
textbox x=5, y=5, width=200, height=100, text="sample text"
```
#### Required Output

```
----------------------------------------------------------------
Requested Drawing
----------------------------------------------------------------
Rectangle (10,10) width=30 height=40
Square (15,30) size=35
Ellipse (100,150) diameterH = 300 diameterV = 200
Circle (1,1) size=300
Textbox (5,5) width=200 height=100 Text="sample text"
----------------------------------------------------------------
```

I noticed a space between the diameterH and = as well as diameterV and =. I decided to keep it to match the required output.
