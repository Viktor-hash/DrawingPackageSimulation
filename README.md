# DrawingPackageSimulation
## Introduction

The aim of this project is to develop a C# .net console application to simulate a drawing package. The application does not include a UI. It displays the parameters of each widget.

The application supports the following **5 widgets** (drawing primitives) :

- **Rectangle**
- **Square**
- **Ellipse**
- **Circle**
- **Textbox**

Each widget has a unique implementation for displaying its parameters but shares a common structure. This is achieved through the use of :

- **Interface (`IWidget`)**: Defines a contract for all widgets, ensuring they implement a `Draw` method.
- **Abstract Class (`Widget`)**: Provides shared properties (`PositionX` and `PositionY` coordinates) that are common to all widgets.

The inputs are hardcoded in the Main method and displayed using a class called DrawingSimulation to simplify the tests.

### Inheritance

To avoid code duplication and reflect real-world relationships:
- **Circle** inherits from **Ellipse** (a circle is an ellipse with equal horizontal and vertical diameters).
- **Square** inherits from **Rectangle** (a square is a rectangle with equal width and height).
- **Textbox** inherits from **Rectangle** (a textbox is a rectangle with additional text properties).

### Validation

Integer units are used for all dimensions. The constructors include checks to ensure that widths, heights, and diameters are **positive**. As well as a check to insure the text in the Textbox is **not null**.

## Maintainability

This code respects SOLID principles by using interfaces and abstract classes.

### Extensibility

- If a **common behavior** is added, it can be implemented in the `Widget` abstract class.
- If a **new behavior** requires different implementations, it can be added to the `IWidget` interface or a new interface can be created.

## Running the application

### Prerequisites

Ensure you have the following installed:
- **.NET SDK**: 9.0.102

### Test coverage

Run the following command to execute the unit tests:

```bash
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

```asciidoc
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

**Note**: I noticed a space between the diameterH and = as well as diameterV and =. I decided to keep it to match the required output.

## Further Work 

If more time were available, the following enhancements could be made:

- Implement a user interface for user input.
- Add support for additional widgets (e.g., triangles, polygons).
- Include graphical rendering of the widgets.
- Add serilog
